namespace lab21
{
    public class Gallery
    {
        public string GalleryName { get; set; }
        public Car[] Cars { get; set; }
        public Gallery(string galleryname, Car[] cars)
        {
            GalleryName = galleryname;
            Cars = cars;    
        }
        
        public void GetGalleryCarShow()
        {
            Console.WriteLine($"Gallery Name: {GalleryName}");
            foreach ( Car car in Cars )
            {
                car.GetinfoCar();
            }
        }
       public Car GetCarById(int id)
        {
            foreach ( Car car in Cars )
            {
                if (car.Id == id)   
                    return car;
            }return null;
        }
        public double SumCarsPrice()
        {
            double sum = 0;
            foreach ( Car car in Cars)
            {
                sum += car.Price;
            }
            return sum;

        }
    }
}
