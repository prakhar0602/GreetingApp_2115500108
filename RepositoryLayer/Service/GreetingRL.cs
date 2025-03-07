using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.DTO;
using RepositoryLayer.Context;
using RepositoryLayer.Interface;

namespace RepositoryLayer.Service
{
    public class GreetingRL : IGreetingRL
    {
        private GreetingDB _greetingContext;

        public GreetingRL(GreetingDB context)
        {
            _greetingContext = context;
        }
        public bool addMessage(string? message)
        {
            try
            {
            Message a = new Message();
            a.message = message;
            _greetingContext.Add(a);
            _greetingContext.SaveChanges();
            return true;
            }
            catch
            {
                return false;
            }

        }
        public string findMessage(int? id)
        {
            var message = _greetingContext.Messages.Find(id);
            if (message == null)
            {
                return "Messsage Not Found";
            }
            else
            {
                return message.message;
            }
        }

        public List<Message> getAllMessages()
        {
            var list = _greetingContext.Messages.ToList();
            return list;
        }
        public bool updateMessage(int id,string updatedMessage)
        {
            try{var message = _greetingContext.Messages.Find(id);
            message.message = updatedMessage;
            _greetingContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
