using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Words.NET;


namespace QUANLYTHUVIEN.BLL
{
    public  class CreateFileDoc
    {
        public CreateFileDoc() { }
        public void  CreateFileWord(string path, string content)
        {
            string basepath = AppDomain.CurrentDomain.BaseDirectory;
            using (var doc = DocX.Load(basepath + path))
            {
                doc.InsertParagraph("\n"+ content);
                doc.Save();
            }
            MessageBox.Show("File Log đã được lưu!!", "Thông báo", MessageBoxButtons.OK);
        }
    }
}
