using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C16_Ex02_Michael_305597478_Shai_300518495
{
    class PostScoreCalculator
    {
        BestPostFinder.eScoreCalculationStyle ScoreCalculationStyle {get;set ;}
        public int LikesCount { get; set; }
        public int CommentsCount { get; set; }

        public PostScoreCalculator(BestPostFinder.eScoreCalculationStyle i_ScoreCalculationStyle,int i_LikesCount,int i_CommentsCount)
        {
            ScoreCalculationStyle = i_ScoreCalculationStyle;
            LikesCount = i_LikesCount;
            CommentsCount = i_CommentsCount;
        }

    }
}
