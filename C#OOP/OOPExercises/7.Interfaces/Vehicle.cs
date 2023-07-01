/*
    IVehiculo interface 
    with two methods, one for 
        Drive of type void and another for 
        Refuel of type bool that has a parameter of type integer with the amount of gasoline to refuel. 
*/
interface IVehicle
{
  public abstract void Drive(); // interface method (does not have a body)
  public abstract bool Refuel(int gasolineAmount); // interface method (does not have a body)
}