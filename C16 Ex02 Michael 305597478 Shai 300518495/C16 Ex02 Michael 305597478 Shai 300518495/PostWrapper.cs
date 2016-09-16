using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace C16_Ex02_Michael_305597478_Shai_300518495
{
    public class PostWrapper
    {
        private const int k_LengthOfString = 25;

        public Post Post { get; set; }

        public PostWrapper(Post i_Post)
        {
            this.Post = i_Post;
        }

        public override string ToString()
        {
            string resMsg;
            if (Post.Message != null)
            {
                int maxLength = Math.Min(k_LengthOfString, Post.Message.Length);
                if (maxLength == k_LengthOfString)
                {
                    resMsg = string.Format("{0}...", Post.Message.Substring(0, maxLength));
                }
                else
                {
                    resMsg = Post.Message;
                }
            }
            else if (Post.Description != null)
            {
                int maxLength = Math.Min(k_LengthOfString, Post.Description.Length);
                if (maxLength == k_LengthOfString)
                {
                    resMsg = string.Format("{0}...", Post.Description.Substring(0, maxLength));
                }
                else
                {
                    resMsg = Post.Description;
                }
            }
            else if (Post.Name != null)
            {
                resMsg = string.Format("Post from: {0}", Post.Name);
            }
            else
            {
                resMsg = string.Format("[{0}]", Post.Type.Value.ToString());
            }

            return resMsg;
        }
    }
}
