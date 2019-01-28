using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SDSK.Libs.Unikod.Common;

namespace SDSK.Libs.Unikod.Test {
    [TestClass]
    public class OtherUnikodUtilsTest {
        [TestMethod]
        public void GetSetByName_Test() {
            IUnikodSet test1 = UnicodeSets.GetSetByName("Latin Normal Uppercase");
            IUnikodSet test2 = UnicodeSets.GetSetByName("Number Bold");
            IUnikodSet test3 = UnicodeSets.GetSetByName("Unused Set Name");

            Assert.IsInstanceOfType(test1, typeof(AlphabetSet));
            Assert.IsInstanceOfType(test2, typeof(NumberSet));
            Assert.IsNull(test3);

            Assert.AreEqual(test1.SetName, "Latin Normal Uppercase");
            Assert.AreEqual(test2.SetName, "Number Bold");
            Assert.ThrowsException<NullReferenceException>(() => test3.SetName.Equals("Unused Set Name"));
        }
    }
}
