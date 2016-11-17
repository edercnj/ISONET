using ISONET.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ISONET.Test.Domain
{
    [TestClass]
    public class DataObjectTest
    {
        private IEnumerable<DataObject> do01, do02;

        [TestInitialize]
        public void TestInitialize()
        {
            do01 = new List<DataObject> { new DataObject(@"0001", 002, @"01"), new DataObject(@"0002", 003, @"003"), new DataObject(@"0003", 004, @"0004"), new DataObject(@"0004", 001, @"1") };
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException), @"Comprimento do value.Length diferente do valor definido no campo Length.")]
        public void DataElementToString_Fixed_Must_Return_991000()
        {
            try
            {
                do02 = new List<DataObject> { new DataObject(@"0001", 002, @"0100") };
                Assert.Fail(@"Este teste precisa falhar!");
            }
            catch (ApplicationException err)
            {
                Console.Out.WriteLine(err.Message);
                throw;
            }
        }
    }
}