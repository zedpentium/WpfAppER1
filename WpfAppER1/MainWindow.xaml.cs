using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfAppER1.Model;
using WpfAppER1.Data;

namespace WpfAppER1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Startup.StartUpAtLoad();

            ReadInFromArrayToList();

        }

        public void ReadInFromArrayToList()
        {
            People peopleObjRef = new People();
            this.personListBox.DataContext = peopleObjRef.FindAll();
            this.contentPeopleInfo.DataContext = peopleObjRef.FindAll();

            TodoItems toDoItemsOjbRef = new TodoItems();
            this.toDoListBox.DataContext = toDoItemsOjbRef.FindAllToDoItems();
            this.todoTaskListInfo.DataContext = toDoItemsOjbRef.FindAllToDoItems();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }



        private void btnAddName_Click(object sender, RoutedEventArgs e)
        {
            /*if (!string.IsNullOrWhiteSpace(txtNameBox.Text) && !personListBox.Items.Contains(txtNameBox.Text))
                personListBox.Items.Add(txtNameBox.Text);*/
        }

        private void btnAddPersonTask_Click(object sender, RoutedEventArgs e)
        {
            if (personListBox.SelectedItem != null)
                {
                TodoItems addPersonOjbRef = new TodoItems();
                People peopleObjRef = new People();

                int getPersonID = ((Person)personListBox.SelectedItem).PersonId;
                Person thePersonObj = peopleObjRef.FindById(getPersonID);

                int getToDoId = ((ToDo)toDoListBox.SelectedItem).ToDoId;

                addPersonOjbRef.AddTodoItemToPerson(getToDoId, thePersonObj);

                //addPersonOjbRef todoTaskListInfo.InvalidateArrange;
                //MainWindow mainWin = new MainWindow();
                //mainWin.todoTaskListInfo.UpdateLayout();
            }

            //ReadInFromArrayToList();


        }
    }

}