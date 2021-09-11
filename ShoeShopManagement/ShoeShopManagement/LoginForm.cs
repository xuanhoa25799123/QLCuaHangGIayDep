using ShoeShopManagement.BLL.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoeShopManagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string branch, loginName, password;

            branch = cbbChiNhanh.Text;
            int branchId = cbbChiNhanh.SelectedIndex + 1;
            loginName = txtTaiKhoan.Text;
            password = txtMatKhau.Text;

            WorkingContext.Instance.currentBranchId = branchId;
            WorkingContext.Instance.currentBranch = branch;
            WorkingContext.Instance.currentLoginName = loginName;

            var connectionName = string.Format("Branch{0}", branchId);
            var connectionString = ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;

            connectionString = string.Format(connectionString, loginName, password);
            WorkingContext.Instance.Initialize(connectionString);

            var unitOfWork = WorkingContext.Instance.GetUnitOfWork();
            var authService = new LoginService(unitOfWork);
            try
            {
                var loginInfo = authService.GetLoginInfo(loginName);
                WorkingContext.Instance.CurrentLoginInfo = loginInfo;
                MainForm form = new MainForm(unitOfWork);
                form.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Sai thông tin đăng nhập \r\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            cbbChiNhanh.SelectedIndex = 0;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
