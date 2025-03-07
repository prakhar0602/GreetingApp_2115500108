using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.DTO;

namespace RepositoryLayer.Interface
{
    public interface IGreetingRL
    {
        public bool addMessage(string? message);
        public string findMessage(int? id);

        public List<Message> getAllMessages(); 
    }
}
