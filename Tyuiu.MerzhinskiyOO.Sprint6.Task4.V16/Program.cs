﻿using Tyuiu.MerzhinskiyOO.Sprint6.Task4.V16.Lib;
namespace Tyuiu.MerzhinskiyOO.Sprint6.Task4.V16
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
            Application.Run(new FormMain());
        }
    }
}