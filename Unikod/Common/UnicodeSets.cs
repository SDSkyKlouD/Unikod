using System.Collections.Generic;

namespace SDSK.Libs.Unikod.Common {
    internal static class UnicodeSets {
        #region Shared constants
        internal static readonly List<AlphabetSet> LatinSetList;
        internal static readonly List<NumberSet> NumberSetList;
        #endregion

        #region Alphabets
        #region Normal
        /* Normal Latin alphabets */
        private static readonly AlphabetSet _latinNormalUppercaseSet = new AlphabetSet(new string[] {
            "A", "B", "C", "D", "E",
            "F", "G", "H", "I", "J",
            "K", "L", "M", "N", "O",
            "P", "Q", "R", "S", "T",
            "U", "V", "W", "X", "Y",
            "Z"
        }, StyleType.Normal, true);
        private static readonly AlphabetSet _latinNormalLowercaseSet = new AlphabetSet(new string[] {
            "a", "b", "c", "d", "e",
            "f", "g", "h", "i", "j",
            "k", "l", "m", "n", "o",
            "p", "q", "r", "s", "t",
            "u", "v", "w", "x", "y",
            "z"
        }, StyleType.Normal, false);
        #endregion

        #region Style
        /* Latin bold glyphs */
        private static readonly AlphabetSet _latinBoldUppercaseSet = new AlphabetSet(new string[] {
            "𝐀", "𝐁", "𝐂", "𝐃", "𝐄",
            "𝐅", "𝐆", "𝐇", "𝐈", "𝐉",
            "𝐊", "𝐋", "𝐌", "𝐍", "𝐎",
            "𝐏", "𝐐", "𝐑", "𝐒", "𝐓",
            "𝐔", "𝐕", "𝐖", "𝐗", "𝐘",
            "𝐙"
        }, StyleType.Style, true);
        private static readonly AlphabetSet _latinBoldLowercaseSet = new AlphabetSet(new string[] {
            "𝐚", "𝐛", "𝐜", "𝐝", "𝐞",
            "𝐟", "𝐠", "𝐡", "𝐢", "𝐣",
            "𝐤", "𝐥", "𝐦", "𝐧", "𝐨",
            "𝐩", "𝐪", "𝐫", "𝐬", "𝐭",
            "𝐮", "𝐯", "𝐰", "𝐱", "𝐲",
            "𝐳"
        }, StyleType.Style, false);

        /* Latin italic glyphs */
        private static readonly AlphabetSet _latinItalicUppercaseSet = new AlphabetSet(new string[] {
            "𝐴", "𝐵", "𝐶", "𝐷", "𝐸",
            "𝐹", "𝐺", "𝐻", "𝐼", "𝐽",
            "𝐾", "𝐿", "𝑀", "𝑁", "𝑂",
            "𝑃", "𝑄", "𝑅", "𝑆", "𝑇",
            "𝑈", "𝑉", "𝑊", "𝑋", "𝑌",
            "𝑍"
        }, StyleType.Style, true);
        private static readonly AlphabetSet _latinItalicLowercaseSet = new AlphabetSet(new string[] {
            "𝑎", "𝑏", "𝑐", "𝑑", "𝑒",
            "𝑓", "𝑔", "ℎ", "𝑖", "𝑗",
            "𝑘", "𝑙", "𝑚", "𝑛", "𝑜",
            "𝑝", "𝑞", "𝑟", "𝑠", "𝑡",
            "𝑢", "𝑣", "𝑤", "𝑥", "𝑦",
            "𝑧"
        }, StyleType.Style, false);

        /* Latin bold italic glyphs */
        private static readonly AlphabetSet _latinBoldItalicUppercaseSet = new AlphabetSet(new string[] {
            "𝑨", "𝑩", "𝑪", "𝑫", "𝑬",
            "𝑭", "𝑮", "𝑯", "𝑰", "𝑱",
            "𝑲", "𝑳", "𝑴", "𝑵", "𝑶",
            "𝑷", "𝑸", "𝑹", "𝑺", "𝑻",
            "𝑼", "𝑽", "𝑾", "𝑿", "𝒀",
            "𝒁"
        }, StyleType.Style, true);
        private static readonly AlphabetSet _latinBoldItalicLowercaseSet = new AlphabetSet(new string[] {
            "𝒂", "𝒃", "𝒄", "𝒅", "𝒆",
            "𝒇", "𝒈", "𝒉", "𝒊", "𝒋",
            "𝒌", "𝒍", "𝒎", "𝒏", "𝒐",
            "𝒑", "𝒒", "𝒓", "𝒔", "𝒕",
            "𝒖", "𝒗", "𝒘", "𝒙", "𝒚",
            "𝒛"
        }, StyleType.Style, false);

