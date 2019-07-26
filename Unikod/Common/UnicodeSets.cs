using System;
using System.Collections.Generic;
using System.Linq;
using SDSK.Libs.Unikod.Types;

namespace SDSK.Libs.Unikod.Common {
    public static class UnicodeSets {
        #region Shared constants
        public static readonly List<IUnikodSet> SetListAll;
        public static readonly List<AlphabetSet> SetListLatin;
        public static readonly List<NumberSet> SetListNumber;
        #endregion

        #region Alphabets
        #region Normal
        /* Normal Latin alphabets */
        public static readonly AlphabetSet LatinNormalUppercaseSet = new AlphabetSet("Latin Normal Uppercase", new string[] {
            "A", "B", "C", "D", "E",
            "F", "G", "H", "I", "J",
            "K", "L", "M", "N", "O",
            "P", "Q", "R", "S", "T",
            "U", "V", "W", "X", "Y",
            "Z"
        }, StyleType.Normal, LetterCaseType.Uppercase);
        public static readonly AlphabetSet LatinNormalLowercaseSet = new AlphabetSet("Latin Normal Lowercase", new string[] {
            "a", "b", "c", "d", "e",
            "f", "g", "h", "i", "j",
            "k", "l", "m", "n", "o",
            "p", "q", "r", "s", "t",
            "u", "v", "w", "x", "y",
            "z"
        }, StyleType.Normal, LetterCaseType.Lowercase);
        #endregion

        #region Style
        /* Latin bold glyphs */
        public static readonly AlphabetSet LatinBoldUppercaseSet = new AlphabetSet("Latin Bold Uppercase", new string[] {
            "𝐀", "𝐁", "𝐂", "𝐃", "𝐄",
            "𝐅", "𝐆", "𝐇", "𝐈", "𝐉",
            "𝐊", "𝐋", "𝐌", "𝐍", "𝐎",
            "𝐏", "𝐐", "𝐑", "𝐒", "𝐓",
            "𝐔", "𝐕", "𝐖", "𝐗", "𝐘",
            "𝐙"
        }, StyleType.Style, LetterCaseType.Uppercase);
        public static readonly AlphabetSet LatinBoldLowercaseSet = new AlphabetSet("Latin Bold Lowercase", new string[] {
            "𝐚", "𝐛", "𝐜", "𝐝", "𝐞",
            "𝐟", "𝐠", "𝐡", "𝐢", "𝐣",
            "𝐤", "𝐥", "𝐦", "𝐧", "𝐨",
            "𝐩", "𝐪", "𝐫", "𝐬", "𝐭",
            "𝐮", "𝐯", "𝐰", "𝐱", "𝐲",
            "𝐳"
        }, StyleType.Style, LetterCaseType.Lowercase);

        /* Latin italic glyphs */
        public static readonly AlphabetSet LatinItalicUppercaseSet = new AlphabetSet("Latin Italic Uppercase", new string[] {
            "𝐴", "𝐵", "𝐶", "𝐷", "𝐸",
            "𝐹", "𝐺", "𝐻", "𝐼", "𝐽",
            "𝐾", "𝐿", "𝑀", "𝑁", "𝑂",
            "𝑃", "𝑄", "𝑅", "𝑆", "𝑇",
            "𝑈", "𝑉", "𝑊", "𝑋", "𝑌",
            "𝑍"
        }, StyleType.Style, LetterCaseType.Uppercase);
        public static readonly AlphabetSet LatinItalicLowercaseSet = new AlphabetSet("Latin Italic Lowercase", new string[] {
            "𝑎", "𝑏", "𝑐", "𝑑", "𝑒",
            "𝑓", "𝑔", "ℎ", "𝑖", "𝑗",
            "𝑘", "𝑙", "𝑚", "𝑛", "𝑜",
            "𝑝", "𝑞", "𝑟", "𝑠", "𝑡",
            "𝑢", "𝑣", "𝑤", "𝑥", "𝑦",
            "𝑧"
        }, StyleType.Style, LetterCaseType.Lowercase);

        /* Latin bold italic glyphs */
        public static readonly AlphabetSet LatinBoldItalicUppercaseSet = new AlphabetSet("Latin Bold Italic Uppercase", new string[] {
            "𝑨", "𝑩", "𝑪", "𝑫", "𝑬",
            "𝑭", "𝑮", "𝑯", "𝑰", "𝑱",
            "𝑲", "𝑳", "𝑴", "𝑵", "𝑶",
            "𝑷", "𝑸", "𝑹", "𝑺", "𝑻",
            "𝑼", "𝑽", "𝑾", "𝑿", "𝒀",
            "𝒁"
        }, StyleType.Style, LetterCaseType.Uppercase);
        public static readonly AlphabetSet LatinBoldItalicLowercaseSet = new AlphabetSet("Latin Bold Italic Lowercase", new string[] {
            "𝒂", "𝒃", "𝒄", "𝒅", "𝒆",
            "𝒇", "𝒈", "𝒉", "𝒊", "𝒋",
            "𝒌", "𝒍", "𝒎", "𝒏", "𝒐",
            "𝒑", "𝒒", "𝒓", "𝒔", "𝒕",
            "𝒖", "𝒗", "𝒘", "𝒙", "𝒚",
            "𝒛"
        }, StyleType.Style, LetterCaseType.Lowercase);

