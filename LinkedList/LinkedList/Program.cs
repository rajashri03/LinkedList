using System;
using Linkedlist;
/*Lets create a simple Linked List of 56, 30 and 70*/
bool Run = true;
Linked_List<int> insert = new Linked_List<int>();
while (Run)
{
    Console.Write("Select Number:\n" +
        "1)Adding Node At End\n" +
        "2)Add Element At Start of Node\n" +
        "3)Insert Element between two element\n" +
        "4)Delete the First Node\n"+
        "5)Delete the Last Node\n"+
        "6)Search Element\n" +
        "7)Insert 40 after 30\n" +
        "8)Delete 40\n");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            //Linked_List<int> insert = new Linked_List<int>();
            //Adding element to the list  
            insert.Add(56);
            insert.Add(30);
            insert.Add(70);
            //Display()- display the element in list
            insert.Display();
            break;
        case 2:
            insert.AddStart(70);
            insert.Display();
            insert.AddStart(30);
            insert.Display();
            insert.AddStart(56);
            //Display()- display the element in list
            insert.Display();
            break;
        case 3:
            insert.Add(56);
            insert.Add(70);
            insert.Display();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Add 30 after 56\n");
            Console.ResetColor();
            insert.InsertBetween(30, 2);
            insert.Display();
            break;
        case 4:
            insert.Add(56);
            insert.Add(30);
            insert.Add(70);
            insert.Display();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("After Deleting the First Eelement\n");
            Console.ResetColor();
            insert.Pop(56);
            insert.Display();
            break;
        case 5:
            insert.Add(56);
            insert.Add(30);
            insert.Add(70);
            insert.Display();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("After Deleting the Last Eelement\n");
            Console.ResetColor();
            insert.PopLast(56);
            insert.Display();
            break;
        case 6:
            insert.Add(56);
            insert.Add(30);
            insert.Add(70);
            insert.Display();
            insert.Search(30);
            break;
        case 7:
            insert.Add(56);
            insert.Add(30);
            insert.Add(70);
            insert.Display();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Add 40 after 30\n");
            Console.ResetColor();
            insert.InsertBetween(40, 3);
            insert.Display();
            break;
        case 8:
            insert.Add(56);
            insert.Add(30);
            insert.Add(40);
            insert.Add(70);
            insert.Display();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("After Deleting the 40\n");
            Console.ResetColor();
            insert.DeleteBetween(40);
            insert.Display();
            break;
        default:
            Run = !Run;
            break;
    }
}