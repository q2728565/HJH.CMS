using System;
using System.Collections.Generic;

namespace HJH.TEST.FIRST.MODEL
{
    public class Content
    {

        public int Id { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

        public DateTime CreateTime { get; set; }

    }

    public class ContentViewModel
    {
        public List<Content> content_list { get; set; }
    }
}
