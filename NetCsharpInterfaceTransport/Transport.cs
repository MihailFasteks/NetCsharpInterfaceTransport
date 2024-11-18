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
        void Park();
        void MoveOnRoad();
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

    }
    class RailWay : IGround
    {

    }
    class HorseDawn: IGround
    {

    }
    class Tanker : IWater
    {

    }
    class Boat : IWater
    {

    }
    class Ship : IWater
    {

    }
    class Plain : IAir
    {

    }
    class Helicopter : IAir
    {

    }
    class Airship : IAir
    {

    }
   
}
