using Microsoft.VisualStudio.TestPlatform.TestHost;
using Linked_Liste;

namespace LinkedList_Tests
{
    public class ElementTests
    {
        [Fact]
        public void ElementHasData()
        {
            Element element = new Element();
            element.Data = 3;
            Assert.Equal(3, element.Data);
        }

        [Fact]
        public void ElementHasPointer()
        {
            Element element = new Element();
            Element result = element.NextElement;
            Assert.Null(result);
        }
    }

    public class LinkedListTests
    {
        [Fact]
        public void LinkedListHasMethodeToBeInilatiased()
        {
            LinkedList linkedList = new LinkedList();

            Assert.Null(linkedList.FirstElement);
        }

        [Fact]
        public void LinkedListHasElementPointer()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.AddElement(1);

            Assert.NotNull(linkedList.FirstElement);
        }

        [Fact]
        public void LinkedListAddAdditionalElement()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.AddElement(1);
            linkedList.AddElement(2);

            Assert.NotNull(linkedList.FirstElement?.NextElement);
        }

        [Fact]
        public void LinkedListCountElements()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.AddElement(1);
            linkedList.AddElement(2);
            linkedList.AddElement(3);

            Assert.Equal(3, linkedList.Count());
        }

        [Fact]
        public void LinkedListRemoveElements()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.AddElement(1);
            linkedList.AddElement(2);
            linkedList.AddElement(3);
            linkedList.Remove();

            Assert.Equal(0, linkedList.Count());
        }

        [Fact]
        public void LinkedListPrintElements()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.AddElement(1);
            linkedList.AddElement(2);
            linkedList.AddElement(3);

            Assert.Equal("1,2,3", linkedList.Print());
        }

        [Fact]
        public void LinkedListSortingElements()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.AddElement(7);
            linkedList.AddElement(1);
            linkedList.AddElement(3);
            linkedList.AddElement(2);
            linkedList.AddElement(4);
            linkedList.Sort("ASC");

            Assert.Equal("1,2,3,4,7", linkedList.Print());
        }

        [Fact]
        public void LinkedListSortingDescendingElements()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.AddElement(1);
            linkedList.AddElement(3);
            linkedList.AddElement(7);
            linkedList.AddElement(2);
            linkedList.AddElement(4);
            linkedList.Sort("DESC");

            Assert.Equal("7,4,3,2,1", linkedList.Print());
        }
    }
}