        /* Latin script glyphs */
        private static readonly AlphabetSet _latinScriptUppercaseSet = new AlphabetSet(new string[] {
            "𝒜", "ℬ", "𝒞", "𝒟", "ℰ",
            "ℱ", "𝒢", "ℋ", "ℐ", "𝒥",
            "𝒦", "𝒧", "𝒨", "𝒩", "𝒪",
            "𝒫", "𝒬", "ℛ", "𝒮", "𝒯",
            "𝒰", "𝒱", "𝒲", "𝒳", "𝒴",
            "𝒵"
        }, StyleType.Style, true);
        private static readonly AlphabetSet _latinScriptLowercaseSet = new AlphabetSet(new string[] {
            "𝒶", "𝒷", "𝒸", "𝒹", "ℯ",
            "𝒻", "ℊ", "𝒽", "𝒾", "𝒿",
            "𝓀", "𝓁", "𝓂", "𝓃", "ℴ",
            "𝓅", "𝓆", "𝓇", "𝓈", "𝓉",
            "𝓊", "𝓋", "𝓌", "𝓍", "𝓎",
            "𝓏"
        }, StyleType.Style, false);

        /* Latin script bold glyphs */
        private static readonly AlphabetSet _latinScriptBoldUppercaseSet = new AlphabetSet(new string[] {
            "𝓐", "𝓑", "𝓒", "𝓓", "𝓔",
            "𝓕", "𝓖", "𝓗", "𝓘", "𝓙",
            "𝓚", "𝓛", "𝓜", "𝓝", "𝓞",
            "𝓟", "𝓠", "𝓡", "𝓢", "𝓣",
            "𝓤", "𝓥", "𝓦", "𝓧", "𝓨",
            "𝓩"
        }, StyleType.Style, true);
        private static readonly AlphabetSet _latinScriptBoldLowercaseSet = new AlphabetSet(new string[] {
            "𝓪", "𝓫", "𝓬", "𝓭", "𝓮",
            "𝓯", "𝓰", "𝓱", "𝓲", "𝓳",
            "𝓴", "𝓵", "𝓶", "𝓷", "𝓸",
            "𝓹", "𝓺", "𝓻", "𝓼", "𝓽",
            "𝓾", "𝓿", "𝔀", "𝔁", "𝔂",
            "𝔃"
        }, StyleType.Style, false);

        /* Latin fraktur glyphs */
        private static readonly AlphabetSet _latinFrakturUppercaseSet = new AlphabetSet(new string[] {
            "𝔄", "𝔅", "ℭ", "𝔇", "𝔈",
            "𝔉", "𝔊", "ℌ", "ℑ", "𝔍",
            "𝔎", "𝔏", "𝔐", "𝔑", "𝔒",
            "𝔓", "𝔔", "ℜ", "𝔖", "𝔗",
            "𝔘", "𝔙", "𝔚", "𝔛", "𝔜",
            "ℨ"
        }, StyleType.Style, true);
        private static readonly AlphabetSet _latinFrakturLowercaseSet = new AlphabetSet(new string[] {
            "𝔞", "𝔟", "𝔠", "𝔡", "𝔢",
            "𝔣", "𝔤", "𝔥", "𝔦", "𝔧",
            "𝔨", "𝔩", "𝔪", "𝔫", "𝔬",
            "𝔭", "𝔮", "𝔯", "𝔰", "𝔱",
            "𝔲", "𝔳", "𝔴", "𝔵", "𝔶",
            "𝔷"
        }, StyleType.Style, false);

