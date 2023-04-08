
namespace EN_VN_Lib
{
    partial class DictionaryInfo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Select = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.label_Search = new System.Windows.Forms.Label();
            this.textBox_DictionaryName = new System.Windows.Forms.TextBox();
            this.button_AddNewTranslation = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.button_AddNewTranslation);
            this.groupBox1.Controls.Add(this.button_Select);
            this.groupBox1.Controls.Add(this.button_Delete);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.button_Save);
            this.groupBox1.Controls.Add(this.label_Search);
            this.groupBox1.Controls.Add(this.textBox_DictionaryName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 308);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // button_Select
            // 
            this.button_Select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Select.BackColor = System.Drawing.Color.Plum;
            this.button_Select.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Select.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Select.Location = new System.Drawing.Point(42, 188);
            this.button_Select.Margin = new System.Windows.Forms.Padding(2);
            this.button_Select.Name = "button_Select";
            this.button_Select.Size = new System.Drawing.Size(490, 70);
            this.button_Select.TabIndex = 24;
            this.button_Select.Text = "Select";
            this.button_Select.UseVisualStyleBackColor = false;
            this.button_Select.Click += new System.EventHandler(this.button_Select_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.LightCoral;
            this.button_Delete.BackgroundImage = global::EN_VN_Lib.Properties.Resources.delete;
            this.button_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.Location = new System.Drawing.Point(536, 188);
            this.button_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(70, 70);
            this.button_Delete.TabIndex = 10;
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.pictureBox1.BackgroundImage = global::EN_VN_Lib.Properties.Resources.book;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(41, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 56);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.Plum;
            this.button_Save.BackgroundImage = global::EN_VN_Lib.Properties.Resources.diskette;
            this.button_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.Location = new System.Drawing.Point(536, 89);
            this.button_Save.Margin = new System.Windows.Forms.Padding(2);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(70, 70);
            this.button_Save.TabIndex = 8;
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // label_Search
            // 
            this.label_Search.AutoSize = true;
            this.label_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Search.Location = new System.Drawing.Point(34, 31);
            this.label_Search.Name = "label_Search";
            this.label_Search.Size = new System.Drawing.Size(297, 42);
            this.label_Search.TabIndex = 5;
            this.label_Search.Text = "Dictionary name:";
            // 
            // textBox_DictionaryName
            // 
            this.textBox_DictionaryName.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBox_DictionaryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_DictionaryName.Location = new System.Drawing.Point(103, 91);
            this.textBox_DictionaryName.Name = "textBox_DictionaryName";
            this.textBox_DictionaryName.Size = new System.Drawing.Size(428, 56);
            this.textBox_DictionaryName.TabIndex = 6;
            // 
            // button_AddNewTranslation
            // 
            this.button_AddNewTranslation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_AddNewTranslation.BackColor = System.Drawing.Color.White;
            this.button_AddNewTranslation.BackgroundImage = global::EN_VN_Lib.Properties.Resources.plus;
            this.button_AddNewTranslation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_AddNewTranslation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddNewTranslation.Location = new System.Drawing.Point(536, 89);
            this.button_AddNewTranslation.Margin = new System.Windows.Forms.Padding(2);
            this.button_AddNewTranslation.Name = "button_AddNewTranslation";
            this.button_AddNewTranslation.Size = new System.Drawing.Size(70, 70);
            this.button_AddNewTranslation.TabIndex = 23;
            this.button_AddNewTranslation.UseVisualStyleBackColor = false;
            this.button_AddNewTranslation.Click += new System.EventHandler(this.button_AddNewTranslation_Click);
            // 
            // DictionaryInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 332);
            this.Controls.Add(this.groupBox1);
            this.Name = "DictionaryInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DictionaryInfo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Label label_Search;
        private System.Windows.Forms.TextBox textBox_DictionaryName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Select;
        private System.Windows.Forms.Button button_AddNewTranslation;
    }
}