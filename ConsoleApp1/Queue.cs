using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Queue
    {

        Queue<int> numbers = new Queue<int>();

        numbers.Enqueue(3); 
            numbers.Enqueue(5); 
            numbers.Enqueue(8); 
 
            
            int queueElement = numbers.Dequeue(); 
        Console.WriteLine(queueElement);
 
            Queue<Person> persons = new Queue<Person>();
        persons.Enqueue(new Person() { Name = "Tom" });
            persons.Enqueue(new Person() { Name = "Bill" });
            persons.Enqueue(new Person() { Name = "John" });
 
            // получаем первый элемент без его извлечения
            Person pp = persons.Peek();
        Console.WriteLine(pp.Name);
 
             Console.WriteLine("Сейчас в очереди {0} человек", persons.Count);
             
            // теперь в очереди Tom, Bill, John
            foreach (Person p in persons)
            {
                Console.WriteLine(p.Name);
            }

    // Извлекаем первый элемент в очереди - Tom
    Person person = persons.Dequeue(); // теперь в очереди Bill, John
    Console.WriteLine(person.Name);
 
            Console.ReadLine();
        }
    }
 
    class Person
{
    public string Name { get; set; }
}
}

    }
}
