LinkedList<int> list = new LinkedList<int> ();
list.Add(2);
list.Add(3);
list.Add(5);

list.PrintAll();
list.Print();


class LinkedList <T>
{
    public Node head;
    public class Node
    {
        public T Data { get; set; }
        public Node next { get; set; }

        public Node(T data)
        {
            Data = data;
            this.next = null;
        }
    }

    public void Add(T data)
    {
        Node node = new Node (data);
        if(head == null)
        {
            head = node;
            return;
        }
        node.next = head;
        head = node;
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