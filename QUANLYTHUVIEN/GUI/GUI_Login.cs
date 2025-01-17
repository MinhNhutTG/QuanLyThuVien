﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYTHUVIEN.DTO;
using QUANLYTHUVIEN.BLL;

namespace QUANLYTHUVIEN.GUI
{
    public partial class GUI_Login : Form
    {   
       
        public GUI_Login()
        {
            InitializeComponent();
           
        }

        private void resetTextBox()
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.Focus();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
          BLL_Login  busLogin = new BLL_Login();
          TaiKhoan tk = busLogin.Login(txtUserName.Text, txtPassword.Text);
            if (tk != null) {
                
                MessageBox.Show("Đăng nhập thành công ","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                GUI_Main main = new GUI_Main(tk.getPhanQuyen(), busLogin.LayMaThuThu(tk.getUserName()));
                main.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu ", "Lỗi đăng nhập",MessageBoxButtons .OK, MessageBoxIcon.Error);
                resetTextBox();
                txtUserName.Focus();


            }
            
        }

        //. Hàm này nhận phím enter mỗi khi nhấn thì kiểm tra xem textboxUsername có rỗng hay không , nếu có thì focus vào , mỗi lần enter sẽ focus tiếp
        private void LoginForm_KeyDown(object sender, KeyEventArgs e)  
        {                                                              
            if (e.KeyCode == Keys.Enter) { 
                if (string.IsNullOrWhiteSpace(txtUserName.Text))
                {
                    txtUserName.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtPassword.Text)) { 
                    txtPassword.Focus();
                    return ;
                }
                btnDangNhap.PerformClick(); // dùng perform click để mô phỏng hành động click đăng nhập 
               
            }
        }

        private void GUI_Login_Load(object sender, EventArgs e)
        {
            resetTextBox();
        }

       
      

       
    }
}
