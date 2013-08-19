/*
 * Copyright (c) 2013 Google Inc.
 *
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except
 * in compliance with the License. You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software distributed under the
 * License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 */

using Google.Apis.Mirror.v1.Data;
using System;
using System.Collections.Generic;

namespace MirrorQuickstart.Models
{
    /// <summary>
    /// Model used for the Main Index View.
    /// </summary>
    public class IndexModel
    {
        public String Message { get; set; }

        public IList<TimelineItem> TimelineItems { get; set; }

        public Boolean HasContact { get; set; }

        public Boolean HasTimelineSubscription { get; set; }

        public Boolean HasLocationSubscription { get; set; }
    }

    public class RedditResp
    {
        public string kind { get; set; }
        public RedditObj data { get; set; }
    }
    public class RedditObj
    {
        public string modhash { get; set; }
        public List<RedditChildrenObj> children { get; set; }
    }
    public class RedditChildrenObj
    {
        public string kind { get; set; }
        public RedditDataObj data { get; set; }
    }
    public class RedditDataObj
    {
        public string url { get; set; }
        public string thumbnail { get; set; }
        public string title { get; set; }
    }

    //{
    //    "kind": "Listing", 
    //    "data": {
    //        "modhash": "txjnuoh19o9cb188a73a0f2c2149c0484b8e0b928b0dea7fe1", 
    //        "children": [
    //            {
    //                "kind": "t3", 
    //                "data": {
    //                    "domain": "i.imgur.com", 
    //                    "banned_by": null, 
    //                    "media_embed": {}, 
    //                    "subreddit": "Awww", 
    //                    "selftext_html": null, 
    //                    "selftext": "", 
    //                    "likes": null, 
    //                    "link_flair_text": null, 
    //                    "id": "1kkbgu", 
    //                    "clicked": false, 
    //                    "stickied": false, 
    //                    "title": "Maple the pig at farmer's market...evidently she has her own instagram..", 
    //                    "media": null, 
    //                    "score": 2, 
    //                    "approved_by": null, 
    //                    "over_18": false, 
    //                    "hidden": false, 
    //                    "thumbnail": "http://e.thumbs.redditmedia.com/OllpYShU8MP2VKpj.jpg", 
    //                    "subreddit_id": "t5_2suml", 
    //                    "edited": false, 
    //                    "link_flair_css_class": null, 
    //                    "author_flair_css_class": null, 
    //                    "downs": 1, 
    //                    "saved": false, 
    //                    "is_self": false, 
    //                    "permalink": "/r/Awww/comments/1kkbgu/maple_the_pig_at_farmers_marketevidently_she_has/", 
    //                    "name": "t3_1kkbgu", 
    //                    "created": 1376796130.0, 
    //                    "url": "http://i.imgur.com/GlRoBPb.jpg", 
    //                    "author_flair_text": null, 
    //                    "author": "Lordmonk", 
    //                    "created_utc": 1376767330.0, 
    //                    "ups": 3, 
    //                    "num_comments": 0, 
    //                    "num_reports": null, 
    //                    "distinguished": null}
    //            }]
    //    }
    //}
}