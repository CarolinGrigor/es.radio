internal class Program
{
    class Radio
    {
        public float Volume { get; set; }

        public float AumentaVolume()
        {
            Volume += Volume * 0.1f;
            return Volume;
        }

        public float DiminuisciVolume()
        {
            Volume -= Volume * 0.1f;
            return Volume;
        }
    }

    private static void Main(string[] args)
    {
        Radio radio = new Radio();

        radio.Volume = 50.0f;

        Console.WriteLine($"Volume iniziale: {radio.Volume}");

        radio.AumentaVolume();
        Console.WriteLine($"Volume aumentato: {radio.Volume}");

        radio.DiminuisciVolume();
        Console.WriteLine($"Volume diminuito: {radio.Volume}");

        Console.ReadKey();
    }
}