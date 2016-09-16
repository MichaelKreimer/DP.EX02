using System;
using System.Collections.Generic;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace C16_Ex01_Michael_305597478_Shai_300518495
{
    public class Schedulable
    {
        public DateTime DesiredDateTime { get; set; }

        public Schedulable(DateTime dateTime)
        {
            DesiredDateTime = dateTime;
        }

        public bool isTimeArrived()
        {
            if (DateTime.Now >= this.DesiredDateTime)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