        /* Latin fraktur bold glyphs */
        private static readonly AlphabetSet _latinFrakturBoldUppercaseSet = new AlphabetSet(new string[] {
            "𝕬", "𝕭", "𝕮", "𝕯", "𝕰",
            "𝕱", "𝕲", "𝕳", "𝕴", "𝕵",
            "𝕶", "𝕷", "𝕸", "𝕹", "𝕺",
            "𝕻", "𝕼", "𝕽", "𝕾", "𝕿",
            "𝖀", "𝖁", "𝖂", "𝖃", "𝖄",
            "𝖅"
        }, StyleType.Style, true);
        private static readonly AlphabetSet _latinFrakturBoldLowercaseSet = new AlphabetSet(new string[] {
            "𝖆", "𝖇", "𝖈", "𝖉", "𝖊",
            "𝖋", "𝖌", "𝖍", "𝖎", "𝖏",
            "𝖐", "𝖑", "𝖒", "𝖓", "𝖔",
            "𝖕", "𝖖", "𝖗", "𝖘", "𝖙",
            "𝖚", "𝖛", "𝖜", "𝖝", "𝖞",
            "𝖟"
        }, StyleType.Style, false);

        /* Latin double-struck glyphs */
        private static readonly AlphabetSet _latinDoubleStruckUppercaseSet = new AlphabetSet(new string[] {
            "𝔸", "𝔹", "ℂ", "𝔻", "𝔼",
            "𝔽", "𝔾", "ℍ", "𝕀", "𝕁",
            "𝕂", "𝕃", "𝕄", "ℕ", "𝕆",
            "ℙ", "ℚ", "ℝ", "𝕊", "𝕋",
            "𝕌", "𝕍", "𝕎", "𝕏", "𝕐",
            "ℤ"
        }, StyleType.Style, true);
        private static readonly AlphabetSet _latinDoubleStruckLowercaseSet = new AlphabetSet(new string[] {
            "𝕒", "𝕓", "𝕔", "𝕕", "𝕖",
            "𝕗", "𝕘", "𝕙", "𝕚", "𝕛",
            "𝕜", "𝕝", "𝕞", "𝕟", "𝕠",
            "𝕡", "𝕢", "𝕣", "𝕤", "𝕥",
            "𝕦", "𝕧", "𝕨", "𝕩", "𝕪",
            "𝕫"
        }, StyleType.Style, false);

        /* Latin sans-serif glyphs */
        private static readonly AlphabetSet _latinSansSerifUppercaseSet = new AlphabetSet(new string[] {
            "𝖠", "𝖡", "𝖢", "𝖣", "𝖤",
            "𝖥", "𝖦", "𝖧", "𝖨", "𝖩",
            "𝖪", "𝖫", "𝖬", "𝖭", "𝖮",
            "𝖯", "𝖰", "𝖱", "𝖲", "𝖳",
            "𝖴", "𝖵", "𝖶", "𝖷", "𝖸",
            "𝖹"
        }, StyleType.Style, true);
        private static readonly AlphabetSet _latinSansSerifLowercaseSet = new AlphabetSet(new string[] {
            "𝖺", "𝖻", "𝖼", "𝖽", "𝖾",
            "𝖿", "𝗀", "𝗁", "𝗂", "𝗃",
            "𝗄", "𝗅", "𝗆", "𝗇", "𝗈",
            "𝗉", "𝗊", "𝗋", "𝗌", "𝗍",
            "𝗎", "𝗏", "𝗐", "𝗑", "𝗒",
            "𝗓"
        }, StyleType.Style, false);

        /* Latin sans-serif bold glyphs */
        private static readonly AlphabetSet _latinSansSerifBoldUppercaseSet = new AlphabetSet(new string[] {
            "𝗔", "𝗕", "𝗖", "𝗗", "𝗘",
            "𝗙", "𝗚", "𝗛", "𝗜", "𝗝",
            "𝗞", "𝗟", "𝗠", "𝗡", "𝗢",
            "𝗣", "𝗤", "𝗥", "𝗦", "𝗧",
            "𝗨", "𝗩", "𝗪", "𝗫", "𝗬",
            "𝗭"
        }, StyleType.Style, true);
        private static readonly AlphabetSet _latinSansSerifBoldLowercaseSet = new AlphabetSet(new string[] {
            "𝗮", "𝗯", "𝗰", "𝗱", "𝗲",
            "𝗳", "𝗴", "𝗵", "𝗶", "𝗷",
            "𝗸", "𝗹", "𝗺", "𝗻", "𝗼",
            "𝗽", "𝗾", "𝗿", "𝘀", "𝘁",
            "𝘂", "𝘃", "𝘄", "𝘅", "𝘆",
            "𝘇"
        }, StyleType.Style, false);

