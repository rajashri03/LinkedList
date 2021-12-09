using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedlist
{
    public class AddNode<link>//Created Generic class
    {
        public link data;
        public AddNode<link> next;
        public AddNode(link value)//Constructor
        {
            data = value;
        }
    }
    public class Linked_List<link>
    {
        //Represent the head the  linked list  
        public AddNode<link> head;
        //Add() will add a new node to the list
        public void Add(link data)
        {
            //Create a new node  
            AddNode<link> node = new AddNode<link>(data);
            //Checks if the list is empty  
            if (head == null)
            {
                head = node;
            }
            else
            {
                AddNode<link> tempnode = head;
                while (tempnode.next != null)
                {
                    tempnode = tempnode.next;
                }
                tempnode.next = node;
            }

        }
        //Inserts a new element at the given position
        public void InsertBetween(link data, int position)
        {
            AddNode<link> newnode = new AddNode<link>(data);
            newnode.data = data;
            newnode.next = null;
            if (position < 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Position Should be greater than one");
                Console.ResetColor();
            }
            else if (position == 1)
            {
                newnode.next = head;
                head = newnode;
            }
            else
            {
                AddNode<link> tempnode = new AddNode<link>(data);
                tempnode = head;
                while (position > 2)
                {
                    tempnode = tempnode.next;
                    position--;
                }
                newnode.next = tempnode.next;
                tempnode.next = newnode;

            }

        }
        public void AddStart(link data)
        {
            AddNode<link> startnode = new AddNode<link>(data);
            startnode.data = data;
            startnode.next = head;
            head = startnode;

        }

        public void Pop(link data)
        {
            AddNode<link> tempnode = head;
            if (head != null)
            {
                tempnode = head;
                head = head.next;
                tempnode = null;
            }

        }

        public void PopLast(link data)
        {
            AddNode<link> tempnode = head;
            AddNode<link> lastnode = tempnode.next;
            if (head.next!= null)
            {
                //tempnode = head;
                tempnode = tempnode.next;
                tempnode.next = null;
                lastnode = null;
                //lastnode = head;
            }
        }

        public void Search(int searchposition)
        {
            AddNode<link> tempnode = head;
            int i = 0;
            int found = 0;
            if(head == null)
            {
                Console.WriteLine("List is Empty");
            }
            else
            {
                while(tempnode!=null)
                {
                    i++;
                    if(tempnode.data.Equals(searchposition))
                    {
                        found++;
                        break;
                    }
                    tempnode = tempnode.next;                     
                    
                }
                if(found==1)
                {
                    Console.WriteLine("Searching Element is " + searchposition);
                    Console.WriteLine(searchposition + " found at position " + i+"\n");
                }
                else
                {
                    Console.WriteLine(searchposition + " Not found");
                }
            }
            
        }
        //display method
        public void Display()
        {
            if (head == null)
                Console.WriteLine("The list is empty.");
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("List Contains: ");
                Console.ResetColor();
                AddNode<link> tempnode = head;
                while (tempnode != null)
                {
                    Console.Write(tempnode.data + " ");
                    tempnode = tempnode.next;
                }
            }
            Console.WriteLine("\n");
        }

    }
}