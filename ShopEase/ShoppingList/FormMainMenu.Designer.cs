namespace ShoppingList
{
    partial class FormMainMenu
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
            this.buttonCreateShoppingList = new System.Windows.Forms.Button();
            this.buttonUpdateData = new System.Windows.Forms.Button();
            this.buttonExsitShoppingList = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonSales = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCreateShoppingList
            // 
            this.buttonCreateShoppingList.Location = new System.Drawing.Point(82, 65);
            this.buttonCreateShoppingList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCreateShoppingList.Name = "buttonCreateShoppingList";
            this.buttonCreateShoppingList.Size = new System.Drawing.Size(112, 92);
            this.buttonCreateShoppingList.TabIndex = 0;
            this.buttonCreateShoppingList.Text = "Create Shopping List";
            this.buttonCreateShoppingList.UseVisualStyleBackColor = true;
            this.buttonCreateShoppingList.Click += new System.EventHandler(this.buttonCreateShoppingList_Click);
            // 
            // buttonUpdateData
            // 
            this.buttonUpdateData.Location = new System.Drawing.Point(261, 146);
            this.buttonUpdateData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUpdateData.Name = "buttonUpdateData";
            this.buttonUpdateData.Size = new System.Drawing.Size(112, 92);
            this.buttonUpdateData.TabIndex = 1;
            this.buttonUpdateData.Text = "Update Data";
            this.buttonUpdateData.UseVisualStyleBackColor = true;
            this.buttonUpdateData.Click += new System.EventHandler(this.buttonUpdateData_Click);
            // 
            // buttonExsitShoppingList
            // 
            this.buttonExsitShoppingList.Location = new System.Drawing.Point(429, 65);
            this.buttonExsitShoppingList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonExsitShoppingList.Name = "buttonExsitShoppingList";
            this.buttonExsitShoppingList.Size = new System.Drawing.Size(112, 91);
            this.buttonExsitShoppingList.TabIndex = 2;
            this.buttonExsitShoppingList.Text = "Exist Shopping List";
            this.buttonExsitShoppingList.UseVisualStyleBackColor = true;
            this.buttonExsitShoppingList.Click += new System.EventHandler(this.buttonExistShoppingList_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(411, 20);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(0, 20);
            this.labelTitle.TabIndex = 3;
            // 
            // buttonSales
            // 
            this.buttonSales.Location = new System.Drawing.Point(429, 242);
            this.buttonSales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSales.Name = "buttonSales";
            this.buttonSales.Size = new System.Drawing.Size(112, 91);
            this.buttonSales.TabIndex = 4;
            this.buttonSales.Text = "Sales";
            this.buttonSales.UseVisualStyleBackColor = true;
            this.buttonSales.Visible = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(82, 242);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(112, 91);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Visible = false;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 528);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonSales);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonExsitShoppingList);
            this.Controls.Add(this.buttonUpdateData);
            this.Controls.Add(this.buttonCreateShoppingList);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShopEase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateShoppingList;
        private System.Windows.Forms.Button buttonUpdateData;
        private System.Windows.Forms.Button buttonExsitShoppingList;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonSales;
        private System.Windows.Forms.Button buttonSearch;
    }
}