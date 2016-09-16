using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using C16_Ex01_Michael_305597478_Shai_300518495;

namespace C16_Ex01_Michael_305597478_Shai_300518495
{
    public class CommenterByNums : Commenter
    {
        private int m_NumOfRequiredLikes;
        private int m_NumOfRequiredComments;
        private bool m_IsAndOperation;

        public CommenterByNums(string commentText, Post handledPost, int numOfRequiredLikes, int numOfRequiredComments, bool isAndOperation) : base(commentText, handledPost)
        {
            m_NumOfRequiredLikes = numOfRequiredLikes;
            m_NumOfRequiredComments = numOfRequiredComments;
            m_IsAndOperation = isAndOperation;
        }

        public override bool IsConditionSatisfied()
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
