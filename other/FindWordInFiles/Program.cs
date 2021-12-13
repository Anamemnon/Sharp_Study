using System.Collections.Concurrent;

class Counter
{
    const string directoryPath = @"C:\Users\Chekir\source\repos\Study\other\FindWordInFiles\test_files\";
    static readonly string[] files = Directory.GetFiles(directoryPath) ?? Array.Empty<string>();
    readonly string target = "dotnet";

    static void Main(string[] args)
    {
        ConcurrentDictionary<string, int> result = new();
        string[] filteredFiles = FilterFiles(files);
        RunCounter(filteredFiles, result);
        PrintResult(result);
    }

    private static string[] FilterFiles(string[] files)
    {
        return files.Where(f => f.EndsWith(".txt")).ToArray();
    }

    private static void RunCounter(string[] files, ConcurrentDictionary<string, int> result)
    {
        List<Task> tasks = new();
        foreach (var file in files)
        {
            tasks.Add(Task.Run(() => CountWord(file, result)));
        }

        tasks.ForEach(x => x.Wait());
    }

    private static void CountWord(string file, ConcurrentDictionary<string, int> result)
    {
        result[file] = 0;

        using StreamReader sr = new(file);
        var line = string.Empty;

        while ((line = sr.ReadLine()) != null)
        {
            result[file] += System.Text.RegularExpressions.Regex.Matches(line, target).Count;
        }
    }

    private static void PrintResult(ConcurrentDictionary<string, int> result)
    {
        foreach (var keyValuePair in result)
        {
            Console.WriteLine($"File: {keyValuePair.Key} => {keyValuePair.Value}");
        }
    }
}