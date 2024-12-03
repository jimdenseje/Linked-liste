using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Linked_Liste
{
    public enum Order
    {
        ASC,
        DESC
    }

    public class LinkedList
    {
        public Element? FirstElement {  get; set; }
        private int _count = 0;

        public void AddElement(int item)
        {
            Element element = new Element();
            element.Data = item;

            if (FirstElement == null)
            {
                FirstElement = element;
            }
            else
            {
                Element? pointer = FirstElement;
                while (pointer.NextElement != null)
                {
                    pointer = pointer.NextElement;
                }
                pointer.NextElement = element;
            }
            _count++;
        }

        public int Count() {
            return _count;
        }

        public void Remove()
        {
            FirstElement = null;
            _count = 0;
        }

        public string Print() {
            string output = "";
            if (FirstElement != null)
            {
                output += FirstElement.Data;
                Element? pointer = FirstElement;
                while (pointer.NextElement != null)
                {
                    pointer = pointer.NextElement;
                    output += "," + pointer.Data;
                }
            }
            return output;
        }

        public void Sort(Order order)
        {
            int flips = 0;
            int oldflips = -1;
            while (flips != oldflips) {
                Element? currentElement = FirstElement;
                Element? nextElement = FirstElement?.NextElement;

                oldflips = flips;
                while (nextElement != null)
                {
                    if (
                        order == Order.ASC && nextElement.Data < currentElement.Data
                        || order == Order.DESC && nextElement.Data > currentElement.Data
                    ) {
                        int elementBuffer = nextElement.Data;
                        nextElement.Data = currentElement.Data;
                        currentElement.Data = elementBuffer;
                        flips++;
                    }

                    currentElement = nextElement;
                    nextElement = currentElement?.NextElement;
                }
            }
        }

        public void Reverse()
        {
            int lastElementPos = Count() -1;
            int elementPos = 0;

            while (lastElementPos > 0 )
            {
                Element? currentElement = FirstElement;
                Element? nextElement = FirstElement?.NextElement;

                while (nextElement != null)
                {
                    int elementBuffer = nextElement.Data;
                    nextElement.Data = currentElement.Data;
                    currentElement.Data = elementBuffer;

                    currentElement = nextElement;
                    nextElement = currentElement?.NextElement;

                    elementPos++;
                    if(elementPos == lastElementPos)
                    {
                        elementPos = 0;
                        lastElementPos--;
                        break;
                    }
                }
            }
        }

        public bool Exists(int item)
        {
            if (FirstElement != null)
            {
                Element? pointer = FirstElement;
                if (pointer.Data == item)
                {
                    return true;
                }
                while (pointer.NextElement != null)
                {
                    if (pointer.Data == item)
                    {
                        return true;
                    }
                    pointer = pointer.NextElement;
                }
            }
            return false;
        }

        public bool DeleteElement(int item) {

            if (FirstElement != null)
            {
                Element? pointer = FirstElement;
                Element? preElementpointer = pointer;

                if (pointer.Data == item)
                {
                    if (pointer.NextElement != null) 
                    {
                        FirstElement = pointer.NextElement;
                    } 
                    else 
                    {
                        FirstElement = null;
                    }
                    _count--;
                    return true;
                }
                while (pointer != null)
                {

                    if (pointer.Data == item)
                    {
                        if (pointer.NextElement != null)
                        {
                            preElementpointer.NextElement = pointer.NextElement;
                        }
                        else
                        {
                            preElementpointer.NextElement = null;
                        }
                        _count--;
                        return true;
                    }

                    preElementpointer = pointer;
                    pointer = pointer.NextElement;

                }
            }
            return false;
        }
    }
}
