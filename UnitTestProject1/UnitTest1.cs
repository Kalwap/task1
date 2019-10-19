using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibtask1;

namespace UnitTestProject1
{
    
    
    
     
        
            [TestClass]
        public class UnitTest1
        {
            [TestMethod]
            [ExpectedException(typeof(ArgumentOutOfRangeException))]

            public static void TestTitle()
            {

                //Arrange
                Book book = new Book();
                //Act

                book.Title = "a";






            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentOutOfRangeException))]

            public static void TestISBN()
            {
                //Arrange
                Book book = new Book();
                //Act
                book.Lsbn13 = "12345";
                //expect expectation


            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentOutOfRangeException))]

            public static void TestPageNum()
            {
                //Arrange
                Book book = new Book();
                //Act
                book.PageNum = 1;


            }
        }
  }
    