        /* Latin sans-serif italic glyphs */
        private static readonly AlphabetSet _latinSansSerifItalicUppercaseSet = new AlphabetSet(new string[] {
            "𝘈", "𝘉", "𝘊", "𝘋", "𝘌",
            "𝘍", "𝘎", "𝘏", "𝘐", "𝘑",
            "𝘒", "𝘓", "𝘔", "𝘕", "𝘖",
            "𝘗", "𝘘", "𝘙", "𝘚", "𝘛",
            "𝘜", "𝘝", "𝘞", "𝘟", "𝘠",
            "𝘡"
        }, StyleType.Style, true);
        private static readonly AlphabetSet _latinSansSerifItalicLowercaseSet = new AlphabetSet(new string[] {
            "𝘢", "𝘣", "𝘤", "𝘥", "𝘦",
            "𝘧", "𝘨", "𝘩", "𝘪", "𝘫",
            "𝘬", "𝘭", "𝘮", "𝘯", "𝘰",
            "𝘱", "𝘲", "𝘳", "𝘴", "𝘵",
            "𝘶", "𝘷", "𝘸", "𝘹", "𝘺",
            "𝘻"
        }, StyleType.Style, false);

        /* Latin sans-serif bold italic glyphs */
        private static readonly AlphabetSet _latinSansSerifBoldItalicUppercaseSet = new AlphabetSet(new string[] {
            "𝘼", "𝘽", "𝘾", "𝘿", "𝙀",
            "𝙁", "𝙂", "𝙃", "𝙄", "𝙅",
            "𝙆", "𝙇", "𝙈", "𝙉", "𝙊",
            "𝙋", "𝙌", "𝙍", "𝙎", "𝙏",
            "𝙐", "𝙑", "𝙒", "𝙓", "𝙔",
            "𝙕"
        }, StyleType.Style, true);
        private static readonly AlphabetSet _latinSansSerifBoldItalicLowercaseSet = new AlphabetSet(new string[] {
            "𝙖", "𝙗", "𝙘", "𝙙", "𝙚",
            "𝙛", "𝙜", "𝙝", "𝙞", "𝙟",
            "𝙠", "𝙡", "𝙢", "𝙣", "𝙤",
            "𝙥", "𝙦", "𝙧", "𝙨", "𝙩",
            "𝙪", "𝙫", "𝙬", "𝙭", "𝙮",
            "𝙯"
        }, StyleType.Style, false);

        /* Latin monospace glyphs */
        private static readonly AlphabetSet _latinMonospaceUppercaseSet = new AlphabetSet(new string[] {
            "𝙰", "𝙱", "𝙲", "𝙳", "𝙴",
            "𝙵", "𝙶", "𝙷", "𝙸", "𝙹",
            "𝙺", "𝙻", "𝙼", "𝙽", "𝙾",
            "𝙿", "𝚀", "𝚁", "𝚂", "𝚃",
            "𝚄", "𝚅", "𝚆", "𝚇", "𝚈",
            "𝚉"
        }, StyleType.Style, true);
        private static readonly AlphabetSet _latinMonospaceLowercaseSet = new AlphabetSet(new string[] {
            "𝚊", "𝚋", "𝚌", "𝚍", "𝚎",
            "𝚏", "𝚐", "𝚑", "𝚒", "𝚓",
            "𝚔", "𝚕", "𝚖", "𝚗", "𝚘",
            "𝚙", "𝚚", "𝚛", "𝚜", "𝚝",
            "𝚞", "𝚟", "𝚠", "𝚡", "𝚢",
            "𝚣"
        }, StyleType.Style, false);

        /* Fullwidth Latin alphabets */
        private static readonly AlphabetSet _latinFullWidthUppercaseSet = new AlphabetSet(new string[] {
            "Ａ", "Ｂ", "Ｃ", "Ｄ", "Ｅ",
            "Ｆ", "Ｇ", "Ｈ", "Ｉ", "Ｊ",
            "Ｋ", "Ｌ", "Ｍ", "Ｎ", "Ｏ",
            "Ｐ", "Ｑ", "Ｒ", "Ｓ", "Ｔ",
            "Ｕ", "Ｖ", "Ｗ", "Ｘ", "Ｙ",
            "Ｚ"
        }, StyleType.Style, true);
        private static readonly AlphabetSet _latinFullWidthLowercaseSet = new AlphabetSet(new string[] {
            "ａ", "ｂ", "ｃ", "ｄ", "ｅ",
            "ｆ", "ｇ", "ｈ", "ｉ", "ｊ",
            "ｋ", "ｌ", "ｍ", "ｎ", "ｏ",
            "ｐ", "ｑ", "ｒ", "ｓ", "ｔ",
            "ｕ", "ｖ", "ｗ", "ｘ", "ｙ",
            "ｚ"
        }, StyleType.Style, false);

