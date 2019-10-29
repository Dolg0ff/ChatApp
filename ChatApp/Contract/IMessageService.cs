using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ServiceModel;
using ChatApp.Domain;

namespace ChatContracts.Contract
{
    [ServiceContract(CallbackContract = typeof(IMessageServiseCallback), SessionMode = SessionMode.Required)]
    public interface IMessageService
    {
        [OperationContract(IsOneWay = true)]
        void Connect(User user);

        [OperationContract(IsOneWay = true)]
        void SendMessage(Message message);
        [OperationContract(IsOneWay = false)]
        ObservableCollection<User> GetConnectedUsers();
    }
}
