﻿using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCartDomain.Entities;

namespace ShoppingCartDemoTest
{
    [TestClass]
    public class CartTest
    {
        [TestMethod]
        public void Can_Add_Items()
        {
            //Arrange 
            Product p1 = new Product { Id = 1, Name = "P1" };
            Product p2 = new Product { Id = 2, Name = "P2" };

            //Arrange
            Cart cart = new Cart();

            //Act
            cart.AddItem(p1, 1);
            CartItem[] list = cart.GetCartItems.ToArray();
            //Assert
            Assert.AreEqual(list[0].Product, p1);
            //Act
            cart.RemoveSingleItem(p1);
            Assert.AreEqual(cart.CartValueTotal(), 0);
            Assert.AreEqual(cart.GetCartItems.Any(), false);
        }

        public void Does_Increase_Quantity()
        {
            //Arrange
            Product p1 = new Product { Id = 1, Name = "P1" };
            Product p2 = new Product { Id = 2, Name = "P2" };

            Cart cart = new Cart();

            cart.AddItem(p1, 1);
            cart.AddItem(p2, 1);
            cart.AddItem(p1, 10);
            CartItem[] list = cart.GetCartItems.OrderBy(c => c.Product.Id).ToArray();

            Assert.AreEqual(list.Length, 2);
            Assert.AreEqual(list[0].Quantity, 11);
            Assert.AreEqual(list[1].Quantity, 1);
        }

        public void Calculate_Cart_Total()
        {
            Product p1 = new Product { Id = 1, Name = "P1", Price = 100m};
            Product p2 = new Product { Id = 2, Name = "P2", Price = 100m };

            Cart cart = new Cart();

            cart.AddItem(p1, 1);
            cart.AddItem(p2, 1);
            cart.AddItem(p1, 2);

            Assert.AreEqual(cart.CartValueTotal(), 400m);

        }
    }
}