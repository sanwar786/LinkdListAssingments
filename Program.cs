using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Assingments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Choose an Option\n 1.Built in Linked List Method\t 2.Add First by creating Method\t3.Add last\t4.append \t5.Delete first node \t6.Search Method\t7.Delete Last node\t8.Display list");
            int option = Convert.ToInt32(Console.ReadLine());
            CustomLinkList LinkList = new CustomLinkList();
            switch (option)
            {
                case 1:
                    Console.WriteLine("Built In LinkedList");
                    LinkedList<int> list = new LinkedList<int>();
                    list.AddLast(10);
                    list.AddLast(20);
                    list.AddLast(30);
                    foreach (int element in list)
                    {
                        Console.WriteLine(element);
                    }
                    Console.WriteLine("After removing first element");
                    list.RemoveFirst();
                    foreach (int element in list)
                    {
                        Console.WriteLine(element);
                    }
                    break;
                case 2:
                    Console.WriteLine("Add First node");

                    LinkList.AddFirst(70);
                    LinkList.AddFirst(30);
                    LinkList.AddFirst(56);
                    break;
                case 3:
                    LinkList.AddLastMethod(56);
                    LinkList.AddLastMethod(30);
                    LinkList.AddLastMethod(70);
                    LinkList.Display();
                    break;
                case 4:
                    LinkList.Append(70);
                    LinkList.Append(30);
                    LinkList.Append(56);
                    LinkList.Display();
                    break;
                case 5:
                    int result = LinkList.DeleteFirstNode();
                    if (result != 0)
                    {
                        Console.WriteLine("{0} is deleted from link list", result);
                    }
                    break;
                case 6:
                    int searchData = LinkList.Search(30);
                    if (searchData != 0)
                        Console.WriteLine("{0} is present in the linked list", searchData);
                    break;
                case 7:
                    Console.WriteLine("Delete last node");
                    int lastNode = LinkList.DeletelastNode();
                    if (lastNode != 0)
                        Console.WriteLine("{0} is deleted from linked list", lastNode);
                    break;
                case 8:
                    LinkList.Display();
                    break;
            }

            LinkList.Display();
            Console.ReadLine();
        }
    }
}
