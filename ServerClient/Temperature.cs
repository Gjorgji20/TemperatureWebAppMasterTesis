using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerClient
{

    public class Temperature
    {
        public int Celsius { get; set; }
        public int Fahrenheit { get; set; }
        public DateTime DataSend { get; set; }
    }

}
