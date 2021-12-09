using System;
using Linkedlist;
/*Lets create a simple Linked List of 56, 30 and 70*/
bool Run = true;
while (Run)
{
    Console.Write("Select Number:\n1)Adding Node At End\n");
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

        default:
            Run = !Run;
            break;
    }
}
