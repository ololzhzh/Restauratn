namespace Recipes
{
    partial class RecipesForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProductPlusButton = new System.Windows.Forms.Button();
            this.MyProductName = new System.Windows.Forms.TextBox();
            this.MyProductDim = new System.Windows.Forms.TextBox();
            this.MyProductCount = new System.Windows.Forms.TextBox();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.MyProductDimensionLabel = new System.Windows.Forms.Label();
            this.ProductCountLabel = new System.Windows.Forms.Label();
            this.MyProcessLabel = new System.Windows.Forms.Label();
            this.InformationLabel = new System.Windows.Forms.Label();
            this.ProductsPlus = new System.Windows.Forms.Label();
            this.RecipesPlus = new System.Windows.Forms.Label();
            this.DishNameLabel = new System.Windows.Forms.Label();
            this.ProductPlusLabel = new System.Windows.Forms.Label();
            this.ProductToRecept = new System.Windows.Forms.Button();
            this.ProductRecipeLabel = new System.Windows.Forms.Label();
            this.ListOfProducts = new System.Windows.Forms.TextBox();
            this.TextOfrepice = new System.Windows.Forms.TextBox();
            this.AddRecipeButton = new System.Windows.Forms.Button();
            this.DishName = new System.Windows.Forms.TextBox();
            this.ProductPlus = new System.Windows.Forms.TextBox();
            this.ProductCounter = new System.Windows.Forms.TextBox();
            this.RecipesTreeView = new System.Windows.Forms.TreeView();
            this.ListrecipesLabel = new System.Windows.Forms.Label();
            this.DeleteDishButton = new System.Windows.Forms.Button();
            this.NotSave = new System.Windows.Forms.Button();
            this.PlusProductFunctionLabel = new System.Windows.Forms.Label();
            this.SeeButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.MyMenu = new System.Windows.Forms.MenuStrip();
            this.KitchenMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.TextOfRecipeLabel = new System.Windows.Forms.Label();
            this.AllProducts = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductsInRecipeLabel = new System.Windows.Forms.Label();
            this.MyMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductPlusButton
            // 
            this.ProductPlusButton.Location = new System.Drawing.Point(17, 212);
            this.ProductPlusButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProductPlusButton.Name = "ProductPlusButton";
            this.ProductPlusButton.Size = new System.Drawing.Size(359, 23);
            this.ProductPlusButton.TabIndex = 0;
            this.ProductPlusButton.Text = "Добавить продукт";
            this.ProductPlusButton.UseVisualStyleBackColor = true;
            this.ProductPlusButton.Click += new System.EventHandler(this.ProductPlusButton_Click);
            // 
            // MyProductName
            // 
            this.MyProductName.Location = new System.Drawing.Point(165, 84);
            this.MyProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MyProductName.Name = "MyProductName";
            this.MyProductName.Size = new System.Drawing.Size(212, 22);
            this.MyProductName.TabIndex = 1;
            // 
            // MyProductDim
            // 
            this.MyProductDim.Location = new System.Drawing.Point(165, 124);
            this.MyProductDim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MyProductDim.Name = "MyProductDim";
            this.MyProductDim.Size = new System.Drawing.Size(212, 22);
            this.MyProductDim.TabIndex = 2;
            // 
            // MyProductCount
            // 
            this.MyProductCount.Location = new System.Drawing.Point(165, 165);
            this.MyProductCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MyProductCount.Name = "MyProductCount";
            this.MyProductCount.Size = new System.Drawing.Size(212, 22);
            this.MyProductCount.TabIndex = 3;
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Location = new System.Drawing.Point(17, 86);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(63, 17);
            this.ProductNameLabel.TabIndex = 4;
            this.ProductNameLabel.Text = "Продукт";
            // 
            // MyProductDimensionLabel
            // 
            this.MyProductDimensionLabel.AutoSize = true;
            this.MyProductDimensionLabel.Location = new System.Drawing.Point(17, 127);
            this.MyProductDimensionLabel.Name = "MyProductDimensionLabel";
            this.MyProductDimensionLabel.Size = new System.Drawing.Size(141, 17);
            this.MyProductDimensionLabel.TabIndex = 5;
            this.MyProductDimensionLabel.Text = "Единица измерений";
            // 
            // ProductCountLabel
            // 
            this.ProductCountLabel.AutoSize = true;
            this.ProductCountLabel.Location = new System.Drawing.Point(17, 169);
            this.ProductCountLabel.Name = "ProductCountLabel";
            this.ProductCountLabel.Size = new System.Drawing.Size(86, 17);
            this.ProductCountLabel.TabIndex = 6;
            this.ProductCountLabel.Text = "Количество";
            // 
            // MyProcessLabel
            // 
            this.MyProcessLabel.AutoSize = true;
            this.MyProcessLabel.Location = new System.Drawing.Point(161, 250);
            this.MyProcessLabel.Name = "MyProcessLabel";
            this.MyProcessLabel.Size = new System.Drawing.Size(0, 17);
            this.MyProcessLabel.TabIndex = 7;
            // 
            // InformationLabel
            // 
            this.InformationLabel.AutoSize = true;
            this.InformationLabel.Location = new System.Drawing.Point(17, 250);
            this.InformationLabel.Name = "InformationLabel";
            this.InformationLabel.Size = new System.Drawing.Size(94, 17);
            this.InformationLabel.TabIndex = 8;
            this.InformationLabel.Text = "Добавление:";
            // 
            // ProductsPlus
            // 
            this.ProductsPlus.AutoSize = true;
            this.ProductsPlus.Location = new System.Drawing.Point(17, 41);
            this.ProductsPlus.Name = "ProductsPlus";
            this.ProductsPlus.Size = new System.Drawing.Size(138, 17);
            this.ProductsPlus.TabIndex = 9;
            this.ProductsPlus.Text = "Закупка продуктов:";
            // 
            // RecipesPlus
            // 
            this.RecipesPlus.AutoSize = true;
            this.RecipesPlus.Location = new System.Drawing.Point(737, 41);
            this.RecipesPlus.Name = "RecipesPlus";
            this.RecipesPlus.Size = new System.Drawing.Size(153, 17);
            this.RecipesPlus.TabIndex = 10;
            this.RecipesPlus.Text = "Добавление рецепов:";
            // 
            // DishNameLabel
            // 
            this.DishNameLabel.AutoSize = true;
            this.DishNameLabel.Location = new System.Drawing.Point(733, 89);
            this.DishNameLabel.Name = "DishNameLabel";
            this.DishNameLabel.Size = new System.Drawing.Size(118, 17);
            this.DishNameLabel.TabIndex = 11;
            this.DishNameLabel.Text = "Название блюда";
            // 
            // ProductPlusLabel
            // 
            this.ProductPlusLabel.AutoSize = true;
            this.ProductPlusLabel.Location = new System.Drawing.Point(737, 130);
            this.ProductPlusLabel.Name = "ProductPlusLabel";
            this.ProductPlusLabel.Size = new System.Drawing.Size(129, 17);
            this.ProductPlusLabel.TabIndex = 12;
            this.ProductPlusLabel.Text = "Добавить продукт";
            // 
            // ProductToRecept
            // 
            this.ProductToRecept.Location = new System.Drawing.Point(733, 215);
            this.ProductToRecept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProductToRecept.Name = "ProductToRecept";
            this.ProductToRecept.Size = new System.Drawing.Size(359, 23);
            this.ProductToRecept.TabIndex = 13;
            this.ProductToRecept.Text = "Добавить продукт";
            this.ProductToRecept.UseVisualStyleBackColor = true;
            this.ProductToRecept.Click += new System.EventHandler(this.ProductToRecept_Click);
            // 
            // ProductRecipeLabel
            // 
            this.ProductRecipeLabel.AutoSize = true;
            this.ProductRecipeLabel.Location = new System.Drawing.Point(737, 172);
            this.ProductRecipeLabel.Name = "ProductRecipeLabel";
            this.ProductRecipeLabel.Size = new System.Drawing.Size(151, 17);
            this.ProductRecipeLabel.TabIndex = 14;
            this.ProductRecipeLabel.Text = "Количество продукта";
            // 
            // ListOfProducts
            // 
            this.ListOfProducts.Location = new System.Drawing.Point(392, 278);
            this.ListOfProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListOfProducts.Multiline = true;
            this.ListOfProducts.Name = "ListOfProducts";
            this.ListOfProducts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ListOfProducts.Size = new System.Drawing.Size(320, 134);
            this.ListOfProducts.TabIndex = 15;
            // 
            // TextOfrepice
            // 
            this.TextOfrepice.Location = new System.Drawing.Point(733, 278);
            this.TextOfrepice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextOfrepice.Multiline = true;
            this.TextOfrepice.Name = "TextOfrepice";
            this.TextOfrepice.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextOfrepice.Size = new System.Drawing.Size(359, 160);
            this.TextOfrepice.TabIndex = 17;
            // 
            // AddRecipeButton
            // 
            this.AddRecipeButton.Location = new System.Drawing.Point(733, 443);
            this.AddRecipeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddRecipeButton.Name = "AddRecipeButton";
            this.AddRecipeButton.Size = new System.Drawing.Size(359, 23);
            this.AddRecipeButton.TabIndex = 18;
            this.AddRecipeButton.Text = "Добавить рецепт";
            this.AddRecipeButton.UseVisualStyleBackColor = true;
            this.AddRecipeButton.Click += new System.EventHandler(this.AddRecipeButton_Click);
            // 
            // DishName
            // 
            this.DishName.Location = new System.Drawing.Point(893, 87);
            this.DishName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DishName.Name = "DishName";
            this.DishName.Size = new System.Drawing.Size(199, 22);
            this.DishName.TabIndex = 19;
            // 
            // ProductPlus
            // 
            this.ProductPlus.Location = new System.Drawing.Point(893, 127);
            this.ProductPlus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProductPlus.Name = "ProductPlus";
            this.ProductPlus.Size = new System.Drawing.Size(199, 22);
            this.ProductPlus.TabIndex = 20;
            // 
            // ProductCounter
            // 
            this.ProductCounter.Location = new System.Drawing.Point(893, 168);
            this.ProductCounter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProductCounter.Name = "ProductCounter";
            this.ProductCounter.Size = new System.Drawing.Size(199, 22);
            this.ProductCounter.TabIndex = 21;
            // 
            // RecipesTreeView
            // 
            this.RecipesTreeView.Location = new System.Drawing.Point(17, 315);
            this.RecipesTreeView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RecipesTreeView.Name = "RecipesTreeView";
            this.RecipesTreeView.Size = new System.Drawing.Size(359, 121);
            this.RecipesTreeView.TabIndex = 22;
            this.RecipesTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.RecipesTreeView_AfterSelect);
            // 
            // ListrecipesLabel
            // 
            this.ListrecipesLabel.AutoSize = true;
            this.ListrecipesLabel.Location = new System.Drawing.Point(17, 278);
            this.ListrecipesLabel.Name = "ListrecipesLabel";
            this.ListrecipesLabel.Size = new System.Drawing.Size(93, 17);
            this.ListrecipesLabel.TabIndex = 23;
            this.ListrecipesLabel.Text = "Список блюд";
            // 
            // DeleteDishButton
            // 
            this.DeleteDishButton.Location = new System.Drawing.Point(17, 443);
            this.DeleteDishButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteDishButton.Name = "DeleteDishButton";
            this.DeleteDishButton.Size = new System.Drawing.Size(359, 23);
            this.DeleteDishButton.TabIndex = 24;
            this.DeleteDishButton.Text = "Удалить блюдо";
            this.DeleteDishButton.UseVisualStyleBackColor = true;
            this.DeleteDishButton.Click += new System.EventHandler(this.DeleteDishButton_Click);
            // 
            // NotSave
            // 
            this.NotSave.Location = new System.Drawing.Point(392, 443);
            this.NotSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NotSave.Name = "NotSave";
            this.NotSave.Size = new System.Drawing.Size(320, 23);
            this.NotSave.TabIndex = 25;
            this.NotSave.Text = "Новый рецепт / Отмена";
            this.NotSave.UseVisualStyleBackColor = true;
            this.NotSave.Click += new System.EventHandler(this.NotSave_Click);
            // 
            // PlusProductFunctionLabel
            // 
            this.PlusProductFunctionLabel.AutoSize = true;
            this.PlusProductFunctionLabel.Location = new System.Drawing.Point(396, 419);
            this.PlusProductFunctionLabel.Name = "PlusProductFunctionLabel";
            this.PlusProductFunctionLabel.Size = new System.Drawing.Size(140, 17);
            this.PlusProductFunctionLabel.TabIndex = 26;
            this.PlusProductFunctionLabel.Text = "Статус добавления:";
            // 
            // SeeButton
            // 
            this.SeeButton.Location = new System.Drawing.Point(15, 473);
            this.SeeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeeButton.Name = "SeeButton";
            this.SeeButton.Size = new System.Drawing.Size(547, 23);
            this.SeeButton.TabIndex = 27;
            this.SeeButton.Text = "Режим просмотра";
            this.SeeButton.UseVisualStyleBackColor = true;
            this.SeeButton.Click += new System.EventHandler(this.SeeButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Enabled = false;
            this.AddButton.Location = new System.Drawing.Point(579, 471);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(513, 23);
            this.AddButton.TabIndex = 28;
            this.AddButton.Text = "Режим добавления";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
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
            this.MyMenu.Size = new System.Drawing.Size(1112, 28);
            this.MyMenu.TabIndex = 29;
            this.MyMenu.Text = "menuStrip1";
            // 
            // KitchenMenu
            // 
            this.KitchenMenu.Enabled = false;
            this.KitchenMenu.Name = "KitchenMenu";
            this.KitchenMenu.Size = new System.Drawing.Size(116, 24);
            this.KitchenMenu.Text = "Панель кухни";
            // 
            // OrderMenu
            // 
            this.OrderMenu.Name = "OrderMenu";
            this.OrderMenu.Size = new System.Drawing.Size(131, 24);
            this.OrderMenu.Text = "Панель заказов";
            this.OrderMenu.Click += new System.EventHandler(this.OrderMenu_Click);
            // 
            // TextOfRecipeLabel
            // 
            this.TextOfRecipeLabel.AutoSize = true;
            this.TextOfRecipeLabel.Location = new System.Drawing.Point(730, 249);
            this.TextOfRecipeLabel.Name = "TextOfRecipeLabel";
            this.TextOfRecipeLabel.Size = new System.Drawing.Size(105, 17);
            this.TextOfRecipeLabel.TabIndex = 16;
            this.TextOfRecipeLabel.Text = "Текст рецепта";
            // 
            // AllProducts
            // 
            this.AllProducts.Enabled = false;
            this.AllProducts.Location = new System.Drawing.Point(392, 84);
            this.AllProducts.Multiline = true;
            this.AllProducts.Name = "AllProducts";
            this.AllProducts.Size = new System.Drawing.Size(320, 154);
            this.AllProducts.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Продукы на складе";
            // 
            // ProductsInRecipeLabel
            // 
            this.ProductsInRecipeLabel.AutoSize = true;
            this.ProductsInRecipeLabel.Location = new System.Drawing.Point(389, 250);
            this.ProductsInRecipeLabel.Name = "ProductsInRecipeLabel";
            this.ProductsInRecipeLabel.Size = new System.Drawing.Size(147, 17);
            this.ProductsInRecipeLabel.TabIndex = 32;
            this.ProductsInRecipeLabel.Text = "Продукты в рецепте:";
            // 
            // RecipesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 507);
            this.Controls.Add(this.ProductsInRecipeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AllProducts);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SeeButton);
            this.Controls.Add(this.PlusProductFunctionLabel);
            this.Controls.Add(this.NotSave);
            this.Controls.Add(this.DeleteDishButton);
            this.Controls.Add(this.ListrecipesLabel);
            this.Controls.Add(this.RecipesTreeView);
            this.Controls.Add(this.ProductCounter);
            this.Controls.Add(this.ProductPlus);
            this.Controls.Add(this.DishName);
            this.Controls.Add(this.AddRecipeButton);
            this.Controls.Add(this.TextOfrepice);
            this.Controls.Add(this.TextOfRecipeLabel);
            this.Controls.Add(this.ListOfProducts);
            this.Controls.Add(this.ProductRecipeLabel);
            this.Controls.Add(this.ProductToRecept);
            this.Controls.Add(this.ProductPlusLabel);
            this.Controls.Add(this.DishNameLabel);
            this.Controls.Add(this.RecipesPlus);
            this.Controls.Add(this.ProductsPlus);
            this.Controls.Add(this.InformationLabel);
            this.Controls.Add(this.MyProcessLabel);
            this.Controls.Add(this.ProductCountLabel);
            this.Controls.Add(this.MyProductDimensionLabel);
            this.Controls.Add(this.ProductNameLabel);
            this.Controls.Add(this.MyProductCount);
            this.Controls.Add(this.MyProductDim);
            this.Controls.Add(this.MyProductName);
            this.Controls.Add(this.ProductPlusButton);
            this.Controls.Add(this.MyMenu);
            this.MainMenuStrip = this.MyMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RecipesForm";
            this.Text = "Recipes";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MyMenu.ResumeLayout(false);
            this.MyMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ProductPlusButton;
        private System.Windows.Forms.TextBox MyProductName;
        private System.Windows.Forms.TextBox MyProductDim;
        private System.Windows.Forms.TextBox MyProductCount;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.Label MyProductDimensionLabel;
        private System.Windows.Forms.Label ProductCountLabel;
        private System.Windows.Forms.Label MyProcessLabel;
        private System.Windows.Forms.Label InformationLabel;
        private System.Windows.Forms.Label ProductsPlus;
        private System.Windows.Forms.Label RecipesPlus;
        private System.Windows.Forms.Label DishNameLabel;
        private System.Windows.Forms.Label ProductPlusLabel;
        private System.Windows.Forms.Button ProductToRecept;
        private System.Windows.Forms.Label ProductRecipeLabel;
        private System.Windows.Forms.TextBox ListOfProducts;
        private System.Windows.Forms.TextBox TextOfrepice;
        private System.Windows.Forms.Button AddRecipeButton;
        private System.Windows.Forms.TextBox DishName;
        private System.Windows.Forms.TextBox ProductPlus;
        private System.Windows.Forms.TextBox ProductCounter;
        private System.Windows.Forms.TreeView RecipesTreeView;
        private System.Windows.Forms.Label ListrecipesLabel;
        private System.Windows.Forms.Button DeleteDishButton;
        private System.Windows.Forms.Button NotSave;
        private System.Windows.Forms.Label PlusProductFunctionLabel;
        private System.Windows.Forms.Button SeeButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.MenuStrip MyMenu;
        private System.Windows.Forms.ToolStripMenuItem KitchenMenu;
        private System.Windows.Forms.ToolStripMenuItem OrderMenu;
        private System.Windows.Forms.Label TextOfRecipeLabel;
        private System.Windows.Forms.TextBox AllProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ProductsInRecipeLabel;
    }
}