        /* Latin script glyphs */
        public static readonly AlphabetSet LatinScriptUppercaseSet = new AlphabetSet("Latin Script Uppercase", new string[] {
            "𝒜", "ℬ", "𝒞", "𝒟", "ℰ",
            "ℱ", "𝒢", "ℋ", "ℐ", "𝒥",
            "𝒦", "𝒧", "𝒨", "𝒩", "𝒪",
            "𝒫", "𝒬", "ℛ", "𝒮", "𝒯",
            "𝒰", "𝒱", "𝒲", "𝒳", "𝒴",
            "𝒵"
        }, StyleType.Style, LetterCaseType.Uppercase);
        public static readonly AlphabetSet LatinScriptLowercaseSet = new AlphabetSet("Latin Script Lowercase", new string[] {
            "𝒶", "𝒷", "𝒸", "𝒹", "ℯ",
            "𝒻", "ℊ", "𝒽", "𝒾", "𝒿",
            "𝓀", "𝓁", "𝓂", "𝓃", "ℴ",
            "𝓅", "𝓆", "𝓇", "𝓈", "𝓉",
            "𝓊", "𝓋", "𝓌", "𝓍", "𝓎",
            "𝓏"
        }, StyleType.Style, LetterCaseType.Lowercase);

        /* Latin script bold glyphs */
        public static readonly AlphabetSet LatinScriptBoldUppercaseSet = new AlphabetSet("Latin Script Bold Uppercase", new string[] {
            "𝓐", "𝓑", "𝓒", "𝓓", "𝓔",
            "𝓕", "𝓖", "𝓗", "𝓘", "𝓙",
            "𝓚", "𝓛", "𝓜", "𝓝", "𝓞",
            "𝓟", "𝓠", "𝓡", "𝓢", "𝓣",
            "𝓤", "𝓥", "𝓦", "𝓧", "𝓨",
            "𝓩"
        }, StyleType.Style, LetterCaseType.Uppercase);
        public static readonly AlphabetSet LatinScriptBoldLowercaseSet = new AlphabetSet("Latin Script Bold Lowercase", new string[] {
            "𝓪", "𝓫", "𝓬", "𝓭", "𝓮",
            "𝓯", "𝓰", "𝓱", "𝓲", "𝓳",
            "𝓴", "𝓵", "𝓶", "𝓷", "𝓸",
            "𝓹", "𝓺", "𝓻", "𝓼", "𝓽",
            "𝓾", "𝓿", "𝔀", "𝔁", "𝔂",
            "𝔃"
        }, StyleType.Style, LetterCaseType.Lowercase);

        /* Latin fraktur glyphs */
        public static readonly AlphabetSet LatinFrakturUppercaseSet = new AlphabetSet("Latin Fraktur Uppercase", new string[] {
            "𝔄", "𝔅", "ℭ", "𝔇", "𝔈",
            "𝔉", "𝔊", "ℌ", "ℑ", "𝔍",
            "𝔎", "𝔏", "𝔐", "𝔑", "𝔒",
            "𝔓", "𝔔", "ℜ", "𝔖", "𝔗",
            "𝔘", "𝔙", "𝔚", "𝔛", "𝔜",
            "ℨ"
        }, StyleType.Style, LetterCaseType.Uppercase);
        public static readonly AlphabetSet LatinFrakturLowercaseSet = new AlphabetSet("Latin Fraktur Lowercase", new string[] {
            "𝔞", "𝔟", "𝔠", "𝔡", "𝔢",
            "𝔣", "𝔤", "𝔥", "𝔦", "𝔧",
            "𝔨", "𝔩", "𝔪", "𝔫", "𝔬",
            "𝔭", "𝔮", "𝔯", "𝔰", "𝔱",
            "𝔲", "𝔳", "𝔴", "𝔵", "𝔶",
            "𝔷"
        }, StyleType.Style, LetterCaseType.Lowercase);

        /* Latin fraktur bold glyphs */
        public static readonly AlphabetSet LatinFrakturBoldUppercaseSet = new AlphabetSet("Latin Fraktur Bold Uppercase", new string[] {
            "𝕬", "𝕭", "𝕮", "𝕯", "𝕰",
            "𝕱", "𝕲", "𝕳", "𝕴", "𝕵",
            "𝕶", "𝕷", "𝕸", "𝕹", "𝕺",
            "𝕻", "𝕼", "𝕽", "𝕾", "𝕿",
            "𝖀", "𝖁", "𝖂", "𝖃", "𝖄",
            "𝖅"
        }, StyleType.Style, LetterCaseType.Uppercase);
        public static readonly AlphabetSet LatinFrakturBoldLowercaseSet = new AlphabetSet("Latin Fraktur Bold Lowercase", new string[] {
            "𝖆", "𝖇", "𝖈", "𝖉", "𝖊",
            "𝖋", "𝖌", "𝖍", "𝖎", "𝖏",
            "𝖐", "𝖑", "𝖒", "𝖓", "𝖔",
            "𝖕", "𝖖", "𝖗", "𝖘", "𝖙",
            "𝖚", "𝖛", "𝖜", "𝖝", "𝖞",
            "𝖟"
        }, StyleType.Style, LetterCaseType.Lowercase);

