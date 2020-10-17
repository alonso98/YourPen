using System;
using System.Collections.Generic;
using System.Text;

namespace YourPen.Domain.Core.Common
{
    public interface IEntity<T>
    {
        public T Id { get; set; }
    }

    public interface IEntity : IEntity<int>
    {

    }
}
