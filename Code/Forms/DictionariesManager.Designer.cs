
namespace EN_VN_Lib
{
    partial class DictionariesManager
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
            this.button_AddNewDictionary = new System.Windows.Forms.Button();
            this.dataGridView_Dictionaries = new System.Windows.Forms.DataGridView();
            this.label_Search = new System.Windows.Forms.Label();
            this.textBox_SelectedDictionary = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Dictionaries)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.button_AddNewDictionary);
            this.groupBox1.Controls.Add(this.dataGridView_Dictionaries);
            this.groupBox1.Controls.Add(this.label_Search);
            this.groupBox1.Controls.Add(this.textBox_SelectedDictionary);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1255, 711);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // button_AddNewDictionary
            // 
            this.button_AddNewDictionary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_AddNewDictionary.BackColor = System.Drawing.Color.White;
            this.button_AddNewDictionary.BackgroundImage = global::EN_VN_Lib.Properties.Resources.plus;
            this.button_AddNewDictionary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_AddNewDictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddNewDictionary.Location = new System.Drawing.Point(1164, 621);
            this.button_AddNewDictionary.Margin = new System.Windows.Forms.Padding(2);
            this.button_AddNewDictionary.Name = "button_AddNewDictionary";
            this.button_AddNewDictionary.Size = new System.Drawing.Size(70, 70);
            this.button_AddNewDictionary.TabIndex = 22;
            this.button_AddNewDictionary.UseVisualStyleBackColor = false;
            this.button_AddNewDictionary.Click += new System.EventHandler(this.button_AddNewDictionary_Click);
            // 
            // dataGridView_Dictionaries
            // 
            this.dataGridView_Dictionaries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Dictionaries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Dictionaries.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Dictionaries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Dictionaries.Location = new System.Drawing.Point(6, 176);
            this.dataGridView_Dictionaries.Name = "dataGridView_Dictionaries";
            this.dataGridView_Dictionaries.ReadOnly = true;
            this.dataGridView_Dictionaries.RowHeadersWidth = 82;
            this.dataGridView_Dictionaries.RowTemplate.Height = 33;
            this.dataGridView_Dictionaries.Size = new System.Drawing.Size(1242, 529);
            this.dataGridView_Dictionaries.TabIndex = 20;
            this.dataGridView_Dictionaries.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Dictionaries_CellDoubleClick);
            // 
            // label_Search
            // 
            this.label_Search.AutoSize = true;
            this.label_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Search.Location = new System.Drawing.Point(34, 31);
            this.label_Search.Name = "label_Search";
            this.label_Search.Size = new System.Drawing.Size(344, 42);
            this.label_Search.TabIndex = 5;
            this.label_Search.Text = "Selected dictionary:";
            // 
            // textBox_SelectedDictionary
            // 
            this.textBox_SelectedDictionary.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBox_SelectedDictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SelectedDictionary.Location = new System.Drawing.Point(41, 93);
            this.textBox_SelectedDictionary.Name = "textBox_SelectedDictionary";
            this.textBox_SelectedDictionary.ReadOnly = true;
            this.textBox_SelectedDictionary.Size = new System.Drawing.Size(416, 56);
            this.textBox_SelectedDictionary.TabIndex = 6;
            // 
            // DictionariesManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 735);
            this.Controls.Add(this.groupBox1);
            this.Name = "DictionariesManager";
            this.Text = "Dictionaries Manager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Dictionaries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_AddNewDictionary;
        private System.Windows.Forms.DataGridView dataGridView_Dictionaries;
        private System.Windows.Forms.Label label_Search;
        private System.Windows.Forms.TextBox textBox_SelectedDictionary;
    }
}