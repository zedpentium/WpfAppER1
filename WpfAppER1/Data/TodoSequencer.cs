using System;
using System.Collections.Generic;
using System.Text;

namespace WpfAppER1.Data
{
    public class TodoSequencer
    {

        private static int _todoid; // i have underscore on theese private fields, to differentiante them visually


        public static int NextToDoId()
            {

            _todoid = ++_todoid;

            return _todoid;
            }



        public static void ToDoReset()
        {
            TodoItems.Clear();
            _todoid = 0;
        }



    }
}
