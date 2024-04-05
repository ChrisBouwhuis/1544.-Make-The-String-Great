using System.Text;

namespace solution
{
    public class Solution
    {
        public string MakeGood(string s)
        {
            var sb = new StringBuilder(s);
            for (int i = 0; i < sb.Length - 1;)
                if (sb[i] - 32 == sb[i + 1]) { sb.Remove(i, 2); i = 0; }
                else if (sb[i] + 32 == sb[i + 1]) { sb.Remove(i, 2); i = 0; }
                else i++;
            return sb.ToString();
        }
    }
}
