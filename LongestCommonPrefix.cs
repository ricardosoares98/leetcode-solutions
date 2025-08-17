/*
Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".

*/
public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        List<string> prefixs = new List<string>();

        foreach (var word in strs)
        {
            prefixs.Add(word);

            for (int i = 1; i < word.Length; i++)
            {
                prefixs.Add(word.Substring(0, i));
            }            
        }

        var result = prefixs.GroupBy(x => x).Select(g => new { Item = g.Key, Total = g.Count() }).OrderByDescending(k => k.Total).ThenByDescending(t => t.Item.Length).First();

        if (result.Total != strs.Count())
        {
            return "";
        }
        else
        {
            return result.Item;
        }
    }
}