        /* Latin small alphabets */
        private static readonly AlphabetSet _latinSmallUppercaseSet = new AlphabetSet(new string[] {
            "ᴀ", "ʙ", "ᴄ", "ᴅ", "ᴇ",
            "ꜰ", "ɢ", "ʜ", "ɪ", "ᴊ",
            "ᴋ", "ʟ", "ᴍ", "ɴ", "ᴏ",
            "ᴘ", "ꞯ", "ʀ", "ꜱ", "ᴛ",
            "ᴜ", "ᴠ", "ᴡ", null, "ʏ",
            "ᴢ"
        }, StyleType.Style, true);

        /* Modifier(Upper) Latin alphabets */
        private static readonly AlphabetSet _latinModifierUppercaseSet = new AlphabetSet(new string[] {
            "ᴬ", "ᴮ", null, "ᴰ", "ᴱ",
            null, "ᴳ", "ᴴ", "ᴵ", "ᴶ",
            "ᴷ", "ᴸ", "ᴹ", "ᴺ", "ᴼ",
            "ᴾ", null, "ᴿ", null, "ᵀ",
            "ᵁ", null, "ᵂ", null, null,
            null
        }, StyleType.Style, true);
        private static readonly AlphabetSet _latinModifierLowercaseSet = new AlphabetSet(new string[] {
            "ᵃ", "ᵇ", "ᶜ", "ᵈ", "ᵉ",
            "ᶠ", "ᵍ", "ʰ", "ⁱ", "ʲ",
            "ᵏ", "ˡ", "ᵐ", "ⁿ", "ᵒ",
            "ᵖ", null, "ʳ", "ˢ", "ᵗ",
            "ᵘ", "ᵛ", "ʷ", "ˣ", "ʸ",
            "ᶻ"
        }, StyleType.Style, false);

        /* Subscript(Lower) Latin alphabets */
        private static readonly AlphabetSet _latinSubscriptLowercaseSet = new AlphabetSet(new string[] {
            "ₐ", null, null, null, "ₑ",
            null, null, "ₕ", "ᵢ", "ⱼ",
            "ₖ", "ₗ", "ₘ", "ₙ", "ₒ",
            "ₚ", null, "ᵣ", "ₛ", "ₜ",
            "ᵤ", "ᵥ", null, "ₓ", null,
            null
        }, StyleType.Style, false);

        /* Parenthesized Latin small alphabets */
        private static readonly AlphabetSet _latinSmallParenthesizedLowercaseSet = new AlphabetSet(new string[] {
            "⒜", "⒝", "⒞", "⒟", "⒠",
            "⒡", "⒢", "⒣", "⒤", "⒥",
            "⒦", "⒧", "⒨", "⒩", "⒪",
            "⒫", "⒬", "⒭", "⒮", "⒯",
            "⒰", "⒱", "⒲", "⒳", "⒴",
            "⒵"
        }, StyleType.Style, false);

        /* Circled Latin alphabets */
        private static readonly AlphabetSet _latinCircledUppercaseSet = new AlphabetSet(new string[] {
            "Ⓐ", "Ⓑ", "Ⓒ", "Ⓓ", "Ⓔ",
            "Ⓕ", "Ⓖ", "Ⓗ", "Ⓘ", "Ⓙ",
            "Ⓚ", "Ⓛ", "Ⓜ", "Ⓝ", "Ⓞ",
            "Ⓟ", "Ⓠ", "Ⓡ", "Ⓢ", "Ⓣ",
            "Ⓤ", "Ⓥ", "Ⓦ", "Ⓧ", "Ⓨ",
            "Ⓩ"
        }, StyleType.Style, true);
        private static readonly AlphabetSet _latinCircledLowercaseSet = new AlphabetSet(new string[] {
            "ⓐ", "ⓑ", "ⓒ", "ⓓ", "ⓔ",
            "ⓕ", "ⓖ", "ⓗ", "ⓘ", "ⓙ",
            "ⓚ", "ⓛ", "ⓜ", "ⓝ", "ⓞ",
            "ⓟ", "ⓠ", "ⓡ", "ⓢ", "ⓣ",
            "ⓤ", "ⓥ", "ⓦ", "ⓧ", "ⓨ",
            "ⓩ"
        }, StyleType.Style, false);

