using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface
{
    public interface IGeometry
    {
        string GetArea();
        string GetPerimeter();
    }
    public interface ITringular : IGeometry
    {
        string GetTriangleType(); 
    }
    public interface IRectangular : IGeometry
    {
        int GetEdgeNumbers();
    }
    public interface IBirth
    {
        string GetBirthDate();
    }
    public interface IWalk
    {
        string GetWalkSpeed();
    }

    public interface ITalk
    {
        string GetLanguage();
    }
    public interface IFly
    {
        string GetFlySpeed();
    }
    public interface IDeath
    {
        string GetLeftTime();
    }



}
