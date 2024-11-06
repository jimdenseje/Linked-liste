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
                while (true)
                {
                    if (pointer.NextElement == null)
                    {
                        pointer.NextElement = element;
                        break;
                    }
                    pointer = pointer.NextElement;
                }
            }
        }

        public int Count() {
            int count = 0;
            if (FirstElement == null)
            {
                return count;
            }
            else
            {
                count++;
                Element? pointer = FirstElement;
                while (true)
                {
                    if (pointer.NextElement == null)
                    {
                        return count;
                    }
                    pointer = pointer.NextElement;
                    count++;
                }
            }
        }

        public void Remove()
        {
            FirstElement = null;
        }

        public string Print() {
            string output = "";
            if (FirstElement == null)
            {
                return output;
            }
            else
            {
                output += FirstElement.Data;
                Element? pointer = FirstElement;
                while (true)
                {
                    if (pointer.NextElement == null)
                    {
                        return output;
                    }
                    pointer = pointer.NextElement;
                    output += "," + pointer.Data;
                }
            }
        }
    }
}
