using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PracPrism.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly IPageDialogService dialogService;
        private readonly INavigationService navigationService;
        public DelegateCommand PracticaBotonClick { get; }

        public MainPageViewModel(INavigationService navigationService, IPageDialogService dialogService)
            : base(navigationService)
        {
            Title = "Main Page";
            this.navigationService = navigationService;
            this.dialogService = dialogService;
            PracticaBotonClick = new DelegateCommand(async () => await PracticaDelegateCommandAsync());
        }

        private async Task PracticaDelegateCommandAsync()
        {
            //se agrega el servicio de dialogo service, esto con el fin de mostrar mensaje de alerta.
            bool answer = await this.dialogService.DisplayAlertAsync("Pregunta?", "Deseas dirigirte a pagina de practica.", "Yes", "No");            
            Debug.WriteLine("Respuesta: " + answer);
            await this.navigationService.NavigateAsync("practica");
        }
    }
}
