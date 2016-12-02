using System;
using GalaSoft.MvvmLight.Command;
using Prism.Interactivity.InteractionRequest;

namespace OMB_Desktop.ViewModel
{
    public interface ILoginViewModel
    {
        InteractionRequest<INotification> CredencialesInvalidas { get; set; }
        InteractionRequest<INotification> FaltanDatos { get; set; }
        Action FinishInteraction { get; set; }
        RelayCommand<string> LoginCommand { get; set; }
        string LoginID { get; set; }
        INotification Notification { get; set; }

        void DoLogin(string pass);
    }
}