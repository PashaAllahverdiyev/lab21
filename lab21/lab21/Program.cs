using lab21;

class Program
{
    static void Main(string[] args)
    {



          Car car1 = new Car()
          {

              Name = "BMW",
              Speed = 300,
              Price = 30000

          };
        Car car2 = new Car()
        {
            Name = "Mercedes",
            Speed = 260,
            Price = 19000
        };
        Car car3 = new Car()
        {
            Name = "Porsche",
            Speed = 320,
            Price = 50000

        };
        Car car4 = new Car()
        {
            Name = "Lada",
            Speed = 180,
            Price = 7000
        };

        Car[] cars = { car1, car2, car3, car4 };
        Gallery gallery = new Gallery("MyGallery", cars);
        gallery.GetGalleryCarShow();
        int idToSearch = 3; 
        Car foundCar = gallery.GetCarById(idToSearch);
        if (foundCar != null)
            Console.WriteLine($"Car found with id {idToSearch}: {foundCar.Name}");
        else
            Console.WriteLine($"No car found with id {idToSearch}");

        Console.WriteLine($"Total price of all cars: {gallery.SumCarsPrice()}");

    }
}
