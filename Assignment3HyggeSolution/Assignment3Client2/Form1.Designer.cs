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
            this.dataGridViewLoadDataBase.Location = new System.Drawing.Point(117, 165);
            this.dataGridViewLoadDataBase.Name = "dataGridViewLoadDataBase";
            this.dataGridViewLoadDataBase.Size = new System.Drawing.Size(518, 230);
            this.dataGridViewLoadDataBase.TabIndex = 0;
            this.dataGridViewLoadDataBase.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLoadDataBase_CellContentClick);
            // 
            // comboBoxValues
            // 
            this.comboBoxValues.FormattingEnabled = true;
            this.comboBoxValues.Location = new System.Drawing.Point(117, 103);
            this.comboBoxValues.Name = "comboBoxValues";
            this.comboBoxValues.Size = new System.Drawing.Size(197, 21);
            this.comboBoxValues.TabIndex = 1;
            this.comboBoxValues.SelectedIndexChanged += new System.EventHandler(this.comboBoxValues_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(320, 101);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please select a value to see infomation";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.comboBoxValues);
            this.Controls.Add(this.dataGridViewLoadDataBase);
            this.Name = "Form1";
            this.Text = "HyggeClient2";
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

