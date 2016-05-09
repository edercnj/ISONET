using ISONET.Domain.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ISONET.Test.Domain
{
    [TestClass]
    public class ConvertTest
    {
        private bool[] _binaryBoolArray;
        private string _binaryString;
        private char[] _charArray;
        private string _hexaString;

        [TestInitialize]
        public void TestInitialize()
        {
            _binaryString = "00100010001110000000000000000000000000011100000000000000010100000010001000111000000000000000000000000001110000000000000001010000";
            _hexaString = "2238000001C000502238000001C00050";

            _binaryBoolArray = new[]
            {
                false, false, true, false, false, false, true, false,
                false, false, true, true, true, false, false, false,
                false, false, false, false, false, false, false, false,
                false, false, false, false, false, false, false, false,
                false, false, false, false, false, false, false, true,
                true,  true, false, false, false, false, false, false,
                false, false, false, false, false, false, false, false,
                false, true, false, true, false, false, false, false,
                false, false, true, false, false, false, true, false,
                false, false, true, true, true, false, false, false,
                false, false, false, false, false, false, false, false,
                false, false, false, false, false, false, false, false,
                false, false, false, false, false, false, false, true,
                true, true, false, false, false, false, false, false,
                false, false, false, false, false, false, false, false,
                false, true, false, true, false, false, false, false
            };

            _charArray = new[]
            {
                '0', '0', '1', '0', '0', '0', '1', '0',
                '0', '0', '1', '1', '1', '0', '0', '0',
                '0', '0', '0', '0', '0', '0', '0', '0',
                '0', '0', '0', '0', '0', '0', '0', '0',
                '0', '0', '0', '0', '0', '0', '0', '1',
                '1', '1', '0', '0', '0', '0', '0', '0',
                '0', '0', '0', '0', '0', '0', '0', '0',
                '0', '1', '0', '1', '0', '0', '0', '0',
                '0', '0', '1', '0', '0', '0', '1', '0',
                '0', '0', '1', '1', '1', '0', '0', '0',
                '0', '0', '0', '0', '0', '0', '0', '0',
                '0', '0', '0', '0', '0', '0', '0', '0',
                '0', '0', '0', '0', '0', '0', '0', '1',
                '1', '1', '0', '0', '0', '0', '0', '0',
                '0', '0', '0', '0', '0', '0', '0', '0',
                '0', '1', '0', '1', '0', '0', '0', '0'
            };
        }

        [TestMethod]
        public void ToBinaryString_Hexa_Value_hexaString_Must_Equals_binaryString()
        {
            Assert.AreEqual(DataConvert.ToBinaryString(_hexaString), _binaryString);
        }

        [TestMethod]
        public void ToBitMap_hexaString_Must_Be_Equals_binaryBoolArray()
        {
            CollectionAssert.AreEqual(DataConvert.ToBitMap(_hexaString), _binaryBoolArray);
        }

        [TestMethod]
        public void ToCharArray_binaryString_Must_Be_Equals_charArray()
        {
            CollectionAssert.AreEqual(DataConvert.ToCharArray(_binaryString), _charArray);
        }

        [TestMethod]
        public void ToBoolArray_charArray_Must_Be_Equals_binaryBoolArray()
        {
            CollectionAssert.AreEqual(DataConvert.ToBoolArray(_charArray), _binaryBoolArray);
        }
    }
}