using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class ET_DevCounterTest
    {
        [Test]
        public void TestIncrement () 
        {
            //Assign
            var counter = new DEV_BasicCounter(0);

            //Act
            counter.Increment();

            //Assert
            Assert.AreEqual(1, counter.Count);

        }

        [Test]
        public void TestMaxCount ()
        {
        
                var counter = new DEV_BasicCounter(10);

                counter.Increment();

                Assert.AreEqual(10, counter.Count);
            
        }
    }
}
