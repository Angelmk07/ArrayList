namespace ConsoleApp40
{
    internal class Program
    {

        static void Main(string[] args)
        {
            IntArrayList array = new IntArrayList(2);
            array.PushBack(2);
            array.PushBack(2);
            array.PushBack(2);
            array.PushBack(2);
            array.PushBack(3);
            array.PopBack();
            array.TryInsert(2,199);
            array.TryErase(1);
            array.TryForceCapacity(90);
            array.TryForceCapacity(2);
            array.Find(2);
            array.Clear();
            
        }


    }
}
