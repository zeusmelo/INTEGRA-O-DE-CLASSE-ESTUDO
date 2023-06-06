using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEC_GUANABARA
{
    internal interface ILutador
    {
      void  Apresentar();
        void Status();
        void GanharLuta();
        void PerderLuta();
        void EmpatarLuta();

    }
}
