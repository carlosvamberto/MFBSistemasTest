using Unity;
using MFBSistemas.Repositories;
using MFBSistemas.Models;
using System.Globalization;

namespace MFBSistemas
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Define a cultura para pt-BR para toda a aplica��o
            CultureInfo culture = new CultureInfo("pt-BR");
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Cria e configura o container de inje��o de depend�ncia
            var container = new UnityContainer();

            //var optionsBuilder = new DbContextOptionsBuilder<LocalDBMSSQLLocalDBContext>();
            //optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=DatabaseName;Integrated Security=True");


            //// Registra as op��es configuradas no container
            //container.RegisterInstance(optionsBuilder.Options);

            // Registra as depend�ncias (exemplo: contexto e reposit�rios)
            container.RegisterType<LocalDBMSSQLLocalDBContext>(); // Registro padr�o, cria nova inst�ncia a cada resolu��o
            container.RegisterType(typeof(IRepository<>), typeof(Repository<>));
            container.RegisterType(typeof(IClienteRepository), typeof(ClienteRepository));
            container.RegisterType(typeof(IProdutoRepository), typeof(ProdutoRepository));
            container.RegisterType(typeof(IVendaRepository), typeof(VendaRepository));
            container.RegisterType(typeof(IRelatoriosRepository), typeof(RelatoriosRepository));

            // Registra os formul�rios (por exemplo, FormPrincipal e FormListagemClientes)
            container.RegisterType<FormPrincipal>();
            container.RegisterType<Forms.Clientes.FormListagemClientes>();

            // Resolve o formul�rio principal com as depend�ncias injetadas
            var mainForm = container.Resolve<FormPrincipal>();

            Application.Run(mainForm);
        }
    }
}