using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface
{
    internal class Interfaces
    {
    }
    public interface IBirth
    {
        string Birth();
        string GetBirthDate();
    }
    public interface IWalk
    {
        string GetWalkSpeed();
    }

    public interface ITalk:IBirth
    {
        string GetLanguage();
    }

}
