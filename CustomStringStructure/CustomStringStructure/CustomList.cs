using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStringStructure
{
    public class CustomList
    {
        public CustomNode head = null;
        private int size = 0;
        public int Count
        {
            get
            {
                return size;
            }
        }
        public void AddLast(char Character)
        {
            size++;
            CustomNode newNode = new CustomNode();
            if (head == null)
            {
                head = new CustomNode();
                head.data = Character;
                head.next = null;             
            }
            else
            {
                CustomNode nodeToAdd = new CustomNode();
                nodeToAdd.data = Character;
                CustomNode previousNode = head;
                while(previousNode.next != null)
                {
                    previousNode = previousNode.next;
                }
                previousNode.next = nodeToAdd;
            }   
                    
        }

    }
}
