using System;
using System.Collections.Generic;
using System.Text;

namespace YourPen.Domain.Core.Common
{
	public abstract class Entity
	{
		public Guid Id { get; private set; }
		public bool IsDeleted { get; private set; }

		public Entity()
		{
			this.Id = Guid.NewGuid();
			this.IsDeleted = false;
		}

		public void Delete()
		{
			this.IsDeleted = true;
		}
	}
}
