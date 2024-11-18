using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCsharpInterfaceTransport
{
    interface ITransport
    {
        string Name { get; set; }
        string Type { get; set; }
        int maxSpeed { get; set; }
        int height { get; set; }
        int width { get; set; }
        string petrolType { get; set; }
        int Capacity { get; set; }

        void Move();

    }
    interface IGround : ITransport
    {
        void FollowTransportSigns();
        void StopAtTrafficLight();
    }
    interface IWater : ITransport
    {
        void Anchor();
        void Moor();
        void NavigateToPort();
    }
    interface IAir : ITransport
    {
        void TakeOff();
        void Land();
        void NavigateToAirport();
    }
    class Car : IGround
    {
      public  string Name { get; set; }
        public string Type { get; set; }
        public int maxSpeed { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public string petrolType { get; set; }
        public int Capacity { get; set; }

        public Car() { }
        public Car(string n, string t, int ms, int h, int w, string pt, int c)
        {
            Name = n;
            Type=t;
            maxSpeed = ms;
            height = h;
            width = w;
            petrolType = pt;
            Capacity = c;
        }
        public void Move()
        {
            Console.Write("Car move");
            Console.WriteLine();
        }
       public void Park()
        {
            Console.WriteLine("Car parked");
            Console.WriteLine();
        }
       public void MoveOnRoad()
        {
            Console.WriteLine("Car move on road");
            Console.WriteLine();
        }
       public void StopAtTrafficLight()
        {
            Console.WriteLine("Car stopped at traffic light");
            Console.WriteLine();
        }
        public void FollowTransportSigns()
        {
            Console.WriteLine("Car is following transport signs");
            Console.WriteLine();
        }

    }
    class RailWay : IGround
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int maxSpeed { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public string petrolType { get; set; }
        public int Capacity { get; set; }

        public RailWay() { }
        public RailWay(string n, string t, int ms, int h, int w, string pt, int c)
        {
            Name = n;
            Type = t;
            maxSpeed = ms;
            height = h;
            width = w;
            petrolType = pt;
            Capacity = c;
        }
        public void Move()
        {
            Console.Write("RailWay move");
            Console.WriteLine();
        }
        public void Park()
        {
            Console.WriteLine("RailWay parked");
            Console.WriteLine();
        }
        public void MoveOnRoad()
        {
            Console.WriteLine("RailWay move on road");
            Console.WriteLine();
        }
        public void StopAtTrafficLight()
        {
            Console.WriteLine("Car stopped at traffic light");
            Console.WriteLine();
        }
        public void FollowTransportSigns()
        {
            Console.WriteLine("RailWay is following transport signs");
            Console.WriteLine();
        }
    }
    class HorseDawn: IGround
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int maxSpeed { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public string petrolType { get; set; }
        public int Capacity { get; set; }

        public HorseDawn() { }
        public HorseDawn(string n, string t, int ms, int h, int w, string pt, int c)
        {
            Name = n;
            Type = t;
            maxSpeed = ms;
            height = h;
            width = w;
            petrolType = pt;
            Capacity = c;
        }
        public void Move()
        {
            Console.Write("HorseDawn move");
            Console.WriteLine();
        }
        public void FollowTransportSigns()
        {
            Console.WriteLine("HorseDawn is following transport signs");
            Console.WriteLine();
        }
        public void StopAtTrafficLight()
        {
            Console.WriteLine("HorseDawn stopped at traffic light");
            Console.WriteLine();
        }

    }
    class Tanker : IWater
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int maxSpeed { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public string petrolType { get; set; }
        public int Capacity { get; set; }

        public Tanker() { }
        public Tanker(string n, string t, int ms, int h, int w, string pt, int c)
        {
            Name = n;
            Type = t;
            maxSpeed = ms;
            height = h;
            width = w;
            petrolType = pt;
            Capacity = c;
        }
        public void Move()
        {
            Console.Write("Tanker move");
            Console.WriteLine();
        }
        public void Anchor()
        {
            Console.Write("Tanker put down the anchor");
            Console.WriteLine();
        }
       public void Moor()
        {
            Console.Write("Tanker moored");
            Console.WriteLine();
        }
        public void NavigateToPort()
        {
            Console.Write("Tanker is going to port");
            Console.WriteLine();
        }
    }
    class Boat : IWater
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int maxSpeed { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public string petrolType { get; set; }
        public int Capacity { get; set; }

        public Boat() { }
        public Boat(string n, string t, int ms, int h, int w, string pt, int c)
        {
            Name = n;
            Type = t;
            maxSpeed = ms;
            height = h;
            width = w;
            petrolType = pt;
            Capacity = c;
        }
        public void Move()
        {
            Console.Write("Boat move");
            Console.WriteLine();
        }
        public void Anchor()
        {
            Console.Write("Boat put down the anchor");
            Console.WriteLine();
        }
        public void Moor()
        {
            Console.Write("Boat moored");
            Console.WriteLine();
        }
        public void NavigateToPort()
        {
            Console.Write("Boat is going to port");
            Console.WriteLine();
        }
    }
    class Ship : IWater
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int maxSpeed { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public string petrolType { get; set; }
        public int Capacity { get; set; }

        public Ship() { }
        public Ship(string n, string t, int ms, int h, int w, string pt, int c)
        {
            Name = n;
            Type = t;
            maxSpeed = ms;
            height = h;
            width = w;
            petrolType = pt;
            Capacity = c;
        }
        public void Move()
        {
            Console.Write("Ship move");
            Console.WriteLine();
        }
        public void Anchor()
        {
            Console.Write("Ship put down the anchor");
            Console.WriteLine();
        }
        public void Moor()
        {
            Console.Write("Ship moored");
            Console.WriteLine();
        }
        public void NavigateToPort()
        {
            Console.Write("Ship is going to port");
            Console.WriteLine();
        }
    }
    class Plane : IAir
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int maxSpeed { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public string petrolType { get; set; }
        public int Capacity { get; set; }

        public Plane() { }
        public Plane(string n, string t, int ms, int h, int w, string pt, int c)
        {
            Name = n;
            Type = t;
            maxSpeed = ms;
            height = h;
            width = w;
            petrolType = pt;
            Capacity = c;
        }
        public void Move()
        {
            Console.Write("Plane move");
            Console.WriteLine();
        }
       public void TakeOff()
        {
            Console.Write("Plane took off");
            Console.WriteLine();
        }
        public void Land()
        {
            Console.Write("Plane landed");
            Console.WriteLine();
        }
        public void NavigateToAirport()
        {
            Console.Write("Plane is going to the airport");
            Console.WriteLine();
        }
    }
    class Helicopter : IAir
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int maxSpeed { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public string petrolType { get; set; }
        public int Capacity { get; set; }

        public Helicopter() { }
        public Helicopter(string n, string t, int ms, int h, int w, string pt, int c)
        {
            Name = n;
            Type = t;
            maxSpeed = ms;
            height = h;
            width = w;
            petrolType = pt;
            Capacity = c;
        }
        public void Move()
        {
            Console.Write("Helicopter move");
            Console.WriteLine();
        }
        public void TakeOff()
        {
            Console.Write("Helicopter took off");
            Console.WriteLine();
        }
        public void Land()
        {
            Console.Write("Helicopter landed");
            Console.WriteLine();
        }
        public void NavigateToAirport()
        {
            Console.Write("Helicopter is going to the airport");
            Console.WriteLine();
        }
    }
    class Airship : IAir
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int maxSpeed { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public string petrolType { get; set; }
        public int Capacity { get; set; }

        public Airship() { }
        public Airship(string n, string t, int ms, int h, int w, string pt, int c)
        {
            Name = n;
            Type = t;
            maxSpeed = ms;
            height = h;
            width = w;
            petrolType = pt;
            Capacity = c;
        }
        public void Move()
        {
            Console.Write("Airship move");
            Console.WriteLine();
        }
        public void TakeOff()
        {
            Console.Write("Airship took off");
            Console.WriteLine();
        }
        public void Land()
        {
            Console.Write("Airship landed");
            Console.WriteLine();
        }
        public void NavigateToAirport()
        {
            Console.Write("Airship is going to the airport");
            Console.WriteLine();
        }
    }
   
}
