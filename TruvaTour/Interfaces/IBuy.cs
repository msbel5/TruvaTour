using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruvaTour.Interfaces
{
    public interface IBuy
    {
        string Buy(int tourID, int quantity);
    }
}
