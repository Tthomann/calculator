using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator
{
    public interface IOperations
    {
        double addition();
        double subtraction();
        double multiplication();
        double division();
        double exponential();

    }
}
