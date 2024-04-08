namespace lab21
{
    public class Car
    {
        public static int IdCounter;
        public int Id;
        public string Name;
        public int Speed;
        public double Price;
        public Car()
        {
            Id= ++IdCounter;
        }
        public void GetinfoCar()
        {
            Console.WriteLine($"Id: {Id}, Name:{Name}, Speed: {Speed}, Price: {Price}");
            
        }
    }
}
