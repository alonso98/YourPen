using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using YourPen.Domain.Core.Common;
using YourPen.Domain.Core.Entities.Entries;
using YourPen.Domain.Core.Entities.Users;

namespace YourPen.Domain.Core.Entities.Topics
{
    public class Topic : Entity
    {
        public virtual string Name { get; protected set; }

        public virtual Guid UserId { get; protected set; }

        public virtual User User { get; protected set; }

        public virtual ReadOnlyCollection<Entry> Entries { get; protected set; }

        #region Static methods
        public static Topic Create(string name, Guid userId)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("name");

            var topic = new Topic
            {
                Name = name,
                UserId = userId
            };
            return topic;
        }

        //public static Topic Create(string name, Guid userId)
        //{
        //    return Create(Guid.NewGuid(), name, userId);
        //}
        #endregion

        #region Methods
        public virtual void ChangeName(string topicName)
        {
            this.Name = topicName ?? throw new ArgumentNullException(nameof(topicName));
        }
        #endregion
    }
}
