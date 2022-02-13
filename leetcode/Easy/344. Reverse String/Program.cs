var l = new[] {'h', 'e', 'l', 'l', 'o'};
ReverseString(l);
foreach (var item in l)
{
    Console.Write(item);
}

void ReverseString(char[] s) {
    for (var i = 0; i < s.Length / 2; i++)
    {
        (s[i], s[^(i+1)]) = (s[^(i+1)], s[i]);
    }
}
