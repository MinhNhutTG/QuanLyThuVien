using System;
using System.Collections.Generic;
using System.IO;
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
        public void  CreateFileWord(string filename, string content)
        {
            try
            {
                string basepath = AppDomain.CurrentDomain.BaseDirectory + @"FileLog\\";
                string path = Path.Combine(basepath, filename + ".docx");
                if (File.Exists(path))
                {
                    using (var doc = DocX.Load(path))
                    {
                        doc.InsertParagraph("\n" + content);
                        doc.Save();
                    }
                }
                else
                {
                    using (var newdoc = DocX.Create(path))
                    {
                        newdoc.InsertParagraph("\n" + content);
                        newdoc.Save();
                    }
                }
                MessageBox.Show("File Log đã được lưu!!", "Thông báo", MessageBoxButtons.OK);

            }
            catch (Exception ex) {
                MessageBox.Show("Không thể ghi log! \n Chi tiết lỗi : "+ex.Message);
            }



        }
    }
}