        /* Latin double-struck glyphs */
        public static readonly AlphabetSet LatinDoubleStruckUppercaseSet = new AlphabetSet("Latin Double-Struck Uppercase", new string[] {
            "𝔸", "𝔹", "ℂ", "𝔻", "𝔼",
            "𝔽", "𝔾", "ℍ", "𝕀", "𝕁",
            "𝕂", "𝕃", "𝕄", "ℕ", "𝕆",
            "ℙ", "ℚ", "ℝ", "𝕊", "𝕋",
            "𝕌", "𝕍", "𝕎", "𝕏", "𝕐",
            "ℤ"
        }, StyleType.Style, LetterCaseType.Uppercase);
        public static readonly AlphabetSet LatinDoubleStruckLowercaseSet = new AlphabetSet("Latin Double-Struck Lowercase", new string[] {
            "𝕒", "𝕓", "𝕔", "𝕕", "𝕖",
            "𝕗", "𝕘", "𝕙", "𝕚", "𝕛",
            "𝕜", "𝕝", "𝕞", "𝕟", "𝕠",
            "𝕡", "𝕢", "𝕣", "𝕤", "𝕥",
            "𝕦", "𝕧", "𝕨", "𝕩", "𝕪",
            "𝕫"
        }, StyleType.Style, LetterCaseType.Lowercase);

        /* Latin sans-serif glyphs */
        public static readonly AlphabetSet LatinSansSerifUppercaseSet = new AlphabetSet("Latin Sans-Serif Uppercase", new string[] {
            "𝖠", "𝖡", "𝖢", "𝖣", "𝖤",
            "𝖥", "𝖦", "𝖧", "𝖨", "𝖩",
            "𝖪", "𝖫", "𝖬", "𝖭", "𝖮",
            "𝖯", "𝖰", "𝖱", "𝖲", "𝖳",
            "𝖴", "𝖵", "𝖶", "𝖷", "𝖸",
            "𝖹"
        }, StyleType.Style, LetterCaseType.Uppercase);
        public static readonly AlphabetSet LatinSansSerifLowercaseSet = new AlphabetSet("Latin Sans-Serif Lowercase", new string[] {
            "𝖺", "𝖻", "𝖼", "𝖽", "𝖾",
            "𝖿", "𝗀", "𝗁", "𝗂", "𝗃",
            "𝗄", "𝗅", "𝗆", "𝗇", "𝗈",
            "𝗉", "𝗊", "𝗋", "𝗌", "𝗍",
            "𝗎", "𝗏", "𝗐", "𝗑", "𝗒",
            "𝗓"
        }, StyleType.Style, LetterCaseType.Lowercase);

        /* Latin sans-serif bold glyphs */
        public static readonly AlphabetSet LatinSansSerifBoldUppercaseSet = new AlphabetSet("Latin Sans-Serif Bold Uppercase", new string[] {
            "𝗔", "𝗕", "𝗖", "𝗗", "𝗘",
            "𝗙", "𝗚", "𝗛", "𝗜", "𝗝",
            "𝗞", "𝗟", "𝗠", "𝗡", "𝗢",
            "𝗣", "𝗤", "𝗥", "𝗦", "𝗧",
            "𝗨", "𝗩", "𝗪", "𝗫", "𝗬",
            "𝗭"
        }, StyleType.Style, LetterCaseType.Uppercase);
        public static readonly AlphabetSet LatinSansSerifBoldLowercaseSet = new AlphabetSet("Latin Sans-Serif Bold Lowercase", new string[] {
            "𝗮", "𝗯", "𝗰", "𝗱", "𝗲",
            "𝗳", "𝗴", "𝗵", "𝗶", "𝗷",
            "𝗸", "𝗹", "𝗺", "𝗻", "𝗼",
            "𝗽", "𝗾", "𝗿", "𝘀", "𝘁",
            "𝘂", "𝘃", "𝘄", "𝘅", "𝘆",
            "𝘇"
        }, StyleType.Style, LetterCaseType.Lowercase);

        /* Latin sans-serif italic glyphs */
        public static readonly AlphabetSet LatinSansSerifItalicUppercaseSet = new AlphabetSet("Latin Sans-Serif Italic Uppercase", new string[] {
            "𝘈", "𝘉", "𝘊", "𝘋", "𝘌",
            "𝘍", "𝘎", "𝘏", "𝘐", "𝘑",
            "𝘒", "𝘓", "𝘔", "𝘕", "𝘖",
            "𝘗", "𝘘", "𝘙", "𝘚", "𝘛",
            "𝘜", "𝘝", "𝘞", "𝘟", "𝘠",
            "𝘡"
        }, StyleType.Style, LetterCaseType.Uppercase);
        public static readonly AlphabetSet LatinSansSerifItalicLowercaseSet = new AlphabetSet("Latin Sans-Serif Italic Lowercase", new string[] {
            "𝘢", "𝘣", "𝘤", "𝘥", "𝘦",
            "𝘧", "𝘨", "𝘩", "𝘪", "𝘫",
            "𝘬", "𝘭", "𝘮", "𝘯", "𝘰",
            "𝘱", "𝘲", "𝘳", "𝘴", "𝘵",
            "𝘶", "𝘷", "𝘸", "𝘹", "𝘺",
            "𝘻"
        }, StyleType.Style, LetterCaseType.Lowercase);

