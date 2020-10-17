using LinqSpecs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace YourPen.Domain.Core.Entities.Topics
{
    public class TopicsByUserSpecification : Specification<Topic>
    {
        private Guid guid;


        public TopicsByUserSpecification(Guid id)
        {
            this.guid = id;
        }

        public override Expression<Func<Topic, bool>> ToExpression()
        {
            return m => m.UserId == this.guid;
        }
    }
}
