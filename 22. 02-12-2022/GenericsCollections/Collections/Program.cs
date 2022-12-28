using System.Collections;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList

            //ArrayList  arrayList = new ArrayList();

            //arrayList.Add("Murad");
            //arrayList.Add(89);
            //arrayList.Add(true);
            //arrayList.Add(new Teacher { Fullname = "Eli Eliyev" });


            //for (int i = 0; i < arrayList.Count; i++)
            //{
            //    Console.WriteLine(arrayList[i]);
            //}
            #endregion

            #region SortedList
            //SortedList sortedList = new SortedList();

            //sortedList.Add("one", 5);
            //sortedList.Add("three", "Jeyhun");
            //sortedList.Add("four", true);
            //sortedList.Add("five", "Asif");

            //foreach (DictionaryEntry item in sortedList)
            //{
            //    Console.WriteLine(item.Key + "-" + item.Value);
            //}
            #endregion

            #region Stack

            //Stack stack = new Stack();

            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("siradaki: " + stack.Peek());
            //Console.WriteLine("================");
            //stack.Pop();
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("siradaki: " + stack.Peek());


            #endregion

            #region Queue

            //Queue queue = new Queue();

            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue("Salam");
            //queue.Enqueue(4);
            //queue.Enqueue(5);

            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("siradaki: " + queue.Peek());
            //Console.WriteLine("========================");
            //queue.Dequeue();

            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("siradaki: " + queue.Peek());
            #endregion

            #region Hashtable


            //Hashtable hashtable = new Hashtable();

            //hashtable.Add(1, "Murad");
            //hashtable.Add(20, "Jeyhun");
            //hashtable.Add(3, "Sabina");
            //hashtable.Add(16, "Sabina");
            //hashtable.Add(4, "Sabina");

            //foreach (DictionaryEntry item in hashtable)
            //{
            //    Console.WriteLine(item.Key +" " + item.Value);
            //}
            #endregion

            #region List

            List<int> numbers = new List<int>();
            List<long> ints = new List<long>() { 16, 78, 90,99,10 };

            Console.WriteLine(ints.Capacity);

            //numbers.Add(5);
            //numbers.Add(9);
            //numbers.Add(7);
            //numbers.Add(8);

            //Console.WriteLine(numbers.Count);

            //numbers.AddRange(ints);
            //numbers.Sort();
            //numbers.Reverse();



            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

        }
    }
}