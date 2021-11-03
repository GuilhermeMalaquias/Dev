using Dev.App.Extensions;
using Dev.Business.Intefaces;
using Dev.Business.Interfaces;
using Dev.Business.Notificacoes;
using Dev.Business.Services;
using Dev.Data.Context;
using Dev.Data.Repository;
using Microsoft.AspNetCore.Mvc.DataAnnotations;
using Microsoft.Extensions.DependencyInjection;

namespace Dev.App.Configurations
{
    public static class DependenceInjectionConfig
    {
        public static  IServiceCollection ResolveDependence(this IServiceCollection services)
        {
            services.AddScoped<ContextDb>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddSingleton<IValidationAttributeAdapterProvider, MoedaAttributeAdapterProvider>();
            services.AddScoped<INotificador, Notificador>();
            services.AddScoped<IFornecedorService, FornecedorService>();
            services.AddScoped<IProdutoService, ProdutoService>();
            return services;
        }
    }
}
