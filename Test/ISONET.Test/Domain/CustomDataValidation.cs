using ISONET.Domain.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ISONET.Test.Domain
{
    [TestClass]
    public class CustomDataValidation
    {
        [TestMethod]
        public void CustomDataValidation_201_IsSecond_Shold_Be_True() => Assert.IsTrue(@"201".IsServiceCode());

        [TestMethod]
        public void CustomDataValidation_801_IsSecond_Shold_Be_False() => Assert.IsFalse(@"801".IsServiceCode());

        [TestMethod]
        public void CustomDataValidation_280_IsSecond_Shold_Be_False() => Assert.IsFalse(@"208".IsServiceCode());

        [TestMethod]
        public void CustomDataValidation_529_IsSecond_Shold_Be_False() => Assert.IsFalse(@"529".IsServiceCode());

    }
}
