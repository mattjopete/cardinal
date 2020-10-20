
using System.Collections.Generic;
using Twitter.Api.Models;

namespace Twitter.Api.Interfaces
{
    public interface IFeed
    {
        IEnumerable<Tweet> GetTweets();
    }
}
