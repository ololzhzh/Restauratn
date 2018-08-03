namespace Recipes
{
    partial class ClientForm
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
            this.MyMenu = new System.Windows.Forms.MenuStrip();
            this.KitchenMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DishesTree = new System.Windows.Forms.TreeView();
            this.OrderTree = new System.Windows.Forms.TreeView();
            this.OkeyOrder = new System.Windows.Forms.Button();
            this.AddToOrder = new System.Windows.Forms.Button();
            this.RemoveInOrder = new System.Windows.Forms.Button();
            this.AllProducts = new System.Windows.Forms.TextBox();
            this.AllProductsLabel = new System.Windows.Forms.Label();
            this.MyMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MyMenu
            // 
            this.MyMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.KitchenMenu,
            this.OrderMenu});
            this.MyMenu.Location = new System.Drawing.Point(0, 0);
            this.MyMenu.Name = "MyMenu";
            this.MyMenu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.MyMenu.Size = new System.Drawing.Size(1107, 28);
            this.MyMenu.TabIndex = 30;
            this.MyMenu.Text = "menuStrip1";
            // 
            // KitchenMenu
            // 
            this.KitchenMenu.Name = "KitchenMenu";
            this.KitchenMenu.Size = new System.Drawing.Size(116, 24);
            this.KitchenMenu.Text = "Панель кухни";
            this.KitchenMenu.Click += new System.EventHandler(this.KitchenMenu_Click);
            // 
            // OrderMenu
            // 
            this.OrderMenu.Enabled = false;
            this.OrderMenu.Name = "OrderMenu";
            this.OrderMenu.Size = new System.Drawing.Size(131, 24);
            this.OrderMenu.Text = "Панель заказов";
            // 
            // DishesTree
            // 
            this.DishesTree.Location = new System.Drawing.Point(0, 33);
            this.DishesTree.Margin = new System.Windows.Forms.Padding(4);
            this.DishesTree.Name = "DishesTree";
            this.DishesTree.Size = new System.Drawing.Size(260, 434);
            this.DishesTree.TabIndex = 31;
            // 
            // OrderTree
            // 
            this.OrderTree.Location = new System.Drawing.Point(847, 33);
            this.OrderTree.Margin = new System.Windows.Forms.Padding(4);
            this.OrderTree.Name = "OrderTree";
            this.OrderTree.Size = new System.Drawing.Size(259, 434);
            this.OrderTree.TabIndex = 32;
            // 
            // OkeyOrder
            // 
            this.OkeyOrder.Location = new System.Drawing.Point(267, 188);
            this.OkeyOrder.Margin = new System.Windows.Forms.Padding(4);
            this.OkeyOrder.Name = "OkeyOrder";
            this.OkeyOrder.Size = new System.Drawing.Size(569, 70);
            this.OkeyOrder.TabIndex = 35;
            this.OkeyOrder.Text = "Подтверждение";
            this.OkeyOrder.UseVisualStyleBackColor = true;
            this.OkeyOrder.Click += new System.EventHandler(this.OkeyOrder_Click);
            // 
            // AddToOrder
            // 
            this.AddToOrder.Location = new System.Drawing.Point(267, 33);
            this.AddToOrder.Name = "AddToOrder";
            this.AddToOrder.Size = new System.Drawing.Size(569, 70);
            this.AddToOrder.TabIndex = 36;
            this.AddToOrder.Text = "Добавить в заказ";
            this.AddToOrder.UseVisualStyleBackColor = true;
            this.AddToOrder.Click += new System.EventHandler(this.AddToOrder_Click);
            // 
            // RemoveInOrder
            // 
            this.RemoveInOrder.Location = new System.Drawing.Point(267, 111);
            this.RemoveInOrder.Name = "RemoveInOrder";
            this.RemoveInOrder.Size = new System.Drawing.Size(569, 70);
            this.RemoveInOrder.TabIndex = 37;
            this.RemoveInOrder.Text = "Убрать из заказа";
            this.RemoveInOrder.UseVisualStyleBackColor = true;
            this.RemoveInOrder.Click += new System.EventHandler(this.RemoveInOrder_Click);
            // 
            // AllProducts
            // 
            this.AllProducts.Location = new System.Drawing.Point(268, 293);
            this.AllProducts.Multiline = true;
            this.AllProducts.Name = "AllProducts";
            this.AllProducts.Size = new System.Drawing.Size(568, 174);
            this.AllProducts.TabIndex = 38;
            // 
            // AllProductsLabel
            // 
            this.AllProductsLabel.AutoSize = true;
            this.AllProductsLabel.Location = new System.Drawing.Point(268, 266);
            this.AllProductsLabel.Name = "AllProductsLabel";
            this.AllProductsLabel.Size = new System.Drawing.Size(131, 17);
            this.AllProductsLabel.TabIndex = 39;
            this.AllProductsLabel.Text = "Список продуктов:";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 479);
            this.Controls.Add(this.AllProductsLabel);
            this.Controls.Add(this.AllProducts);
            this.Controls.Add(this.RemoveInOrder);
            this.Controls.Add(this.AddToOrder);
            this.Controls.Add(this.OkeyOrder);
            this.Controls.Add(this.OrderTree);
            this.Controls.Add(this.DishesTree);
            this.Controls.Add(this.MyMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ClientForm";
            this.Text = "Client Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientForm_FormClosing);
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.MyMenu.ResumeLayout(false);
            this.MyMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MyMenu;
        private System.Windows.Forms.ToolStripMenuItem KitchenMenu;
        private System.Windows.Forms.ToolStripMenuItem OrderMenu;
        private System.Windows.Forms.TreeView DishesTree;
        private System.Windows.Forms.TreeView OrderTree;
        private System.Windows.Forms.Button OkeyOrder;
        private System.Windows.Forms.Button AddToOrder;
        private System.Windows.Forms.Button RemoveInOrder;
        private System.Windows.Forms.TextBox AllProducts;
        private System.Windows.Forms.Label AllProductsLabel;
    }
}