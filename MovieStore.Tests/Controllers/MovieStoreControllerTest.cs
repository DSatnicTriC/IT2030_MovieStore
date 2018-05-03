using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieStore.Controllers;
using MovieStore.Models;

namespace MovieStore.Tests.Controllers
{
    [TestClass]
    public class MovieStoreControllerTest
    {
        [TestMethod]
        public void MovieStore_Index_TestView()
        {
            //Arrange
            MoviesController controller = new MoviesController();

            //Act
            ViewResult result = controller.Index() as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void MovieStore_ListOfMovies()
        {
            //Arrange
            MoviesController controller = new MoviesController();

            //Act
            var result = controller.ListOfMovies();

            //Assert
            Assert.AreEqual("Terminator 1", result[0].Title);
            Assert.AreEqual("Terminator 2", result[1].Title);
            Assert.AreEqual("Terminator 3", result[2].Title);
        }

        [TestMethod]
        public void MovieStore_IndexRedirect()
        {
            //Arrange
            MoviesController controller = new MoviesController();

            //Act
            var result = controller.IndexRedirect() as RedirectToRouteResult;

            //Assert
            Assert.AreEqual("Create", result.RouteValues["action"]);
            Assert.AreEqual("Home", result.RouteValues["controller"]);
        }
    }
}
