namespace ExtensionMethodsStandard
{
    public static class ExtensionMethods
    {
        public static bool IsNullOrEmpty(this string word) => string.IsNullOrEmpty(word);
        public static bool IsNullOrWhiteSpace(this string word) => string.IsNullOrWhiteSpace(word);
        public static bool IsNullOrEmpty(this object obj) => obj == null ? false : true;

    }
}
