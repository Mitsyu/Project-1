namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // personalized greeting
            string firstName = "Jila Phonprasith";
            string favMovie = "The Matrix";
            string greeting = "Hello " + firstName + "! My Favourite movie is " + favMovie;

            Console.WriteLine(greeting.ToLower());


            // movie title
            favMovie = favMovie.ToUpper();
            Console.WriteLine(favMovie);

            // 1 c
            Console.WriteLine(favMovie.Contains("THE"));

            // 1 d
            Console.WriteLine(favMovie.Replace("A", "@").Replace("E", "3"));


            // 2
            string favMovieQuote = "When you give up, that's when the game ends.";

            favMovieQuote = favMovieQuote.Replace("a", "").Replace("e", "").Replace("i", "").Replace("e", "").Replace("o", "").Replace("u", "");
            Console.WriteLine(favMovieQuote.ToLower());



            //ascii art
            Console.WriteLine("             ;,'           )  (");
            Console.WriteLine("     _o_    ;:;'          (   ) )");
            Console.WriteLine(" ,-.'---`.__ ;             ) ( (");
            Console.WriteLine("((j`=====',-'              ) ( (");
            Console.WriteLine(" `-\\     /            .-'---------|  ");
            Console.WriteLine("    `-=-'            ( C|/\\/\\/\\/\\/|");
            Console.WriteLine("                      '-./\\/\\/\\/\\/|");
            Console.WriteLine("                        '_________'    ");
            Console.WriteLine("                         '-------'    ");
        }
    }
}