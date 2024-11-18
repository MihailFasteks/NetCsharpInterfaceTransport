// See https://aka.ms/new-console-template for more information
using NetCsharpInterfaceTransport;
using System.Drawing;

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
