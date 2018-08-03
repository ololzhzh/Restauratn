using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FunctionsLibrary;

namespace Recipes
{
    public partial class ClientForm : Form
    {
        MyInterLayer product = new MyInterLayer();
        List<string> products = new List<string>();
        TreeNode toOrder = new TreeNode();
        TreeNode toMenu = new TreeNode();
        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Arrow;
            MakeTreeView();
            MakeAllProducts();
            Cursor.Current = Cursors.Arrow;
        }

        private void MakeTreeView()
        {
            List<string> myRecipes = product.ReturnDishes();
            DishesTree.Nodes.Clear();
            foreach (string name in myRecipes)
            {
                DishesTree.Nodes.Add(name);
                DishesTree.Sort();
            }
        }

        private void OkeyOrder_Click(object sender, EventArgs e)
        {
            product.Save();
            OrderTree.Nodes.Clear();
        }

        private bool Order(string name)
        {
           if (product.Order(name))
            {
                product.Order(name, true);
                return true;
            }
            return false;
        }

        private bool OrderRemove(string name)
        {
            if (product.OrderRemove(name))
            {
                return true;
            }
            else
                return false;
        }

        private void KitchenMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            RecipesForm form = new RecipesForm();
            form.Show();
        }
        private void AddToOrder_Click(object sender, EventArgs e)
        {
            if (Order(DishesTree.SelectedNode.Text))
            {
                OrderTree.Nodes.Add(DishesTree.SelectedNode.Text);
                MakeAllProducts();
            }
        }

        private void RemoveInOrder_Click(object sender, EventArgs e)
        {
            if (OrderRemove(OrderTree.SelectedNode.Text))
            {
                OrderTree.Nodes.Remove(OrderTree.SelectedNode);
                MakeAllProducts();
            }
        }

        private void MakeAllProducts()
        {
            AllProducts.Clear();
            foreach (string product in product.ReturnAllProducts())
            {
                AllProducts.Text += product;
            }
        }

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
