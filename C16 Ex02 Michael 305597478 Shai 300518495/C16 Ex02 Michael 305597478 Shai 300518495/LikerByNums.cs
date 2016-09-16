using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C16_Ex02_Michael_305597478_Shai_300518495
{
    public class LikerByNums : Liker
    {
        private int m_NumOfRequiredLikes;
        private int m_NumOfRequiredComments;
        private bool m_IsAndOperation;

        public LikerByNums(bool i_IsUnlike, Post i_HandledPost, int i_NumOfRequiredLikes, int i_NumOfRequiredComments, bool i_isAndOperation) : base(i_IsUnlike, i_HandledPost)
        {
            m_NumOfRequiredLikes = i_NumOfRequiredLikes;
            m_NumOfRequiredComments = i_NumOfRequiredComments;
            m_IsAndOperation = i_isAndOperation;
        }

        protected override bool IsConditionSatisfied()
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
