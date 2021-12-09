using System;
using Linkedlist;
/*Lets create a simple Linked List of 56, 30 and 70*/
bool Run = true;
while (Run)
{
    Console.Write("Select Number:\n" +
        "1)Adding Node At End\n" +
        "2)Add Element At Start of Node\n" +
        "3)Insert Element between two element\n" +
        "4)Delete the First Node\n"+
        "5)Delete the Last Node\n");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            Linked_List<int> nodeList = new Linked_List<int>();
            //Adding element to the list  
            nodeList.Add(56);
            nodeList.Add(30);
            nodeList.Add(70);
            //Display()- display the element in list
            nodeList.Display();
            break;
        case 2:
            Linked_List<int> startlist = new Linked_List<int>();
            startlist.AddStart(70);
            startlist.Display();
            startlist.AddStart(30);
            startlist.Display();
            startlist.AddStart(56);
            //Display()- display the element in list
            startlist.Display();
            break;
        case 3:
            Linked_List<int> between = new Linked_List<int>();
            between.Add(56);
            between.Add(70);
            between.Display();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Add 30 between 56 and 70\n");
            Console.ResetColor();
            between.InsertBetween(30, 2);
            between.Display();
            break;
        case 4:
            Linked_List<int> startdelete = new Linked_List<int>();
            startdelete.Add(56);
            startdelete.Add(30);
            startdelete.Add(70);
            startdelete.Display();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("After Deleting the First Eelement\n");
            Console.ResetColor();
            startdelete.Pop(56);
            startdelete.Display();
            break;
        case 5:
            Linked_List<int> lastdelete = new Linked_List<int>();
            lastdelete.Add(56);
            lastdelete.Add(30);
            lastdelete.Add(70);
            lastdelete.Display();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("After Deleting the Last Eelement\n");
            Console.ResetColor();
            lastdelete.PopLast(56);
            lastdelete.Display();
            break;
        default:
            Run = !Run;
            break;
    }
}