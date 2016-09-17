using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C16_Ex02_Michael_305597478_Shai_300518495
{
    abstract class PostScoreCalculator
    {
        //public static PostScoreCalculator CreatePostScoreCalculator(BestPostFinder.eScoreCalculationStyle i_ScoreCalculationStyle)
        //{
        //    if (i_ScoreCalculationStyle.Equals(BestPostFinder.eScoreCalculationStyle.Comments))
        //    {
        //        return new PostScoreCalculatorByComments.Create();
        //    }
        //    else if (i_ScoreCalculationStyle.Equals(BestPostFinder.eScoreCalculationStyle.Formula))
        //    {
        //        return new PostScoreCalculatorByFormula();
        //    }
        //    else // (i_ScoreCalculationStyle.Equals(BestPostFinder.eScoreCalculationStyle.Likes)
        //    {
        //        return new PostScoreCalculatorByLikes();
        //    }
        //}
        public int GenerateScore(ref int i_Likes,ref int i_Comments,int i_LikeValue,int i_CommentValue)
        {
            i_Likes = i_Likes * i_LikeValue;
            i_Comments = i_Comments * i_CommentValue;
            return GetScore(i_Likes,i_Comments);
            
        }
        protected abstract int GetScore(int i_Likes,int i_Comments);
        //public abstract int GetScore();

        //public int GetScore(int i_Comments, int i_Likes)
        //{
        //    throw new NotImplementedException();
        //}
    }
    
}
