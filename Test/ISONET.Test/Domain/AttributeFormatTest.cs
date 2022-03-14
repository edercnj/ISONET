using ISONET.Domain.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ISONET.Test.Domain
{
    [TestClass]
    public class AttributeFormatTest
    {
        [TestMethod]
        public void AttributeFormatTest_IsNumeric_12345_Must_Retun_true() => Assert.IsTrue(@"12345".ContainsNumeric());

        [TestMethod]
        public void AttributeFormatTest_IsNumeric_BBBCCCDD_Must_Retun_False() => Assert.IsFalse(@"BBBCCCDD".ContainsNumeric());

        [TestMethod]
        public void AttributeFormatTest_IsAlphabetical_ABC12345_Must_Retun_true() => Assert.IsTrue(@"123A456".ContainsAlphabetical());

        [TestMethod]
        public void AttributeFormatTest_IsAlphabetical_specialChar_Must_Retun_False() => Assert.IsFalse(@"##@@&&".ContainsAlphabetical());

        [TestMethod]
        public void AttributeFormatTest_ContainlSpecialCharacter_withSpecial_Must_Retun_true() => Assert.IsTrue(@"ABC12@345".ContainsSpecialCharacter());

        [TestMethod]
        public void AttributeFormatTest_ContainlSpecialCharacter_Must_Retun_False() => Assert.IsFalse(@"123A456".ContainsSpecialCharacter());

        [TestMethod]
        public void AttributeFormatTest_ContainlSpaceAndPad_with_Space_Must_Retun_true() => Assert.IsTrue(@"ABC 12345".ContainsSpaceAndPad());

        [TestMethod]
        public void AttributeFormatTest_ContainlSpaceAndPad_With_Tab_Must_Retun_true() => Assert.IsTrue(@"ABC    12    345".ContainsSpaceAndPad());

        [TestMethod]
        public void AttributeFormatTest_ContainlSpaceAndPad_No_Space_And_No_Tab_Must_Retun_False() => Assert.IsFalse(@"123A456".ContainsSpaceAndPad());

        [TestMethod]
        public void AttributeFormatTest_IsBinary_Must_Retun_True() => Assert.IsTrue(@"2238000001C000502238000001C00050".IsBinary());

        [TestMethod]
        public void AttributeFormatTest_IsBinary_Must_Retun_False() => Assert.IsFalse(@"2238000001C000502238000001C000YYKK0".IsBinary());

        [TestMethod]
        public void AttributeFormatTest_isXFormat_C_Must_Retun_True() => Assert.IsTrue(@"C2238000001C000502238000001C000YYKK0".IsXFormat());

        [TestMethod]
        public void AttributeFormatTest_isXFormat_D_Must_Retun_True() => Assert.IsTrue(@"D2238000001C000502238000001CD000YYKK0".IsXFormat());

        [TestMethod]
        public void AttributeFormatTest_isXFormat_Must_Retun_False() => Assert.IsFalse(@"2238000001C000502238000001C000YYKK0".IsXFormat());

        [TestMethod]
        public void AttributeFormatTest_isISOTrack_Must_Retun_True() => Assert.IsTrue(@"5177560057276510=16052016373909290369".IsISOTrack());

        [TestMethod]
        public void AttributeFormatTest_isISOTrack_InvalidNumber_Must_Retun_False() => Assert.IsFalse(@"5000560057276510=16052016373909290369".IsISOTrack());

        [TestMethod]
        public void AttributeFormatTest_isISOTrack_InvalidSeparator_Must_Retun_False() => Assert.IsFalse(@"5177560057276510;16122016373909290369".IsISOTrack());

        [TestMethod]
        public void AttributeFormatTest_isISOTrack_InvalidExpiration_Must_Retun_False() => Assert.IsFalse(@"5177560057276510=16182016373909290369".IsISOTrack());
        [TestMethod]
        public void AttributeFormatTest_isISOTrack_InvalidServiceCode_Must_Retun_False() => Assert.IsFalse(@"5177560057276510=16058016373909290369".IsISOTrack());
    }
}