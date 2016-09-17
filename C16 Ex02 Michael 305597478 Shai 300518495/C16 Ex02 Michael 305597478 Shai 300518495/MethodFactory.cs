using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C16_Ex02_Michael_305597478_Shai_300518495
{
    class MethodFactory
    {
        public static PostScoreCalculator CreateScoreCalculator(BestPostFinder.eScoreCalculationStyle i_CalculationStyle)
        {
            if (i_CalculationStyle.Equals(BestPostFinder.eScoreCalculationStyle.Comments))
            {
                return new PostScoreCalculatorByComments;
            }
            else if (i_CalculationStyle.Equals(BestPostFinder.eScoreCalculationStyle.Formula))
            {
                return new PostScoreCalculatorByFormula();
            }
            else // (i_ScoreCalculationStyle.Equals(BestPostFinder.eScoreCalculationStyle.Likes)
            {
                return new PostScoreCalculatorByLikes();
            }
        }
    }
}
