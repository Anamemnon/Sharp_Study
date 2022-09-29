/* 125. Valid Palindrome
 * 
 * A phrase is a palindrome if, after converting all uppercase letters into lowercase letters 
 * and removing all non-alphanumeric characters, it reads the same forward and backward.
 * Alphanumeric characters include letters and numbers.
 * 
 * Given a string s, return true if it is a palindrome, or false otherwise.
 * 
 * Example 1:
 * 
 * Input: s = "A man, a plan, a canal: Panama"
 * Output: true
 * Explanation: "amanaplanacanalpanama" is a palindrome.

 */
public class Solution
{
    public bool IsPalindrome(string s)
    {
        int i = 0;
        int j = s.Length-1;
        s = s.ToLower();

        while (i < j){
            if (!char.IsLetterOrDigit(s[i]))
                i++;
            else if (!char.IsLetterOrDigit(s[j]))
                j--;
            else if (s[i++] != s[j--])
                return false;
        }
        
        return true;
    }
    }
}