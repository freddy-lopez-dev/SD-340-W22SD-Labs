LinkedList<int> list = new LinkedList<int> ();
list.Add(2);

list.PrintAll();


class LinkedList<T>
{
    Node head;
    public class Node
    {
        public T Data { get; set; }
        public Node next;
    }

    public void Add(T data)
    {
        Node node = new Node ();
        node.Data = data;
    }

    
    public void PrintAll()
    {
        Node n = head;
        while(n != null)
        {
            Console.WriteLine(n.Data);
            n = n.next;
        }
    }

    public void Print()
    {
        Node node = head;
        Console.WriteLine(node.Data);
    }

}