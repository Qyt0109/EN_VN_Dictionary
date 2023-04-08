
namespace EN_VN_Lib
{
    partial class SettingsForm
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
            this.button_Login = new System.Windows.Forms.Button();
            this.label_Copyright = new System.Windows.Forms.Label();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.pictureBox_Logout = new System.Windows.Forms.PictureBox();
            this.label_Username = new System.Windows.Forms.Label();
            this.pictureBox_EN = new System.Windows.Forms.PictureBox();
            this.label_Language = new System.Windows.Forms.Label();
            this.pictureBox_VN = new System.Windows.Forms.PictureBox();
            this.groupBox_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_VN)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Login
            // 
            this.groupBox_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox_Login.BackColor = System.Drawing.Color.PapayaWhip;
            this.groupBox_Login.Controls.Add(this.button_Login);
            this.groupBox_Login.Controls.Add(this.label_Copyright);
            this.groupBox_Login.Controls.Add(this.textBox_Username);
            this.groupBox_Login.Controls.Add(this.pictureBox_Logout);
            this.groupBox_Login.Controls.Add(this.label_Username);
            this.groupBox_Login.Controls.Add(this.pictureBox_EN);
            this.groupBox_Login.Controls.Add(this.label_Language);
            this.groupBox_Login.Controls.Add(this.pictureBox_VN);
            this.groupBox_Login.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Login.Name = "groupBox_Login";
            this.groupBox_Login.Size = new System.Drawing.Size(628, 336);
            this.groupBox_Login.TabIndex = 1;
            this.groupBox_Login.TabStop = false;
            // 
            // button_Login
            // 
            this.button_Login.BackColor = System.Drawing.Color.PeachPuff;
            this.button_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Login.Location = new System.Drawing.Point(155, 71);
            this.button_Login.Margin = new System.Windows.Forms.Padding(2);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(308, 102);
            this.button_Login.TabIndex = 2;
            this.button_Login.Text = "DangNhap";
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // label_Copyright
            // 
            this.label_Copyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Copyright.AutoSize = true;
            this.label_Copyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Copyright.Location = new System.Drawing.Point(8, 295);
            this.label_Copyright.Name = "label_Copyright";
            this.label_Copyright.Size = new System.Drawing.Size(110, 25);
            this.label_Copyright.TabIndex = 20;
            this.label_Copyright.Text = "Copyright:";
            // 
            // textBox_Username
            // 
            this.textBox_Username.Enabled = false;
            this.textBox_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Username.Location = new System.Drawing.Point(13, 99);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(547, 56);
            this.textBox_Username.TabIndex = 19;
            // 
            // pictureBox_Logout
            // 
            this.pictureBox_Logout.BackColor = System.Drawing.Color.Honeydew;
            this.pictureBox_Logout.BackgroundImage = global::EN_VN_Lib.Properties.Resources.icons8_logout_rounded_left_64;
            this.pictureBox_Logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Logout.Location = new System.Drawing.Point(566, 99);
            this.pictureBox_Logout.Name = "pictureBox_Logout";
            this.pictureBox_Logout.Size = new System.Drawing.Size(56, 56);
            this.pictureBox_Logout.TabIndex = 18;
            this.pictureBox_Logout.TabStop = false;
            this.pictureBox_Logout.Click += new System.EventHandler(this.pictureBox_Logout_Click);
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Username.Location = new System.Drawing.Point(6, 27);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(200, 42);
            this.label_Username.TabIndex = 17;
            this.label_Username.Text = "Username:";
            // 
            // pictureBox_EN
            // 
            this.pictureBox_EN.BackColor = System.Drawing.Color.PeachPuff;
            this.pictureBox_EN.BackgroundImage = global::EN_VN_Lib.Properties.Resources.united_kingdom;
            this.pictureBox_EN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_EN.Location = new System.Drawing.Point(382, 220);
            this.pictureBox_EN.Name = "pictureBox_EN";
            this.pictureBox_EN.Size = new System.Drawing.Size(56, 56);
            this.pictureBox_EN.TabIndex = 16;
            this.pictureBox_EN.TabStop = false;
            this.pictureBox_EN.Click += new System.EventHandler(this.pictureBox_EN_Click);
            // 
            // label_Language
            // 
            this.label_Language.AutoSize = true;
            this.label_Language.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Language.Location = new System.Drawing.Point(148, 225);
            this.label_Language.Name = "label_Language";
            this.label_Language.Size = new System.Drawing.Size(191, 42);
            this.label_Language.TabIndex = 15;
            this.label_Language.Text = "Ngôn ngữ:";
            // 
            // pictureBox_VN
            // 
            this.pictureBox_VN.BackColor = System.Drawing.Color.PeachPuff;
            this.pictureBox_VN.BackgroundImage = global::EN_VN_Lib.Properties.Resources.vietnam;
            this.pictureBox_VN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_VN.Location = new System.Drawing.Point(382, 220);
            this.pictureBox_VN.Name = "pictureBox_VN";
            this.pictureBox_VN.Size = new System.Drawing.Size(56, 56);
            this.pictureBox_VN.TabIndex = 14;
            this.pictureBox_VN.TabStop = false;
            this.pictureBox_VN.Click += new System.EventHandler(this.pictureBox_VN_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(652, 360);
            this.Controls.Add(this.groupBox_Login);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsForm";
            this.groupBox_Login.ResumeLayout(false);
            this.groupBox_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_VN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Login;
        private System.Windows.Forms.PictureBox pictureBox_EN;
        private System.Windows.Forms.Label label_Language;
        private System.Windows.Forms.PictureBox pictureBox_VN;
        private System.Windows.Forms.PictureBox pictureBox_Logout;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.Label label_Copyright;
        private System.Windows.Forms.Button button_Login;
    }
}