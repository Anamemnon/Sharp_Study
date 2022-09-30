/* 1221. Split a String in Balanced Strings
 * 
 * Balanced strings are those that have an equal quantity of 'L' and 'R' characters.
 * 
 * Given a balanced string s, split it into some number of substrings such that:
 * - Each substring is balanced.
 * 
 * Return the maximum number of balanced strings you can obtain.
 */

public class Solution
{
    public int BalancedStringSplit(string s)
    {
        var count = 0;
        var points = 0;

        foreach (char c in s)
        {
            if (c == 'R') count++;
            else count--;

            if (count == 0) points++;
        }

        return points;
    }
}