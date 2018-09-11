using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen2Training
{
    public partial class Globals
    {
       public string plcipaddressglobal { get; set; }
       public class MotorParameters
        {
            public string ParameterNumber { get; set; }
            public string ParameterName { get; set; }
            public string Unit { get; set; }
            public string plcaddress { get; set; }
        }


        public Dictionary<int, MotorParameters> ParamDict()
        {
            Dictionary<int, MotorParameters> nameplate = new Dictionary<int, MotorParameters>()
            {
                {1, new MotorParameters{ParameterNumber="99.06", ParameterName="Motor Nominal Current", Unit="Amps", plcaddress="np_nomcurrent"} },
                {2, new MotorParameters{ParameterNumber="99.07", ParameterName="Motor Nominal Voltage", Unit="Volts", plcaddress="np_nomvolt"} },
                {3, new MotorParameters{ParameterNumber="99.08", ParameterName="Motor Nominal Frequency", Unit="Hz", plcaddress="np_freq"} },
                {4, new MotorParameters{ParameterNumber="99.09", ParameterName="Motor Nominal Speed", Unit="RPM", plcaddress="np_rpm" } },
                {5, new MotorParameters{ParameterNumber="99.10", ParameterName="Motor Nominal Power", Unit="kW", plcaddress="np_kw" } },
                {6, new MotorParameters{ParameterNumber="99.11", ParameterName="Motor Nominal Power Factor", Unit="", plcaddress="np_cos" } }
            };

            return nameplate;
           
        }

       
     


        //public void nameplate()
        //{
        //    var nameplateparams = new List<string> {"Motor Nominal Current", "Motor Nominal Voltage", "Motor Nominal Frequency", "Motor Nominal Speed", "Motor Nominal Power", "Motor Nominal Cos" };

        //}






    }
}
