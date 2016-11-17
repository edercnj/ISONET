using ISONET.Domain.Entities;
using ISONET.Domain.Interfaces.Entities;
using ISONET.Domain.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ISONET.Test.Domain
{
    [TestClass]
    public class LengthTypeTest
    {
        private IDataElementAttribute attr01, attr02, attr03, attr04, attr05, attr06, attr07, attr08;

        [TestInitialize]
        public void TestInitialize()
        {
            attr01 = new DataElementAttribute(new[] { AttributeFormat.Numeric }, LengthType.LLVAR, new[] { AttributeMask.NoMask }, 100, 100);
            attr02 = new DataElementAttribute(new[] { AttributeFormat.Numeric }, LengthType.LLVAR, new[] { AttributeMask.NoMask }, 99, 99);
            attr03 = new DataElementAttribute(new[] { AttributeFormat.Numeric }, LengthType.LLLVAR, new[] { AttributeMask.NoMask }, 1000, 1000);
            attr04 = new DataElementAttribute(new[] { AttributeFormat.Numeric }, LengthType.LLLVAR, new[] { AttributeMask.NoMask }, 999, 999);
            attr05 = new DataElementAttribute(new[] { AttributeFormat.Numeric }, LengthType.FIXED, new[] { AttributeMask.NoMask }, 1000, 1000);
            attr06 = new DataElementAttribute(new[] { AttributeFormat.Numeric }, LengthType.FIXED, new[] { AttributeMask.NoMask }, 999, 999);
            attr07 = new DataElementAttribute(new[] { AttributeFormat.Numeric }, LengthType.FIXED, new[] { AttributeMask.NoMask }, 999, 998);
            attr08 = new DataElementAttribute(new[] { AttributeFormat.Numeric }, LengthType.LLLVAR, new[] { AttributeMask.NoMask }, 700, 701);
        }

        [TestMethod]
        public void LengthType_LLVAR_MaxLength_100_Must_Retun_False() => Assert.IsFalse(attr01.MaxLengthIsValid());

        [TestMethod]
        public void LengthType_LLVAR_MaxLength_99_Must_Retun_True() => Assert.IsTrue(attr02.MaxLengthIsValid());

        [TestMethod]
        public void LengthType_LLLVAR_MaxLength_1000_Must_Retun_False() => Assert.IsFalse(attr03.MaxLengthIsValid());

        [TestMethod]
        public void LengthType_LLLVAR_MaxLength_999_Must_Retun_True() => Assert.IsTrue(attr04.MaxLengthIsValid());

        [TestMethod]
        public void LengthType_FIXED_MaxLength_1000_Must_Retun_False() => Assert.IsFalse(attr05.MaxLengthIsValid());

        [TestMethod]
        public void LengthType_FIXED_MaxLength_999_Must_Retun_True() => Assert.IsTrue(attr06.MaxLengthIsValid());

        [TestMethod]
        public void MaxLenght_999_Lenght_998_Must_Return_True() => Assert.IsTrue(attr07.LengthIsValid());

        [TestMethod]
        public void MaxLenght_700_Lenght_701_Must_Return_False() => Assert.IsFalse(attr08.LengthIsValid());
    }
}