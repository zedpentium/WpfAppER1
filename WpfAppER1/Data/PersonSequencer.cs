using System;
using System.Collections.Generic;
using System.Text;

namespace WpfAppER1.Data
{
    public class PersonSequencer
    {

        private static int _personId; // i have underscore on theese private fields, to differentiante them visually


        public static int NextPersonId()
            {

            _personId = _personId + 1;

            return _personId;
            }



        public static void Reset()
        {
            _personId = 0;
        }



    }
}