        /* Latin sans-serif bold italic glyphs */
        public static readonly AlphabetSet LatinSansSerifBoldItalicUppercaseSet = new AlphabetSet("Latin Sans-Serif Bold Italic Uppercase", new string[] {
            "𝘼", "𝘽", "𝘾", "𝘿", "𝙀",
            "𝙁", "𝙂", "𝙃", "𝙄", "𝙅",
            "𝙆", "𝙇", "𝙈", "𝙉", "𝙊",
            "𝙋", "𝙌", "𝙍", "𝙎", "𝙏",
            "𝙐", "𝙑", "𝙒", "𝙓", "𝙔",
            "𝙕"
        }, StyleType.Style, LetterCaseType.Uppercase);
        public static readonly AlphabetSet LatinSansSerifBoldItalicLowercaseSet = new AlphabetSet("Latin Sans-Serif Bold Italic Lowercase", new string[] {
            "𝙖", "𝙗", "𝙘", "𝙙", "𝙚",
            "𝙛", "𝙜", "𝙝", "𝙞", "𝙟",
            "𝙠", "𝙡", "𝙢", "𝙣", "𝙤",
            "𝙥", "𝙦", "𝙧", "𝙨", "𝙩",
            "𝙪", "𝙫", "𝙬", "𝙭", "𝙮",
            "𝙯"
        }, StyleType.Style, LetterCaseType.Lowercase);

        /* Latin monospace glyphs */
        public static readonly AlphabetSet LatinMonospaceUppercaseSet = new AlphabetSet("Latin Monospace Uppercase", new string[] {
            "𝙰", "𝙱", "𝙲", "𝙳", "𝙴",
            "𝙵", "𝙶", "𝙷", "𝙸", "𝙹",
            "𝙺", "𝙻", "𝙼", "𝙽", "𝙾",
            "𝙿", "𝚀", "𝚁", "𝚂", "𝚃",
            "𝚄", "𝚅", "𝚆", "𝚇", "𝚈",
            "𝚉"
        }, StyleType.Style, LetterCaseType.Uppercase);
        public static readonly AlphabetSet LatinMonospaceLowercaseSet = new AlphabetSet("Latin Monospace Lowercase", new string[] {
            "𝚊", "𝚋", "𝚌", "𝚍", "𝚎",
            "𝚏", "𝚐", "𝚑", "𝚒", "𝚓",
            "𝚔", "𝚕", "𝚖", "𝚗", "𝚘",
            "𝚙", "𝚚", "𝚛", "𝚜", "𝚝",
            "𝚞", "𝚟", "𝚠", "𝚡", "𝚢",
            "𝚣"
        }, StyleType.Style, LetterCaseType.Lowercase);

        /* Fullwidth Latin alphabets */
        public static readonly AlphabetSet LatinFullWidthUppercaseSet = new AlphabetSet("Latin Fullwidth Uppercase", new string[] {
            "Ａ", "Ｂ", "Ｃ", "Ｄ", "Ｅ",
            "Ｆ", "Ｇ", "Ｈ", "Ｉ", "Ｊ",
            "Ｋ", "Ｌ", "Ｍ", "Ｎ", "Ｏ",
            "Ｐ", "Ｑ", "Ｒ", "Ｓ", "Ｔ",
            "Ｕ", "Ｖ", "Ｗ", "Ｘ", "Ｙ",
            "Ｚ"
        }, StyleType.Style, LetterCaseType.Uppercase);
        public static readonly AlphabetSet LatinFullWidthLowercaseSet = new AlphabetSet("Latin Fullwidth Lowercase", new string[] {
            "ａ", "ｂ", "ｃ", "ｄ", "ｅ",
            "ｆ", "ｇ", "ｈ", "ｉ", "ｊ",
            "ｋ", "ｌ", "ｍ", "ｎ", "ｏ",
            "ｐ", "ｑ", "ｒ", "ｓ", "ｔ",
            "ｕ", "ｖ", "ｗ", "ｘ", "ｙ",
            "ｚ"
        }, StyleType.Style, LetterCaseType.Lowercase);

        /* Latin small alphabets */
        public static readonly AlphabetSet LatinSmallUppercaseSet = new AlphabetSet("Latin Small Uppercase", new string[] {
            "ᴀ", "ʙ", "ᴄ", "ᴅ", "ᴇ",
            "ꜰ", "ɢ", "ʜ", "ɪ", "ᴊ",
            "ᴋ", "ʟ", "ᴍ", "ɴ", "ᴏ",
            "ᴘ", "ꞯ", "ʀ", "ꜱ", "ᴛ",
            "ᴜ", "ᴠ", "ᴡ", null, "ʏ",
            "ᴢ"
        }, StyleType.Style, LetterCaseType.Uppercase);

