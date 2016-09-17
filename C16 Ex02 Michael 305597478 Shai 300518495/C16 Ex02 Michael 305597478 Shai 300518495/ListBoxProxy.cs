using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C16_Ex02_Michael_305597478_Shai_300518495
{
    public partial class ListBoxProxy : ListBox
    {
        private Timer m_Timer;
        public ListBoxProxy()
        {
            //this.BackColor = Color.Cyan; 
            InitializeComponent();
        }

        public override void ResetBackColor()
        {
            for (int i = 0; i < 20; i++)
            {
                this.BackColor = Color.Aqua;
                createTimeInterval(300);
                this.BackColor = Color.DarkCyan;
            } 
            this.BackColor = Color.Green;
        }
        public void createTimeInterval(int i_MiliSecsToWait)
        {
            Timer timer = new Timer();
            timer.Interval = i_MiliSecsToWait;
            timer.Start();


        }
        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            //  Console.WriteLine("The Elapsed event was raised at {0}", e.SignalTime);
            m_Timer.Stop();
        }
    }
}
