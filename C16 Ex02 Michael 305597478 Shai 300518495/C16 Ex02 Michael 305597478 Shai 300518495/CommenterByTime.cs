using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace C16_Ex02_Michael_305597478_Shai_300518495
{
    public class CommenterByTime : Commenter
    {
        private Schedulable m_Schedule;

        public CommenterByTime(string i_CommentText, Post i_HandledPost, DateTime i_ChosenDateTime) : base(i_CommentText, i_HandledPost)
        {
            m_Schedule = new Schedulable(i_ChosenDateTime);
        }

        protected override bool IsConditionSatisfied()
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