        /* Modifier(Superscript) Latin alphabets */
        public static readonly AlphabetSet LatinModifierUppercaseSet = new AlphabetSet("Latin Modifier(Superscript) Uppercase", new string[] {
            "ᴬ", "ᴮ", null, "ᴰ", "ᴱ",
            null, "ᴳ", "ᴴ", "ᴵ", "ᴶ",
            "ᴷ", "ᴸ", "ᴹ", "ᴺ", "ᴼ",
            "ᴾ", null, "ᴿ", null, "ᵀ",
            "ᵁ", null, "ᵂ", null, null,
            null
        }, StyleType.Style, LetterCaseType.Uppercase);
        public static readonly AlphabetSet LatinModifierLowercaseSet = new AlphabetSet("Latin Modifier(Superscript) Lowercase", new string[] {
            "ᵃ", "ᵇ", "ᶜ", "ᵈ", "ᵉ",
            "ᶠ", "ᵍ", "ʰ", "ⁱ", "ʲ",
            "ᵏ", "ˡ", "ᵐ", "ⁿ", "ᵒ",
            "ᵖ", null, "ʳ", "ˢ", "ᵗ",
            "ᵘ", "ᵛ", "ʷ", "ˣ", "ʸ",
            "ᶻ"
        }, StyleType.Style, LetterCaseType.Lowercase);

        /* Subscript Latin alphabets */
        public static readonly AlphabetSet LatinSubscriptLowercaseSet = new AlphabetSet("Latin Subscript Lowercase", new string[] {
            "ₐ", null, null, null, "ₑ",
            null, null, "ₕ", "ᵢ", "ⱼ",
            "ₖ", "ₗ", "ₘ", "ₙ", "ₒ",
            "ₚ", null, "ᵣ", "ₛ", "ₜ",
            "ᵤ", "ᵥ", null, "ₓ", null,
            null
        }, StyleType.Style, LetterCaseType.Lowercase);

        /* Parenthesized Latin alphabets */
        public static readonly AlphabetSet LatinParenthesizedUppercaseSet = new AlphabetSet("Latin Parenthesized Uppercase", new string[] {
            "🄐", "🄑", "🄒", "🄓", "🄔",
            "🄕", "🄖", "🄗", "🄘", "🄙",
            "🄚", "🄛", "🄜", "🄝", "🄞",
            "🄟", "🄠", "🄡", "🄢", "🄣",
            "🄤", "🄥", "🄦", "🄧", "🄨",
            "🄩"
        }, StyleType.Style, LetterCaseType.Uppercase);
        public static readonly AlphabetSet LatinParenthesizedLowercaseSet = new AlphabetSet("Latin Parenthesized Lowercase", new string[] {
            "⒜", "⒝", "⒞", "⒟", "⒠",
            "⒡", "⒢", "⒣", "⒤", "⒥",
            "⒦", "⒧", "⒨", "⒩", "⒪",
            "⒫", "⒬", "⒭", "⒮", "⒯",
            "⒰", "⒱", "⒲", "⒳", "⒴",
            "⒵"
        }, StyleType.Style, LetterCaseType.Lowercase);

        /* Circled Latin alphabets */
        public static readonly AlphabetSet LatinCircledUppercaseSet = new AlphabetSet("Latin Circled Uppercase", new string[] {
            "Ⓐ", "Ⓑ", "Ⓒ", "Ⓓ", "Ⓔ",
            "Ⓕ", "Ⓖ", "Ⓗ", "Ⓘ", "Ⓙ",
            "Ⓚ", "Ⓛ", "Ⓜ", "Ⓝ", "Ⓞ",
            "Ⓟ", "Ⓠ", "Ⓡ", "Ⓢ", "Ⓣ",
            "Ⓤ", "Ⓥ", "Ⓦ", "Ⓧ", "Ⓨ",
            "Ⓩ"
        }, StyleType.Style, LetterCaseType.Uppercase);
        public static readonly AlphabetSet LatinCircledLowercaseSet = new AlphabetSet("Latin Circled Lowercase", new string[] {
            "ⓐ", "ⓑ", "ⓒ", "ⓓ", "ⓔ",
            "ⓕ", "ⓖ", "ⓗ", "ⓘ", "ⓙ",
            "ⓚ", "ⓛ", "ⓜ", "ⓝ", "ⓞ",
            "ⓟ", "ⓠ", "ⓡ", "ⓢ", "ⓣ",
            "ⓤ", "ⓥ", "ⓦ", "ⓧ", "ⓨ",
            "ⓩ"
        }, StyleType.Style, LetterCaseType.Lowercase);

