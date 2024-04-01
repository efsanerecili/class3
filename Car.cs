public class Car
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Speed { get; set; }
    public string CarCode { get; private set; }

    public Car(int id, string name, int speed)
    {
        Id = id;
        Name = name;
        Speed = speed;
        
    }
    public static int id = 1000;
    public Car() 
    {
        id++;
        CarCode = "CA" + id;
        Console.WriteLine(CarCode);
    }

    
}
