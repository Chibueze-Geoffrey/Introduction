namespace Intro
{
    public static class Person
    {
        public static int Id { get; set; }
        public static string Name { get; set; }
        public static  string Title { get; set; }

        public static void colour(string colour)
        {
            Console.WriteLine($"I am {colour} in Complexion");
        }

        public static void ThrowExcep()
        {
          //  if (Name != "John")
            throw new Exception();
        }

    }
   
}
