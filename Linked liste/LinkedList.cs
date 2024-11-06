using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Linked_Liste
{
    public class LinkedList
    {
        public Element? FirstElement {  get; set; }

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
        }

        public int Count() {
            int count = 0;
            if (FirstElement != null)
            {
                count++;
                Element? pointer = FirstElement;
                while (pointer.NextElement != null)
                {
                    pointer = pointer.NextElement;
                    count++;
                }
            }
            return count;
        }

        public void Remove()
        {
            FirstElement = null;
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

        public void Sort(string order)
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
                        order == "ASC" && nextElement.Data < currentElement.Data
                        || order == "DESC" && nextElement.Data > currentElement.Data
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

            while (lastElementPos != 0)
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

                //Element element = new Element();
                //element.Data = 99;
                //FirstElement = element;
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
