namespace ConsignmentShopUI
{
    partial class ConsignmentShop
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
            this.headerText = new System.Windows.Forms.Label();
            this.storeItemsListBox = new System.Windows.Forms.ListBox();
            this.storeItemsLabel = new System.Windows.Forms.Label();
            this.shoppingCartLabel = new System.Windows.Forms.Label();
            this.shoppingCartListBox = new System.Windows.Forms.ListBox();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.purchaseButton = new System.Windows.Forms.Button();
            this.vendorLabel = new System.Windows.Forms.Label();
            this.vendorListBox = new System.Windows.Forms.ListBox();
            this.storeProfitValue = new System.Windows.Forms.Label();
            this.storeProfitLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.Location = new System.Drawing.Point(6, 9);
            this.headerText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(306, 37);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Consignment Shop";
            // 
            // storeItemsListBox
            // 
            this.storeItemsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeItemsListBox.FormattingEnabled = true;
            this.storeItemsListBox.ItemHeight = 20;
            this.storeItemsListBox.Location = new System.Drawing.Point(13, 132);
            this.storeItemsListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.storeItemsListBox.Name = "storeItemsListBox";
            this.storeItemsListBox.Size = new System.Drawing.Size(397, 184);
            this.storeItemsListBox.TabIndex = 1;
            // 
            // storeItemsLabel
            // 
            this.storeItemsLabel.AutoSize = true;
            this.storeItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeItemsLabel.Location = new System.Drawing.Point(9, 100);
            this.storeItemsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.storeItemsLabel.Name = "storeItemsLabel";
            this.storeItemsLabel.Size = new System.Drawing.Size(114, 24);
            this.storeItemsLabel.TabIndex = 2;
            this.storeItemsLabel.Text = "Store Items";
            // 
            // shoppingCartLabel
            // 
            this.shoppingCartLabel.AutoSize = true;
            this.shoppingCartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingCartLabel.Location = new System.Drawing.Point(684, 100);
            this.shoppingCartLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shoppingCartLabel.Name = "shoppingCartLabel";
            this.shoppingCartLabel.Size = new System.Drawing.Size(143, 24);
            this.shoppingCartLabel.TabIndex = 4;
            this.shoppingCartLabel.Text = "Shopping Cart";
            // 
            // shoppingCartListBox
            // 
            this.shoppingCartListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingCartListBox.FormattingEnabled = true;
            this.shoppingCartListBox.ItemHeight = 20;
            this.shoppingCartListBox.Location = new System.Drawing.Point(688, 132);
            this.shoppingCartListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.shoppingCartListBox.Name = "shoppingCartListBox";
            this.shoppingCartListBox.Size = new System.Drawing.Size(397, 184);
            this.shoppingCartListBox.TabIndex = 3;
            // 
            // addToCartButton
            // 
            this.addToCartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToCartButton.Location = new System.Drawing.Point(501, 213);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(99, 37);
            this.addToCartButton.TabIndex = 5;
            this.addToCartButton.Text = "Add To Cart";
            this.addToCartButton.UseVisualStyleBackColor = true;
            this.addToCartButton.Click += new System.EventHandler(this.addToCartButton_Click);
            // 
            // purchaseButton
            // 
            this.purchaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseButton.Location = new System.Drawing.Point(986, 335);
            this.purchaseButton.Name = "purchaseButton";
            this.purchaseButton.Size = new System.Drawing.Size(99, 37);
            this.purchaseButton.TabIndex = 6;
            this.purchaseButton.Text = "Purchase";
            this.purchaseButton.UseVisualStyleBackColor = true;
            this.purchaseButton.Click += new System.EventHandler(this.purchaseButton_Click);
            // 
            // vendorLabel
            // 
            this.vendorLabel.AutoSize = true;
            this.vendorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorLabel.Location = new System.Drawing.Point(9, 398);
            this.vendorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vendorLabel.Name = "vendorLabel";
            this.vendorLabel.Size = new System.Drawing.Size(89, 24);
            this.vendorLabel.TabIndex = 8;
            this.vendorLabel.Text = "Vendors";
            // 
            // vendorListBox
            // 
            this.vendorListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorListBox.FormattingEnabled = true;
            this.vendorListBox.ItemHeight = 20;
            this.vendorListBox.Location = new System.Drawing.Point(13, 430);
            this.vendorListBox.Margin = new System.Windows.Forms.Padding(4);
            this.vendorListBox.Name = "vendorListBox";
            this.vendorListBox.Size = new System.Drawing.Size(397, 184);
            this.vendorListBox.TabIndex = 7;
            // 
            // storeProfitValue
            // 
            this.storeProfitValue.AutoSize = true;
            this.storeProfitValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeProfitValue.Location = new System.Drawing.Point(637, 401);
            this.storeProfitValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.storeProfitValue.Name = "storeProfitValue";
            this.storeProfitValue.Size = new System.Drawing.Size(27, 20);
            this.storeProfitValue.TabIndex = 9;
            this.storeProfitValue.Text = "$0";
            // 
            // storeProfitLabel
            // 
            this.storeProfitLabel.AutoSize = true;
            this.storeProfitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeProfitLabel.Location = new System.Drawing.Point(564, 398);
            this.storeProfitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.storeProfitLabel.Name = "storeProfitLabel";
            this.storeProfitLabel.Size = new System.Drawing.Size(65, 24);
            this.storeProfitLabel.TabIndex = 10;
            this.storeProfitLabel.Text = "Store:";
            // 
            // ConsignmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 627);
            this.Controls.Add(this.storeProfitLabel);
            this.Controls.Add(this.storeProfitValue);
            this.Controls.Add(this.vendorLabel);
            this.Controls.Add(this.vendorListBox);
            this.Controls.Add(this.purchaseButton);
            this.Controls.Add(this.addToCartButton);
            this.Controls.Add(this.shoppingCartLabel);
            this.Controls.Add(this.shoppingCartListBox);
            this.Controls.Add(this.storeItemsLabel);
            this.Controls.Add(this.storeItemsListBox);
            this.Controls.Add(this.headerText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ConsignmentShop";
            this.Text = "Consignment Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.ListBox storeItemsListBox;
        private System.Windows.Forms.Label storeItemsLabel;
        private System.Windows.Forms.Label shoppingCartLabel;
        private System.Windows.Forms.ListBox shoppingCartListBox;
        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.Button purchaseButton;
        private System.Windows.Forms.Label vendorLabel;
        private System.Windows.Forms.ListBox vendorListBox;
        private System.Windows.Forms.Label storeProfitValue;
        private System.Windows.Forms.Label storeProfitLabel;
    }
}

