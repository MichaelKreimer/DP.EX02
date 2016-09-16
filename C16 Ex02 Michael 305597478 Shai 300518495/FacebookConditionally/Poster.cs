using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace C16_Ex01_Michael_305597478_Shai_300518495
{
    public class Poster : IFacebookAction
    {
        private const int k_LengthOfString = 25;
        private User m_User;
        private Schedulable m_Schedule;
        private string m_TextToPost;

        public Poster(User user, DateTime chosenDateTime, string textToPost)
        {
            m_User = user;
            m_Schedule = new Schedulable(chosenDateTime);
            m_TextToPost = textToPost;
        }

        public void InvokeAction()
        {
            m_User.PostStatus(m_TextToPost);
        }

        public bool IsConditionSatisfied()
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
    }
}
