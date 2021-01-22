/*
0003 Program structure

The Program structures in C# are

programs
namespaces
types
members
assemblies
*/
using System;
namespace YourNamespace
{
 delegate int YourDelegate();

 class YourMainClass
 {
 static void Main(string[] args) 
 {
 //Your program starts here...
 }
 }

 class YourClass
 {
 }

 struct YourStruct
 {
 }

 interface IYourInterface 
 {
 }


 enum YourEnum 
 {
 }

 namespace YourNestedNamespace
 {
 struct YourStruct 
 {
 }
 }

}

/*

C# programs consist of one or more source files.

Programs declare types(class, interface, delegate, struct...).

Types contain members and can be organized into namespaces.

Fields, methods, properties, and events are examples of members.

When C# programs are compiled, they are physically packaged into assemblies.

Assemblies have the file extension .exe or .dll.

.exe file is an application.

.dll file is a library.

EXAMPLE 

using System;
namespace MyNamespace
{
 public class Stack
 {
 MyElement top;
 public void Push(object data)
 {
 top = new MyElement(top, data);
 }
 public object Pop()
 {
 if (top == null) throw new InvalidOperationException();
 object result = top.data;
 top = top.next;
 return result;
 }
 class MyElement
 {
 public MyElement next;
 public object data;
 public MyElement(MyElement next, object data)
 {
 this.next = next;
 this.data = data;
 }
 }
 }
 class Test
 {
 static void Main()
 {
 Stack s = new Stack();
 s.Push(1);
 s.Push(10);
 s.Push(100);
 Console.WriteLine(s.Pop());
 Console.WriteLine(s.Pop());
 Console.WriteLine(s.Pop());
 }
 }

}


The code above declares a class named Stack in a namespace called MyNamespace.

The fully qualified name of this class is MyNamespace.Stack.

The class contains several members: a field named top, two methods named Push and Pop, and a nested class named MyElement.

The output:


100
10
1

*/
