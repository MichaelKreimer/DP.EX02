using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using C16_Ex02_Michael_305597478_Shai_300518495;

namespace C16_Ex02_Michael_305597478_Shai_300518495
{
    public class CommenterByNums : Commenter
    {
        private int m_NumOfRequiredLikes;
        private int m_NumOfRequiredComments;
        private bool m_IsAndOperation;

        public CommenterByNums(string i_CommentText, Post i_HandledPost, int i_NumOfRequiredLikes, int i_NumOfRequiredComments, bool i_IsAndOperation) : base(i_CommentText, i_HandledPost)
        {
            m_NumOfRequiredLikes = i_NumOfRequiredLikes;
            m_NumOfRequiredComments = i_NumOfRequiredComments;
            m_IsAndOperation = i_IsAndOperation;
        }

        protected override bool IsConditionSatisfied()
        {
            return Services.IsEnoughLikesComments(this.HandledPost, m_NumOfRequiredLikes, m_NumOfRequiredComments, m_IsAndOperation);
        }

        public override string ToString()
        {
            PostWrapper handledPostWrapper = new PostWrapper(HandledPost);
            return string.Format("Comment at {0} Likes {1} {2} Comments : {3}", m_NumOfRequiredLikes, m_IsAndOperation ? "AND" : "OR", m_NumOfRequiredComments, handledPostWrapper);
        }
    }
}
