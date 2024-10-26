using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Common
{
    public interface IEmailService
    {

        public Task Send(string from, string to, string subject);



    }
}
