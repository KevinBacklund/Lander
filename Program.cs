namespace Lander
{
    internal class Program
    {
        public class Land
        {
            public string namn = "";
            public string styrestyp = "";
            public string huvudstad = "";
            public string invånarantal = "";
            public void Print() 
            {
                Console.WriteLine($"{namn}  {styrestyp}  {huvudstad}  {invånarantal}\n");
            }
        }
        static void Main(string[] args)
        {
            Land sverige = new Land() 
            {
                namn = "Sverige",
                styrestyp = "monarki",
                huvudstad = "Stockholm",
                invånarantal = "10512820"
            };
            Land tyskland = new Land()
            {
                namn = "Tyskland",
                styrestyp = "republik",
                huvudstad = "Berlin",
                invånarantal = "83783902"
            };
            Land sanMarino = new Land()
            {
                namn = "San Marino",
                styrestyp = "republik",
                huvudstad = "San Marino",
                invånarantal = "33600"
            };
            sverige.Print();
            tyskland.Print();
            sanMarino.Print();
        }
    }
}