        /* Old italic letters */
        private static readonly AlphabetSet _latinOldItalicUppercaseSet = new AlphabetSet(new string[] {
            "𐌀", "𐌁", "𐌂", "𐌃", "𐌄",
            "𐌅", null, null, "𐌆", null,
            "𐌊", "𐌋", "𐌑", null, "𐌏",
            "𐌓", "𐌒", null, "𐌔", "𐌕",
            null, null, null, "𐌗", "𐌖",
            null
        }, StyleType.Style, true);
        #endregion

        #region Obfuscation
        /* Cherokee glyphs */
        private static readonly AlphabetSet _cherokeeGlyphsUppercaseSet = new AlphabetSet(new string[] {
            "Ꭺ", "Ᏼ", "Ꮯ", "Ꭰ", "Ꭼ",
            null, "Ꮐ", "Ꮋ", null, "Ꭻ",
            "Ꮶ", "Ꮮ", "Ꮇ", null, null,
            "Ꮲ", null, "Ꭱ", "Ꮪ", "Ꭲ",
            null, "Ꮩ", "Ꮃ", null, null,
            "Ꮓ"
        }, StyleType.Obfuscation, true);
        private static readonly AlphabetSet _cherokeeGlyphsLowercaseSet = new AlphabetSet(new string[] {
            null, "Ꮟ", null, null, null,
            null, null, "Ꮒ", "Ꭵ", null,
            null, null, null, null, null,
            null, null, null, null, null,
            null, null, null, null, "Ꭹ",
            null
        }, StyleType.Obfuscation, false);

        /* Cherokee small glyphs */
        private static readonly AlphabetSet _cherokeeSmallGlyphsUppercaseSet = new AlphabetSet(new string[] {
            "ꭺ", null, "ꮯ", "ꭰ", "ꭼ",
            null, "ꮆ", "ꮋ", "ꮖ", "ꭻ",
            null, "ꮮ", "ꮇ", null, null,
            "ꮲ", null, "ꭱ", "ꮪ", "ꭲ",
            null, "ꮩ", "ꮃ", null, null,
            "ꮓ"
        }, StyleType.Obfuscation, true);
        private static readonly AlphabetSet _cherokeeSmallGlyphsLowercaseSet = new AlphabetSet(new string[] {
            null, "ꮟ", null, "ꮷ", null,
            null, null, "ꮒ", "ꭵ", null,
            "ꮶ", null, null, null, null,
            "ꮅ", null, "ꮁ", null, null,
            "ꮼ", "ꮴ", "ꮤ", null, "ꮍ",
            null
        }, StyleType.Obfuscation, false);

        /* Roman glyphs */
        private static readonly AlphabetSet _romanGlyphsUppercaseSet = new AlphabetSet(new string[] {
            null, null, "Ⅽ", "Ⅾ", null,
            null, null, null, "Ⅰ", null,
            null, "Ⅼ", "Ⅿ", null, null,
            null, null, null, null, null,
            null, "Ⅴ", null, "Ⅹ", null,
            null
        }, StyleType.Obfuscation, true);
        private static readonly AlphabetSet _romanGlyphsLowercaseSet = new AlphabetSet(new string[] {
            null, null, "ⅽ", "ⅾ", null,
            null, null, null, "ⅰ", null,
            null, "ⅼ", "ⅿ", null, null,
            null, null, null, null, null,
            null, "ⅴ", null, "ⅹ", null,
            null
        }, StyleType.Obfuscation, false);
        
        /* Coptic glyphs */
        private static readonly AlphabetSet _copticGlyphsUppercaseSet = new AlphabetSet(new string[] {
            null, "Ⲃ", "Ⲥ", null, null,
            null, null, "Ⲏ", "Ⲓ", null,
            "Ⲕ", "Ⳑ", "Ⲙ", "Ⲛ", "Ⲟ",
            "Ⲣ", null, null, null, "Ⲧ",
            "Ⳙ", null, "Ⲱ", "Ⲭ", "Ⲩ",
            "Ⲍ"
        }, StyleType.Obfuscation, true);

