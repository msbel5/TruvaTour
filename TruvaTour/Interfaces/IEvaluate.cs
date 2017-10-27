using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruvaTour.Interfaces
{
    public interface IEvaluate
    {
        void Evaluate(int TourID, int Vote, string Comment);
        void Evaluate(int TourID, int Vote);
    }
}
