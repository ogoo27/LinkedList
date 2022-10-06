// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections;
using System.Collections.Generic;
using DataStructureAndAccess;

var list = new DataStructureAndAccess.Queue<int>();
list.Enqueue(1);
list.Enqueue(2);
list.Enqueue(3);
//list.Dequeue();
Console.WriteLine(list.Dequeue());
//list.Pop();

//list.PrintList();
