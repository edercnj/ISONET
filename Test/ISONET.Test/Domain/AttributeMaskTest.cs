using ISONET.Domain.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ISONET.Test.Domain
{
    [TestClass]
    public class AttributeMaskTest
    {
        [TestMethod]
        public void AttributeMaskValidation_31_IsDay_Shold_Be_True() => Assert.IsTrue(@"31".IsDay());

        [TestMethod]
        public void AttributeMaskValidation_32_IsDay_Shold_Be_False() => Assert.IsFalse(@"32".IsDay());

        [TestMethod]
        public void AttributeMaskValidation_1_IsDay_Shold_Be_False() => Assert.IsFalse(@"1".IsDay());

        [TestMethod]
        public void AttributeMaskValidation_01_IsDay_Shold_Be_True() => Assert.IsTrue(@"01".IsDay());

        [TestMethod]
        public void AttributeMaskValidation_11_IsDay_Shold_Be_True() => Assert.IsTrue(@"11".IsDay());

        [TestMethod]
        public void AttributeMaskValidation_12_Month_Shold_Be_True() => Assert.IsTrue(@"12".IsMonth());

        [TestMethod]
        public void AttributeMaskValidation_13_Month_Shold_Be_False() => Assert.IsFalse(@"13".IsMonth());

        [TestMethod]
        public void AttributeMaskValidation_1_Month_Shold_Be_False() => Assert.IsFalse(@"1".IsMonth());

        [TestMethod]
        public void AttributeMaskValidation_13_Month_Shold_Be_True() => Assert.IsTrue(@"01".IsMonth());

        [TestMethod]
        public void AttributeMaskValidation_185_IsYear_Shold_Be_False() => Assert.IsFalse(@"185".IsYear());

        [TestMethod]
        public void AttributeMaskValidation_1899_IsYear_Shold_Be_False() => Assert.IsFalse(@"1899".IsYear());

        [TestMethod]
        public void AttributeMaskValidation_2200_IsYear_Shold_Be_False() => Assert.IsFalse(@"2200".IsYear());

        [TestMethod]
        public void AttributeMaskValidation_1900_IsYear_Shold_Be_True() => Assert.IsTrue(@"1900".IsYear());

        [TestMethod]
        public void AttributeMaskValidation_2050_IsYear_Shold_Be_True() => Assert.IsTrue(@"2070".IsYear());

        [TestMethod]
        public void AttributeMaskValidation_01_IsHour_Shold_Be_True() => Assert.IsTrue(@"01".IsHour());

        [TestMethod]
        public void AttributeMaskValidation_00_IsHour_Shold_Be_True() => Assert.IsTrue(@"00".IsHour());

        [TestMethod]
        public void AttributeMaskValidation_1_IsHour_Shold_Be_False() => Assert.IsFalse(@"1".IsHour());

        [TestMethod]
        public void AttributeMaskValidation_10_IsHour_Shold_Be_True() => Assert.IsTrue(@"10".IsHour());

        [TestMethod]
        public void AttributeMaskValidation_23_IsHour_Shold_Be_True() => Assert.IsTrue(@"23".IsHour());

        [TestMethod]
        public void AttributeMaskValidation_24_IsHour_Shold_Be_False() => Assert.IsFalse(@"24".IsHour());

        [TestMethod]
        public void AttributeMaskValidation_25_IsHour_Shold_Be_False() => Assert.IsFalse(@"25".IsHour());

        [TestMethod]
        public void AttributeMaskValidation_00_IsMinute_Shold_Be_True() => Assert.IsTrue(@"00".IsMinute());

        [TestMethod]
        public void AttributeMaskValidation_10_IsMinute_Shold_Be_True() => Assert.IsTrue(@"10".IsMinute());

        [TestMethod]
        public void AttributeMaskValidation_59_IsMinute_Shold_Be_True() => Assert.IsTrue(@"59".IsMinute());

        [TestMethod]
        public void AttributeMaskValidation_01_IsMinute_Shold_Be_True() => Assert.IsTrue(@"01".IsMinute());

        [TestMethod]
        public void AttributeMaskValidation_1_IsMinute_Shold_Be_False() => Assert.IsFalse(@"1".IsMinute());

        [TestMethod]
        public void AttributeMaskValidation_60_IsMinute_Shold_Be_False() => Assert.IsFalse(@"60".IsMinute());

        [TestMethod]
        public void AttributeMaskValidation_00_IsSecond_Shold_Be_True() => Assert.IsTrue(@"00".IsSecond());

        [TestMethod]
        public void AttributeMaskValidation_10_IsSecond_Shold_Be_True() => Assert.IsTrue(@"10".IsSecond());

        [TestMethod]
        public void AttributeMaskValidation_59_IsSecond_Shold_Be_True() => Assert.IsTrue(@"59".IsSecond());

        [TestMethod]
        public void AttributeMaskValidation_01_IsSecond_Shold_Be_True() => Assert.IsTrue(@"01".IsSecond());

        [TestMethod]
        public void AttributeMaskValidation_1_IsSecond_Shold_Be_False() => Assert.IsFalse(@"1".IsSecond());

        [TestMethod]
        public void AttributeMaskValidation_60_IsSecond_Shold_Be_False() => Assert.IsFalse(@"60".IsSecond());
    }
}