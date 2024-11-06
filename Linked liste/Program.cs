namespace Linked_Liste;
public class Program
{
    public static void Main(string[] args)
    {
        LinkedList linkedList = new LinkedList();
        linkedList.AddElement(1);
        linkedList.AddElement(3);
        linkedList.AddElement(7);
        linkedList.AddElement(2);
        linkedList.AddElement(4);
        linkedList.Reverse();
    }

}