        /* Old italic letters */
        public static readonly AlphabetSet LatinOldItalicUppercaseSet = new AlphabetSet("Latin Old Italic Uppercase", new string[] {
            "𐌀", "𐌁", "𐌂", "𐌃", "𐌄",
            "𐌅", null, null, "𐌆", null,
            "𐌊", "𐌋", "𐌑", null, "𐌏",
            "𐌓", "𐌒", null, "𐌔", "𐌕",
            null, null, null, "𐌗", "𐌖",
            null
        }, StyleType.Style, LetterCaseType.Uppercase);
        #endregion

        #region Obfuscation
        /* Cherokee glyphs */
        public static readonly AlphabetSet CherokeeGlyphsUppercaseSet = new AlphabetSet("Cherokee Glyphs for Latin Uppercase Obfuscation", new string[] {
            "Ꭺ", "Ᏼ", "Ꮯ", "Ꭰ", "Ꭼ",
            null, "Ꮐ", "Ꮋ", null, "Ꭻ",
            "Ꮶ", "Ꮮ", "Ꮇ", null, null,
            "Ꮲ", null, "Ꭱ", "Ꮪ", "Ꭲ",
            null, "Ꮩ", "Ꮃ", null, null,
            "Ꮓ"
        }, StyleType.Obfuscation, LetterCaseType.Uppercase);
        public static readonly AlphabetSet CherokeeGlyphsLowercaseSet = new AlphabetSet("Cherokee Glyphs for Latin Lowercase Obfuscation", new string[] {
            null, "Ꮟ", null, null, null,
            null, null, "Ꮒ", "Ꭵ", null,
            null, null, null, null, null,
            null, null, null, null, null,
            null, null, null, null, "Ꭹ",
            null
        }, StyleType.Obfuscation, LetterCaseType.Lowercase);

        /* Cherokee small glyphs */
        public static readonly AlphabetSet CherokeeSmallGlyphsUppercaseSet = new AlphabetSet("Cherokee Small Glyphs for Latin Uppercase Obfuscation", new string[] {
            "ꭺ", null, "ꮯ", "ꭰ", "ꭼ",
            null, "ꮆ", "ꮋ", "ꮖ", "ꭻ",
            null, "ꮮ", "ꮇ", null, null,
            "ꮲ", null, "ꭱ", "ꮪ", "ꭲ",
            null, "ꮩ", "ꮃ", null, null,
            "ꮓ"
        }, StyleType.Obfuscation, LetterCaseType.Uppercase);
        public static readonly AlphabetSet CherokeeSmallGlyphsLowercaseSet = new AlphabetSet("Cherokee Small Glyphs for Latin Lowercase Obfuscation", new string[] {
            null, "ꮟ", null, "ꮷ", null,
            null, null, "ꮒ", "ꭵ", null,
            "ꮶ", null, null, null, null,
            "ꮅ", null, "ꮁ", null, null,
            "ꮼ", "ꮴ", "ꮤ", null, "ꮍ",
            null
        }, StyleType.Obfuscation, LetterCaseType.Lowercase);

        /* Roman glyphs */
        public static readonly AlphabetSet RomanGlyphsUppercaseSet = new AlphabetSet("Roman Glyphs for Latin Uppercase Obfuscation", new string[] {
            null, null, "Ⅽ", "Ⅾ", null,
            null, null, null, "Ⅰ", null,
            null, "Ⅼ", "Ⅿ", null, null,
            null, null, null, null, null,
            null, "Ⅴ", null, "Ⅹ", null,
            null
        }, StyleType.Obfuscation, LetterCaseType.Uppercase);
        public static readonly AlphabetSet RomanGlyphsLowercaseSet = new AlphabetSet("Roman Glyphs for Latin Lowercase Obfuscation", new string[] {
            null, null, "ⅽ", "ⅾ", null,
            null, null, null, "ⅰ", null,
            null, "ⅼ", "ⅿ", null, null,
            null, null, null, null, null,
            null, "ⅴ", null, "ⅹ", null,
            null
        }, StyleType.Obfuscation, LetterCaseType.Lowercase);
        
        /* Coptic glyphs */
        public static readonly AlphabetSet CopticGlyphsUppercaseSet = new AlphabetSet("Coptic Glyphs for Latin Uppercase Obfuscation", new string[] {
            null, "Ⲃ", "Ⲥ", null, null,
            null, null, "Ⲏ", "Ⲓ", null,
            "Ⲕ", "Ⳑ", "Ⲙ", "Ⲛ", "Ⲟ",
            "Ⲣ", null, null, null, "Ⲧ",
            "Ⳙ", null, "Ⲱ", "Ⲭ", "Ⲩ",
            "Ⲍ"
        }, StyleType.Obfuscation, LetterCaseType.Uppercase);

        /* Tifinagh glyphs */
        public static readonly AlphabetSet TifinaghGlyphsUppercaseSet = new AlphabetSet("Tifinagh Glyphs for Latin Uppercase Obfuscation", new string[] {
            "ⴷ", null, "ⵎ", null, "ⴹ",
            null, null, null, "ⵊ", null,
            null, null, null, null, "ⵔ",
            null, "ⵕ", null, "ⵢ", null,
            "ⵡ", "ⴸ", null, "ⵝ", "ⵖ",
            null
        }, StyleType.Obfuscation, LetterCaseType.Uppercase);

