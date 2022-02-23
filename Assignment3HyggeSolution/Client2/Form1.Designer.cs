namespace Assignment3Client2
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
            this.dataGridViewLoadDataBase = new System.Windows.Forms.DataGridView();
            this.comboBoxValues = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoadDataBase)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLoadDataBase
            // 
            this.dataGridViewLoadDataBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLoadDataBase.Location = new System.Drawing.Point(136, 190);
            this.dataGridViewLoadDataBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewLoadDataBase.Name = "dataGridViewLoadDataBase";
            this.dataGridViewLoadDataBase.Size = new System.Drawing.Size(604, 265);
            this.dataGridViewLoadDataBase.TabIndex = 0;
            this.dataGridViewLoadDataBase.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLoadDataBase_CellContentClick);
            // 
            // comboBoxValues
            // 
            this.comboBoxValues.FormattingEnabled = true;
            this.comboBoxValues.Location = new System.Drawing.Point(136, 119);
            this.comboBoxValues.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxValues.Name = "comboBoxValues";
            this.comboBoxValues.Size = new System.Drawing.Size(229, 23);
            this.comboBoxValues.TabIndex = 1;
            this.comboBoxValues.SelectedIndexChanged += new System.EventHandler(this.comboBoxValues_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(373, 117);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 27);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please select a value to see infomation";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.comboBoxValues);
            this.Controls.Add(this.dataGridViewLoadDataBase);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "HyggeClient2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoadDataBase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLoadDataBase;
        private System.Windows.Forms.ComboBox comboBoxValues;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
    }
}

