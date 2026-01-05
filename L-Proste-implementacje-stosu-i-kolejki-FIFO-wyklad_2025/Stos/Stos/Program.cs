using StosLib;


var s = new Stos<int>(3);

s.Push(1);
s.Push(2);
s.Push(3);
s.Push(4);

Console.WriteLine(s.Count);

Console.WriteLine(s);

var s02 = new Stos<char>(3);
s02.Push('a');
s02.Push('2');
s02.Push('*');
s02.Push('B');
s02.Push('B');


Console.WriteLine(s02.Count);

Console.WriteLine(s02);


var s03 = new Stos<int>(3);

s03.Pop();