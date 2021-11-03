using System;
using System.Threading.Tasks;
using Dev.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Dev.App.Extensions
{
    public class SummaryViewComponent : ViewComponent
    {
        private readonly INotificador _notificador;

        public SummaryViewComponent(INotificador notificador)
        {
            _notificador = notificador;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var notificacoes = await Task.FromResult(_notificador.ObterNotificacoes());
            
            notificacoes.ForEach(n => ViewData.ModelState.AddModelError(String.Empty, n.Message));
            return View();
        }
    }
}