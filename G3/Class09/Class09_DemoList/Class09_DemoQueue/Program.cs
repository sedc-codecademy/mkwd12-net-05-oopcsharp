namespace Class09_DemoQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> bankQueue = new Queue<string>();

            bankQueue.Enqueue("Risto");
            bankQueue.Enqueue("SLave");
            bankQueue.Enqueue("Saso");

            string namePeek = bankQueue.Peek();
            string namePeek1 = bankQueue.Peek();
            string namePeek2 = bankQueue.Peek();

            string name = bankQueue.Dequeue();
            string name1 = bankQueue.Dequeue();
            string name2 = bankQueue.Dequeue();

            //string name3 = bankQueue.Dequeue();
            //bankQueue.Enqueue("Jane");
            //bankQueue.Enqueue("Misho");
            bool success = bankQueue.TryDequeue(out string name3);

            bool success1 = bankQueue.TryPeek(out string name4);
        }
    }
}