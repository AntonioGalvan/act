using System;
using System.Windows.Forms;
using act.Models;
using act.Presenters;
using act._Repositories;
using act.Views;
using act.Forms.Side_bar;
using act.Forms.Roles;

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
            string sqlConnectionString;
            //IProjectview projectview = new ProjectView();
            //IProjectRepository projectRepository = projectRepository();
            Application.Run(new RoleIndex());
        }
    }
}