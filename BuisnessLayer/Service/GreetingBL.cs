using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using BuisnessLayer.Interface;
using ModelLayer.DTO;
using RepositoryLayer.Interface;

namespace BuisnessLayer.Service
{
     public class GreetingBL:IGreetingBL
    {
        private IGreetingRL _repositoryLayerInstance;
        public GreetingBL(IGreetingRL instance)
        {
            _repositoryLayerInstance = instance;
        }
        public string SimpleGreeting()
        {
            return "Hello World";
        }
        public string GetGreeting(string? firstName,string? lastName)
        {
            if (!string.IsNullOrWhiteSpace(firstName?.Trim()) && !string.IsNullOrWhiteSpace(lastName?.Trim()))
            {
                return $"Hello, {firstName} {lastName}";
            }
            else if (!string.IsNullOrWhiteSpace(firstName?.Trim()))
            {
                return $"Hello, {firstName}";
            }
            else if (!string.IsNullOrWhiteSpace(lastName?.Trim()))
            {
                return $"Hello, {lastName}";
            }
            else
            {
                return "Hello World";
            }
        }

        public string addMessages(string? message)
        {
            if (_repositoryLayerInstance.addMessage(message))
            {
                return "Message Stored";
            }
            else
            {
                return "Message Creation Failed";
            }
        }
    }
}