        /* Tifinagh glyphs */
        private static readonly AlphabetSet _tifinaghGlyphsUppercaseSet = new AlphabetSet(new string[] {
            "ⴷ", null, "ⵎ", null, "ⴹ",
            null, null, null, "ⵊ", null,
            null, null, null, null, "ⵔ",
            null, "ⵕ", null, "ⵢ", null,
            "ⵡ", "ⴸ", null, "ⵝ", "ⵖ",
            null
        }, StyleType.Obfuscation, true);

        /* Lisu glyphs */
        private static readonly AlphabetSet _lisuGlyphsUppercaseSet = new AlphabetSet(new string[] {
            "ꓮ", "ꓐ", "ꓚ", "ꓓ", "ꓰ",
            "ꓝ", "ꓖ", "ꓧ", "ꓲ", "ꓙ",
            "ꓗ", "ꓡ", "ꓟ", "ꓠ", "ꓳ",
            "ꓑ", null, "ꓣ", "ꓢ", "ꓔ",
            "ꓴ", "ꓦ", "ꓪ", "ꓫ", "ꓬ",
            null
        }, StyleType.Obfuscation, true);
        #endregion
        #endregion

        #region Numbers
        #region Normal
        /* Normal numbers */
        private static readonly NumberSet _numberNormalSet = new NumberSet(new string[] {
            "0", "1", "2", "3", "4",
            "5", "6", "7", "8", "9"
        }, StyleType.Normal);
        
        #endregion

        #region Style
        /* Fullwidth numbers */
        private static readonly NumberSet _numberFullWidthSet = new NumberSet(new string[] {
            "０", "１", "２", "３", "４",
            "５", "６", "７", "８", "９"
        }, StyleType.Style);

        /* Superscript(Upper) numbers */
        private static readonly NumberSet _numberSuperscriptSet = new NumberSet(new string[] {
            "⁰", null, null, null, "⁴",
            "⁵", "⁶", "⁷", "⁸", "⁹"
        }, StyleType.Style);

        /* Superscript(Lower) numbers */
        private static readonly NumberSet _numberSubscriptSet = new NumberSet(new string[] {
            "₀", "₁", "₂", "₃", "₄",
            "₅", "₆", "₇", "₈", "₉"
        }, StyleType.Style);

        /* Circled numbers */
        private static readonly NumberSet _numberCircledSet = new NumberSet(new string[] {
            "⓪", "①", "②", "③", "④",
            "⑤", "⑥", "⑦", "⑧", "⑨"
        }, StyleType.Style);

        /* Parenthesized numbers */
        private static readonly NumberSet _numberParenthesizedSet = new NumberSet(new string[] {
            null, "⑴", "⑵", "⑶", "⑷",
            "⑸", "⑹", "⑺", "⑻", "⑼"
        }, StyleType.Style);

        /* Double circled numbers */
        private static readonly NumberSet _numberDoubleCircledSet = new NumberSet(new string[] {
            null, "⓵", "⓶", "⓷", "⓸",
            "⓹", "⓺", "⓻", "⓼", "⓽"
        }, StyleType.Style);

        /* Negative circled numbers (dingbat) */
        private static readonly NumberSet _numberDingbatNegativeCircledSet = new NumberSet(new string[] {
            null, "❶", "❷", "❸", "❹",
            "❺", "❻", "❼", "❽", "❾"
        }, StyleType.Style);

        /* Circled sans-serif numbers (dingbat) */
        private static readonly NumberSet _numberDingbatSansSerifCircledSet = new NumberSet(new string[] {
            null, "➀", "➁", "➂", "➃",
            "➄", "➅", "➆", "➇", "➈"
        }, StyleType.Style);

        /* Negative circled sans-serif numbers (dingbat) */
        private static readonly NumberSet _numberDingbatSansSerifNegativeCircledSet = new NumberSet(new string[] {
            null, "➊", "➋", "➌", "➍",
            "➎", "➏", "➐", "➑", "➒"
        }, StyleType.Style);

        /* Bold numbers */
        private static readonly NumberSet _numberBoldSet = new NumberSet(new string[] {
            "𝟎", "𝟏", "𝟐", "𝟑", "𝟒",
            "𝟓", "𝟔", "𝟕", "𝟖", "𝟗"
        }, StyleType.Style);

