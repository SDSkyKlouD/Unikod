﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SDSK.Libs.Unikod.Common;
using SDSK.Libs.Unikod.Types;

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

            Assert.AreEqual(test1.Name, "Latin Normal Uppercase");
            Assert.AreEqual(test2.Name, "Number Bold");
            CollectionAssert.AreEqual(new string[] {
                "ᵃ", "ᵇ", "ᶜ", "ᵈ", "ᵉ",
                "ᶠ", "ᵍ", "ʰ", "ⁱ", "ʲ",
                "ᵏ", "ˡ", "ᵐ", "ⁿ", "ᵒ",
                "ᵖ", null, "ʳ", "ˢ", "ᵗ",
                "ᵘ", "ᵛ", "ʷ", "ˣ", "ʸ",
                "ᶻ"
            }, test3.Data);
        }

        [TestMethod]
        public void GetSetByNameTest_IgnoreCase() {
            IUnikodSet test1 = UnicodeSets.GetSetByName("numBer doublE CirclED");
            IUnikodSet test2 = UnicodeSets.GetSetByName("latin fullwidth uppercase");
            IUnikodSet test3 = UnicodeSets.GetSetByName("lisu gLyphS for LATIN UPPERCASE obfuscation");

            Assert.IsInstanceOfType(test1, typeof(NumberSet));
            Assert.IsInstanceOfType(test2, typeof(AlphabetSet));
            Assert.IsInstanceOfType(test3, typeof(AlphabetSet));

            Assert.AreEqual(test1.Name, "Number Double Circled");
            Assert.AreEqual(test2.Name, "Latin Fullwidth Uppercase");
            CollectionAssert.AreEqual(UnicodeSets.LisuGlyphsUppercaseSet.Data, test3.Data);
        }

        [TestMethod]
        public void GetSetByNameTest_Null() {
            IUnikodSet test1 = UnicodeSets.GetSetByName("Unused Set Name");
            IUnikodSet test2 = UnicodeSets.GetSetByName(string.Empty);
            IUnikodSet test3 = UnicodeSets.GetSetByName(null);

            Assert.IsNull(test1);
            Assert.IsNull(test2);
            Assert.IsNull(test3);

            Assert.ThrowsException<NullReferenceException>(() => test1.Data.Length);
            Assert.ThrowsException<NullReferenceException>(() => test2.Name.Length);
            Assert.ThrowsException<NullReferenceException>(() => test3.StyleType.ToString());
        }

        [TestMethod]
        public void GetSetsByStyleTypeTest_Normal() {
            List<IUnikodSet> testList = UnicodeSets.GetSetsByStyleType(StyleType.Normal);

            CollectionAssert.AreEquivalent(new List<IUnikodSet>() {
                UnicodeSets.LatinNormalUppercaseSet,
                UnicodeSets.LatinNormalLowercaseSet,
                UnicodeSets.NumberNormalSet
            }, testList);
        }
    }
}
