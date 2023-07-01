/*
Then create a Car class with a 
    builder that receives a parameter with the car's starting gasoline amount and
    implements the Drive and Refuel methods of the car.

The Drive method will print on the screen that the car is Driving, if the gasoline is greater than 0. 
The Refuel method will increase the gasoline of the car and return true.
*/

class Car : IVehicle {
    private int gasolineAmount;

    public Car(int gasolineAmount) {
        this.gasolineAmount = gasolineAmount;
    }

    public void Drive() {
        if (this.gasolineAmount > 0) {
            Console.WriteLine("The car is Driving");
        } else {
            Console.WriteLine("The car run out of fuel.");
        }
    }

    public bool Refuel(int increaseAmount) {
        this.gasolineAmount += increaseAmount;
        return true;
    }

}