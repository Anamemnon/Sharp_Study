/* 2325. Decode the Message
 * 
 * You are given the strings key and message, which represent a cipher key and a secret message, 
 * respectively. The steps to decode message are as follows:
 * 
 * Use the first appearance of all 26 lowercase English letters in key as the order 
 * of the substitution table.
 * 
 * Align the substitution table with the regular English alphabet.
 * 
 * Each letter in message is then substituted using the table.
 * 
 * Spaces ' ' are transformed to themselves.
 * 
 * For example, given key = "happy boy" (actual key would have at least one 
 * instance of each letter in the alphabet), we have the partial 
 * substitution table of ('h' -> 'a', 'a' -> 'b', 'p' -> 'c', 'y' -> 'd', 'b' -> 'e', 'o' -> 'f').
 * 
 * Return the decoded message.
 */

public class Solution
{
    public string DecodeMessage(string key, string message)
    {
        var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower();
        var d = new Dictionary<char, char>();
        var i = 0;

        foreach (var ch in key)
        {
            if (i >= alphabet.Length) break;

            if (!d.ContainsKey(ch) && ch != ' ')
            {
                d.Add(ch, alphabet[i++]);
            }
        }

        char[] arr = new char[message.Length];

        for (int j = 0; j < message.Length; j++)
        {
            if (message[j] == ' ') arr[j] = ' ';
            else { arr[j] = d[message[j]]; }
        }

        return String.Join("", arr);
    }
}