        /* Double-struck numbers */
        private static readonly NumberSet _numberDoubleStruckSet = new NumberSet(new string[] {
            "𝟘", "𝟙", "𝟚", "𝟛", "𝟜",
            "𝟝", "𝟞", "𝟟", "𝟠", "𝟡"
        }, StyleType.Style);

        /* Sans-serif numbers */
        private static readonly NumberSet _numberSansSerifSet = new NumberSet(new string[] {
            "𝟢", "𝟣", "𝟤", "𝟥", "𝟦",
            "𝟧", "𝟨", "𝟩", "𝟪", "𝟫"
        }, StyleType.Style);

        /* Sans-serif bold numbers */
        private static readonly NumberSet _numberSansSerifBoldSet = new NumberSet(new string[] {
            "𝟬", "𝟭", "𝟮", "𝟯", "𝟰",
            "𝟱", "𝟲", "𝟳", "𝟴", "𝟵"
        }, StyleType.Style);

        /* Monospace numbers */
        private static readonly NumberSet _numberMonospaceSet = new NumberSet(new string[] {
            "𝟶", "𝟷", "𝟸", "𝟹", "𝟺",
            "𝟻", "𝟼", "𝟽", "𝟾", "𝟿"
        }, StyleType.Style);
        #endregion
        #endregion

        static UnicodeSets() {
            /* Set lists : normal sets should come first */
            LatinSetList = new List<AlphabetSet>() {
                /* Normal */
                _latinNormalUppercaseSet,
                _latinNormalLowercaseSet,

                /* Style */
                _latinBoldUppercaseSet,
                _latinBoldLowercaseSet,
                _latinItalicUppercaseSet,
                _latinItalicLowercaseSet,
                _latinBoldItalicUppercaseSet,
                _latinBoldItalicLowercaseSet,
                _latinScriptUppercaseSet,
                _latinScriptLowercaseSet,
                _latinScriptBoldUppercaseSet,
                _latinScriptBoldLowercaseSet,
                _latinFrakturUppercaseSet,
                _latinFrakturLowercaseSet,
                _latinFrakturBoldUppercaseSet,
                _latinFrakturBoldLowercaseSet,
                _latinDoubleStruckUppercaseSet,
                _latinDoubleStruckLowercaseSet,
                _latinSansSerifUppercaseSet,
                _latinSansSerifLowercaseSet,
                _latinSansSerifBoldUppercaseSet,
                _latinSansSerifBoldLowercaseSet,
                _latinSansSerifItalicUppercaseSet,
                _latinSansSerifItalicLowercaseSet,
                _latinSansSerifBoldItalicUppercaseSet,
                _latinSansSerifBoldItalicLowercaseSet,
                _latinMonospaceUppercaseSet,
                _latinMonospaceLowercaseSet,
                _latinFullWidthUppercaseSet,
                _latinFullWidthLowercaseSet,
                _latinSmallUppercaseSet,
                _latinModifierUppercaseSet,
                _latinModifierLowercaseSet,
                _latinSubscriptLowercaseSet,
                _latinSmallParenthesizedLowercaseSet,
                _latinCircledUppercaseSet,
                _latinCircledLowercaseSet,
                _latinOldItalicUppercaseSet,

                /* Obfuscation */
                _cherokeeGlyphsUppercaseSet,
                _cherokeeGlyphsLowercaseSet,
                _cherokeeSmallGlyphsUppercaseSet,
                _cherokeeSmallGlyphsLowercaseSet,
                _romanGlyphsUppercaseSet,
                _romanGlyphsLowercaseSet,
                _copticGlyphsUppercaseSet,
                _tifinaghGlyphsUppercaseSet,
                _lisuGlyphsUppercaseSet
            };
            NumberSetList = new List<NumberSet>() {
                /* Normal */
                _numberNormalSet,

                /* Style */
                _numberFullWidthSet,
                _numberSuperscriptSet,
                _numberSubscriptSet,
                _numberCircledSet,
                _numberParenthesizedSet,
                _numberDoubleCircledSet,
                _numberDingbatNegativeCircledSet,
                _numberDingbatSansSerifCircledSet,
                _numberDingbatSansSerifNegativeCircledSet,
                _numberBoldSet,
                _numberDoubleStruckSet,
                _numberSansSerifSet,
                _numberSansSerifBoldSet,
                _numberMonospaceSet
            };
        }
    }
}
