using System.Collections.ObjectModel;
using ChatApp.Domain;
using ChatContracts.Contract;

namespace ChatApp.Desktop.ViewModels
{
    public class MessageCallBack : IMessageServiseCallback
    {
        public void ForwardToClient(Message message)
        {
            throw new System.NotImplementedException();
        }

        public void UserConnected(ObservableCollection<User> users)
        {
            throw new System.NotImplementedException();
        }
    }
}
