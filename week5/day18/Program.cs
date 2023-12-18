namespace day18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x = 12345;
            //Console.WriteLine(IntegerMirror.Mirror(x));
            //Console.WriteLine(x.Mirror());

            //int y = 54789;
            //Console.WriteLine(y.Mirror());
            //Console.WriteLine(IntegerMirror.Mirror(y));

            //List<int> lst = new List<int>() { 1, 2, 3, 4 };
            //List<string> NameList = new List<string>() { "salim juma", "mohammed said", "ali mohanad" };
            //IEnumerable<int> Result = Enumerable.Where(lst, x => x == 1);
            //var Res = Enumerable.Where(lst, x => x % 2 == 0);

            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            Console.WriteLine(list.GetType());

            list.Remove(2);
            list.AddRange(new int[] { 10, 11, 12, 13, 14 });

            foreach (int i in list)
            {
                
                Console.WriteLine($"{i}");
            }
            list.AddRange(new int[] { 15, 16, 17, 18, 19 } );

            Console.WriteLine("---------------------------- ");

            foreach (int i in list)
            {
                Console.WriteLine($"{i}");
            }
            Console.WriteLine("------------------------------");
        }
    }
}