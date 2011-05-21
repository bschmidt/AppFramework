namespace TestDataAccess
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GridTestData = new System.Windows.Forms.DataGridView();
            this.btnGetTable = new System.Windows.Forms.Button();
            this.CEGridData = new System.Windows.Forms.DataGridView();
            this.btnCELoadData = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTestData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CEGridData)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(527, 250);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.GridTestData);
            this.tabPage1.Controls.Add(this.btnGetTable);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(519, 224);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Full";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CEGridData);
            this.tabPage2.Controls.Add(this.btnCELoadData);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(519, 224);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CE";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // GridTestData
            // 
            this.GridTestData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridTestData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTestData.Location = new System.Drawing.Point(8, 35);
            this.GridTestData.Name = "GridTestData";
            this.GridTestData.Size = new System.Drawing.Size(503, 177);
            this.GridTestData.TabIndex = 3;
            // 
            // btnGetTable
            // 
            this.btnGetTable.Location = new System.Drawing.Point(8, 6);
            this.btnGetTable.Name = "btnGetTable";
            this.btnGetTable.Size = new System.Drawing.Size(75, 23);
            this.btnGetTable.TabIndex = 2;
            this.btnGetTable.Text = "Load Table";
            this.btnGetTable.UseVisualStyleBackColor = true;
            // 
            // CEGridData
            // 
            this.CEGridData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CEGridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CEGridData.Location = new System.Drawing.Point(8, 35);
            this.CEGridData.Name = "CEGridData";
            this.CEGridData.Size = new System.Drawing.Size(503, 177);
            this.CEGridData.TabIndex = 5;
            // 
            // btnCELoadData
            // 
            this.btnCELoadData.Location = new System.Drawing.Point(8, 6);
            this.btnCELoadData.Name = "btnCELoadData";
            this.btnCELoadData.Size = new System.Drawing.Size(75, 23);
            this.btnCELoadData.TabIndex = 4;
            this.btnCELoadData.Text = "Load Table";
            this.btnCELoadData.UseVisualStyleBackColor = true;
            this.btnCELoadData.Click += new System.EventHandler(this.btnCELoadData_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(519, 224);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 250);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridTestData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CEGridData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView GridTestData;
        private System.Windows.Forms.Button btnGetTable;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView CEGridData;
        private System.Windows.Forms.Button btnCELoadData;
        private System.Windows.Forms.TabPage tabPage3;

    }
}

