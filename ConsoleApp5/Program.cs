using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main()
        {
        }
    }
}
class Passenger
{
    public ClassofPlace classofPlace { get; private set; }
    public string name { get; private set; }
    public int placenumber { get; private set; }
}
class Airplane
{
    List<Passenger> passengers = new List<Passenger> { };
    public void AddPassenger(Passenger passenger)
    {
        passengers.Add(passenger);
    }
    public void RemovePassenger(Passenger passenger)
    {
        passengers.Remove(passenger);
    }
    public List<Passenger> GetPassenger(ClassofPlace classofPlace)
    {
        var result = new List<Passenger>();
        foreach (var item in passengers)
        {
            if (item.classofPlace == classofPlace)
            {
                result.Add(item);
            }
        }
        return result;

    }
}
public enum ClassofPlace
{
    Economy,
    Business,
    VIP
}
