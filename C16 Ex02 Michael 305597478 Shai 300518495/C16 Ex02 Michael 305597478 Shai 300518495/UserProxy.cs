using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C16_Ex02_Michael_305597478_Shai_300518495
{
    public class UserProxy
    {
        public User User { get; set; }
        public FacebookObjectCollection<Post> Posts { get { return User.Posts; } }

        public string PictureNormalURL { get { return User.PictureNormalURL; } }

        public string Name { get { return User.Name; } }
        public bool IsUserLogged()
        {
            return User != null;
        }
        public void PostStatus(string i_TextToPost)
        {
            if (i_TextToPost != string.Empty)
            {
                User.PostStatus(i_TextToPost);
            }
        }
    }
}
