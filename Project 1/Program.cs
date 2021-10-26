/// Week 9 Project 1
/// File Name: week9project1.cs
/// Author: Lucas Smith
/// Date:  October 25, 2021
///
/// Problem Statement: Define a class called Odometer that will be used to track fuel usage and miles per gallon.
/// 
/// 
/// Overall Plan:
/// 1) Declare public class Odometer
/// 2) Declare the methods inside, along with the private scope variable count that will be used inside.
/// 3) Test each method in the Main class

using System;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing All Methods: ");

            Odometer odo = new Odometer(19, 20);

            odo.addFuel(9);

            odo.drive(18);

            Console.WriteLine(odo.getFuelEfficiency());
            Console.WriteLine(odo.getFuelLevel());
            Console.WriteLine(odo.getOdometer());


            Console.WriteLine(odo.ToString());


        }
    }
}


class Odometer
{
    private double fuelLevel;
    private double fuelEff;
    private double odometer;

    public Odometer(double fuelEff, double fuelLevel)
    {
        this.fuelLevel = fuelLevel;
        this.fuelEff = fuelEff;
        this.odometer = 0.0;
    }

    public double getFuelEfficiency()
    {
        return this.fuelEff;
    }

    public double getFuelLevel()
    {
        return this.fuelLevel;
    }

    public double getOdometer()
    {
        return this.odometer;
    }

    public double addFuel(double gallons)
    {
        this.fuelLevel = this.fuelLevel + gallons;
        return this.fuelLevel;
    }

    public double drive(double miles)
    {
        double distance = (this.fuelLevel * this.fuelEff);

        if (distance > miles)
        {
            distance = miles;
        }

        this.fuelLevel = (fuelLevel - (distance / fuelEff));
        this.odometer = odometer + distance;
        return distance;
    }

    public override String ToString()
    {
        return "MPG: " + this.fuelEff + " Miles: " + this.odometer + " Fuel: " + this.fuelLevel;
    }
}