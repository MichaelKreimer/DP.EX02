using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C16_Ex02_Michael_305597478_Shai_300518495
{
    public class FacebookActionFactory : ActionFactory
    {
        public static Action CreateFacebookAction(bool i_IsUnlike, Post i_HandledPost, int i_NumOfRequiredLikes, int i_NumOfRequiredComments, bool i_isAndOperation)
        {
            return new LikerByNums(i_IsUnlike, i_HandledPost, i_NumOfRequiredLikes, i_NumOfRequiredComments, i_isAndOperation);
        }
        public static Action CreateFacebookAction(bool i_IsUnlike, Post i_HandledPost, DateTime i_ChosenDateTime)
        {
            return new LikerByTime(i_IsUnlike, i_HandledPost, i_ChosenDateTime);
        }
        public static Action CreateFacebookAction(string i_CommentText, Post i_HandledPost, int i_NumOfRequiredLikes, int i_NumOfRequiredComments, bool i_IsAndOperation)
        {
            return new CommenterByNums(i_CommentText, i_HandledPost, i_NumOfRequiredLikes, i_NumOfRequiredComments, i_IsAndOperation);
        }
        public static Action CreateFacebookAction(string i_CommentText, Post i_HandledPost, DateTime i_ChosenDateTime)
        {
            return new CommenterByTime(i_CommentText, i_HandledPost, i_ChosenDateTime);
        }
        public static Action CreateFacebookAction(User i_User, DateTime i_ChosenDateTime, string i_TextToPost)
        {
            return new Poster(i_User, i_ChosenDateTime, i_TextToPost);
        }

        public override Liker CreateLiker()
        {
            throw new NotImplementedException();
        }
    }
}
