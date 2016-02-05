using ISONET.Domain.Entities;
using ISONET.Domain.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ISONET.Test.Domain
{
    [TestClass]
    public class LengthTypeTest
    {
        [TestMethod]
        public void LengthType_LLVAR_MaxLength_100_Must_Retun_False()
        {
            Assert.IsFalse(LengthTypeValidation.MaxLengthIsValid(LengthType.LLVAR, 100));
        }

        [TestMethod]
        public void LengthType_LLVAR_MaxLength_99_Must_Retun_True()
        {
            Assert.IsTrue(LengthTypeValidation.MaxLengthIsValid(LengthType.LLVAR, 99));
        }

        [TestMethod]
        public void LengthType_LLLVAR_MaxLength_1000_Must_Retun_False()
        {
            Assert.IsFalse(LengthTypeValidation.MaxLengthIsValid(LengthType.LLLVAR, 1000));
        }

        [TestMethod]
        public void LengthType_LLLVAR_MaxLength_999_Must_Retun_True()
        {
            Assert.IsTrue(LengthTypeValidation.MaxLengthIsValid(LengthType.LLLVAR, 999));
        }

        [TestMethod]
        public void LengthType_FIXED_MaxLength_1000_Must_Retun_False()
        {
            Assert.IsFalse(LengthTypeValidation.MaxLengthIsValid(LengthType.FIXED, 1000));
        }

        [TestMethod]
        public void LengthType_FIXED_MaxLength_999_Must_Retun_True()
        {
            Assert.IsTrue(LengthTypeValidation.MaxLengthIsValid(LengthType.FIXED, 999));
        }
    }
}