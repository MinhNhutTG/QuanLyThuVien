using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using QUANLYTHUVIEN.GUI;

namespace QUANLYTHUVIEN
{
    internal static class Program
    {
        public static string ProjectDirectory { get; private set; }
      

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            ProjectDirectory = Directory.GetParent(baseDirectory).Parent.Parent.FullName;
            Console.WriteLine($"Project Directory: {ProjectDirectory}");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GUI_Login());
            //Application.Run(new GUI_Main());
            //Application.Run(new QuanLySachForm());
            //Application.Run(new frmQuanLySach_ThemSach());
            //Application.Run(new frmQuanLySachXemChiTiet());
            //Application.Run(new CategoryManagement());

        }
    }
}
