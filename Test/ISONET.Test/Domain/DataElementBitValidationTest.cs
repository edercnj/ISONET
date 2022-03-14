using ISONET.Domain.Entities;
using ISONET.Domain.Interfaces.Entities;
using ISONET.Domain.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ISONET.Test.Domain

{
    [TestClass]
    public class DataElementBitValidationTest
    {
        private IDataElement deNegativo, de00, de01, de128, de129;

        [TestInitialize]
        public void TestInitialize()
        {
            deNegativo = new DataElement(new DataElementAttribute(new[] { AttributeFormat.Numeric, AttributeFormat.Numeric }, LengthType.FIXED, new[] { AttributeMask.NoMask, AttributeMask.MM }, 6, 6), -5, @"PCode", @"PCode", ConditionUse.Mandatory, @"991000");
            de01 = new DataElement(new DataElementAttribute(new[] { AttributeFormat.Numeric, AttributeFormat.Numeric }, LengthType.FIXED, new[] { AttributeMask.NoMask, AttributeMask.MM }, 6, 6), 01, @"PCode", @"PCode", ConditionUse.Mandatory, @"991000");
            de00 = new DataElement(new DataElementAttribute(new[] { AttributeFormat.Numeric, AttributeFormat.Numeric }, LengthType.FIXED, new[] { AttributeMask.NoMask, AttributeMask.MM }, 6, 6), 00, @"PCode", @"PCode", ConditionUse.Mandatory, @"991000");
            de128 = new DataElement(new DataElementAttribute(new[] { AttributeFormat.Numeric, AttributeFormat.Numeric }, LengthType.FIXED, new[] { AttributeMask.NoMask, AttributeMask.MM }, 6, 6), 128, @"PCode", @"PCode", ConditionUse.Mandatory, @"991000");
            de129 = new DataElement(new DataElementAttribute(new[] { AttributeFormat.Numeric, AttributeFormat.Numeric }, LengthType.FIXED, new[] { AttributeMask.NoMask, AttributeMask.MM }, 6, 6), 129, @"PCode", @"PCode", ConditionUse.Mandatory, @"991000");
        }

        [TestMethod]
        public void DataElementBitValidation_Bit_01_Must_Return_True() => Assert.IsTrue(de01.BitIsValid());

        [TestMethod]
        public void DataElementBitValidation_Bit_128_Must_Return_True() => Assert.IsTrue(de128.BitIsValid());

        [TestMethod]
        public void DataElementBitValidation_Bit_00_Must_Return_False() => Assert.IsFalse(de00.BitIsValid());

        [TestMethod]
        public void DataElementBitValidation_Bit_deNegativo_Must_Return_False() => Assert.IsFalse(deNegativo.BitIsValid());

        [TestMethod]
        public void DataElementBitValidation_Bit_129_Must_Return_False() => Assert.IsFalse(de129.BitIsValid());
    }
}