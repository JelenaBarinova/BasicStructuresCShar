using System;
using System.Collections.Generic;
public class Node
{
  public Node left;
  public Node right;
  public char nodeValue;
  public Node(char nodeValue)
  {
    this.nodeValue = nodeValue;
    this.left = null;
    this.right = null;
  }
}
public class Tree
{
  public Node root;
  public Tree(char[] arr)
  {
    foreach (char item in arr)
    {
      this.root = AddNode(item, this.root);
    }
  }
  private Node AddNode(char nodeValue, Node root)
  {
    if (root == null)
    {
      return new Node(nodeValue);
    }
    if (nodeValue > root.nodeValue)
    {
      root.right = AddNode(nodeValue, root.right);
    }
    else
    {
      root.left = AddNode(nodeValue, root.left);
    }
    return root;
  }
  public static List<char> InOrder(Node root)
  {
    var list = new List<char>();
    Order(root, list);
    return list;
  }
  private static void Order(Node root, List<char> list)
  {
    if (root == null) return;
    Order(root.left, list);
    list.Add(root.nodeValue);
    Order(root.right, list);
  }
  public static void Mirror(Node root)
  {
    if (root == null) return;
    Mirror(root.left);
    Mirror(root.right);
    ExchangeChildren(root);
  }
  private static void ExchangeChildren(Node root)
  {
    var tmp = root.left;
    root.left = root.right;
    root.right = tmp;
  }
}
public static class TreeTest
{
  public static void RunTree()
  {
    Console.WriteLine("Tree");

    Console.WriteLine("Given tree");
    var tree = new Tree(new char[] {'a','b','c','d','e','f','g','i','h'});
    var list = Tree.InOrder(tree.root);
    foreach(char item in list)
    {
      Console.Write(item + " ");
    }
    Console.WriteLine();

    Console.WriteLine("Mirrored tree");
    var treeRoot = tree.root;
    Tree.Mirror(treeRoot);
    var listMirrored = Tree.InOrder(treeRoot);
    foreach(char item in listMirrored)
    {
      Console.Write(item + " ");
    }
    Console.WriteLine();
  }
}
