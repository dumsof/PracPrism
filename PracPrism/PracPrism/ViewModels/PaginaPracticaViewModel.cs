namespace PracPrism.ViewModels
{
    using Prism.Commands;
    using Prism.Navigation;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class PaginaPracticaViewModel : ViewModelBase
    {
        private INavigationService navigationService;       

        /// <summary>
        /// DUM: se debe crear el constructor y heredar de la clase base y pasar la navegación.
        /// </summary>
        /// <param name="navigationService"></param>
        public PaginaPracticaViewModel(INavigationService navigationService):base(navigationService)
        {
            this.navigationService = navigationService;
        }
    }
}
