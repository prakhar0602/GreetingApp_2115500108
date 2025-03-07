using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.DTO;

namespace BuisnessLayer.Interface
{
    public interface IGreetingBL
    {
        public string SimpleGreeting();
        public string GetGreeting(string? firstName, string? lastName);
        public string addMessages(string? message);

        public string findMessage(int? id);

        public List<Message> getAllMessages();
    }
}
