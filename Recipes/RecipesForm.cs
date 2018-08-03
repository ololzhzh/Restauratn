using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FunctionsLibrary;

namespace Recipes
{
    public partial class RecipesForm : Form
    {
        #region fields
        MyInterLayer product = new MyInterLayer();
        List<string> products = new List<string>();
        #endregion
        
        #region methods
        public RecipesForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function Add Products to the Base
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductPlusButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                
                if (product.Add(MyProductName.Text, MyProductDim.Text, int.Parse(MyProductCount.Text)))
                {
                    MyProductName.Clear();
                    MyProductDim.Clear();
                    MyProductCount.Clear();
                    MakeAllProducts();
                    MyProcessLabel.Text = "прошло";
                }
                else
                {
                    MyProcessLabel.Text = "не прошло";
                }
            }
            catch (FormatException)
            {
                MyProcessLabel.Text = "не прошло";
            }
            Cursor.Current = Cursors.Arrow;
        }
        /// <summary>
        /// Function Add Products to the Recipe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductToRecept_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (!product.MyProducts(ProductPlus.Text, int.Parse(ProductCounter.Text), true))
                {
                    ListOfProducts.Text = string.Concat(ListOfProducts.Text, $"{ProductPlus.Text} - {ProductCounter.Text} {product.dim};\r\n");
                    ProductCounter.Clear();
                    ProductPlus.Clear();
                }
                else
                {
                    PlusProductFunctionLabel.Text = "Добавьте продукт в закупку с количеством = 0.";
                }
            }
            catch (FormatException)
            {
                PlusProductFunctionLabel.Text = "Ошибка в формате количества.";
            }
            Cursor.Current = Cursors.Arrow;
        }
        /// <summary>
        /// Function cancels recent activities with recipe.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotSave_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (product.RecipeClear())
            {
                Clear();
                PlusProductFunctionLabel.Text = "Отмена";
            }
            Cursor.Current = Cursors.Arrow;
        }
        /// <summary>
        /// Function Add the recipe to the base.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRecipeButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (product.AddRecipe(DishName.Text, TextOfrepice.Text))
            {
                Clear();
                PlusProductFunctionLabel.Text = "Рецепт успешно добавлен.";
                MakeTreeView();
            }
            else
            {
                PlusProductFunctionLabel.Text = "Ошибки в добавлении.";
            }
            Cursor.Current = Cursors.Arrow;
        }
        /// <summary>
        /// Function clear some user elements.
        /// </summary>
        private void Clear()
        {
            Cursor.Current = Cursors.Arrow;
            DishName.Clear();
            ProductPlus.Clear();
            ProductCounter.Clear();
            ListOfProducts.Clear();
            TextOfrepice.Clear();
            Cursor.Current = Cursors.Arrow;
        }
        /// <summary>
        ///  Funcions when loading a form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Arrow;
            MakeTreeView();
            MakeAllProducts();
            Cursor.Current = Cursors.Arrow;
        }
        /// <summary>
        /// Displays the parameters of the recipe.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RecipesTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Cursor.Current = Cursors.Arrow;
            if (!product.MyDishes(RecipesTreeView.SelectedNode.Text))
            {
                DishName.Text = product.dishName;
                ListOfProducts.Clear();
                for (int i=0; i<product.dishProductsName.Count; i++)
                {
                    ListOfProducts.Text += $"{product.dishProductsName[i]} - {product.dishProductCounter[i]} {product.dishProductsDim[i]}\r\n";
                }
                TextOfrepice.Text = product.dishRecipe;
            }
            Cursor.Current = Cursors.Arrow;
        }
        /// <summary>
        /// Change Enabled property.
        /// </summary>
        private void NotEnabled()
        {
            SeeButton.Enabled = !SeeButton.Enabled;
            AddButton.Enabled = !AddButton.Enabled;
            DishName.Enabled = !DishName.Enabled;
            ProductPlus.Enabled = !ProductPlus.Enabled;
            ProductCounter.Enabled = !ProductCounter.Enabled;
            ListOfProducts.Enabled = !ListOfProducts.Enabled;
            TextOfrepice.Enabled = !TextOfrepice.Enabled;
            ProductToRecept.Enabled = !ProductToRecept.Enabled;
            NotSave.Enabled = !NotSave.Enabled;
            AddRecipeButton.Enabled = !AddRecipeButton.Enabled;
        }
        /// <summary>
        /// Enables the view mode.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SeeButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            NotEnabled();
            Cursor.Current = Cursors.Arrow;
        }
        /// <summary>
        /// Enables the add mode.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            NotEnabled();
            Cursor.Current = Cursors.Arrow;
        }
        /// <summary>
        ///  Filling an item TreeView
        /// </summary>
        private void MakeTreeView()
        {
            List<string> myRecipes = product.ReturnDishes();
            RecipesTreeView.Nodes.Clear();
            foreach (string name in myRecipes)
            {
                RecipesTreeView.Nodes.Add(name);
                RecipesTreeView.Sort();
            }
        }
        /// <summary>
        /// Fills the list of products in the warehouse.
        /// </summary>
        private void MakeAllProducts()
        {
            AllProducts.Clear();
            foreach (string product in product.ReturnAllProducts())
            {
                AllProducts.Text += product;
            }
        }
        /// <summary>
        /// Starts the client form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientForm form = new ClientForm();
            form.Show();
        }
        /// <summary>
        /// Removing the dish.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteDishButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (product.DeleteDish(RecipesTreeView.SelectedNode.Text))
            {
                MakeTreeView();
                Clear();
            }
            Cursor.Current = Cursors.Arrow;
        }
        #endregion
    }
}
