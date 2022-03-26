using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class SLL
    {
        public Node head;


        public static void Insert(SLL list1, int value)
        {
            Node newNode = new Node(value);
            newNode.next = list1.head;
            list1.head = newNode;

        }

        public static Boolean Includes(SLL list, int value)
        {
            Boolean flag = false;
            Node temp = list.head;
            while( temp.next!= null)
            {
                if(temp.value == value)
                {
                    flag = true;
                }
                
                temp = temp.next;

                
            }
            if (temp.value == value)
            {
                flag = true;
            }
            return flag;

        }

        public static String ToStringMethod(SLL list)
        {
            String str = "";
            Node temp = list.head;
            while(temp.next != null)
            {
                str = str + "[" + Convert.ToString(temp.value) + "]" +" -> ";
                temp = temp.next;
            }
            
            str = str + "[" + Convert.ToString(temp.value) + "]" + " -> ";


            str = str + "NUll";
            return str;
        }


    }
}
