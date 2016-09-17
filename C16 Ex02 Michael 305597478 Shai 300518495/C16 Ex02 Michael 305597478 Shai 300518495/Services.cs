using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace C16_Ex02_Michael_305597478_Shai_300518495
{
    public class Services
    {
        public static bool IsEnoughLikesComments(Post post, int numOfRequiredLikes, int numOfRequiredComments, bool isAndOperation)
        {
            if(isAndOperation == true)
            {
                if(post.LikedBy.Count >= numOfRequiredLikes && post.Comments.Count >= numOfRequiredComments)
                {
                    return true;
                }
            }
            else
            {
                if (post.LikedBy.Count >= numOfRequiredLikes || post.Comments.Count >= numOfRequiredComments)
                {
                    return true;
                }
            }

            return false;
        }

    }
}
