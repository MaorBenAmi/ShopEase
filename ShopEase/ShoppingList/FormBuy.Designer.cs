namespace ShoppingList
{
    partial class FormBuy
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonBackToMainMenu = new System.Windows.Forms.Button();
            this.buttonCurrentLocation = new System.Windows.Forms.Button();
            this.buttonHomeLocation = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTiTle = new System.Windows.Forms.Label();
            this.dataGridViewQueryAnswer = new System.Windows.Forms.DataGridView();
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.ColumnShowDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Map = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQueryAnswer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonBackToMainMenu);
            this.splitContainer1.Panel1.Controls.Add(this.buttonCurrentLocation);
            this.splitContainer1.Panel1.Controls.Add(this.buttonHomeLocation);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.labelTiTle);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewQueryAnswer);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewList);
            this.splitContainer1.Size = new System.Drawing.Size(1481, 844);
            this.splitContainer1.SplitterDistance = 235;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonBackToMainMenu
            // 
            this.buttonBackToMainMenu.Location = new System.Drawing.Point(18, 592);
            this.buttonBackToMainMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBackToMainMenu.Name = "buttonBackToMainMenu";
            this.buttonBackToMainMenu.Size = new System.Drawing.Size(129, 98);
            this.buttonBackToMainMenu.TabIndex = 22;
            this.buttonBackToMainMenu.Text = "Back To Main Menu";
            this.buttonBackToMainMenu.UseVisualStyleBackColor = true;
            this.buttonBackToMainMenu.Click += new System.EventHandler(this.buttonBackToMainMenu_Click);
            // 
            // buttonCurrentLocation
            // 
            this.buttonCurrentLocation.Location = new System.Drawing.Point(22, 234);
            this.buttonCurrentLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCurrentLocation.Name = "buttonCurrentLocation";
            this.buttonCurrentLocation.Size = new System.Drawing.Size(148, 95);
            this.buttonCurrentLocation.TabIndex = 14;
            this.buttonCurrentLocation.Text = "Current Location";
            this.buttonCurrentLocation.UseVisualStyleBackColor = true;
            this.buttonCurrentLocation.Click += new System.EventHandler(this.buttonCurrentLocation_Click);
            // 
            // buttonHomeLocation
            // 
            this.buttonHomeLocation.Location = new System.Drawing.Point(22, 93);
            this.buttonHomeLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonHomeLocation.Name = "buttonHomeLocation";
            this.buttonHomeLocation.Size = new System.Drawing.Size(148, 91);
            this.buttonHomeLocation.TabIndex = 13;
            this.buttonHomeLocation.Text = "Home Location";
            this.buttonHomeLocation.UseVisualStyleBackColor = true;
            this.buttonHomeLocation.Click += new System.EventHandler(this.buttonHomeLocation_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(18, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Filter By:";
            // 
            // labelTiTle
            // 
            this.labelTiTle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelTiTle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelTiTle.Location = new System.Drawing.Point(0, 369);
            this.labelTiTle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTiTle.Name = "labelTiTle";
            this.labelTiTle.Size = new System.Drawing.Size(1240, 58);
            this.labelTiTle.TabIndex = 2;
            this.labelTiTle.Text = "Title";
            // 
            // dataGridViewQueryAnswer
            // 
            this.dataGridViewQueryAnswer.AllowUserToAddRows = false;
            this.dataGridViewQueryAnswer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewQueryAnswer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQueryAnswer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewQueryAnswer.Location = new System.Drawing.Point(0, 427);
            this.dataGridViewQueryAnswer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewQueryAnswer.MultiSelect = false;
            this.dataGridViewQueryAnswer.Name = "dataGridViewQueryAnswer";
            this.dataGridViewQueryAnswer.ReadOnly = true;
            this.dataGridViewQueryAnswer.RowHeadersVisible = false;
            this.dataGridViewQueryAnswer.Size = new System.Drawing.Size(1240, 417);
            this.dataGridViewQueryAnswer.TabIndex = 1;
            // 
            // dataGridViewList
            // 
            this.dataGridViewList.AllowUserToAddRows = false;
            this.dataGridViewList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnShowDetails,
            this.Map});
            this.dataGridViewList.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewList.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewList.Name = "dataGridViewList";
            this.dataGridViewList.ReadOnly = true;
            this.dataGridViewList.RowHeadersVisible = false;
            this.dataGridViewList.Size = new System.Drawing.Size(1240, 364);
            this.dataGridViewList.TabIndex = 0;
            this.dataGridViewList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewList_CellContentClick);
            // 
            // ColumnShowDetails
            // 
            this.ColumnShowDetails.FillWeight = 50.76142F;
            this.ColumnShowDetails.HeaderText = "Details";
            this.ColumnShowDetails.MinimumWidth = 50;
            this.ColumnShowDetails.Name = "ColumnShowDetails";
            this.ColumnShowDetails.ReadOnly = true;
            // 
            // Map
            // 
            this.Map.FillWeight = 49.23858F;
            this.Map.HeaderText = "Map";
            this.Map.Name = "Map";
            this.Map.ReadOnly = true;
            // 
            // FormBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 844);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormBuy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBuy";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQueryAnswer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCurrentLocation;
        private System.Windows.Forms.Button buttonHomeLocation;
        private System.Windows.Forms.DataGridView dataGridViewList;
        private System.Windows.Forms.Button buttonBackToMainMenu;
        private System.Windows.Forms.DataGridView dataGridViewQueryAnswer;
        private System.Windows.Forms.Label labelTiTle;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnShowDetails;
        private System.Windows.Forms.DataGridViewButtonColumn Map;
    }
}