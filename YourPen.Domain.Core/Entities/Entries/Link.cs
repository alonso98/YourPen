using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using YourPen.Domain.Core.Common.Exceptions;

namespace YourPen.Domain.Core.Entities.Entries
{
    public class Link
    {
        public virtual int Id { get; protected set; }
        public virtual string Url { get; protected set; }
        public virtual string NameUrl { get; protected set; }

        private string template = @"^http(s)?://([\w-]+.)+[\w-]+(/[\w- ./?%&=])?$";

        internal Link()
        {

        }

        public Link(string url, string name)
        {
            Regex regex = new Regex(template);
            if (url == null)
                throw new ArgumentNullException(nameof(url));
            if (!regex.IsMatch(url))
                throw new InvalidUrlException();

            this.Url = url;
            this.NameUrl = name;
        }
    }

    public class InvalidUrlException : InvalidFormatException<Link>
    {
    }
}
