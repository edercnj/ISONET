using ISONET.Domain.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ISONET.Test.Domain
{
    [TestClass]
    public class ConvertTest
    {
        private bool[] _binaryBoolArray;
        private string _hexaString;
        private string _binaryString;
        private char[] _charArray;

        [TestInitialize]
        public void TestInitialize()
        {
            _binaryString = "0010001000111000000000000000000000000001110000000000000001010000";
            _hexaString = "2238000001C00050";

            _binaryBoolArray = new bool[64]{
                false, false, true,  false, false, false, true,  false,
                false, false, true,  true,  true,  false, false, false,
                false, false, false, false, false, false, false, false,
                false, false, false, false, false, false, false, false,
                false, false, false, false, false, false, false, true,
                true,  true,  false, false, false, false, false, false,
                false, false, false, false, false, false, false, false,
                false, true,  false, true,  false, false, false, false
            };

            _charArray = new char[64]
            {
                '0','0','1','0','0','0','1','0',
                '0','0','1','1','1','0','0','0',
                '0','0','0','0','0','0','0','0',
                '0','0','0','0','0','0','0','0',
                '0','0','0','0','0','0','0','1',
                '1','1','0','0','0','0','0','0',
                '0','0','0','0','0','0','0','0',
                '0','1','0','1','0','0','0','0',
            };
        }

        [TestMethod]
        public void ToBinaryString_Hexa_Value_hexaString_Must_Equals_binaryString()
        {
            Assert.AreEqual(MessageConvert.ToBinaryString(_hexaString), _binaryString);
        }

        [TestMethod]
        public void ToBitMap_hexaString_Must_Be_Equals_binaryBoolArray()
        {
            CollectionAssert.AreEqual(MessageConvert.ToBitMap(_hexaString), _binaryBoolArray);
        }

        [TestMethod]
        public void ToCharArray_binaryString_Must_Be_Equals_charArray()
        {
            CollectionAssert.AreEqual(MessageConvert.ToCharArray(_binaryString), _charArray);
        }

        [TestMethod]
        public void ToBoolArray_charArray_Must_Be_Equals_binaryBoolArray()
        {
            CollectionAssert.AreEqual(MessageConvert.ToBoolArray(_charArray), _binaryBoolArray);
        }
    }
}