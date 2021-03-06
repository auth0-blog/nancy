﻿using Nancy;
using Nancy.ModelBinding;

namespace NancyStandalone
{
    public class PostModule : NancyModule
    {
        public PostModule()
        {
            Post["/sendname"] = parameters =>
            {
                PostData recievedData = this.Bind<PostData>();

                return new { success = true, message = $"Record recieved name = {recievedData.Name}" };
            };
        }
    }
}