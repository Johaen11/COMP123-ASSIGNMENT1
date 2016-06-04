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
            HeroTest hero = new HeroTest("johaen");

            bool expectedResult = true;
            bool actualResult = hero._generateAbilities();

            Assert.AreEqual(expectedResult, actualResult);
            
            /*hero.Fight();
            hero.Show();

            //Arrange
            int _strength;
            int _speed;
            int _health;
            int expectedResult;
            //Act

            //Assert*/

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
            HeroTest hero = new HeroTest("johaen");
            
            int actualResult = hero._hitDamage();

            Assert.IsTrue(actualResult >= 1 && actualResult <= 600);
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
