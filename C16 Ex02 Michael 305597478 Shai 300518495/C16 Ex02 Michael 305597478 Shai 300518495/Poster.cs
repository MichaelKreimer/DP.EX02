using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C16_Ex02_Michael_305597478_Shai_300518495
{
    public class Poster : Task, ITextUpdateable
    {
        private const int k_LengthOfString = 25;
        private User m_User;
        private Schedulable m_Schedule;
        private string m_TextToPost;

        public Poster(User i_User, DateTime i_ChosenDateTime, string i_TextToPost)
        {
            m_User = i_User;
            m_Schedule = new Schedulable(i_ChosenDateTime);
            m_TextToPost = i_TextToPost;
        }

        protected override void InvokeAction()
        {
            m_User.PostStatus(m_TextToPost);
        }

        protected override bool IsConditionSatisfied()
        {
            return m_Schedule.isTimeArrived();
        }

        public override string ToString()
        {
            return string.Format("Post at {0}: {1}", m_Schedule.DesiredDateTime, m_TextToPost.Substring(0, finalLength()));
        }

        private int finalLength()
        {
            return m_TextToPost.Length > k_LengthOfString ? k_LengthOfString : m_TextToPost.Length;
        }

        public override string GetTextOfTask()
        {
            return m_TextToPost;
        }

        public void UpdateTextOfTask(string text)
        {
            this.m_TextToPost = text;
        }
    }
}
