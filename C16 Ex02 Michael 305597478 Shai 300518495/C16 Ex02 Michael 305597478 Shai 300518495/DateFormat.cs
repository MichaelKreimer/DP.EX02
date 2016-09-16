using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C16_Ex02_Michael_305597478_Shai_300518495
{
    public class DateFormat
    {
        public eDate eDate { get; set; }

        public DateFormat(eDate i_eDate)
        {
            this.eDate = i_eDate;
        }

        public override string ToString()
        {
            if (eDate.Equals(eDate.AllTime))
            {
                return "All Time";
            }
            else
            {
                return string.Format("Last {0}", eDate.ToString());
            }
        }
    }

    public enum eDate
    {
        Day = 1,
        Week = 7,
        Year = 365,
        AllTime,
    }
}
