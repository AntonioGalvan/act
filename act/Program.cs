using System;
using System.Windows.Forms;
using act.Models;
using act.Presenters;
using act._Repositories;
using act.Views;
using act.Forms.Side_bar;
using act.Forms.Roles;
using System.Configuration;
namespace act
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            string sqlConnectionString = ConfigurationManager.ConnectionStrings[1].ConnectionString;
            IProjectview projectview = new ProjectView();
            IProjectRepository projectRepository = new ProjectRepository(sqlConnectionString);
            //new ProjectPresenter(projectview, projectRepository);

            Application.Run(new SideBar());
        }
    }
}