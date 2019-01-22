namespace SDSK.Libs.Unikod.Common {
    internal enum StyleType {
        Normal,
        Style,
        Obfuscation,
        All
    }

    internal interface IUnikodSet {
        string SetName { get; }
        string[] SetData { get; }
        StyleType StyleType { get; }
    }

    internal class AlphabetSet : IUnikodSet {
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

    internal class NumberSet : IUnikodSet {
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
