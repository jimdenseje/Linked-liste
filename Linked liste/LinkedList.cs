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
    }
}
