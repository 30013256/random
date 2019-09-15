namespace GoldEmailFlooder
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxEmailPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.textBoxBody = new System.Windows.Forms.TextBox();
            this.textBoxMailTo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownSendAmmount = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSender = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonFlood = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSendAmmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.Location = new System.Drawing.Point(112, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gold\'s Email Flooder";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(210, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(133, 79);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(215, 20);
            this.textBoxEmail.TabIndex = 2;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // textBoxEmailPassword
            // 
            this.textBoxEmailPassword.Location = new System.Drawing.Point(133, 122);
            this.textBoxEmailPassword.Name = "textBoxEmailPassword";
            this.textBoxEmailPassword.Size = new System.Drawing.Size(215, 20);
            this.textBoxEmailPassword.TabIndex = 0;
            this.textBoxEmailPassword.TextChanged += new System.EventHandler(this.textBoxEmailPassword_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(177, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(12, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Subject";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(12, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Body";
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(15, 322);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(215, 20);
            this.textBoxSubject.TabIndex = 6;
            this.textBoxSubject.TextChanged += new System.EventHandler(this.textBoxSubject_TextChanged);
            // 
            // textBoxBody
            // 
            this.textBoxBody.Location = new System.Drawing.Point(15, 369);
            this.textBoxBody.Name = "textBoxBody";
            this.textBoxBody.Size = new System.Drawing.Size(457, 20);
            this.textBoxBody.TabIndex = 7;
            this.textBoxBody.TextChanged += new System.EventHandler(this.textBoxBody_TextChanged);
            // 
            // textBoxMailTo
            // 
            this.textBoxMailTo.Location = new System.Drawing.Point(15, 235);
            this.textBoxMailTo.Name = "textBoxMailTo";
            this.textBoxMailTo.Size = new System.Drawing.Size(215, 20);
            this.textBoxMailTo.TabIndex = 9;
            this.textBoxMailTo.TextChanged += new System.EventHandler(this.textBoxMailTo_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(12, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Receiving Email";
            // 
            // numericUpDownSendAmmount
            // 
            this.numericUpDownSendAmmount.Location = new System.Drawing.Point(15, 434);
            this.numericUpDownSendAmmount.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownSendAmmount.Name = "numericUpDownSendAmmount";
            this.numericUpDownSendAmmount.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownSendAmmount.TabIndex = 10;
            this.numericUpDownSendAmmount.ValueChanged += new System.EventHandler(this.numericUpDownSendAmmount_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.Location = new System.Drawing.Point(12, 414);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(252, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Emails to Send (0 Sends Untill Stoped)";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBoxSender
            // 
            this.textBoxSender.Location = new System.Drawing.Point(15, 278);
            this.textBoxSender.Name = "textBoxSender";
            this.textBoxSender.Size = new System.Drawing.Size(215, 20);
            this.textBoxSender.TabIndex = 13;
            this.textBoxSender.TextChanged += new System.EventHandler(this.textBoxSender_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.Location = new System.Drawing.Point(12, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Sender ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(70, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(351, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "(You may have to allow access from less secure apps on gmail accounts)";
            // 
            // buttonFlood
            // 
            this.buttonFlood.BackColor = System.Drawing.Color.Yellow;
            this.buttonFlood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonFlood.Cursor = System.Windows.Forms.Cursors.Cross;
            this.buttonFlood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonFlood.Location = new System.Drawing.Point(180, 478);
            this.buttonFlood.Name = "buttonFlood";
            this.buttonFlood.Size = new System.Drawing.Size(113, 31);
            this.buttonFlood.TabIndex = 15;
            this.buttonFlood.Text = "Flood";
            this.buttonFlood.UseVisualStyleBackColor = false;
            this.buttonFlood.Click += new System.EventHandler(this.buttonFlood_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label10.Location = new System.Drawing.Point(335, 540);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 12);
            this.label10.TabIndex = 16;
            this.label10.Text = "Gold\'s Email Flooder Alpha V1.0";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonFlood);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxSender);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDownSendAmmount);
            this.Controls.Add(this.textBoxMailTo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxBody);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxEmailPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Gold\'s Email Flooder";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSendAmmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxEmailPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.TextBox textBoxBody;
        private System.Windows.Forms.TextBox textBoxMailTo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSender;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonFlood;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.NumericUpDown numericUpDownSendAmmount;
    }
}

