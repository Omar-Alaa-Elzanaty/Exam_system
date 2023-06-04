using Examsystem.Models;
using System.Drawing;

namespace Examsystem
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (ExamDb Db=new ExamDb())
            {
                Db.Database.EnsureCreated(); 
            }
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
        
    }
}