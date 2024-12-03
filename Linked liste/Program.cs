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
        Console.WriteLine(linkedList.Print());

        linkedList.Reverse();
        Console.WriteLine(linkedList.Print());

        linkedList.Sort(Order.DESC);
        Console.WriteLine(linkedList.Print());

        Console.WriteLine();
        string stringlist = linkedList.Print();
        string buffer = "";
        int key = 0;
        for (int x = 0; x < stringlist.Length; x++) {
            if (stringlist[x] == ',') {
                Console.WriteLine(key.ToString() + ": " + buffer);
                buffer = "";
                key++;
            } else {
                buffer += stringlist[x];
            }
        }
        Console.WriteLine(key.ToString() + ": " + buffer);
    }

}

