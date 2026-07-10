using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4
{
    internal class Red : Signal_Tower
    {
        public bool Isturn { get; set; }

        public Red(bool power, bool isturn) : base(power)
        {
            Isturn = isturn;
        }

        public string TurnON_OFF()
        {
            if (Isturn)
            {
                return "불이 들어와 있습니다";
            }
            else
            {
                return "불이 안들어와 있습니다";
            }
        }
    }
}
