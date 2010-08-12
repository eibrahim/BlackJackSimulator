using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BlackjackSimulator
{
    public partial class Form1 : Form
    {
        Shoe shoe;
        private static int _handCount = 0;
        private Player _player1;
        private Player _player2;
        private IList<Player> _players;
        private Player _dealer;


        public Form1()
        {
            InitializeComponent();
            ResetForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlayHand();
        }

        private void PlayHand()
        {
            _handCount++;
            if (shoe.Cards.Count < 80)
            {
                //reshuffle
                //txtMe.Clear();
                txtPlayer1.AppendText("\r\n----------NEW SHOW----------\r\n");
                //txtDealer.Clear();
                shoe = new Shoe();
            }

            foreach (var player in _players)
            {
                player.NewHand();
            }
            _dealer.NewHand();
            
            Deal(_players, _dealer);

            foreach (var player in _players)
            {
                PlayerPlays(player, _dealer.Cards[0].CardType);
            }

            DealerPlays(_players, _dealer);

            CalculateWinner(_players, _dealer);

            DisplayResults(_players, _dealer);
        }

        private void DisplayResults(IList<Player> players, Player dealer)
        {
            //first player
            DisplayPlayerInfo(players.First(), txtBankroll, txtBet, txtPlayer1,txtHighest,txtLowest);
            if (players.Count > 1)
                DisplayPlayerInfo(players[1], txtBankroll2, txtBet2, txtPlayer2,txtHighest2,txtLowest2);

            //dealer side
            txtDealer.AppendText(string.Format("{0} - ", _handCount));
            foreach (var card in dealer.Cards)
            {
                txtDealer.AppendText(card + " ");
            }
            txtDealer.AppendText(string.Format("\r\nHigh Total = {0} - Low Total = {1} - Total = {2}\r\n", dealer.HighTotal, dealer.LowTotal, dealer.Total));
            txtDealer.AppendText("\r\n");
            txtDealer.AppendText("-----------------------\r\n");

            
        }

        private static void DisplayPlayerInfo(Player player, TextBox bankroll, TextBox bet, TextBox playerInfo, TextBox highest, TextBox lowest)
        {
            bankroll.Text = player.Money.ToString();
            bet.Text = player.Bet.ToString();
            playerInfo.AppendText(string.Format("{0} - ", _handCount));
            foreach (var card in player.Cards)
            {
                playerInfo.AppendText(string.Format("{0} ", card));
            }
            playerInfo.AppendText(string.Format("\r\nHigh Total = {0} - Low Total = {1} - Total = {2}\r\n", player.HighTotal, player.LowTotal, player.Total));
            playerInfo.AppendText(string.Format(" Bet = {0}", player.LastBet));
            playerInfo.AppendText(string.Format(" Money = {0}\r\n", player.Money));
            playerInfo.AppendText("-----------------------\r\n");


            if (string.IsNullOrEmpty(highest.Text))
            {
                highest.Text = player.Money.ToString();
            }
            else
            {
                if (player.Money > int.Parse(highest.Text))
                {
                    highest.Text = player.Money.ToString();
                }
            }

            if (string.IsNullOrEmpty(lowest.Text))
            {
                lowest.Text = player.Money.ToString();
            }
            else
            {
                if (player.Money < int.Parse(lowest.Text))
                {
                    lowest.Text = player.Money.ToString();
                }
            }
        }

        private void CalculateWinner(IList<Player> players, Player dealer)
        {
            foreach (var player in players)
            {
                var lastBet = player.Bet;
                if (player.Total <= 21)
                {
                    //calculate winner
                    if (dealer.Total <= 21)
                    {
                        if (player.Total > dealer.Total)
                        {
                            //player won
                            player.Money += player.Bet;
                            player.Bet = player.Money < 0 ? lastBet : Player.DefaultBet;
                        }
                        else if (dealer.Total > player.Total)
                        {
                            //player lost
                            player.Money -= player.Bet;
                            player.Bet = player.Bet * 2;
                        }
                        else if (dealer.Total == player.Total)
                        {
                            //push - nothing happens

                        }
                    }
                    else
                    {
                        //dealer busted
                        player.Money += player.Bet;
                        player.Bet = player.Money < 0 ? lastBet : Player.DefaultBet;
                    }
                }
                else
                {
                    //player busted
                    player.Money -= player.Bet;
                    player.Bet = player.Bet * 2;
                }
                
                
                //player.Bet = player.Bet > Player.MaxBet ? Player.MaxBet : player.Bet;
            }

        }

        private void DealerPlays(IList<Player> players, Player dealer)
        {
            if (players.All(p => p.Total > 21))
            {
                return;
            }
            //dealer hits
            while (dealer.Total < 17)
            {
                dealer.GiveCard(shoe.GetCard());
            }

            if (dealer.Total == 17 && dealer.IsSoft())
                dealer.GiveCard(shoe.GetCard());
        }

        private void PlayerPlays(Player player, CardTypes dealerShowing)
        {
            var hitvalue = GetHitvalue(dealerShowing);

            while (player.Total < hitvalue && player.Total < 21)
            {
                player.GiveCard(shoe.GetCard());
            }
        }

        private static int GetHitvalue(CardTypes dealerShowing)
        {
            int hitvalue;
            switch (dealerShowing)
            {
                case CardTypes.Jack:
                case CardTypes.Queen:
                case CardTypes.King:
                case CardTypes.Ten:
                case CardTypes.Seven:
                case CardTypes.Eight:
                case CardTypes.Nine:
                    hitvalue = 17;
                    break;
                case CardTypes.Two:
                case CardTypes.Three:
                    hitvalue = 11;
                    break;
                default:
                    hitvalue = 11;
                    break;
            }
            return hitvalue;
        }

        private void Deal(IList<Player> players, Player dealer)
        {
            foreach (var player in players)
            {
                player.GiveCard(shoe.GetCard());
            }
            dealer.GiveCard(shoe.GetCard());
            foreach (var player in players)
            {
                player.GiveCard(shoe.GetCard());
            }
            dealer.GiveCard(shoe.GetCard());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            shoe = new Shoe();

        }

        private void btnPlay10_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                PlayHand();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            txtPlayer1.Clear();
            txtPlayer2.Clear();

            txtLowest.Clear();
            txtLowest2.Clear();
            txtHighest.Clear();
            txtHighest2.Clear();
            txtDealer.Clear();
            txtBet.Clear();
            txtBet2.Clear();
            txtBankroll.Clear();
            txtBankroll2.Clear();

            _player1 = new Player();
            _player2 = new Player();
            _players = new List<Player>() { _player1, _player2 };
            _dealer = new Player();

            _handCount = 0;
        }
    }
}
