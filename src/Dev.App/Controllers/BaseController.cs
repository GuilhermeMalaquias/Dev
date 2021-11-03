﻿using Dev.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Dev.App.Controllers
{
    public abstract class BaseController : Controller
    {
        private readonly INotificador _notificador;

        protected BaseController(INotificador notificador)
        {
            _notificador = notificador;
        }
        public bool OperacaoValida()
        {
            return !_notificador.TemNotificacao();
        }
    }
}
