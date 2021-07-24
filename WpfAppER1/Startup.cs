using System;
using WpfAppER1.Model;
using WpfAppER1.Data;
using System.Windows.Controls;

namespace WpfAppER1
{
    class Startup
    {


        public static void StartUpAtLoad()
        {

            // People --------------------------
            string firstNameA = "Eric";
            string lastNameA = "Rönnhult";
            string firstNameB = "Tomas";
            string lastNameB = "Nilsson";
            string firstNameC = "Mattias";
            string lastNameC = "Bertilsson";
            string firstNameD = "Bernt";
            string lastNameD = "Jonsson";

            People testArrayPeople = new People();

            Person personA = testArrayPeople.CreateNewPersonToArray(firstNameA, lastNameA);
            Person personB = testArrayPeople.CreateNewPersonToArray(firstNameB, lastNameB);
            Person personC = testArrayPeople.CreateNewPersonToArray(firstNameC, lastNameC);
            Person personD = testArrayPeople.CreateNewPersonToArray(firstNameD, lastNameD);


            // ToDoItems ------------------------
            string descriptionA = "Städa garaget";
            string descriptionB = "Diska";
            string descriptionC = "Köpa mjölk";
            string descriptionD = "Boka vaccinstid";

            TodoItems testToDo = new TodoItems();

            TodoItems.Clear();

            ToDo iToDoItemA = testToDo.CreateNewTodoToArray(descriptionA);
            ToDo iToDoItemB = testToDo.CreateNewTodoToArray(descriptionB);
            ToDo iToDoItemC = testToDo.CreateNewTodoToArray(descriptionC);
            ToDo iToDoItemD = testToDo.CreateNewTodoToArray(descriptionD);

        }




    }
}
