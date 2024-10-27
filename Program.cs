namespace SimpleList_with_Indexers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleList<string> sL = new SimpleList<string>();
            sL.Add("first","o");
            sL.Add("second","x");
            sL.Add("third","z");
            sL.Add("forth","y");
            sL.Add("fifth","t");
            sL.RemoveFirst();
            sL.Remove("third");
           
            Console.WriteLine(sL.Contains("forth"));
            sL["t"] = "blopblop";
            Console.WriteLine(sL.Count());

            Console.WriteLine(sL["y"]);
        }
    }
}
