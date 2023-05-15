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
            //Remove the Element from Queue......
            queue.Dequeue();
            //For Showing / Display the queue.
            queue.Display();
            Console.ReadKey();
        }
    }
}