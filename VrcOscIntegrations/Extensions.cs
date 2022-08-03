using System.Text;

namespace VrcOscIntegrations
{
    public static class Extensions
    {
        public static object ConvertStringToObject(this object obj)
        {
            if (obj.GetType() != typeof(string)) return obj;

            string str = (string)obj;

            if (bool.TryParse(str, out bool b))
            {
                return b;
            }
            else if (int.TryParse(str, out int i))
            {
                return i;
            }
            else if (double.TryParse(str, out double d))
            {
                return d;
            }
            return null;
        }

        public static void CopyProperties(this object target, object source)
        {
            Type type = target.GetType();

            if (type != source.GetType())
                throw new Exception("Target and source type mismatch!");

            foreach (PropertyInfo sourceProperty in type.GetProperties())
                type.GetProperty(sourceProperty.Name)?.SetValue(target, sourceProperty.GetValue(source, null), null);
        }

        public static IEnumerable<string> SplitToLines(this string stringToSplit, int maxLineLength)
        {
            string[] words = stringToSplit.Split(new string[] { " ", Environment.NewLine }, StringSplitOptions.None);
            StringBuilder line = new StringBuilder();
            foreach (string word in words)
            {
                if (word.Length + line.Length <= maxLineLength)
                {
                    line.Append(word + " ");
                }
                else
                {
                    if (line.Length > 0)
                    {
                        yield return line.ToString().Trim();
                        line.Clear();
                    }
                    string overflow = word;
                    while (overflow.Length > maxLineLength)
                    {
                        yield return overflow.Substring(0, maxLineLength);
                        overflow = overflow.Substring(maxLineLength);
                    }
                    line.Append(overflow + " ");
                }
            }
            yield return line.ToString().Trim();
        }
    }
}
