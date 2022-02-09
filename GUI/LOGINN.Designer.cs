namespace SuperMarket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.user_in = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pass_in = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.MaskedTextBox();
            this.Pass = new System.Windows.Forms.MaskedTextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.PictureBox();
            this.hide = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.show)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hide)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "PassWord";
            // 
            // user_in
            // 
            this.user_in.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.user_in.AutoSize = true;
            this.user_in.Location = new System.Drawing.Point(242, 179);
            this.user_in.Name = "user_in";
            this.user_in.Size = new System.Drawing.Size(0, 17);
            this.user_in.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(228, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 97);
            this.label4.TabIndex = 3;
            this.label4.Text = "Login";
            // 
            // pass_in
            // 
            this.pass_in.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pass_in.AutoSize = true;
            this.pass_in.Location = new System.Drawing.Point(242, 238);
            this.pass_in.Name = "pass_in";
            this.pass_in.Size = new System.Drawing.Size(0, 17);
            this.pass_in.TabIndex = 4;
            // 
            // User
            // 
            this.User.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.User.Location = new System.Drawing.Point(178, 152);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(357, 24);
            this.User.TabIndex = 5;
            // 
            // Pass
            // 
            this.Pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Pass.Location = new System.Drawing.Point(178, 211);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(308, 24);
            this.Pass.TabIndex = 6;
            this.Pass.UseSystemPasswordChar = true;
            // 
            // button_login
            // 
            this.button_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_login.Location = new System.Drawing.Point(309, 259);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(75, 23);
            this.button_login.TabIndex = 7;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // show
            // 
            this.show.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("show.BackgroundImage")));
            this.show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.show.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.show.Location = new System.Drawing.Point(492, 211);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(54, 24);
            this.show.TabIndex = 8;
            this.show.TabStop = false;
            this.show.Click += new System.EventHandler(this.show_Click);
            this.show.MouseHover += new System.EventHandler(this.show_MouseHover);
            // 
            // hide
            // 
            this.hide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hide.BackgroundImage")));
            this.hide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hide.Location = new System.Drawing.Point(492, 211);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(54, 24);
            this.hide.TabIndex = 9;
            this.hide.TabStop = false;
            this.hide.Click += new System.EventHandler(this.hide_Click);
            this.hide.MouseHover += new System.EventHandler(this.hide_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 394);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.User);
            this.Controls.Add(this.pass_in);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.user_in);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.show);
            this.Controls.Add(this.hide);
            this.Name = "Form1";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.show)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label user_in;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label pass_in;
        private System.Windows.Forms.MaskedTextBox User;
        private System.Windows.Forms.MaskedTextBox Pass;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.PictureBox show;
        private System.Windows.Forms.PictureBox hide;
    }
}

