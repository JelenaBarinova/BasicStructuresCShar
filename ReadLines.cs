using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
public class ReadFile
{
  public const int R = 10;
  public static List<string> Write10LastLines(string filePath)
  {
    StreamReader reader = new StreamReader(filePath);
    Queue queue = new Queue();
    string str = reader.ReadLine();
    while (str != null)
    {
      if (queue.Count > R)
      {
        queue.Dequeue();
      }
      queue.Enqueue(str);
      str = reader.ReadLine();
    }
    List<string> res = new List<string>();
    foreach(string item in queue)
    {
      res.Add(item);
    }
    return res;
  }
}
public static class ReadFileTest
{
  public static void RunReadFile()
  {
    Console.WriteLine("Read 10 last lines from text");

    List<string> res = ReadFile.Write10LastLines(@"../Ruby/CodingChallenges/Summer camp diary 2013.txt");
    foreach(string item in res)
    {
      Console.WriteLine(item);
    }
    Console.WriteLine();

  }
}
