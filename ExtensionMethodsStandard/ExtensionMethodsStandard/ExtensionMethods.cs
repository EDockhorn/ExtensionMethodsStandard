namespace ExtensionMethodsStandard
{
    public static class ExtensionMethods
    {
        public static bool IsNullOrEmpty(this string word) => string.IsNullOrEmpty(word);
        public static bool IsNullOrWhiteSpace(this string word) => string.IsNullOrWhiteSpace(word);
        public static bool IsNullOrEmpty(this object obj) => obj == null ? false : true;
        
        public static ObjectId MongoConvertId(this string id) => ObjectId.Parse(id);

        public static string CurrentDateTimeFormatString(this DateTime dateTime) => dateTime.ToString("yyyy-MM-ddThh:mm:sszzz");

        public static bool ValidateEnumValue(this ManifestOperationEnum operacao, int enumValue)
        {
            var result = Enum.IsDefined(typeof(ManifestOperationEnum), enumValue);
            return result;
        }
        
        public static XmlDocument ToXmlDocument(this XDocument xDocument)
        {
            var xmlDocument = new XmlDocument();
            using (var xmlReader = xDocument.CreateReader())
            {
                xmlDocument.Load(xmlReader);
            }
            return xmlDocument;
        }
        
        public static XDocument ToXDocument(this XmlDocument xmlDocument)
        {
            using (var nodeReader = new XmlNodeReader(xmlDocument))
            {
                nodeReader.MoveToContent();
                return XDocument.Load(nodeReader);
            }
        }

        public static bool IsValidBase64String(this string text)
        {
            byte[] buffer = new byte[((text.Length * 3) + 3) / 4 -
            (text.Length > 0 && text[text.Length - 1] == '=' ?
            text.Length > 1 && text[text.Length - 2] == '=' ? 2 : 1 : 0)];

            return Convert.TryFromBase64String(text, buffer, out int written);
        }

    }
}
