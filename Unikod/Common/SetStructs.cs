namespace SDSK.Libs.Unikod.Common {
    internal enum StyleType {
        Normal,
        Style,
        Obfuscation,
        All
    }

    internal struct AlphabetSet {
        internal string[] SetData { get; }
        internal StyleType StyleType { get; }
        internal bool IsUppercase { get; }

        internal AlphabetSet(string[] data, StyleType styleType, bool uppercase) {
            SetData = data;
            StyleType = styleType;
            IsUppercase = uppercase;
        }
    }

    internal struct NumberSet {
        internal string[] SetData { get; }
        internal StyleType StyleType { get; }

        internal NumberSet(string[] data, StyleType styleType) {
            SetData = data;
            StyleType = styleType;
        }
    }
}
