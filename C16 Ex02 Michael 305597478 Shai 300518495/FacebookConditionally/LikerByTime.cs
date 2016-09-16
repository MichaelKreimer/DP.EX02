using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace C16_Ex01_Michael_305597478_Shai_300518495
{
    public class LikerByTime : Liker
    {
        private Schedulable m_Schedule;

        public LikerByTime(bool isUnlike, Post handledPost, DateTime chosenDateTime) : base(isUnlike, handledPost)
        {
            m_Schedule = new Schedulable(chosenDateTime);
        }

        public override bool IsConditionSatisfied()
        {
            return m_Schedule.isTimeArrived();
        }

        public override string ToString()
        {
            PostWrapper handledPostWrapper = new PostWrapper(HandledPost);
            return string.Format("{0} at {1} : {2}", IsUnlike ? "Unlike" : "Like", m_Schedule.DesiredDateTime, handledPostWrapper);
        }
    }
}
