/// Week 9 Project 2
/// File Name: week9project2.cs
/// Author: Lucas Smith
/// Date:  October 25, 2021
///
/// Problem Statement: Write a Temperature class that has two instance variables: a temperature value (a floating-point number) and a character for the scale, either C for Celsius of F for Fahrenheit.
/// 
/// 
/// Overall Plan:
/// 1) Declare public class Temperature
/// 2) Declare the methods inside, along with the private scope variable count that will be used inside.
/// 3) Test each method in the Main class
/// 
using System;

namespace Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the scale (c for Celsius or f for Fahrenheit): ");
            char scaleLetter = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter the temperature value: ");
            double temperature = Convert.ToDouble(Console.ReadLine());

            Temperature t = new Temperature(scaleLetter, temperature);

            char oldScale = t.getScale();
            double oldTemp = t.getTemp();
            double newTemp;

            Console.WriteLine(t.Equals(oldTemp));

            Console.WriteLine("Set a new temperature: ");
            newTemp = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(t.Equals(newTemp));

            Console.WriteLine("Set a new scale: ");
            char newScale = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Now set both (Temp first): ");
            double nextTemp = Convert.ToDouble(Console.ReadLine());
            newScale = Convert.ToChar(Console.ReadLine());

            t.SetBoth(nextTemp, newScale);

            Console.WriteLine(t.ToString());



        }
    }
}

class Temperature
{
    private char scale = 'c';
    private double temp = 0.0;

    public Temperature(char sc, double tp)
    {
        scale = sc;
        temp = tp;
    }

    public char getScale()
    {
        return scale;
    }

    public double getTemp()
    {
        return temp;
    }

    public void setTemp(double t)
    {
        temp = t;
    }

    public void setScale(char s)
    {
        scale = s;
    }

    public void SetBoth(double te, char se)
    {
        temp = te;
        scale = se;
    }

    public override bool Equals(object obj)
    {
        return temp.Equals(obj);
    }
    public override String ToString()
    {
        return "The temperature is " + temp + " " + scale + ".";
    }
}