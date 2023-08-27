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

namespace To_DoLists
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Set focus to the text field when the window is loaded.
            TextInput.Focus();
        }
        private int taskCount = 1;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string taskText = TextInput.Text.Trim();
            
            

           
                if (!string.IsNullOrEmpty(taskText))
                {
                    string numberdTask = $"{taskCount}. {taskText}"; //Bullet or Number Prepare gareko
                    TaskListBox.Items.Add(numberdTask);
                    TextInput.Clear();
                    TextInput.Focus();
                taskCount++;
                }
                else
                {
                    string warn = "Please Enter A Task.";
                    WarningAddT.ToolTip = warn;
                   WarningAddT.Visibility = Visibility.Visible;
                    TextInput.Focus() ;
                

                }        
           
        }

        private void removeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (TaskListBox.SelectedItem != null)
            {
                TaskListBox.Items.Remove(TaskListBox.SelectedItem);
            }
            else
            {
                string warn = "No Task Selected.";
                WarningRemoveT.ToolTip = warn;
                //WarningRemoveT.Visibility = Visibility.Visible;

            }
        }
    }
}
