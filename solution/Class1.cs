namespace solution
{
    public class Solution
    {
        public string MakeGood(string s)
        {
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] != s[i + 1])
                {
                    if (Char.ToLower(s[i]) == Char.ToLower(s[i + 1]))
                    {
                        s = s.Remove(i, 2);
                        return MakeGood(s);
                    }
                }
            }
            return s;
        }
    }
}
