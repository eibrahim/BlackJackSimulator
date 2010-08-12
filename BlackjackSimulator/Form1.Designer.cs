namespace BlackjackSimulator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPlay = new System.Windows.Forms.Button();
            this.txtPlayer1 = new System.Windows.Forms.TextBox();
            this.txtDealer = new System.Windows.Forms.TextBox();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblDealer = new System.Windows.Forms.Label();
            this.txtBankroll = new System.Windows.Forms.TextBox();
            this.btnPlay10 = new System.Windows.Forms.Button();
            this.txtBet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHighest = new System.Windows.Forms.TextBox();
            this.txtLowest = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtPlayer2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBet2 = new System.Windows.Forms.TextBox();
            this.txtLowest2 = new System.Windows.Forms.TextBox();
            this.txtHighest2 = new System.Windows.Forms.TextBox();
            this.txtBankroll2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(834, 33);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(103, 23);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play Hand";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPlayer1
            // 
            this.txtPlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPlayer1.Location = new System.Drawing.Point(16, 65);
            this.txtPlayer1.Multiline = true;
            this.txtPlayer1.Name = "txtPlayer1";
            this.txtPlayer1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPlayer1.Size = new System.Drawing.Size(286, 605);
            this.txtPlayer1.TabIndex = 1;
            // 
            // txtDealer
            // 
            this.txtDealer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDealer.Location = new System.Drawing.Point(600, 65);
            this.txtDealer.Multiline = true;
            this.txtDealer.Name = "txtDealer";
            this.txtDealer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDealer.Size = new System.Drawing.Size(286, 605);
            this.txtDealer.TabIndex = 2;
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(13, 46);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(45, 13);
            this.lblPlayer.TabIndex = 3;
            this.lblPlayer.Text = "Player 1";
            // 
            // lblDealer
            // 
            this.lblDealer.AutoSize = true;
            this.lblDealer.Location = new System.Drawing.Point(600, 46);
            this.lblDealer.Name = "lblDealer";
            this.lblDealer.Size = new System.Drawing.Size(38, 13);
            this.lblDealer.TabIndex = 4;
            this.lblDealer.Text = "Dealer";
            // 
            // txtBankroll
            // 
            this.txtBankroll.Location = new System.Drawing.Point(58, 7);
            this.txtBankroll.Name = "txtBankroll";
            this.txtBankroll.Size = new System.Drawing.Size(74, 20);
            this.txtBankroll.TabIndex = 5;
            // 
            // btnPlay10
            // 
            this.btnPlay10.Location = new System.Drawing.Point(834, 7);
            this.btnPlay10.Name = "btnPlay10";
            this.btnPlay10.Size = new System.Drawing.Size(103, 23);
            this.btnPlay10.TabIndex = 0;
            this.btnPlay10.Text = "Play 10 Hands";
            this.btnPlay10.UseVisualStyleBackColor = true;
            this.btnPlay10.Click += new System.EventHandler(this.btnPlay10_Click);
            // 
            // txtBet
            // 
            this.txtBet.Location = new System.Drawing.Point(58, 27);
            this.txtBet.Name = "txtBet";
            this.txtBet.Size = new System.Drawing.Size(74, 20);
            this.txtBet.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Money";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Highest";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lowest";
            // 
            // txtHighest
            // 
            this.txtHighest.Location = new System.Drawing.Point(213, 7);
            this.txtHighest.Name = "txtHighest";
            this.txtHighest.Size = new System.Drawing.Size(74, 20);
            this.txtHighest.TabIndex = 5;
            // 
            // txtLowest
            // 
            this.txtLowest.Location = new System.Drawing.Point(213, 27);
            this.txtLowest.Name = "txtLowest";
            this.txtLowest.Size = new System.Drawing.Size(74, 20);
            this.txtLowest.TabIndex = 5;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(738, 7);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtPlayer2
            // 
            this.txtPlayer2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPlayer2.Location = new System.Drawing.Point(308, 65);
            this.txtPlayer2.Multiline = true;
            this.txtPlayer2.Name = "txtPlayer2";
            this.txtPlayer2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPlayer2.Size = new System.Drawing.Size(286, 605);
            this.txtPlayer2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(471, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Lowest";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(471, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Highest";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(323, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Bet";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(320, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Money";
            // 
            // txtBet2
            // 
            this.txtBet2.Location = new System.Drawing.Point(365, 27);
            this.txtBet2.Name = "txtBet2";
            this.txtBet2.Size = new System.Drawing.Size(74, 20);
            this.txtBet2.TabIndex = 11;
            // 
            // txtLowest2
            // 
            this.txtLowest2.Location = new System.Drawing.Point(520, 27);
            this.txtLowest2.Name = "txtLowest2";
            this.txtLowest2.Size = new System.Drawing.Size(74, 20);
            this.txtLowest2.TabIndex = 10;
            // 
            // txtHighest2
            // 
            this.txtHighest2.Location = new System.Drawing.Point(520, 7);
            this.txtHighest2.Name = "txtHighest2";
            this.txtHighest2.Size = new System.Drawing.Size(74, 20);
            this.txtHighest2.TabIndex = 13;
            // 
            // txtBankroll2
            // 
            this.txtBankroll2.Location = new System.Drawing.Point(365, 7);
            this.txtBankroll2.Name = "txtBankroll2";
            this.txtBankroll2.Size = new System.Drawing.Size(74, 20);
            this.txtBankroll2.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(308, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Player2";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnPlay10;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 673);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBet2);
            this.Controls.Add(this.txtLowest2);
            this.Controls.Add(this.txtHighest2);
            this.Controls.Add(this.txtBankroll2);
            this.Controls.Add(this.txtPlayer2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBet);
            this.Controls.Add(this.txtLowest);
            this.Controls.Add(this.txtHighest);
            this.Controls.Add(this.txtBankroll);
            this.Controls.Add(this.lblDealer);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.txtDealer);
            this.Controls.Add(this.btnPlay10);
            this.Controls.Add(this.txtPlayer1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPlay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TextBox txtPlayer1;
        private System.Windows.Forms.TextBox txtDealer;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblDealer;
        private System.Windows.Forms.TextBox txtBankroll;
        
        
        private System.Windows.Forms.Button btnPlay10;
        private System.Windows.Forms.TextBox txtBet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHighest;
        private System.Windows.Forms.TextBox txtLowest;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtPlayer2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBet2;
        private System.Windows.Forms.TextBox txtLowest2;
        private System.Windows.Forms.TextBox txtHighest2;
        private System.Windows.Forms.TextBox txtBankroll2;
        private System.Windows.Forms.Label label9;
    }
}

