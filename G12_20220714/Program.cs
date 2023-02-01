using G12_20220714;
using System.Collections;


////================MyQueue===============

//MyQueue myQueue = new MyQueue();

//myQueue.Enqueue("Nika");
//myQueue.Enqueue("Shota");
//myQueue.Enqueue("Mukhran");
//myQueue.Enqueue("Daiana");

//string[] strArr = new string[14];
//strArr[0] = "AB";
//strArr[1] = "BC";
//strArr[2] = "DE";
//strArr[3] = "EF";
//myQueue.CopyTo(strArr, 4);

//Console.WriteLine("This is strArray");
//foreach (string str in strArr)
//    Console.WriteLine(str);

////Console.WriteLine($"\n");
//Console.WriteLine("This is myQueue");
//foreach (var item in myQueue)
//    Console.WriteLine(item);

//Console.WriteLine($"\n");

//Console.WriteLine("This is myQueue");
//while (myQueue.Count > 0)
//{
//    Console.WriteLine(myQueue.Dequeue());
//}


//================MyStack===============
MyStack stack1 = new MyStack();
stack1.Push("Nika");
stack1.Push("Shota");
stack1.Push("Mukhran");
stack1.Push("Daiana");


Console.WriteLine(stack1.Peek());

Console.WriteLine("\n");

foreach (var item in stack1)
{
    Console.WriteLine(item);
}

Console.WriteLine("\n");

while (stack1.Count > 0)
{
    //Console.WriteLine(stack.Peek());
    Console.WriteLine(stack1.Pop());
}
