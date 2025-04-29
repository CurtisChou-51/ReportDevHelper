using System.Reflection;

namespace ReportDevHelper
{
    public class HtmlCreator
    {
        private readonly Dictionary<string, string> _templates = new();

        public void Init()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            string resNamespace = $"{assembly.GetName().Name}.res";
            foreach (string name in assembly.GetManifestResourceNames().Where(x => x.StartsWith(resNamespace)))
            {
                string templateName = Path.GetFileNameWithoutExtension(name[(resNamespace.Length + 1)..]);
                _templates[templateName] = ReadResource(assembly, name);
            }
        }

        public string Create(ColumnDto dto)
        {
            if (string.IsNullOrEmpty(dto.ColumnName) || string.IsNullOrEmpty(dto.Type))
                return string.Empty;
            if (!_templates.TryGetValue(dto.Type, out string? template))
                return string.Empty;

            string len = dto.Len;
            if (string.IsNullOrEmpty(len))
                len = "1";

            bool displayAsNumber = dto.DataType is "int" or "double" or "float" or "decimal"
                && len != "1";


            if (dto.Type != "radio")
                return html("", dto.CodeClass);

            IEnumerable<string> radioValues = (dto.RadioValues ?? "")
                .Split(',')
                .Where(x => !string.IsNullOrEmpty(x))
                .Distinct();
            return string.Join("\n", radioValues.Select(x => html(x, dto.CodeClass)));

            string html(string radioValue, string codeClass)
            {
                return CleanHtml(template
                    .Replace("{ColumnName}", dto.ColumnName)
                    .Replace("{Len}", len)
                    .Replace("{Class}", (displayAsNumber ? $"textNumber {codeClass}" : $"textCenter {codeClass}").Trim())
                    .Replace("{Style}", displayAsNumber ? "style=\"text-align: right;\" " : "")
                    .Replace("{RadioValue}", radioValue));
            }
        }

        private static string CleanHtml(string html)
        {
            html = html.Replace("\r", "").Replace("\n", "").Replace("\t", "");
            html = System.Text.RegularExpressions.Regex.Replace(html, @"\s{2,}", " ");
            return html;
        }

        private static string ReadResource(Assembly assembly, string resourceName)
        {
            using Stream? stream = assembly.GetManifestResourceStream(resourceName);
            if (stream == null)
                return string.Empty;
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
