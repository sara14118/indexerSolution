namespace indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //create instance of program2 class 

            Program2 obj = new Program2();

            //insert values in obj[] using indexer position 
            obj[0] = "sara";
            obj[1] = "ahmed";
            obj[2] = "khlood";

            Console.WriteLine($"First element in obj :{obj[0]}");
            Console.WriteLine($"second element in obj :{obj[1]}");

        }
    }
}