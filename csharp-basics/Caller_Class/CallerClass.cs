using csharp_basics.Console_Methods_Props;
using csharp_basics.Data_Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_basics.Caller_Class
{
    class CallerClass
    {

        public void CallDataTypes()
        {
            DataTypes dt = new DataTypes();
            //dt.ByteDTDemo();
            //dt.CharDTDemo();
            //dt.StringDTDemo();
            //dt.NumericDTWithoutDecimal();
            //dt.NumericDTWithDecimal();
            //dt.DataTypePerformance();
            //dt.SizeOfPredefinedST();
            dt.DefaultValuesOfBuildInDT();
            //dt.PointersDT();
        }

        public void CallConsoleMethodsProperties() {


            //PropertiesOfConsole pc = new PropertiesOfConsole()
            //pc.SetConsoleProperties();

            ConsoleMethods cm = new ConsoleMethods();
            //cm.CheckOutConsoleMethods();
            cm.ReadLineBufferErrorDemo();
        }
            

    }
}
