using LinqSpecs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace YourPen.Domain.Core.Entities.Entries
{
    public class EntriesByTopicIdSpecification : Specification<Entry>
    {
        private int topicId;
        public EntriesByTopicIdSpecification(int topicId)
        {
            this.topicId = topicId;
        }

        public override Expression<Func<Entry, bool>> ToExpression()
        {
            return m => m.TopicId == topicId;
        }
    }
}
