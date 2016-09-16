using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace C16_Ex01_Michael_305597478_Shai_300518495
{
    public class CommenterByTime : Commenter
    {
        private Schedulable m_Schedule;

        public CommenterByTime(string commentText, Post handledPost, DateTime chosenDateTime) : base(commentText, handledPost)
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
            return string.Format("Comment at {0} : {1}", m_Schedule.DesiredDateTime, handledPostWrapper);
        }
    }
}
