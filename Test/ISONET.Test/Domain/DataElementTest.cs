using ISONET.Domain.Entities;
using ISONET.Domain.Interfaces.Entities;
using ISONET.Domain.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ISONET.Test.Domain
{
    [TestClass]
    public class DataElementTest
    {
        private IDataElement de03, de07, de10, de11, de12, de52, de61;
        private IEnumerable<DataObject> dataObjects;

        [TestInitialize]
        public void TestInitialize()
        {
            dataObjects = new List<DataObject> { new DataObject(@"0001", 002, @"01"), new DataObject(@"0002", 003, @"003"), new DataObject(@"0003", 004, @"0004"), new DataObject(@"0004", 001, @"1") };

            de03 = new DataElement(new DataElementAttribute(new[] { AttributeFormat.Numeric, AttributeFormat.Numeric }, LengthType.FIXED, new[] { AttributeMask.NoMask, AttributeMask.MM }, 6, 6), 3, @"PCode", @"PCode", ConditionUse.Mandatory, @"991000");
            de07 = new DataElement(new DataElementAttribute(new[] { AttributeFormat.Numeric }, LengthType.LLVAR, new[] { AttributeMask.MM, AttributeMask.DD, AttributeMask.hh, AttributeMask.mm, AttributeMask.ss }, 10, 10), 7, @"Data e Hora GMT", @"Data e Hora GMT", ConditionUse.Mandatory, @"2106150513");
            de10 = new DataElement(new DataElementAttribute(new[] { AttributeFormat.Numeric }, LengthType.LLLVAR, new[] { AttributeMask.MM, AttributeMask.DD, AttributeMask.hh, AttributeMask.mm, AttributeMask.ss }, 15, 15), 10, @"Test LLLVAR", @"Test LLLVAR", ConditionUse.Mandatory, @"00000124567895A");
            de11 = new DataElement(new DataElementAttribute(new[] { AttributeFormat.Numeric, AttributeFormat.Alphabetical }, LengthType.LLLVAR, new[] { AttributeMask.MM, AttributeMask.DD, AttributeMask.hh, AttributeMask.mm, AttributeMask.ss }, 10, 10), 11, @"Test LLLVAR", @"Test LLLVAR", ConditionUse.Mandatory, @"1225115857");
            de12 = new DataElement(new DataElementAttribute(new[] { AttributeFormat.Numeric }, LengthType.LLLVAR, new[] { AttributeMask.MM, AttributeMask.DD, AttributeMask.hh, AttributeMask.mm, AttributeMask.ss }, 15, 15), 12, @"Test LLLVAR", @"Test LLLVAR", ConditionUse.Mandatory, @"AYAAAAAAAABBBBB");
            de61 = new DataElement(new DataElementAttribute(new[] { AttributeFormat.Numeric }, LengthType.FIXED, new[] { AttributeMask.MM, AttributeMask.DD, AttributeMask.hh, AttributeMask.mm, AttributeMask.ss }, 38, 38), 52, @"Test LLLVAR", @"Test LLLVAR", ConditionUse.Mandatory, dataObjects);
        }

        [TestMethod]
        public void DataElementToString_Fixed_Must_Return_991000() => Assert.AreEqual(@"991000", de03.ToString());

        [TestMethod]
        public void DataElementToString_LLVAR_Must_Return_102106150513() => Assert.AreEqual(@"102106150513", de07.ToString());

        [TestMethod]
        public void DataElementToString_LLLVAR_Must_Return_015000001245678954() => Assert.AreEqual(@"01500000124567895A", de10.ToString());

        [TestMethod]
        public void DataElementToString_de61_Must_Return_00010020100020030030003004000400040011() => Assert.AreEqual(@"00010020100020030030003004000400040011", de61.ToString());

        [TestMethod]
        public void DataElement_IsValid_Must_Return_True() => Assert.IsTrue(de03.IsValid());

        [TestMethod]
        public void DataElement_IsValid_Must_Return_False() => Assert.IsFalse(de10.IsValid());

        [TestMethod]
        public void DataElement_NUMERIC_ALPHABETICAL_IsValid_Must_Return_True() => Assert.IsTrue(de11.IsValid());

        [TestMethod]
        public void DataElement_ALPHABETICAL_Must_Return_False() => Assert.IsFalse(de12.IsValid());

        [TestMethod]
        [ExpectedException(typeof(ApplicationException), @"Comprimento do dataElementAttribute.Length diferente do valor definido no campo dataObjects.ToString().Length")]
        public void DataElement_de52_With_Overflow_Lenght_Must_Return_ApplicationException()
        {
            try
            {
                de52 = new DataElement(new DataElementAttribute(new[] { AttributeFormat.Numeric }, LengthType.FIXED, new[] { AttributeMask.MM, AttributeMask.DD, AttributeMask.hh, AttributeMask.mm, AttributeMask.ss }, 8, 8), 52, @"Test LLLVAR", @"Test LLLVAR", ConditionUse.Mandatory, @"01030905000");
                Assert.Fail(@"Este teste precisa falhar!");
            }
            catch (ApplicationException err)
            {
                Console.Out.WriteLine(err.Message);
                throw;
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException), @"Comprimento do dataElementAttribute.Length diferente do valor definido no campo dataObjects.ToString().Length")]
        public void DataElement_de61_With_Overflow_Lenght_Must_Return_ApplicationException()
        {
            try
            {
                de61 = new DataElement(new DataElementAttribute(new[] { AttributeFormat.Numeric }, LengthType.LLLVAR, new[] { AttributeMask.MM, AttributeMask.DD, AttributeMask.hh, AttributeMask.mm, AttributeMask.ss }, 35, 35), 52, @"Test LLLVAR", @"Test LLLVAR", ConditionUse.Mandatory, dataObjects);
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