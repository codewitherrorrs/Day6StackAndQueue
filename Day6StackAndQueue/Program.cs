namespace Day6StackAndQueue
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            //For Adding Element in queue.....
            Queue queue = new Queue();
            queue.Enqueue(20);
            queue.Enqueue(10);
            queue.Enqueue(40);
            queue.Enqueue(54);
            queue.Peek();
            Console.WriteLine("Original Queue : ");
            queue.Display();
            //Remove the Element from Queue......
            queue.Dequeue();
            //For Find the Peek.
            queue.Peek();
            //For Showing / Display the queue.
            queue.Display();
            Console.ReadKey();
        }
    }
}