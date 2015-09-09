using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataApp.Core.Abstracts;
using DataApp.Core.Factories;
using DataApp.Core.Models;

namespace DataApp.Core.Test
{
    [TestClass]
    public class UserControllerTest
    {
        IUserController target = null;

        [TestInitialize]
        public void Init()
        {
            this.target = ControllerFactory.CreateIUserController();
            target.Delete(1);
        }

        [TestCleanup]
        public void CleanUp()
        {
            this.target.Delete(1);
        }

        [TestMethod]
        public void TestAdd()
        {
            //arrange
            User user = new User();
            user.Username = "test";
            user.Password = "test";

            //act


            //assert
            Assert.IsTrue(target.Add(user));
        }

        [TestMethod]
        public void TestUpdate()
        {
            //arrange
            User user = new User();
            user.Id = 1;
            user.Username = "test";
            user.Password = "test";

            //act
            target.Add(user); //insert
            user.Username = "UPDATE";//update data
            user.Password = "UPDATE";

            //assert
            Assert.IsTrue(target.Update(user));
        }

        [TestMethod]
        public void TestDelete()
        {
            //arrange
            User user = new User();
            user.Id = 1;
            user.Username = "test";
            user.Password = "test";

            //act
            target.Add(user); //insert
            //assert
            Assert.IsTrue(target.Delete(1));
        }

        [TestMethod]
        public void TestGet()
        {
            //arrange
            User user = new User();
            user.Id = 1;
            user.Username = "test";
            user.Password = "test";

            //act
            target.Add(user); //insert

            //assert
            Assert.IsNotNull(target.Get(1));
        }

        [TestMethod]
        public void TestGetAll()
        {
            //arrange

            //act


            //assert
            Assert.IsTrue(target.Get().Count > 0 ? true : false);
        }

        [TestMethod]
        public void TestLogin()
        {
            //arrange
            User result = null;
            User user = new User();
            user.Id = 1;
            user.Username = "userxxx";
            user.Password = "passxxx";

            //act
            target.Add(user); //insert
            result = target.Login("userxxx", "passxxx");
            //assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Token.Length > 0 ? true:false);
        }

        [TestMethod]
        public void TestLogout()
        {
            //arrange
            User result = null;

            User user = new User();
            user.Id = 1;
            user.Username = "userxxx";
            user.Password = "passxxx";

            //act
            target.Add(user); //insert
            target.Login("userxxx", "passxxx");
            target.Logout(user.Id);

            result = target.Get(1);
            //assert
            Assert.IsNotNull(result);
            Assert.IsTrue(String.IsNullOrEmpty(result.Token));
        }
    }
}
