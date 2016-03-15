using ISONET.Domain.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ISONET.Test.Domain
{
    [TestClass]
    public class AttributeFormatTest
    {
        [TestMethod]
        public void AttributeFormatTest_IsNumeric_12345_Must_Retun_true()
        {
            Assert.IsTrue(AttributeFormatValidation.ContainNumeric("12345"));
        }

        [TestMethod]
        public void AttributeFormatTest_IsNumeric_AA1B45_Must_Retun_False()
        {
            Assert.IsFalse(AttributeFormatValidation.ContainNumeric("BBBCCCDD"));
        }

        [TestMethod]
        public void AttributeFormatTest_IsAlphabetical_ABC12345_Must_Retun_true()
        {
            Assert.IsTrue(AttributeFormatValidation.ContainAlphabetical("123A456"));
        }

        [TestMethod]
        public void AttributeFormatTest_IsAlphabetical_specialChar_Must_Retun_False()
        {
            Assert.IsFalse(AttributeFormatValidation.ContainAlphabetical("##@@&&"));
        }

        [TestMethod]
        public void AttributeFormatTest_ContainlSpecialCharacter_withSpecial_Must_Retun_true()
        {
            Assert.IsTrue(AttributeFormatValidation.ContainlSpecialCharacter("ABC12@345"));
        }

        [TestMethod]
        public void AttributeFormatTest_ContainlSpecialCharacter_Must_Retun_False()
        {
            Assert.IsFalse(AttributeFormatValidation.ContainlSpecialCharacter("123A456"));
        }

        [TestMethod]
        public void AttributeFormatTest_ContainlSpaceAndPad_with_Space_Must_Retun_true()
        {
            Assert.IsTrue(AttributeFormatValidation.ContainlSpaceAndPad("ABC 12345"));
        }

        [TestMethod]
        public void AttributeFormatTest_ContainlSpaceAndPad_With_Tab_Must_Retun_true()
        {
            Assert.IsTrue(AttributeFormatValidation.ContainlSpaceAndPad("ABC    12    345"));
        }

        [TestMethod]
        public void AttributeFormatTest_ContainlSpaceAndPad_No_Space_And_No_Tab_Must_Retun_False()
        {
            Assert.IsFalse(AttributeFormatValidation.ContainlSpaceAndPad("123A456"));
        }
    }
}