        /* Lisu glyphs */
        public static readonly AlphabetSet LisuGlyphsUppercaseSet = new AlphabetSet("Lisu Glyphs for Latin Uppercase Obfuscation", new string[] {
            "ꓮ", "ꓐ", "ꓚ", "ꓓ", "ꓰ",
            "ꓝ", "ꓖ", "ꓧ", "ꓲ", "ꓙ",
            "ꓗ", "ꓡ", "ꓟ", "ꓠ", "ꓳ",
            "ꓑ", null, "ꓣ", "ꓢ", "ꓔ",
            "ꓴ", "ꓦ", "ꓪ", "ꓫ", "ꓬ",
            null
        }, StyleType.Obfuscation, LetterCaseType.Uppercase);

        /* Regional indicator symbol */
        public static readonly AlphabetSet RegionalIndicatorSymbolsUppercaseSet = new AlphabetSet("Regional Indicator Symbols for Latin Uppercase Obfuscation", new string[] {
            "🇦","🇧","🇨","🇩","🇪",
            "🇫","🇬","🇭","🇮","🇯",
            "🇰","🇱","🇲","🇳","🇴",
            "🇵","🇶","🇷","🇸","🇹",
            "🇺","🇻","🇼","🇽","🇾",
            "🇿"
        }, StyleType.Obfuscation, LetterCaseType.Uppercase);
        #endregion
        #endregion

        #region Numbers
        #region Normal
        /* Normal numbers */
        public static readonly NumberSet NumberNormalSet = new NumberSet("Number Normal", new string[] {
            "0", "1", "2", "3", "4",
            "5", "6", "7", "8", "9"
        }, StyleType.Normal);
        
        #endregion

        #region Style
        /* Fullwidth numbers */
        public static readonly NumberSet NumberFullWidthSet = new NumberSet("Number Fullwidth", new string[] {
            "０", "１", "２", "３", "４",
            "５", "６", "７", "８", "９"
        }, StyleType.Style);

        /* Superscript(Upper) numbers */
        public static readonly NumberSet NumberSuperscriptSet = new NumberSet("Number Superscript", new string[] {
            "⁰", "¹", "²", "³", "⁴",
            "⁵", "⁶", "⁷", "⁸", "⁹"
        }, StyleType.Style);

        /* Superscript(Lower) numbers */
        public static readonly NumberSet NumberSubscriptSet = new NumberSet("Number Subscript", new string[] {
            "₀", "₁", "₂", "₃", "₄",
            "₅", "₆", "₇", "₈", "₉"
        }, StyleType.Style);

        /* Circled numbers */
        public static readonly NumberSet NumberCircledSet = new NumberSet("Number Circled", new string[] {
            "⓪", "①", "②", "③", "④",
            "⑤", "⑥", "⑦", "⑧", "⑨"
        }, StyleType.Style);

        /* Parenthesized numbers */
        public static readonly NumberSet NumberParenthesizedSet = new NumberSet("Number Parenthesized", new string[] {
            null, "⑴", "⑵", "⑶", "⑷",
            "⑸", "⑹", "⑺", "⑻", "⑼"
        }, StyleType.Style);

        /* Double circled numbers */
        public static readonly NumberSet NumberDoubleCircledSet = new NumberSet("Number Double Circled", new string[] {
            null, "⓵", "⓶", "⓷", "⓸",
            "⓹", "⓺", "⓻", "⓼", "⓽"
        }, StyleType.Style);

        /* Negative circled numbers (dingbat) */
        public static readonly NumberSet NumberDingbatNegativeCircledSet = new NumberSet("Number Negative Circled (Dingbat)", new string[] {
            "⓿", "❶", "❷", "❸", "❹",
            "❺", "❻", "❼", "❽", "❾"
        }, StyleType.Style);

        /* Circled sans-serif numbers (dingbat) */
        public static readonly NumberSet NumberDingbatSansSerifCircledSet = new NumberSet("Number Sans-Serif Circled (Dingbat)", new string[] {
            "🄋", "➀", "➁", "➂", "➃",
            "➄", "➅", "➆", "➇", "➈"
        }, StyleType.Style);

        /* Negative circled sans-serif numbers (dingbat) */
        public static readonly NumberSet NumberDingbatSansSerifNegativeCircledSet = new NumberSet("Number Sans-Serif Negative Circled (Dingbat)", new string[] {
            "🄌", "➊", "➋", "➌", "➍",
            "➎", "➏", "➐", "➑", "➒"
        }, StyleType.Style);

        /* Bold numbers */
        public static readonly NumberSet NumberBoldSet = new NumberSet("Number Bold", new string[] {
            "𝟎", "𝟏", "𝟐", "𝟑", "𝟒",
            "𝟓", "𝟔", "𝟕", "𝟖", "𝟗"
        }, StyleType.Style);

        /* Double-struck numbers */
        public static readonly NumberSet NumberDoubleStruckSet = new NumberSet("Number Double-Struck", new string[] {
            "𝟘", "𝟙", "𝟚", "𝟛", "𝟜",
            "𝟝", "𝟞", "𝟟", "𝟠", "𝟡"
        }, StyleType.Style);

