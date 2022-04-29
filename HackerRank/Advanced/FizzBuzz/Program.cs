fizzBuzz(100);

Enumerable.Range(1, 100)
    .Select(fizzBuzz).ToList()
    .ForEach(Console.WriteLine);

string fizzBuzz(int i) =>
    (i % 3 == 0, i % 5 == 0) switch
    {
        (true, true) => "FizzBuzz",
        (true, _) => "Fizz",
        (_, true) => "Buzz",
        _ => i.ToString()
    };

