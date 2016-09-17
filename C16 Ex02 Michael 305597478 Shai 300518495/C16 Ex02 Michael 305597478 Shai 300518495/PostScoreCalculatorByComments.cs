using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C16_Ex02_Michael_305597478_Shai_300518495
{
    class PostScoreCalculatorByComments : PostScoreCalculator
    {
        protected override int GetScore(int i_Likes,int i_Comments)
        {
            return i_Comments;
        }
    }
}
