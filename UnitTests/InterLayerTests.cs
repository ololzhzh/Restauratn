using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FunctionsLibrary;
using System.Collections.Generic;

namespace MyUnitTests
{
    [TestClass]
    public class InterLayerTests
    {
        //clear DB before using Unit-tests
        MyInterLayer layer = new MyInterLayer();

        [TestMethod]
        public void AddTestMethod_1()
        {
            Assert.AreEqual(true, layer.Add("Сосиски", "шт.", 5));
        }

        [TestMethod]
        public void MyProductsTestMethod_1()
        {
            layer.Add("Рыба", "шт.", 3);
            Assert.AreEqual(false, layer.MyProducts("Рыба", 5));
        }

        [TestMethod]
        public void MyProductsTestMethod_2()
        {
            Assert.AreEqual(true, layer.MyProducts("Каракатица", 5));
        }

        [TestMethod]
        public void MyProductsTestMethod_3()
        {
            layer.listProduct.Clear();
            layer.MyProducts("Хлеб", 5, true);
            Assert.AreEqual(1, layer.listProduct.Count);
        }

        [TestMethod]
        public void MyProductsTestMethod_4()
        {
            layer.listProduct.Clear();
            layer.MyProducts("Хлеб", 5, false);
            Assert.AreEqual(0, layer.listProduct.Count);
        }

        [TestMethod]
        public void RecipeClearTestMethod_1()
        {
            Assert.AreEqual(true, layer.RecipeClear());
            Assert.AreEqual(0, layer.listProduct.Count);

        }

        [TestMethod]
        public void AddRecipeTestMethod_1()
        {
            layer.RecipeClear();
            layer.Add("Яйцо", "шт.", 5);
            layer.MyProducts("Яйцо", 2, true);
            layer.MyProducts("Хлеб", 4, true);
            layer.AddRecipe("Гренки", "Яйца+Хлеб+Сковородка=Гренки.");
            Assert.AreEqual(false, layer.MyDishes("Гренки"));
        }

        [TestMethod]
        public void DeleteRecipeTestMethod_1()
        {
            layer.RecipeClear();
            layer.DeleteDish("Гренки");
            Assert.AreEqual(true, layer.MyDishes("Гренки"));
        }

        [TestMethod]
        public void AllDishesTestMethod_1()
        {
            List<string> dishes = layer.ReturnDishes();
            Assert.AreNotEqual(0, dishes.Count);

        }

        [TestMethod]
        public void AllProductsTestMethod_1()
        {
            List<string> products = layer.ReturnAllProducts();
            Assert.AreNotEqual(0, products.Count);

        }

        [TestMethod]
        public void SaveTestMethod_1()
        {
            Assert.AreEqual(true, layer.Save());

        }
    }
}
