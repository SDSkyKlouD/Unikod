namespace SDSK.Libs.Unikod.Common {
    public enum StyleType {
        Normal,
        Style,
        Obfuscation,
        All
    }

    public interface IUnikodSet {
        string SetName { get; }
        string[] SetData { get; }
        StyleType StyleType { get; }
    }

    public class AlphabetSet : IUnikodSet {
        public string SetName { get; }
        public string[] SetData { get; }
        public StyleType StyleType { get; }
        public bool IsUppercase { get; }

        internal AlphabetSet(string name, string[] data, StyleType styleType, bool uppercase) {
            SetName = name;
            SetData = data;
            StyleType = styleType;
            IsUppercase = uppercase;
        }
    }

    public class NumberSet : IUnikodSet {
        public string SetName { get; }
        public string[] SetData { get; }
        public StyleType StyleType { get; }

        internal NumberSet(string name, string[] data, StyleType styleType) {
            SetName = name;
            SetData = data;
            StyleType = styleType;
        }
    }
}
