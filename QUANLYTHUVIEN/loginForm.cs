using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYTHUVIEN
{
    public partial class loginForm : Form
    {   
        XuLyLogin login = new XuLyLogin();
        public loginForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            txtPassword.Focus();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
        private void resetTextBox()
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.Focus();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
           
            DataTable dt = login.TimTaiKhoan(txtUserName.Text);

            if (dt != null && dt.Rows.Count > 0) { 
                if (dt.Rows[0][0].ToString() == txtUserName.Text){
                    if (dt.Rows[0][1].ToString() == txtPassword.Text) {
                     

                        if (dt.Rows[0][2].ToString() == "admin") {
                            Form frmmain = new Main("admin", dt.Rows[0][0].ToString());
                            frmmain.Show();
                            this.Hide();

                        }
                        else if (dt.Rows[0][2].ToString() == "nhanvien")
                        {
                            Form frmmain = new Main("nhanvien", dt.Rows[0][0].ToString());
                            frmmain.Show();
                            this.Hide();

                        }


                    }
                    else
                    {
                        MessageBox.Show("Sai tên tài khoản hoặc mật khẩu . Vui lòng nhập lại!!");
                        resetTextBox();
                    }
                }
                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu . Vui lòng nhập lại!!");
                    resetTextBox();
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy tài khoản!!");
                resetTextBox();
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
       
        private void loginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
