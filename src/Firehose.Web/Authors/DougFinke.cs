﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class DougFinke : IFilterMyBlogPosts, IAmAMicrosoftMVP
    {
        public string FirstName => "Doug";
        public string LastName => "Finke";
        public string ShortBioOrTagLine => "Microsoft PowerShell MVP, Author: Windows PowerShell for Developers http://goo.gl/D3gsQ , consultant, speaker, father";
        public string StateOrRegion => "New York City, United States";
        public string EmailAddress => "finked@hotmail.com";
        public string TwitterHandle => "dfinke";
        public string GravatarHash => "94c48c63e7e63f5e713f7f7a5cdbcac0";

        public Uri WebSite => new Uri("https://dfinke.github.io/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://dfinke.github.io/feed.xml"); }
        }

        public string GitHubHandle => "dfinke";

        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Where(i => i.Name.Equals("powershell", StringComparison.OrdinalIgnoreCase)).Any();
        }

        public GeoPosition Position => new GeoPosition(40.7526970, -73.9749950);
        
        //DateTime IAmAMicrosoftMVP.FirstAwarded => new DateTime(2008, 4, 1);
    }
}