using System.ComponentModel.Design;
using System.Timers;

namespace Digital_Clock



{
    public partial class DigitalClock : Form
    {
        public DigitalClock()
        {
            InitializeComponent();

           

            System.Timers.Timer myTimer = new System.Timers.Timer(1000);
            myTimer.Elapsed += TimerElapsed;
            myTimer.Start();

           


        }

       

        private void TimerElapsed(object? sender, ElapsedEventArgs e)
        {
            string time = DateTime.Now.ToLongTimeString();

            this.Invoke((MethodInvoker)delegate { labelTime.Text = time; });   //other method is to use the timer from toolbox too
            

        }

       
    }
}

/* Just use of code not design forms/ without adding timer from mydesign  WPF app 
 * public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;




            Timer myTimer = new Timer(1000);
            myTimer.Elapsed += TimerElapsed;
            myTimer.Start();
           



        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            string date = DateTime.Now.ToLongTimeString();
            labelT.Content = date;
        }

        private void TimerElapsed(object? sender, ElapsedEventArgs e)
        {
            string date = DateTime.Now.ToLongTimeString();
            Dispatcher.Invoke(new Action(()=>  labelT.Content = date ));
        }

        
    }
*/