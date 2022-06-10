using System.Collections;

public class SubstringFinder
{
    public int FindIndexInString(string s)
    {
        var longestSubstring = 0;
        var runningCountOfDistinctCharacters = 0;
        foreach (var c in s)
        {
            var firstIndex = s.IndexOf(c);
            var secondIndex = s.IndexOf(c, s.IndexOf(c) + 1);
            if (secondIndex != -1)
            {
                if (runningCountOfDistinctCharacters == 0)
                {
                    longestSubstring = secondIndex;
                }
                else
                {
                    var potentialLongestSubstring = runningCountOfDistinctCharacters + secondIndex;
                    longestSubstring = potentialLongestSubstring > longestSubstring
                        ? potentialLongestSubstring
                        : longestSubstring;
                    runningCountOfDistinctCharacters = 0;
                }
            }
            else
            {
                runningCountOfDistinctCharacters++;
            }
            s = s.Remove(0, 1);
        }

        return longestSubstring < runningCountOfDistinctCharacters
            ? runningCountOfDistinctCharacters
            : longestSubstring;
    }
    public int FindSubstring(string s)
    {
        var currentLongestSubstring = 0;
        foreach (var c in s)
        {
            var newLongestSubstring = FindLongestSubstring(s);
            currentLongestSubstring = newLongestSubstring > currentLongestSubstring ? newLongestSubstring : currentLongestSubstring;
            s = s.Remove(0,1);
        }

        return currentLongestSubstring;
    }

    private int FindLongestSubstring(string s)
    {
        var charDictionary = new Dictionary<int, char>();
        var i = 0;
        foreach (var c in s)
        {
            if (charDictionary.ContainsValue(c))
            {
                return i;
            }
            else
            {
                charDictionary.Add(i, c);
                i++;
            }
        }

        return i;
    }
}