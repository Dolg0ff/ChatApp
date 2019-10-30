using ChatApp.Domain;
using ChatContracts.Contract;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.Servise
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.Single)]
    public class MessageService : IMessageService
    {
        private IMessageServiseCallback _callBack = null;
        private ObservableCollection<User> _users;
        private readonly Dictionary<string, IMessageServiseCallback> _clients;
        public MessageService()
        {
            _users = new ObservableCollection<User>();
            _clients = new Dictionary<string, IMessageServiseCallback>();
        }
        public void Connect(User user)
        {
            _callBack = OperationContext.Current.GetCallbackChannel<IMessageServiseCallback>();
            if (_callBack != null)
            {
                _clients.Add(user.UserId, _callBack);
                _users.Add(user);
                _clients?.ToList().ForEach(c => c.Value.UserConnected(_users));
                Console.WriteLine($"{user.Name} just connected");
            }
        }

        public ObservableCollection<User> GetConnectedUsers()
        {
            return _users;
        }

        public void SendMessage(Message message)
        {
            var sendto = _clients?.First(c => c.Key == message.ToUserId).Value;
            if (sendto != null)
            {
                sendto?.ForwardToClient(message);
            }
        }
    }
}

