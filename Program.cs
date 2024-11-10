namespace SimpleList_with_Indexers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleList<string> sL = new SimpleList<string>();
            sL.Add("first","a");
            sL.Add("second","b");
            sL.Add("third","c");
            sL.Add("forth","d");
            sL.Add("fifth","e");
            sL.RemoveFirst();
            sL.Remove("third");

            
        }
    }
}
