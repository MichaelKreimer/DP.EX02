using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace C16_Ex02_Michael_305597478_Shai_300518495
{
    public abstract class Commenter : Action
    {
        public string CommentText { get; set; }

        public Post HandledPost { get; set; }

        public Commenter(string i_CommentText, Post i_HandledPost)
        {
            this.CommentText = i_CommentText;
            this.HandledPost = i_HandledPost;
        }
        protected override void InvokeAction()
        {
            this.HandledPost.Comment(CommentText);
        }

        //protected override abstract bool IsConditionSatisfied();
    }
}
