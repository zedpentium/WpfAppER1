using System;
using System.Collections.Generic;
using System.Text;
using WpfAppER1.Model;

namespace WpfAppER1.Data
{
    public class People
    {

        private static Person[] _arrOfPersonObjects = new Person[0]; // i have underscore on this private object array, to differentiante them visually


        public int Size()
        {
            return _arrOfPersonObjects.Length;
        }

        public Person[] FindAll()
        {

            /*Person[] allPersonsFromPeepsArray = new Person[0];
            Array.Resize(ref allPersonsFromPeepsArray, Size());

            for (int i = 0; i < Size(); i++)
            {
                allPersonsFromPeepsArray[i] = arrOfPersonObjects[i];
            }
            */
            //return allPersonsFromPeepsArray;
            // My first code above, commented out. Coz i realized i can just return the actual arrOfPersonObject instead
            // and did all the above code for nothing.

            return _arrOfPersonObjects;
        }


        public Person FindById(int personId)
        { 
            Person foundObjectIndex = Array.Find(_arrOfPersonObjects, idNr => idNr.PersonId == personId);

            return foundObjectIndex;
        }

        /* string item = "Eric";
        public void TestFindID()
        {
            int index = Array.FindIndex(arrOfPersonObjects, 0, Size(), Person.Equals(Person.personID);
            if (index != -1)
            {
                Console.WriteLine(String.Format("Element {0} is found at index {1}", item, index));
            }
            else
            {
                Console.WriteLine("Element not found in the given array.");
            }
        }*/

        public Person CreateNewPersonToArray(string firstName, string lastName)
        {
            Person newPersonInfo = new Person(firstName, lastName, PersonSequencer.NextPersonId());

            Array.Resize(ref _arrOfPersonObjects, 1 + Size()); // adding 1 more element to array to make room for the newPersonInfo object

            _arrOfPersonObjects[Size() - 1] = newPersonInfo;

            return newPersonInfo;

        }


        public void Clear()
        {
            Array.Resize(ref _arrOfPersonObjects, 0);
            PersonSequencer.Reset();
        }


        public Person[] RemoveOneToDoItemRebuildArray(Person removeThisPerson)
        {

            Person[] beforeCopyArray = new Person[_arrOfPersonObjects.Length];

            int toDoItemIndexRemove = Array.FindIndex(_arrOfPersonObjects, idNr => idNr == removeThisPerson);

            _arrOfPersonObjects.CopyTo(beforeCopyArray, 0);

            _arrOfPersonObjects[toDoItemIndexRemove] = null;

            _arrOfPersonObjects = Array.FindAll(_arrOfPersonObjects, idNr => idNr != null);

            return beforeCopyArray; // this is returning a separate Array BEFORE 1 object was removed in _arrOfTodoObjects
                                    // to compare this BEFORE, with AFTER removal in x Unit test.

        }



    }
}
