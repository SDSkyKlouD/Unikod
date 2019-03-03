using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SDSK.Libs.Unikod.Test {
    [TestClass]
    public class NormalizeTest {
        [TestMethod]
        public void NormalizeTest_OneStylePerText() {
            string testText1 = "𝐘𝐨𝐮 𝐚𝐫𝐞 𝐦𝐲 𝐒𝐇𝐘 𝐁𝐎𝐘";
            string testText2 = "𝔸𝕝𝕝 𝕀 𝕎𝕒𝕟𝕥 𝔽𝕠𝕣 ℂ𝕙𝕣𝕚𝕤𝕥𝕞𝕒𝕤 𝕀𝕤 𝔾𝕆𝔻𝔻𝔸𝕄ℕ 𝕄𝕆ℕ𝔼𝕐";
            string testText3 = "ℌ𝔢𝔶 𝔟𝔯𝔬 ℑ 𝔤𝔬𝔱𝔱𝔞 𝔪𝔬𝔳𝔢 𝔬𝔫";
            string testText4 = "🇹🇭🇪 🇶🇺🇮🇨🇰 🇧🇷🇴🇼🇳 🇫🇴🇽 🇯🇺🇲🇵🇸 🇴🇻🇪🇷 🇹🇭🇪 🇱🇦🇿🇾 🇩🇴🇬";

            Assert.AreEqual("You are my SHY BOY", UnikodUtils.Normalize(testText1), false);
            Assert.AreEqual("All I Want For Christmas Is GODDAMN MONEY", UnikodUtils.Normalize(testText2), false);
            Assert.AreEqual("Hey bro I gotta move on", UnikodUtils.Normalize(testText3), false);
            Assert.AreEqual("THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG", UnikodUtils.Normalize(testText4), false);
        }

        [TestMethod]
        public void NormalizeTest_OneStylePerText_MixWithSpecialCharacters() {
            string testText1 = "𝐔𝐧𝐝𝐞𝐫 𝐭𝐡𝐞 𝐭𝐫𝐞𝐞 𝐰𝐡𝐞𝐫𝐞 𝐭𝐡𝐞 𝐠𝐫𝐚𝐬𝐬 𝐝𝐨𝐧'𝐭 𝐠𝐫𝐨𝐰 @@@@##$%!*";
            string testText2 = "𝑊𝑎𝑡𝑎𝑠ℎ𝑖, 𝐾𝑖 𝑛𝑖 𝑁𝑎𝑟𝑖𝑚𝑎𝑠𝑢! -/**\\|\\()";
            string testText3 = "𝒮𝒸ℴℴ𝓉ℯ𝓇 𝒷𝓇ℴ𝓉𝒽ℯ𝓇𝓈! 𝒮𝒞𝒪𝒪𝒯ℰℛ ℬℛ𝒪𝒯ℋℰℛ𝒮!!! ##^&**%!(**)";

            Assert.AreEqual("Under the tree where the grass don't grow @@@@##$%!*", UnikodUtils.Normalize(testText1), false);
            Assert.AreEqual("Watashi, Ki ni Narimasu! -/**\\|\\()", UnikodUtils.Normalize(testText2), false);
            Assert.AreEqual("Scooter brothers! SCOOTER BROTHERS!!! ##^&**%!(**)", UnikodUtils.Normalize(testText3), false);
        }

        [TestMethod]
        public void NormalizeTest_MultiStylesPerText() {
            string testText1 = "Ⓗⓔⓐⓡⓣⓐⓒⓗⓔ, 𝗁𝖾𝖺𝗋𝗍𝖻𝗋𝖾𝖺𝗄, ᵃˡˡ ᵒᵛᵉʳ ᵗᵒʷⁿ";
            string testText2 = "𝗯𝘂𝘁 𝘀𝗼𝗺𝗲𝘁𝗵𝗶𝗻𝗴 𝘧𝘭𝘪𝘱𝘱𝘦𝘥 𝘭𝘪𝘬𝘦 𝚊 𝚜𝚠𝚒𝚝𝚌𝚑";
            string testText3 = "𝙬𝙝𝙚𝙣 𝙮𝙤𝙪 came ａｒ𝖔𝖚𝓷𝓭";

            Assert.AreEqual("Heartache, heartbreak, all over town", UnikodUtils.Normalize(testText1), false);
            Assert.AreEqual("but something flipped like a switch", UnikodUtils.Normalize(testText2), false);
            Assert.AreEqual("when you came around", UnikodUtils.Normalize(testText3), false);
        }
        
        [TestMethod]
        public void NormalizeTest_NumberOnly_OneStylePerText() {
            string testText1 = "𝟏𝟐𝟑𝟒𝟓𝟔𝟕𝟖𝟗𝟎";
            string testText2 = "③⑥②③①⑥④⑧⑨④⑥⑤①⑤③①③②①①⑥①⑥⑤⓪①⑥⑧④⑥④⑧⑨⑨⑤⑦⑨⑧⑤②③⓪";
            string testText3 = "❾❾❽❾❺❻❶❻❺❶❺❷⓿⓿❶❹❻❹❽❼❹❽❾❾❺❻❷❸⓿❶❺❹❻❹❽❾";

            Assert.AreEqual("1234567890", UnikodUtils.Normalize(testText1), false);
            Assert.AreEqual("362316489465153132116165016846489957985230", UnikodUtils.Normalize(testText2), false);
            Assert.AreEqual("998956165152001464874899562301546489", UnikodUtils.Normalize(testText3), false);
        }

        [TestMethod]
        public void NormalizeTest_NumberOnly_MultiStylesPerText() {
            string testText1 = "𝟣𝟤𝟥𝟰𝟱𝟲𝟟𝟠𝟡𝟘";
            string testText2 = "𝟼𝟼𝟺𝟼𝟻𝟾𝟸𝟹𝟹𝟺𝟻𝟾𝟼𝟿𝟽𝟻⑼⑼⑷⑵⑴₃₅₇₈₉₉₅⑻⑸⑵⑵⑴⑷⑵⑸";
            string testText3 = "０１１２０２３５４４５６𝟫𝟨𝟦𝟪𝟩𝟧𝟤𝟣𝟢𝟠𝟞𝟡𝟟𝟝𝟙𝟚𝟜𝟠𝟞𝟛𝟚𝟛𝟝";

            Assert.AreEqual("1234567890", UnikodUtils.Normalize(testText1), false);
            Assert.AreEqual("664658233458697599421357899585221425", UnikodUtils.Normalize(testText2), false);
            Assert.AreEqual("01120235445696487521086975124863235", UnikodUtils.Normalize(testText3), false);
        }

        [TestMethod]
        public void NormalizeTest_MixAllTogether() {
            string testText1 = "𝖶𝖾 𝖺𝗋𝖾 𝗒𝗈𝗎𝗇𝗀. 𝖾𝗏𝖾𝗇 𝗂𝖿 𝗒𝗈𝗎 𝖺𝗋𝖾 𝟣𝟢𝗌, 𝟤𝟢𝗌, 𝟧𝟢𝗌, 𝖺𝗇𝖽 𝟣𝟢𝟢𝗌!";
            string testText2 = "𝚃𝚑𝚎 𝙧𝙖𝙙𝙞𝙪𝙨 𝙤𝙛 𝙩𝙝𝙚 𝙀𝙖𝙧𝙩𝙝 𝚒𝚜 𝚊𝚋𝚘𝚞𝚝 𝟼,𝟹𝟽𝟷𝚔𝚖.";
            string testText3 = "🄘⒯ ⒲⒤⒧⒧ ⒯⒜⒦⒠ ⒜⒝⒪⒰⒯ 𝟞𝟜 𝕙𝕠𝕦𝕣𝕤 ⒝⒴ ⒜ ⒞⒜⒭ ⒜⒯ ①⓪⓪ⓚⓜ/ⓗ.";

            Assert.AreEqual("We are young. even if you are 10s, 20s, 50s, and 100s!", UnikodUtils.Normalize(testText1), false);
            Assert.AreEqual("The radius of the Earth is about 6,371km.", UnikodUtils.Normalize(testText2), false);
            Assert.AreEqual("It will take about 64 hours by a car at 100km/h.", UnikodUtils.Normalize(testText3), false);
        }
    }
}
