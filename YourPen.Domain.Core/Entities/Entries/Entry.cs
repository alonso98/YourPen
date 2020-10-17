using System;
using System.Collections.Generic;
using System.Text;
using YourPen.Domain.Core.Common;
using YourPen.Domain.Core.Entities.Topics;

namespace YourPen.Domain.Core.Entities.Entries
{
    public class Entry : IEntity
    {
        public int Id { get; set; }

        public virtual string Text { get; protected set; }

        public virtual string Head { get; protected set; }

        public virtual int TopicId { get; protected set; }

        public virtual Topic Topics { get; protected set; }

        public virtual DateTime? CreationTime { get; protected set; }

        public virtual EntryTypes Type { get; protected set; }

        //public virtual ReadOnlyCollection<Link> Links { get { return links.AsReadOnly(); } }

        #region Static methods
        public static Entry Create(int id,
                                   string head,
                                   string text,
                                   int topicId,
                                   EntryTypes type)
        {
            var note = new Entry
            {
                Id = id,
                Head = head,
                Text = text,
                TopicId = topicId,
                Type = type,
                CreationTime = DateTime.Now
            };

            return note;
        }


        #endregion

        #region Public methods
        //public void AddLink(string url, string name = null)
        //{
        //    var link = new Link(url, name);
        //    links.Add(link);
        //}
        #endregion
    }
}
