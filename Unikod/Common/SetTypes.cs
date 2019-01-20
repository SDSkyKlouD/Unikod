namespace SDSK.Libs.Unikod.Common {
    internal enum StyleType {
        Normal,
        Style,
        Obfuscation,
        All
    }

    internal interface IUnikodSet {
        string[] SetData { get; }
        StyleType StyleType { get; }
    }

    internal class AlphabetSet : IUnikodSet {
        public string[] SetData { get; }
        public StyleType StyleType { get; }
        public bool IsUppercase { get; }

        internal AlphabetSet(string[] data, StyleType styleType, bool uppercase) {
            SetData = data;
            StyleType = styleType;
            IsUppercase = uppercase;
        }
    }

    internal class NumberSet : IUnikodSet {
        public string[] SetData { get; }
        public StyleType StyleType { get; }

        internal NumberSet(string[] data, StyleType styleType) {
            SetData = data;
            StyleType = styleType;
        }
    }
}