        /* Sans-serif numbers */
        public static readonly NumberSet NumberSansSerifSet = new NumberSet("Number Sans-Serif", new string[] {
            "𝟢", "𝟣", "𝟤", "𝟥", "𝟦",
            "𝟧", "𝟨", "𝟩", "𝟪", "𝟫"
        }, StyleType.Style);

        /* Sans-serif bold numbers */
        public static readonly NumberSet NumberSansSerifBoldSet = new NumberSet("Number Sans-Serif Bold", new string[] {
            "𝟬", "𝟭", "𝟮", "𝟯", "𝟰",
            "𝟱", "𝟲", "𝟳", "𝟴", "𝟵"
        }, StyleType.Style);

        /* Monospace numbers */
        public static readonly NumberSet NumberMonospaceSet = new NumberSet("Number Monospace", new string[] {
            "𝟶", "𝟷", "𝟸", "𝟹", "𝟺",
            "𝟻", "𝟼", "𝟽", "𝟾", "𝟿"
        }, StyleType.Style);
        #endregion
        #endregion

        #region Static constructor
        static UnicodeSets() {
            /* Set lists : normal sets should come first */
            SetListLatin = new List<AlphabetSet>() {
                /* Normal */
                LatinNormalUppercaseSet,
                LatinNormalLowercaseSet,

                /* Style */
                LatinBoldUppercaseSet,
                LatinBoldLowercaseSet,
                LatinItalicUppercaseSet,
                LatinItalicLowercaseSet,
                LatinBoldItalicUppercaseSet,
                LatinBoldItalicLowercaseSet,
                LatinScriptUppercaseSet,
                LatinScriptLowercaseSet,
                LatinScriptBoldUppercaseSet,
                LatinScriptBoldLowercaseSet,
                LatinFrakturUppercaseSet,
                LatinFrakturLowercaseSet,
                LatinFrakturBoldUppercaseSet,
                LatinFrakturBoldLowercaseSet,
                LatinDoubleStruckUppercaseSet,
                LatinDoubleStruckLowercaseSet,
                LatinSansSerifUppercaseSet,
                LatinSansSerifLowercaseSet,
                LatinSansSerifBoldUppercaseSet,
                LatinSansSerifBoldLowercaseSet,
                LatinSansSerifItalicUppercaseSet,
                LatinSansSerifItalicLowercaseSet,
                LatinSansSerifBoldItalicUppercaseSet,
                LatinSansSerifBoldItalicLowercaseSet,
                LatinMonospaceUppercaseSet,
                LatinMonospaceLowercaseSet,
                LatinFullWidthUppercaseSet,
                LatinFullWidthLowercaseSet,
                LatinSmallUppercaseSet,
                LatinModifierUppercaseSet,
                LatinModifierLowercaseSet,
                LatinSubscriptLowercaseSet,
                LatinParenthesizedUppercaseSet,
                LatinParenthesizedLowercaseSet,
                LatinCircledUppercaseSet,
                LatinCircledLowercaseSet,
                LatinOldItalicUppercaseSet,

                /* Obfuscation */
                CherokeeGlyphsUppercaseSet,
                CherokeeGlyphsLowercaseSet,
                CherokeeSmallGlyphsUppercaseSet,
                CherokeeSmallGlyphsLowercaseSet,
                RomanGlyphsUppercaseSet,
                RomanGlyphsLowercaseSet,
                CopticGlyphsUppercaseSet,
                TifinaghGlyphsUppercaseSet,
                LisuGlyphsUppercaseSet,
                RegionalIndicatorSymbolsUppercaseSet
            };
            SetListNumber = new List<NumberSet>() {
                /* Normal */
                NumberNormalSet,

                /* Style */
                NumberFullWidthSet,
                NumberSuperscriptSet,
                NumberSubscriptSet,
                NumberCircledSet,
                NumberParenthesizedSet,
                NumberDoubleCircledSet,
                NumberDingbatNegativeCircledSet,
                NumberDingbatSansSerifCircledSet,
                NumberDingbatSansSerifNegativeCircledSet,
                NumberBoldSet,
                NumberDoubleStruckSet,
                NumberSansSerifSet,
                NumberSansSerifBoldSet,
                NumberMonospaceSet
            };

            SetListAll = new List<IUnikodSet>();
            SetListAll.AddRange(SetListLatin);
            SetListAll.AddRange(SetListNumber);
            SetListAll = SetListAll.OrderByDescending(x => x.StyleType == StyleType.Normal).ToList();
        }
        #endregion

        #region Functions
        public static IUnikodSet GetSetByName(string name) {
            try {
                return SetListAll.First(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            } catch(Exception exception)
              when (exception is InvalidOperationException || exception is ArgumentNullException) {
                return null;        // No matching found or the argument is null
            }
        }

        public static List<IUnikodSet> GetSetsByStyleType(StyleType type)
            => SetListAll.Where(x => x.StyleType == type).ToList();
        #endregion
    }
}
