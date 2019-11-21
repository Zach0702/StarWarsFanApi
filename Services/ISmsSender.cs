using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsFan.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
