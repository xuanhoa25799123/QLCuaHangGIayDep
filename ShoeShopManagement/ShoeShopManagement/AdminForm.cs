using ShoeShopManagement.BLL.Accounts;
using ShoeShopManagement.BLL.Employees;
using ShoeShopManagement.DAL;
using ShoeShopManagement.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoeShopManagement
{
    public partial class AdminForm : Form
    {
        private IUnitOfWork _unitOfWork;
        private IEmployeeService _employeeService;
        private IAccountService _accountService;
        public AdminForm(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _employeeService = new EmployeeService(_unitOfWork);
            _accountService = new AccountService(_unitOfWork);
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            try
            {
                cbbChiNhanhTK.Enabled = false;
                gvNhanVien.AutoGenerateColumns = false;
                gvTaiKhoan.AutoGenerateColumns = false;
                txtID.Text = "0";
                cbbChiNhanh.SelectedIndex = WorkingContext.Instance.currentBranchId - 1;
                cbbChiNhanhTK.SelectedIndex = WorkingContext.Instance.currentBranchId - 1;
                if (WorkingContext.Instance.CurrentLoginInfo.RoleName != "GIAMDOC")
                {
                    cbbChiNhanh.Enabled = false;
                   
                } 
                gvNhanVien.DataSource = _employeeService.GetAll().Where(c => c.State != true).Select(c=> new { c.ID, c.Name, c.PhoneNumber, c.Position, c.Salary, c.Address, c.DateOfBirth }).ToList();
                gvTaiKhoan.DataSource = _accountService.GetAllAccount();
                cbbNhanVien.DataSource = _employeeService.GetAll().Where(c=>c.State != true).Select(c => c.ID + " | " + c.Name + " | " + c.Position ).ToList();
                
            }

            catch(Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra \r\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void cbbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbChiNhanh.SelectedIndex == WorkingContext.Instance.currentBranchId - 1)
                    gvNhanVien.DataSource = _employeeService.GetAll().Where(c => c.State != true).Select(c => new { c.ID, c.Name, c.PhoneNumber, c.Position, c.Salary, c.Address, c.DateOfBirth }).ToList();
                else
                    gvNhanVien.DataSource = _employeeService.GetAllFromRemote().Where(c => c.State != true).Select(c => new { c.ID, c.Name, c.PhoneNumber, c.Position, c.Salary, c.Address, c.DateOfBirth}).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra \r\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
        }


        private void Reset()
        {
            txtID.Text = "0";
            txtViTri.Text = "";
            txtTen.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtLuong.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
        }

        private void btnXoaTrong_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee
                {
                    ID = Convert.ToInt32(txtID.Text),
                    Name = txtTen.Text,
                    DateOfBirth = dtpNgaySinh.Value.Date,
                    Address = txtDiaChi.Text,
                    PhoneNumber = txtSDT.Text,
                    Position = txtViTri.Text,
                    Salary = Convert.ToInt32(txtLuong.Text)
                };
                if (cbbChiNhanh.SelectedIndex == WorkingContext.Instance.currentBranchId - 1)
                {
                    employee.BranchID = WorkingContext.Instance.currentBranchId;
                    if (txtID.Text == "0")
                    {
                        _employeeService.AddEmployee(employee);
                    }
                    else
                        _employeeService.UpdateEmployee(employee);
                }
                else
                {
                    if (WorkingContext.Instance.currentBranchId == 1)
                        employee.BranchID = 2;
                    else
                        employee.BranchID = 1;
                    if (txtID.Text == "0")
                    {
                        _employeeService.AddEmployeeFromRemote(employee);
                    }
                    else
                        _employeeService.UpdateEmployeeFromRemote(employee);
                }
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK);
                AdminForm_Load(null, EventArgs.Empty);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra \r\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
        }
        
        private void gvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;
            if(grid[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
            {
                int EmployeeID = (int)gvNhanVien.SelectedRows[0].Cells["clID"].Value;
                if (cbbChiNhanh.SelectedIndex == WorkingContext.Instance.currentBranchId - 1)
                    _employeeService.DeleteEmployee(EmployeeID);
                else
                    _employeeService.DeleteEmployeeFromRemote(EmployeeID);
                MessageBox.Show("Xóa nhân viên thành công", "Thông báo", MessageBoxButtons.OK);
                AdminForm_Load(null, EventArgs.Empty);
            }    
        }

        private void gvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = gvNhanVien.SelectedRows[0].Cells["clID"].Value.ToString();
            txtViTri.Text = gvNhanVien.SelectedRows[0].Cells["clViTri"].Value.ToString();
            txtTen.Text = gvNhanVien.SelectedRows[0].Cells["clTen"].Value.ToString();
            txtDiaChi.Text = gvNhanVien.SelectedRows[0].Cells["clDiaChi"].Value.ToString();
            txtSDT.Text = gvNhanVien.SelectedRows[0].Cells["clSDT"].Value.ToString();
            txtLuong.Text = gvNhanVien.SelectedRows[0].Cells["clLuong"].Value.ToString();
            dtpNgaySinh.Value = (DateTime)gvNhanVien.SelectedRows[0].Cells["clNgaySinh"].Value;
        }

        private void cbbChiNhanhTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void gvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;
            if (grid[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
            {
                if (e.ColumnIndex == 4)
                {
                    string ID = gvTaiKhoan.SelectedRows[0].Cells["clIDTK"].Value.ToString();
                    string loginName = gvTaiKhoan.SelectedRows[0].Cells["clTenTK"].Value.ToString();
                    _accountService.DeleteAccount(ID, loginName);
                    gvTaiKhoan.DataSource = _accountService.GetAllAccount();
                    MessageBox.Show("Xóa thành công" , "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    string loginName = gvTaiKhoan.SelectedRows[0].Cells["clTenTK"].Value.ToString();
                    _accountService.ResetPassword(loginName);
                    MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK);
                }    
            }
        }

        private void btnLuuTK_Click(object sender, EventArgs e)
        {
            string loginName = txtTenTK.Text;
            string[] info = cbbNhanVien.SelectedItem.ToString().Split('|');
            int userName = Convert.ToInt32(info[0].Trim());
            string vaiTro;
            if(cbbVaiTro.SelectedIndex == 0)
            {
                vaiTro = "GIAMDOC";
            }    
            else if(cbbVaiTro.SelectedIndex == 1)
            {
                vaiTro = "QLCHINHANH";
            }
            else
            {
                vaiTro = "NHANVIEN";
            }
            _accountService.AddAccount(loginName, userName, vaiTro);
            MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK);
            gvTaiKhoan.DataSource = _accountService.GetAllAccount();
        }

        private void chuyểnChiNhánhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = (int)gvNhanVien.SelectedRows[0].Cells["clID"].Value;
            Employee employee = new Employee
            {
                Name = gvNhanVien.SelectedRows[0].Cells["clTen"].Value.ToString(),
                DateOfBirth = Convert.ToDateTime(gvNhanVien.SelectedRows[0].Cells["clNgaySinh"].Value),
                Address = gvNhanVien.SelectedRows[0].Cells["clDiaChi"].Value.ToString(),
                PhoneNumber = gvNhanVien.SelectedRows[0].Cells["clSDT"].Value.ToString(),
                Position = gvNhanVien.SelectedRows[0].Cells["clViTri"].Value.ToString(),
                Salary = (int)gvNhanVien.SelectedRows[0].Cells["clLuong"].Value
            };
            if (cbbChiNhanh.SelectedIndex == WorkingContext.Instance.currentBranchId - 1)
            {
                if (WorkingContext.Instance.currentBranchId == 1)
                    employee.BranchID = 2;
                else
                    employee.BranchID = 1;
                _employeeService.DeleteEmployee(ID);
                _employeeService.AddEmployeeFromRemote(employee);
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK);
                gvNhanVien.DataSource = _employeeService.GetAll().Where(c => c.State != true).Select(c => new { c.ID, c.Name, c.PhoneNumber, c.Position, c.Salary, c.Address, c.DateOfBirth }).ToList();
                gvTaiKhoan.DataSource = _accountService.GetAllAccount();
            }
            else
            {
                employee.BranchID = WorkingContext.Instance.currentBranchId;
                _employeeService.DeleteEmployeeFromRemote(ID);
                _employeeService.AddEmployee(employee);
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK);
                gvNhanVien.DataSource = _employeeService.GetAllFromRemote().Where(c => c.State != true).Select(c => new { c.ID, c.Name, c.PhoneNumber, c.Position, c.Salary, c.Address, c.DateOfBirth }).ToList();
                gvTaiKhoan.DataSource = _accountService.GetAllAccount();
            }
        }

        private void btnXoaTrongTK_Click(object sender, EventArgs e)
        {
            txtTenTK.Text = "";
        }
    }
}
