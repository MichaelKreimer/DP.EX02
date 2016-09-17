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
        private readonly object m_lockTimer = new object();
        private DateTime m_EndTime;
        //private Color m_CurrentColor {get { return this.BackColor; } set { this.BackColor = value; }
        public ListBoxProxy()
        {
            InitializeComponent();
        }

        public override void ResetBackColor()
        {
                createTimeInterval(100);
                this.BackColor = Color.DarkCyan;
        }
        private void createTimeInterval(int i_MiliSecsToWait)
        {
            lock (m_lockTimer)
            {
                m_Timer = new Timer();
                m_EndTime = DateTime.Now.AddSeconds(3);
                m_Timer.Interval = i_MiliSecsToWait;
                m_Timer.Tick += OnTimedEvent;
                m_Timer.Start();
            }
        }
        private void switchColor()
        {
            if (this.BackColor == Color.DarkCyan)
            {
                this.BackColor = Color.LightBlue;
            }
            else
            {
                this.BackColor = Color.DarkCyan;
            }
        }
        private void OnTimedEvent(Object source, EventArgs e)
        {
            lock (m_lockTimer)
            {
                switchColor();
                if (DateTime.Now >= m_EndTime)
                {
                    m_Timer.Stop();
                    base.ResetBackColor();
                    //this.BackColor = Color.White;
                }
            }


        }
    }
}
