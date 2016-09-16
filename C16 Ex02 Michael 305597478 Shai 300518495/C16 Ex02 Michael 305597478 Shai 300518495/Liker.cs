using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace C16_Ex02_Michael_305597478_Shai_300518495
{
    public abstract class Liker : Task
    {
        public Post HandledPost { get; set; }

        public Liker(bool i_IsUnlike, Post i_HandledPost)
        {
            this.IsUnlike = i_IsUnlike;
            this.HandledPost = i_HandledPost;
        }

        public bool IsUnlike { get; set; }
        
        protected override void InvokeAction()
        {
            if (this.IsUnlike == false)
            {
                this.HandledPost.Like();
            }
            else
            {
                this.HandledPost.Unlike();
            }
        }
    }
}
