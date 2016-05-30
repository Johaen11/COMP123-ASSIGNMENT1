using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using COMP123_Assignment1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void generateAbilitiesTestMethod()
        {
            Hero hero = new Hero("johaen");

            hero.Fight();
            hero.Show();

            //Arrange
            int _strength;
            int _speed;
            int _health;
            int expectedResult;
            //Act

            //Assert

        }

        [TestMethod]
        public void hitAttempt()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void hitDamage()
        {
            //Arrange

            //Act

            //Assert

        }
        [TestMethod]
        public void fight()
        {
            //Arrange

            //Act

            //Assert


        }


        [TestMethod]
        public void show()
        {
            //Arrange

            //Act

            //Assert


        }



    }
}
