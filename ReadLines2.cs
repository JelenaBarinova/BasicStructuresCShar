using System;
using System.IO;
using System.Collections.Generic;

public class ReverseLineReader
{
  private const int R = 10;

  public IEnumerable<string> Write10LastLines(string filePath)
  {
    var lines = new Stack<string>();
    using (var reader = File.OpenRead(filePath))
    {
      var line = new Stack<char>();
      for (var i = -1; Math.Abs(i) < reader.Length; i--)
      {
        reader.Seek(i, SeekOrigin.End);

        var ch = Convert.ToChar(reader.ReadByte());
        if (ch == '\n')
        {
          lines.Push(new String(line.ToArray()));
          line.Clear();
          if (lines.Count == R) break;
        }
        else
        {
          line.Push(ch);
        }
      }
    }
    return lines.ToArray();
  }
}
public static class ReverseLineReaderTest
{
  public static void RunReadFile()
  {
    Console.WriteLine("Read 10 last lines from text");

    var reader = new ReverseLineReader();
    var path = @"../Ruby/CodingChallenges/Summer camp diary 2013.txt";
    foreach(var line in reader.Write10LastLines(path))
    {
      Console.WriteLine(line);
    }
    Console.WriteLine();
  }
}
