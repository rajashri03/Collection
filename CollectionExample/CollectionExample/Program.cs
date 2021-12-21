// See https://aka.ms/new-console-template for more information
using CollectionExample;
Console.WriteLine("************** Generic collection **************");

//Index Based Generic Collection(Arraylist)
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("---Index Based Generic Collection(Arraylist) ---");
Console.ResetColor();
List<int> indexlist = new List<int>();
indexlist.Add(3);
indexlist.Add(4);
indexlist.Add(5);
indexlist.Add(6);
// Displaying list value using index  
foreach (var data in indexlist)
{
    Console.WriteLine(data);
}

// Key based generic Collection (Dictionary)  
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("--- Key based generic Collection (Dictionary) ---");
Console.ResetColor();
Dictionary<int, string> objDic = new Dictionary<int, string>();
objDic.Add(123, "Sayali");
objDic.Add(124, "Rajashri");
// Displaying Dictionary value using Key  
foreach (var data1 in objDic)
{
    Console.WriteLine(data1);
}


//Generic Collection using stack
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("--- Generic Collection using stack ---");
Console.ResetColor();
Stack<int> stackobj = new Stack<int>();
stackobj.Push(20);
stackobj.Push(30);
stackobj.Push(40);
foreach(var stackdata in stackobj)
{
    Console.WriteLine(stackdata);
}
Console.WriteLine("Last Element in Stack:- " + stackobj.Peek());
Console.WriteLine("Remove Value from Stack:"+ stackobj.Pop());
Console.WriteLine("--- Stack after removing element ---");
foreach (var stackdata in stackobj)
{
    Console.WriteLine(stackdata);
}

//Generic Collection using stack
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("--- Generic Collection using Queue ---");
Console.ResetColor();
Queue<int> queueobj = new Queue<int>();
queueobj.Enqueue(20);
queueobj.Enqueue(30);
queueobj.Enqueue(40);
foreach (var queuedata in queueobj)
{
    Console.WriteLine(queuedata);
}
Console.WriteLine("First Element in Queue:- " + queueobj.Peek());
Console.WriteLine("Remove Value from Queue:" + queueobj.Dequeue());
Console.WriteLine("--- Queue after removing element ---");
foreach (var queuedata in queueobj)
{
    Console.WriteLine(queuedata);
}

//Creating Generic List of Persons
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("--- Creating Generic List of Persons ---");
Console.ResetColor();
List<GenericCollection> personlist = new List<GenericCollection>()
{
    new GenericCollection(){ Firstname="Rajashri", age=25, Lastname="Telvekar", phoneNumber="9876543210"},
    new GenericCollection(){ Firstname="Sayali", age=26, Lastname="Kadam", phoneNumber="9566543210"},
    new GenericCollection(){ Firstname="Aditi", age=25, Lastname="Mali", phoneNumber="8895757483"}
};
foreach(var persondata in personlist)
{
    Console.Write("Name:- "+persondata.Firstname);
    Console.Write(" Age:- "+persondata.age);
    Console.Write(" LastName:- "+persondata.Lastname);
    Console.Write(" Phonenumber:- "+persondata.phoneNumber);
    Console.WriteLine();
}

// Creating SortedSet Using SortedSet class
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("--- Generic Collection using SortedSet  ---");
Console.ResetColor();
SortedSet<int> mySet = new SortedSet<int>();
mySet.Add(101);
mySet.Add(101);
mySet.Add(21);
mySet.Add(201);
foreach (var sortdata in mySet)
{
    Console.WriteLine(sortdata);
}
