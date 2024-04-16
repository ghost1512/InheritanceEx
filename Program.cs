internal class Program
{
    private static void Main(string[] args)
    {
        Mosgain mos = new Mosgain(1, 2);

        if (mos is Mosgain)
        {
            Console.WriteLine("Gia tri la {0}", mos.attack);
            Console.WriteLine("Gia tri la {0}", mos.health);
            mos.SetColor();
        }
    }
}