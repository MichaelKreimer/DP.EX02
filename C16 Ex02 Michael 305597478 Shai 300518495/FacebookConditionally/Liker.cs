using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace C16_Ex01_Michael_305597478_Shai_300518495
{
    public abstract class Liker : IFacebookAction
    {
        public Post HandledPost { get; set; }

        public Liker(bool isUnlike, Post handledPost)
        {
            this.IsUnlike = isUnlike;
            this.HandledPost = handledPost;
        }

        public bool IsUnlike { get; set; }
        
        public void InvokeAction()
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

        public abstract bool IsConditionSatisfied();
    }
}
