//product interface 
public interface IVehicle {
    void Drive();
}

//Concrete Products
public class Car : IVehicle {
    public void Drive() => Console.WriteLine("Driving a car!");
}

public class Bike : IVehicle {
    public void Drive() => Console.WriteLine("Riding a Bike");
}

//Factory 
public class VehicleFactory {
    public IVehicle GetVehicle(string type) {
        return type switch {
            "car" => new Car(),
            "bike" => new Bike(),
            _ => throw new ArgumentException("Ivalid type")
        };
    }
}

//usage
var factory = new VehicleFactory();
IVehicle vehicle = factory.GetVehicle("car");
vehicle.Drive();

