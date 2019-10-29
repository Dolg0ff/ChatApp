using ChatApp.Domain;
using System.Collections.ObjectModel;
using System.ServiceModel;

namespace ChatContracts.Contract
{
    public interface IMessageServiseCallback
    {
        [OperationContract(IsOneWay = true)]
        void ForwardToClient(Message message);
        [OperationContract(IsOneWay = true)]
        void UserConnected(ObservableCollection<User> users);
    }
}