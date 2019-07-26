namespace SDSK.Libs.Unikod.Types {
    public enum StyleType {
        Normal,
        Style,
        Obfuscation
    }

    public enum LetterCaseType {
        Uppercase,
        Lowercase
    }

    public interface IUnikodSet {
        string Name { get; }
        string[] Data { get; }
        StyleType StyleType { get; }
    }

    public class AlphabetSet : IUnikodSet {
        public string Name { get; }
        public string[] Data { get; }
        public StyleType StyleType { get; }
        public LetterCaseType LetterCaseType { get; }

        public AlphabetSet(string name, string[] data, StyleType styleType, LetterCaseType caseType) {
            Name = name;
            Data = data;
            StyleType = styleType;
            LetterCaseType = caseType;
        }
    }

    public class NumberSet : IUnikodSet {
        public string Name { get; }
        public string[] Data { get; }
        public StyleType StyleType { get; }

        public NumberSet(string name, string[] data, StyleType styleType) {
            Name = name;
            Data = data;
            StyleType = styleType;
        }
    }
}
