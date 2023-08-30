


using LinkedList;

BasicLinkedList obj= new BasicLinkedList();
//Node first = new Node();
//first.data = 10;
//obj.head = first;

//Node second = new Node();
//second.data = 20;
//first.next = second;

//Node third = new Node();
//third.data = 30;
//second.next = third;

//Node fourth = new Node();
//fourth.data = 40;
//third.next = fourth;
//obj.Traverse();


AddElementInLinkedList add=new AddElementInLinkedList();
add.Add(20);
add.Add(30);
add.Add(40);
add.Add(50);
add.AddFirst(60);
add.AddAtIndex(3, 800);
add.Traverse();
Console.WriteLine("----------------------------------------");
add.RemoveLastIndex();
add.Traverse();
Console.WriteLine("----------------------------------------");
add.FindIndex(30);
Console.WriteLine("----------------------------------------");
add.RemoveFirstElement();
add.Traverse();




