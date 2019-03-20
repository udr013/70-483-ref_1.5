using System;
using System.Threading.Tasks;

namespace AggregateExceptions
{
    internal class HttpClcient
    {
        public HttpClcient()
        {
        }

        internal Task GetAsync(string uri)
        {
            throw new NotImplementedException();
        }
    }
}