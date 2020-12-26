using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using YourPen.Domain.Core.Common;
using YourPen.Domain.Core.Entities.Topics;

namespace YourPen.Domain.Core.Entities.Users
{
    public class User : Entity
    {
        #region Props
        public virtual string UserName { get; protected set; }

        public virtual string Password { get; protected set; }

        public virtual string Salt { get; protected set; }

        public virtual Email Email { get; protected set; }

        public virtual DateTime? CreatingDate { get; protected set; }

        public virtual Roles Role { get; protected set; }

        public virtual ReadOnlyCollection<Topic> Topics { get; protected set; }
        #endregion

        #region Static methods
        public static User Create(Email email,
                                  string username,
                                  string password,
                                  string salt,
                                  Roles role)
        {
            if (email == null)
                throw new ArgumentNullException("email");

            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentNullException("username");

            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentNullException("password");

            if (string.IsNullOrWhiteSpace(salt))
                throw new ArgumentNullException("salt");

            User user = new User
            {
                CreatingDate = DateTime.Now,
                Email = email,
                UserName = username,
                Password = password,
                Role = role,
                Salt = salt
            };

            //todo: вызов события "создано"

            return user;
        }
        #endregion
    }
}
