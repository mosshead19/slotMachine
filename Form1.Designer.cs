namespace slotMachine
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
            this.components = new System.ComponentModel.Container();
            this.btnSpin = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.TextBox();
            this.timerSpin = new System.Windows.Forms.Timer(this.components);
            this.lblResult = new System.Windows.Forms.TextBox();
            this.txtStake = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMaxBet = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSpin
            // 
            this.btnSpin.BackColor = System.Drawing.Color.Transparent;
            this.btnSpin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpin.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpin.ForeColor = System.Drawing.Color.IndianRed;
            this.btnSpin.Location = new System.Drawing.Point(229, 263);
            this.btnSpin.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(55, 36);
            this.btnSpin.TabIndex = 4;
            this.btnSpin.Text = "SPIN";
            this.btnSpin.UseVisualStyleBackColor = false;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.BackColor = System.Drawing.Color.White;
            this.lblBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblBalance.Location = new System.Drawing.Point(308, 298);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(2);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.ReadOnly = true;
            this.lblBalance.Size = new System.Drawing.Size(90, 13);
            this.lblBalance.TabIndex = 5;
            // 
            // timerSpin
            // 
            this.timerSpin.Tick += new System.EventHandler(this.timerSpin_Tick_1);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblResult.Font = new System.Drawing.Font("MS Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(220, 59);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(155, 29);
            this.lblResult.TabIndex = 6;
            this.lblResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lblResult.TextChanged += new System.EventHandler(this.lblResult_TextChanged);
            // 
            // txtStake
            // 
            this.txtStake.BackColor = System.Drawing.Color.White;
            this.txtStake.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStake.Location = new System.Drawing.Point(117, 298);
            this.txtStake.Margin = new System.Windows.Forms.Padding(2);
            this.txtStake.Name = "txtStake";
            this.txtStake.Size = new System.Drawing.Size(76, 13);
            this.txtStake.TabIndex = 7;
            this.txtStake.TextChanged += new System.EventHandler(this.txtStake_TextChanged);
            // 
            // lblUserName
            // 
            this.lblUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblUserName.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(77, 349);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(2);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(95, 13);
            this.lblUserName.TabIndex = 8;
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPlus.Location = new System.Drawing.Point(173, 259);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(28, 26);
            this.btnPlus.TabIndex = 9;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMinus.Location = new System.Drawing.Point(117, 259);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(29, 26);
            this.btnMinus.TabIndex = 10;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnMaxBet
            // 
            this.btnMaxBet.BackColor = System.Drawing.Color.Transparent;
            this.btnMaxBet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxBet.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaxBet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMaxBet.Location = new System.Drawing.Point(308, 263);
            this.btnMaxBet.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaxBet.Name = "btnMaxBet";
            this.btnMaxBet.Size = new System.Drawing.Size(90, 20);
            this.btnMaxBet.TabIndex = 11;
            this.btnMaxBet.Text = "MAX BET";
            this.btnMaxBet.UseVisualStyleBackColor = false;
            this.btnMaxBet.Click += new System.EventHandler(this.btnMaxBet_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(229, 156);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(308, 156);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 63);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(147, 156);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::slotMachine.Properties.Resources.bvx;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnMaxBet);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtStake);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.TextBox lblBalance;
        private System.Windows.Forms.Timer timerSpin;
        private System.Windows.Forms.TextBox lblResult;
        private System.Windows.Forms.TextBox txtStake;
        private System.Windows.Forms.TextBox lblUserName;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMaxBet;
    }
}

