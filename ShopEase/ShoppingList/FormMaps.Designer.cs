namespace ShoppingList
{
    partial class FormMaps
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
            this.comboBoxMall = new System.Windows.Forms.ComboBox();
            this.labelMall = new System.Windows.Forms.Label();
            this.buttonShoppingCenter = new System.Windows.Forms.Button();
            this.buttonCurrentLocation = new System.Windows.Forms.Button();
            this.buttonHomeLocation = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelStreetNumber = new System.Windows.Forms.Label();
            this.textBoxStreetNumber = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelStreet = new System.Windows.Forms.Label();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.webBrowserMaps = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxMall);
            this.splitContainer1.Panel1.Controls.Add(this.labelMall);
            this.splitContainer1.Panel1.Controls.Add(this.buttonShoppingCenter);
            this.splitContainer1.Panel1.Controls.Add(this.buttonCurrentLocation);
            this.splitContainer1.Panel1.Controls.Add(this.buttonHomeLocation);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.labelStreetNumber);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxStreetNumber);
            this.splitContainer1.Panel1.Controls.Add(this.buttonSearch);
            this.splitContainer1.Panel1.Controls.Add(this.labelCity);
            this.splitContainer1.Panel1.Controls.Add(this.labelStreet);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxStreet);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxCity);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowserMaps);
            this.splitContainer1.Size = new System.Drawing.Size(1347, 682);
            this.splitContainer1.SplitterDistance = 301;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // comboBoxMall
            // 
            this.comboBoxMall.FormattingEnabled = true;
            this.comboBoxMall.Location = new System.Drawing.Point(134, 342);
            this.comboBoxMall.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxMall.Name = "comboBoxMall";
            this.comboBoxMall.Size = new System.Drawing.Size(148, 28);
            this.comboBoxMall.TabIndex = 16;
            // 
            // labelMall
            // 
            this.labelMall.AutoSize = true;
            this.labelMall.Location = new System.Drawing.Point(20, 355);
            this.labelMall.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMall.Name = "labelMall";
            this.labelMall.Size = new System.Drawing.Size(37, 20);
            this.labelMall.TabIndex = 15;
            this.labelMall.Text = "Mall";
            // 
            // buttonShoppingCenter
            // 
            this.buttonShoppingCenter.Location = new System.Drawing.Point(21, 223);
            this.buttonShoppingCenter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonShoppingCenter.Name = "buttonShoppingCenter";
            this.buttonShoppingCenter.Size = new System.Drawing.Size(147, 35);
            this.buttonShoppingCenter.TabIndex = 14;
            this.buttonShoppingCenter.Text = "Shopping Center";
            this.buttonShoppingCenter.UseVisualStyleBackColor = true;
            // 
            // buttonCurrentLocation
            // 
            this.buttonCurrentLocation.Location = new System.Drawing.Point(21, 154);
            this.buttonCurrentLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCurrentLocation.Name = "buttonCurrentLocation";
            this.buttonCurrentLocation.Size = new System.Drawing.Size(147, 35);
            this.buttonCurrentLocation.TabIndex = 13;
            this.buttonCurrentLocation.Text = "Current Location";
            this.buttonCurrentLocation.UseVisualStyleBackColor = true;
            // 
            // buttonHomeLocation
            // 
            this.buttonHomeLocation.Location = new System.Drawing.Point(21, 83);
            this.buttonHomeLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonHomeLocation.Name = "buttonHomeLocation";
            this.buttonHomeLocation.Size = new System.Drawing.Size(147, 35);
            this.buttonHomeLocation.TabIndex = 12;
            this.buttonHomeLocation.Text = "Home Location";
            this.buttonHomeLocation.UseVisualStyleBackColor = true;
            this.buttonHomeLocation.Click += new System.EventHandler(this.buttonHomeLocation_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(16, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Filter By:";
            // 
            // labelStreetNumber
            // 
            this.labelStreetNumber.AutoSize = true;
            this.labelStreetNumber.Location = new System.Drawing.Point(16, 462);
            this.labelStreetNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStreetNumber.Name = "labelStreetNumber";
            this.labelStreetNumber.Size = new System.Drawing.Size(109, 20);
            this.labelStreetNumber.TabIndex = 10;
            this.labelStreetNumber.Text = "StreetNumber";
            // 
            // textBoxStreetNumber
            // 
            this.textBoxStreetNumber.Location = new System.Drawing.Point(134, 451);
            this.textBoxStreetNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxStreetNumber.Name = "textBoxStreetNumber";
            this.textBoxStreetNumber.Size = new System.Drawing.Size(148, 26);
            this.textBoxStreetNumber.TabIndex = 9;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(171, 531);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(112, 35);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(20, 303);
            this.labelCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(35, 20);
            this.labelCity.TabIndex = 4;
            this.labelCity.Text = "City";
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new System.Drawing.Point(20, 406);
            this.labelStreet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(53, 20);
            this.labelStreet.TabIndex = 3;
            this.labelStreet.Text = "Street";
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(134, 395);
            this.textBoxStreet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(148, 26);
            this.textBoxStreet.TabIndex = 2;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(134, 292);
            this.textBoxCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(148, 26);
            this.textBoxCity.TabIndex = 1;
            // 
            // webBrowserMaps
            // 
            this.webBrowserMaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserMaps.Location = new System.Drawing.Point(0, 0);
            this.webBrowserMaps.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.webBrowserMaps.MinimumSize = new System.Drawing.Size(30, 31);
            this.webBrowserMaps.Name = "webBrowserMaps";
            this.webBrowserMaps.Size = new System.Drawing.Size(1040, 682);
            this.webBrowserMaps.TabIndex = 0;
            // 
            // FormMaps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 682);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMaps";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buy";
            this.Load += new System.EventHandler(this.FormMaps_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Button buttonShoppingCenter;
        private System.Windows.Forms.Button buttonCurrentLocation;
        private System.Windows.Forms.Button buttonHomeLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelStreetNumber;
        private System.Windows.Forms.TextBox textBoxStreetNumber;
        private System.Windows.Forms.ComboBox comboBoxMall;
        private System.Windows.Forms.Label labelMall;
        private System.Windows.Forms.WebBrowser webBrowserMaps;
    }
}