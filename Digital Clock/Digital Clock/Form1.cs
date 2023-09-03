using System.Timers;

namespace Digital_Clock

{
    public partial class DigitalClock : Form
    {
        public DigitalClock()
        {
            InitializeComponent();

            // timer.Start();

            System.Timers.Timer myTimer = new System.Timers.Timer(1000);
            myTimer.Elapsed += TimerElapsed;
            myTimer.Start();
        }

        //with timer tool
        /*
        private void timer_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToLongTimeString();
            labelYM.Text = DateTime.Now.ToString("yyyy MMM");
            labelDate.Text = DateTime.Now.ToString("dd");
            labelDay.Text = DateTime.Now.ToString("ddd");
        }
        */

        //without timer tool hardcoded

        private void TimerElapsed(object? sender, ElapsedEventArgs e)
        {
            string time = DateTime.Now.ToLongTimeString();
            string ym = DateTime.Now.ToString("yyyy MMM");
            string date = DateTime.Now.ToString("dd");
            string day = DateTime.Now.ToString("ddd");

            this.Invoke((MethodInvoker)delegate { labelTime.Text = time; });   //other method is to use the timer from toolbox too
            this.Invoke((MethodInvoker)delegate { labelYM.Text = ym; });
            this.Invoke((MethodInvoker)delegate { labelDate.Text = date; });
            this.Invoke((MethodInvoker)delegate { labelDay.Text = day; });
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