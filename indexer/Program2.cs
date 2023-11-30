using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexer
{
    internal class Program2
    {

        // declare an array to store element
        private string[] studntName = new string[10];

        // define an indexer 

        public string this[int index]
        {

            get
            {
                //return value of stored at studentName array
                return studntName[index];

            }
            set
            {
                //assigns value to studentName
                studntName[index] = value;
            }
        }






       
    }
}
