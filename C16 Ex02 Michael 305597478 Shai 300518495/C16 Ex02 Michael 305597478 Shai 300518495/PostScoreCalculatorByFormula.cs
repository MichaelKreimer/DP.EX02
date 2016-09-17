using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C16_Ex02_Michael_305597478_Shai_300518495
{
    class PostScoreCalculatorByFormula : PostScoreCalculator
    {
        protected override int GetScore(int i_LikesValue, int i_CommentsValue)
        {
            return i_CommentsValue + i_LikesValue;
        }
    }
}
