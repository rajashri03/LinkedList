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