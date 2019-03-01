using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SDSK.Libs.Unikod.Common;

namespace SDSK.Libs.Unikod.Test {
    [TestClass]
    public class OtherUnikodUtilsTest {
        [TestMethod]
        public void GetSetByNameTest_Normal() {
            IUnikodSet test1 = UnicodeSets.GetSetByName("Latin Normal Uppercase");
            IUnikodSet test2 = UnicodeSets.GetSetByName("Number Bold");
            IUnikodSet test3 = UnicodeSets.GetSetByName("Latin Modifier(Superscript) Lowercase");

            Assert.IsInstanceOfType(test1, typeof(AlphabetSet));
            Assert.IsInstanceOfType(test2, typeof(NumberSet));
            Assert.IsInstanceOfType(test3, typeof(AlphabetSet));

            Assert.AreEqual(test1.SetName, "Latin Normal Uppercase");
            Assert.AreEqual(test2.SetName, "Number Bold");
            CollectionAssert.AreEqual(new string[] {
                "ᵃ", "ᵇ", "ᶜ", "ᵈ", "ᵉ",
                "ᶠ", "ᵍ", "ʰ", "ⁱ", "ʲ",
                "ᵏ", "ˡ", "ᵐ", "ⁿ", "ᵒ",
                "ᵖ", null, "ʳ", "ˢ", "ᵗ",
                "ᵘ", "ᵛ", "ʷ", "ˣ", "ʸ",
                "ᶻ"
            }, test3.SetData);
        }

        [TestMethod]
        public void GetSetByNameTest_IgnoreCase() {
            IUnikodSet test1 = UnicodeSets.GetSetByName("numBer doublE CirclED");
            IUnikodSet test2 = UnicodeSets.GetSetByName("latin fullwidth uppercase");
            IUnikodSet test3 = UnicodeSets.GetSetByName("lisu gLyphS for LATIN UPPERCASE obfuscation");

            Assert.IsInstanceOfType(test1, typeof(NumberSet));
            Assert.IsInstanceOfType(test2, typeof(AlphabetSet));
            Assert.IsInstanceOfType(test3, typeof(AlphabetSet));

            Assert.AreEqual(test1.SetName, "Number Double Circled");
            Assert.AreEqual(test2.SetName, "Latin Fullwidth Uppercase");
            CollectionAssert.AreEqual(new string[] {
                "ꓮ", "ꓐ", "ꓚ", "ꓓ", "ꓰ",
                "ꓝ", "ꓖ", "ꓧ", "ꓲ", "ꓙ",
                "ꓗ", "ꓡ", "ꓟ", "ꓠ", "ꓳ",
                "ꓑ", null, "ꓣ", "ꓢ", "ꓔ",
                "ꓴ", "ꓦ", "ꓪ", "ꓫ", "ꓬ",
                null
            }, test3.SetData);
        }

        [TestMethod]
        public void GetSetByNameTest_Null() {
            IUnikodSet test1 = UnicodeSets.GetSetByName("Unused Set Name");
            IUnikodSet test2 = UnicodeSets.GetSetByName(string.Empty);
            IUnikodSet test3 = UnicodeSets.GetSetByName(null);

            Assert.IsNull(test1);
            Assert.IsNull(test2);
            Assert.IsNull(test3);

            Assert.ThrowsException<NullReferenceException>(() => test1.SetData.Length);
            Assert.ThrowsException<NullReferenceException>(() => test2.SetName.Length);
            Assert.ThrowsException<NullReferenceException>(() => test3.StyleType.ToString());
        }
    }
}
