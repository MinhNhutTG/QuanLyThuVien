using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYTHUVIEN.DAL;
using QUANLYTHUVIEN.GUI;

namespace QUANLYTHUVIEN.BLL
{
    internal class BUS_ThongKe
    {
        DAL_ThongKe DALThongKe = new DAL_ThongKe();
        public DataTable ThongKeSachDangMuon()
        {
            DataTable dt = new DataTable();
            dt = DALThongKe.ThongKeSachDangMuon();
            return dt;
        }
        public DataTable ThongKeSachConTrongKho()
        {
            DataTable dt = new DataTable();
            dt = DALThongKe.ThongKeSachConTrongKho();
            return dt;
        }
        public DataTable ThongKeMuonTrongNgay(string key)
        {
            DataTable dt = new DataTable();
            dt = DALThongKe.ThongKeMuonTrongNgay(key);
                return dt;
        }
        public DataTable ThongKeTrongTuan()
        {
            DataTable dt = new DataTable();
            dt = DALThongKe.ThongKeTrongTuan();
                return dt;
        }
        public DataTable ThongKeTrongThang()
        {
            DataTable dt = new DataTable();
            dt = DALThongKe.ThongKeTrongThang();
                return dt;
        }
        public DataTable ThongKeDangMuon()
        {
            DataTable dt = new DataTable();
            dt = DALThongKe.ThongKeDangMuon();
                return dt;
        }
        public DataTable ThongKeViPham()
        {
            DataTable dt = new DataTable();
            dt = DALThongKe.ThongKeViPham();
            return dt;
        }
    }
    
}

