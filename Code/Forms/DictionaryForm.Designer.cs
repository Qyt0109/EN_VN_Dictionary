
namespace EN_VN_Lib
{
    partial class DictionaryForm
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
            this.button_DictionaryManager = new System.Windows.Forms.Button();
            this.button_AddNewTranslation = new System.Windows.Forms.Button();
            this.button_Setting = new System.Windows.Forms.Button();
            this.dataGridView_Translations = new System.Windows.Forms.DataGridView();
            this.button_Search = new System.Windows.Forms.Button();
            this.label_Search = new System.Windows.Forms.Label();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Translations)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.button_DictionaryManager);
            this.groupBox1.Controls.Add(this.button_AddNewTranslation);
            this.groupBox1.Controls.Add(this.button_Setting);
            this.groupBox1.Controls.Add(this.dataGridView_Translations);
            this.groupBox1.Controls.Add(this.button_Search);
            this.groupBox1.Controls.Add(this.label_Search);
            this.groupBox1.Controls.Add(this.textBox_Search);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1150, 705);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button_DictionaryManager
            // 
            this.button_DictionaryManager.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_DictionaryManager.BackColor = System.Drawing.Color.Plum;
            this.button_DictionaryManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_DictionaryManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DictionaryManager.Location = new System.Drawing.Point(642, 93);
            this.button_DictionaryManager.Margin = new System.Windows.Forms.Padding(2);
            this.button_DictionaryManager.Name = "button_DictionaryManager";
            this.button_DictionaryManager.Size = new System.Drawing.Size(417, 56);
            this.button_DictionaryManager.TabIndex = 23;
            this.button_DictionaryManager.Text = "Dictonary Manager";
            this.button_DictionaryManager.UseVisualStyleBackColor = false;
            this.button_DictionaryManager.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_AddNewTranslation
            // 
            this.button_AddNewTranslation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_AddNewTranslation.BackColor = System.Drawing.Color.White;
            this.button_AddNewTranslation.BackgroundImage = global::EN_VN_Lib.Properties.Resources.plus;
            this.button_AddNewTranslation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_AddNewTranslation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddNewTranslation.Location = new System.Drawing.Point(1059, 615);
            this.button_AddNewTranslation.Margin = new System.Windows.Forms.Padding(2);
            this.button_AddNewTranslation.Name = "button_AddNewTranslation";
            this.button_AddNewTranslation.Size = new System.Drawing.Size(70, 70);
            this.button_AddNewTranslation.TabIndex = 22;
            this.button_AddNewTranslation.UseVisualStyleBackColor = false;
            this.button_AddNewTranslation.Click += new System.EventHandler(this.button_AddNewTranslation_Click);
            // 
            // button_Setting
            // 
            this.button_Setting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Setting.BackColor = System.Drawing.Color.Plum;
            this.button_Setting.BackgroundImage = global::EN_VN_Lib.Properties.Resources.gear;
            this.button_Setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Setting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Setting.Location = new System.Drawing.Point(1089, 0);
            this.button_Setting.Margin = new System.Windows.Forms.Padding(2);
            this.button_Setting.Name = "button_Setting";
            this.button_Setting.Size = new System.Drawing.Size(56, 56);
            this.button_Setting.TabIndex = 21;
            this.button_Setting.UseVisualStyleBackColor = false;
            this.button_Setting.Click += new System.EventHandler(this.button_Setting_Click);
            // 
            // dataGridView_Translations
            // 
            this.dataGridView_Translations.AllowUserToAddRows = false;
            this.dataGridView_Translations.AllowUserToDeleteRows = false;
            this.dataGridView_Translations.AllowUserToResizeColumns = false;
            this.dataGridView_Translations.AllowUserToResizeRows = false;
            this.dataGridView_Translations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Translations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Translations.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Translations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Translations.Location = new System.Drawing.Point(6, 176);
            this.dataGridView_Translations.Name = "dataGridView_Translations";
            this.dataGridView_Translations.ReadOnly = true;
            this.dataGridView_Translations.RowHeadersWidth = 82;
            this.dataGridView_Translations.RowTemplate.Height = 33;
            this.dataGridView_Translations.Size = new System.Drawing.Size(1137, 523);
            this.dataGridView_Translations.TabIndex = 20;
            this.dataGridView_Translations.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Translations_CellDoubleClick);
            // 
            // button_Search
            // 
            this.button_Search.BackColor = System.Drawing.Color.Plum;
            this.button_Search.BackgroundImage = global::EN_VN_Lib.Properties.Resources.magnifying_glass;
            this.button_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Search.Location = new System.Drawing.Point(41, 86);
            this.button_Search.Margin = new System.Windows.Forms.Padding(2);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(70, 70);
            this.button_Search.TabIndex = 8;
            this.button_Search.UseVisualStyleBackColor = false;
            // 
            // label_Search
            // 
            this.label_Search.AutoSize = true;
            this.label_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Search.Location = new System.Drawing.Point(34, 31);
            this.label_Search.Name = "label_Search";
            this.label_Search.Size = new System.Drawing.Size(173, 42);
            this.label_Search.TabIndex = 5;
            this.label_Search.Text = "TimKiem:";
            // 
            // textBox_Search
            // 
            this.textBox_Search.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBox_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Search.Location = new System.Drawing.Point(116, 93);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(416, 56);
            this.textBox_Search.TabIndex = 6;
            this.textBox_Search.TextChanged += new System.EventHandler(this.textBox_Search_TextChanged);
            // 
            // DictionaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1174, 729);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "DictionaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TuDien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Translations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_Search;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.DataGridView dataGridView_Translations;
        private System.Windows.Forms.Button button_Setting;
        private System.Windows.Forms.Button button_AddNewTranslation;
        private System.Windows.Forms.Button button_DictionaryManager;
    }
}