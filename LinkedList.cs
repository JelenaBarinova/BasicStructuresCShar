using System;
public class Node<T>
{
  public Node<T> next;
  public T nodeValue;
  public Node(T nodeValue)
  {
    this.nodeValue = nodeValue;
    this.next = null;
  }
}
public class LinkedList<T>
{
  public Node<T> head;
  public LinkedList(T[] arr)
  {
    this.head = new Node<T>(arr[0]);
    var prev = this.head;
    for (int i = 1; i < arr.Length; i++)
    {
      var tmp = new Node<T>(arr[i]);
      prev.next = tmp;
      prev = tmp;
    }
  }
  public void Reverse()
  {
    Node<T> newHead = null;
    var curr = this.head;
    while (curr != null)
    {
      var node = curr;
      curr = curr.next;
      node.next = newHead;
      newHead = node;
    }
    this.head = newHead;
  }
}
public static class LinkL
{
  public static void RunLinkLists()
  {
    Console.WriteLine("Linked List");

    Console.WriteLine("LinkedList of integers");
    var listOfIntegers = new LinkedList<int>(new int[] {3, 5, 6});
    var curr = listOfIntegers.head;
    while(curr != null)
    {
      Console.WriteLine(curr.nodeValue);
      curr = curr.next;
    }

    Console.WriteLine("LinkedList of strings");
    var listOfStrings = new LinkedList<string>(new string[] {"hi", "this", "is", "me"});
    var curr1 = listOfStrings.head;
    while(curr1 != null)
    {
      Console.WriteLine(curr1.nodeValue);
      curr1 = curr1.next;
    }

    Console.WriteLine("Reversed LinkedList of strings");
    listOfStrings.Reverse();
    curr1 = listOfStrings.head;
    while(curr1 != null)
    {
      Console.WriteLine(curr1.nodeValue);
      curr1 = curr1.next;
    }

  }
}
