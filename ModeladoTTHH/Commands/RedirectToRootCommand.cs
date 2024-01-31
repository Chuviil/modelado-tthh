using Microsoft.AspNetCore.Components;
using ModeladoTTHH.Interfaces;

namespace ModeladoTTHH.Commands
{
    public class RedirectToRootCommand : ICommand
    {
        private readonly NavigationManager _navigationManager;

        public RedirectToRootCommand(NavigationManager navigationManager)
        {
            _navigationManager = navigationManager;
        }

        public void Execute()
        {
            _navigationManager.NavigateTo("/");
        }
    }
}