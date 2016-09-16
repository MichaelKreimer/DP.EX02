using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace C16_Ex01_Michael_305597478_Shai_300518495
{
    public abstract class Commenter : IFacebookAction
    {
        public string CommentText { get; set; }

        public Post HandledPost { get; set; }

        public Commenter(string commentText, Post handledPost)
        {
            this.CommentText = commentText;
            this.HandledPost = handledPost;
        }

        public void InvokeAction()
        {
            this.HandledPost.Comment(CommentText);
        }

        public abstract bool IsConditionSatisfied();
    }
}
