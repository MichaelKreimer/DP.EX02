using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace C16_Ex02_Michael_305597478_Shai_300518495
{
    public class UserProxy : FacebookWrapper.ObjectModel.User
    {
        //public User() : base()
        //{
        //}
        public void PostStatus(string i_TextToPost)
        {
            if (i_TextToPost != string.Empty)
            {
                base.PostStatus(i_TextToPost);
            }
        }
        //public void ClearPosts()
        //{
        //    Posts.Clear();
        //}

    }
}
