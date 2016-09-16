using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace C16_Ex01_Michael_305597478_Shai_300518495
{
    public class LikerByNums : Liker
    {
        private int m_NumOfRequiredLikes;
        private int m_NumOfRequiredComments;
        private bool m_IsAndOperation;

        public LikerByNums(bool isUnlike, Post handledPost, int numOfRequiredLikes, int numOfRequiredComments, bool isAndOperation) : base(isUnlike, handledPost)
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
            return string.Format("{0} at {1} Likes {2} {3} Comments : {4}", IsUnlike ? "Unlike" : "Like", m_NumOfRequiredLikes, m_IsAndOperation ? "AND" : "OR", m_NumOfRequiredComments, handledPostWrapper);
        }
    }
}
