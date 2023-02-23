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
 
            Land[] landarr = new Land[7];
            landarr[0] = sverige;
            landarr[1] = tyskland;
            landarr[2] = sanMarino;
            landarr[3] = new Land()
            {
                namn = "Danmark",
                styrestyp = "monarki",
                huvudstad = "Köpenhamn",
                invånarantal = "5928364"
            };
            landarr[4] = new Land()
            {
                namn = "Italien",
                styrestyp = "republik",
                huvudstad = "Rom",
                invånarantal = "58853482"
            };
            landarr[5] = new Land()
            {
                namn = "Tjeckien",
                styrestyp = "republik",
                huvudstad = "Prag",
                invånarantal = "10551219"
            };
            landarr[6] = new Land()
            {
                namn = "Rumänien",
                styrestyp = "republik",
                huvudstad = "Bukarest",
                invånarantal = "19760314"
            };
        }
    }
}