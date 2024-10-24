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

namespace ToDo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ToDoList myToDoList;

        public MainWindow()
        {
            InitializeComponent();
            myToDoList = new ToDoList();
            DataContext = myToDoList;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void Button_Click_AddRemove(object sender, RoutedEventArgs e)
        {
            if (MyTextBox.Text == string.Empty)
            {
                myToDoList.AccessToDo(myToDoList.SelectedItem);
            }
            else
            {
                myToDoList.AccessToDo(MyTextBox.Text);
                MyTextBox.Clear();
            }
        }

        private void Button_Click_Complete(object sender, RoutedEventArgs e)
        {
            
            if (myToDoList.SelectedItem != null)
            {
                myToDoList.CompletedTask(myToDoList.SelectedItem);
            }
            
        }
    }
}
