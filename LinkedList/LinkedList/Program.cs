using Linkedlist;
Console.Write("Select Number:\n1)Add elements");
int option = Convert.ToInt32(Console.ReadLine());
switch (option)
{
    case 1:
        Linked_List<int> list = new Linked_List<int>();//creating list
        //Adding element to the list  
        list.Add(56);
        list.Add(30);
        list.Add(70);
        //Display()- display the element in list
        list.Display();
        break;
}