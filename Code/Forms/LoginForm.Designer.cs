
namespace EN_VN_Lib
{
    partial class Form_Login
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
            this.groupBox_Login = new System.Windows.Forms.GroupBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label_AppName = new System.Windows.Forms.Label();
            this.label_Username = new System.Windows.Forms.Label();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.pictureBox_ShowPassword = new System.Windows.Forms.PictureBox();
            this.pictureBox_HidePassword = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Info = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Login = new System.Windows.Forms.Button();
            this.groupBox_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ShowPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_HidePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Login
            // 
            this.groupBox_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox_Login.BackColor = System.Drawing.Color.LightCyan;
            this.groupBox_Login.Controls.Add(this.pictureBox_ShowPassword);
            this.groupBox_Login.Controls.Add(this.pictureBox_HidePassword);
            this.groupBox_Login.Controls.Add(this.label_Password);
            this.groupBox_Login.Controls.Add(this.pictureBox2);
            this.groupBox_Login.Controls.Add(this.textBox_Password);
            this.groupBox_Login.Controls.Add(this.pictureBox_Info);
            this.groupBox_Login.Controls.Add(this.label_AppName);
            this.groupBox_Login.Controls.Add(this.label_Username);
            this.groupBox_Login.Controls.Add(this.pictureBox1);
            this.groupBox_Login.Controls.Add(this.textBox_Username);
            this.groupBox_Login.Controls.Add(this.button_Login);
            this.groupBox_Login.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Login.Name = "groupBox_Login";
            this.groupBox_Login.Size = new System.Drawing.Size(750, 433);
            this.groupBox_Login.TabIndex = 0;
            this.groupBox_Login.TabStop = false;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.Location = new System.Drawing.Point(72, 251);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(183, 42);
            this.label_Password.TabIndex = 9;
            this.label_Password.Text = "Password";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Password.Location = new System.Drawing.Point(141, 313);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(293, 56);
            this.textBox_Password.TabIndex = 10;
            // 
            // label_AppName
            // 
            this.label_AppName.AutoSize = true;
            this.label_AppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AppName.Location = new System.Drawing.Point(6, 27);
            this.label_AppName.Name = "label_AppName";
            this.label_AppName.Size = new System.Drawing.Size(246, 55);
            this.label_AppName.TabIndex = 7;
            this.label_AppName.Text = "AppName";
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Username.Location = new System.Drawing.Point(72, 111);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(200, 42);
            this.label_Username.TabIndex = 1;
            this.label_Username.Text = "Username:";
            // 
            // textBox_Username
            // 
            this.textBox_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Username.Location = new System.Drawing.Point(141, 173);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(355, 56);
            this.textBox_Username.TabIndex = 2;
            // 
            // pictureBox_ShowPassword
            // 
            this.pictureBox_ShowPassword.BackColor = System.Drawing.Color.Aquamarine;
            this.pictureBox_ShowPassword.BackgroundImage = global::EN_VN_Lib.Properties.Resources.eye;
            this.pictureBox_ShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_ShowPassword.Location = new System.Drawing.Point(440, 313);
            this.pictureBox_ShowPassword.Name = "pictureBox_ShowPassword";
            this.pictureBox_ShowPassword.Size = new System.Drawing.Size(56, 56);
            this.pictureBox_ShowPassword.TabIndex = 13;
            this.pictureBox_ShowPassword.TabStop = false;
            this.pictureBox_ShowPassword.Click += new System.EventHandler(this.pictureBox_ShowPassword_Click);
            // 
            // pictureBox_HidePassword
            // 
            this.pictureBox_HidePassword.BackColor = System.Drawing.Color.Salmon;
            this.pictureBox_HidePassword.BackgroundImage = global::EN_VN_Lib.Properties.Resources.hide;
            this.pictureBox_HidePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_HidePassword.Location = new System.Drawing.Point(440, 313);
            this.pictureBox_HidePassword.Name = "pictureBox_HidePassword";
            this.pictureBox_HidePassword.Size = new System.Drawing.Size(56, 56);
            this.pictureBox_HidePassword.TabIndex = 12;
            this.pictureBox_HidePassword.TabStop = false;
            this.pictureBox_HidePassword.Click += new System.EventHandler(this.pictureBox_HidePassword_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pictureBox2.BackgroundImage = global::EN_VN_Lib.Properties.Resources.padlock;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(79, 313);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 56);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox_Info
            // 
            this.pictureBox_Info.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pictureBox_Info.BackgroundImage = global::EN_VN_Lib.Properties.Resources.info;
            this.pictureBox_Info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Info.Cursor = System.Windows.Forms.Cursors.Help;
            this.pictureBox_Info.Location = new System.Drawing.Point(704, 27);
            this.pictureBox_Info.Name = "pictureBox_Info";
            this.pictureBox_Info.Size = new System.Drawing.Size(40, 40);
            this.pictureBox_Info.TabIndex = 8;
            this.pictureBox_Info.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pictureBox1.BackgroundImage = global::EN_VN_Lib.Properties.Resources.user;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(79, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 56);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button_Login
            // 
            this.button_Login.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_Login.BackgroundImage = global::EN_VN_Lib.Properties.Resources.enter;
            this.button_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Login.Location = new System.Drawing.Point(531, 194);
            this.button_Login.Margin = new System.Windows.Forms.Padding(2);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(153, 162);
            this.button_Login.TabIndex = 0;
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(774, 457);
            this.Controls.Add(this.groupBox_Login);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form_Login_Load);
            this.groupBox_Login.ResumeLayout(false);
            this.groupBox_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ShowPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_HidePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.GroupBox groupBox_Login;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.PictureBox pictureBox_Info;
        private System.Windows.Forms.Label label_AppName;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.PictureBox pictureBox_HidePassword;
        private System.Windows.Forms.PictureBox pictureBox_ShowPassword;
    }
}

