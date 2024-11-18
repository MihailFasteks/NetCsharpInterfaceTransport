// See https://aka.ms/new-console-template for more information
using NetCsharpInterfaceTransport;
using System.Drawing;


Car car1 = new Car("Hyundai", "H1", 220, 2, 2, "diesel", 8);
RailWay train1 = new RailWay("Odesa-Kyiv", "1111", 90, 4, 4, "coal", 60);
HorseDawn horse1 = new HorseDawn("Zorka", "horse", 60, 2, 1, "carrot", 1);

Plane plane1 = new Plane("Boing", "737", 840, 8, 5, "A-100", 189);
 Helicopter helic1 = new Helicopter("UH-1", "Iroquois", 201, 4, 5, "A-100", 16);
Airship ash1 = new Airship("USS", "ZS-3", 120, 60, 60, "Azot", 60);

Tanker tanker1=new Tanker("T1", "tank1234", 70, 60, 60, "A-100", 60);
Ship ship1 = new Ship("SH1", "ship1234", 90, 60, 60, "A-100", 200);
Boat boat1 = new Boat("B1", "boat1234", 50, 7, 5, "A-100", 12);

Client3(car1);
Client3(train1);
Client3(horse1);
Client3(plane1);
Client3(helic1);
Client3(ash1);
Client3(tanker1);
Client3(ship1);
Client3(boat1);








static void Client3(ITransport itansport)
{
    itansport.Move();

    /*
     Pattern matching выполняет сопоставление с некоторым шаблоном (образцом). 
     Выполняется сопоставление с типом IFigureAngle, который выступает в качестве шаблона. 
     Если сопоставление прошло успешно, то в переменной iFigureAngle будет ссылка на объект.
    */
    if (itansport is IGround iground)
    {
        iground.FollowTransportSigns();
        iground.StopAtTrafficLight();
    }

    /*
    Pattern matching выполняет сопоставление с некоторым шаблоном (образцом). 
    Выполняется сопоставление с типом Rectangle, который выступает в качестве шаблона. 
    Если сопоставление прошло успешно, то в переменной rectangle будет ссылка на объект.
    */
    if (itansport is IWater iwater)
    {
        iwater.Anchor();
        iwater.Moor();
        iwater.NavigateToPort();
    }

    /*
     Pattern matching выполняет сопоставление с некоторым шаблоном (образцом). 
     Выполняется сопоставление с типом IFigureRound, который выступает в качестве шаблона. 
     Если сопоставление прошло успешно, то в переменной iFigureRound будет ссылка на объект.
    */
    if (itansport is IAir iair)
    {
        iair.TakeOff();
        iair.Land();
        iair.NavigateToAirport();
    }

    if (itansport is Car car)
    {
        car.MoveOnRoad();
        car.Park();
       
    }
}
