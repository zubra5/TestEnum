using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkWithQueue();            
        }

        static void WorkWitIEnumerable() 
        {
            Progression progression = new Progression(100, 5);

            foreach (int i in progression)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }

        static void WorkWithICollection() 
        {
            StoreCollection collection = new StoreCollection("\\test.txt");

            collection.Remove(2010);
            //collection.Add(5); - non
            foreach (int i in collection)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }

        static void WorkWithDictionary() 
        {
            Dictionary<int, Person> persons = new Dictionary<int, Person>();

            Person person1 = new Person() { Id=1, Name="John"};
            Person person2 = new Person() { Id = 2, Name = "Kate" };

            persons.Add(person1.Id, person1);
            persons.Add(person2.Id, person2);

            Person searchPerson;
            bool isExist = persons.TryGetValue(2, out searchPerson);

            if (isExist)
            {
                Console.WriteLine(searchPerson.Name);
            }

            Console.ReadLine();
        }

        static void WorkWithStack() 
        {
            //"последний вошел, первый вышел" (last in, first out — LIFO)
            var MyStack = new Stack<char>(); //создаем стек из символов

            MyStack.Push('A');//добавляем в вершину стека букву
            MyStack.Push('B');//добавляем в вершину стека букву
            MyStack.Push('C');//добавляем в вершину стека букву - буква А будет последней вытащена из стека

            Console.WriteLine("The stack in the begining is : ");// печатаем содержимое стека
            foreach (char s in MyStack)
            {
                Console.Write(s);
            }

            Console.WriteLine("\n");

            while (MyStack.Count > 0)
            {
                Console.WriteLine("Pop -> {0}", MyStack.Pop());//извлекаем и удаляем элемент из вершины стека
            }

            if (MyStack.Count == 0) //проверяем пуст ли стек
            {
                Console.WriteLine("\nThe stack is empty!"); // если да, то выводим об этом сообщение
            }

            Console.ReadLine();
        }

        static void WorkWithQueue() 
        {
            //"первый вошел, первый вышел" (first in, first out — FIFO)
            // Creates and initializes a new Queue.
            Queue myQ = new Queue();
            myQ.Enqueue("The");
            myQ.Enqueue("quick");
            myQ.Enqueue("brown");
            myQ.Enqueue("fox");

            // Displays the Queue.
            Console.Write("Queue values:");
            PrintValues(myQ);

            // Removes an element from the Queue.
            Console.WriteLine("(Dequeue)\t{0}", myQ.Dequeue());

            // Displays the Queue.
            Console.Write("Queue values:");
            PrintValues(myQ);

            // Removes another element from the Queue.
            Console.WriteLine("(Dequeue)\t{0}", myQ.Dequeue());

            // Displays the Queue.
            Console.Write("Queue values:");
            PrintValues(myQ);

            // Views the first element in the Queue but does not remove it.
            Console.WriteLine("(Peek)   \t{0}", myQ.Peek());

            // Displays the Queue.
            Console.Write("Queue values:");
            PrintValues(myQ);
            
            Console.ReadLine();
        }

        static void PrintValues(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
                Console.Write("    {0}", obj);
            Console.WriteLine();
        }
    }
}
