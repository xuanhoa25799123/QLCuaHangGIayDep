using ShoeShopManagement.BLL.BillDetails;
using ShoeShopManagement.BLL.Bills;
using ShoeShopManagement.BLL.Employees;
using ShoeShopManagement.DAL;
using ShoeShopManagement.Domain;
using ShoeShopManagement.Domain.Models;
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
    public partial class BillForm : Form
    {
        private IUnitOfWork _unitOfWork;
        private IBillService _billService;
        private IEmployeeService _employeeService;
        public BillForm(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _billService = new BillService(_unitOfWork);
            _employeeService = new EmployeeService(_unitOfWork);
            InitializeComponent();
        }
        private void SetComboBox()
        {
            IList < Employee > employees = _employeeService.GetAll();
            Employee employee = new Employee { ID = 0, Name = "Chọn nhân viên" };
            employees.Add(employee);
            cbbNhanVien.DataSource = employees;
            cbbNhanVien.DisplayMember = "Name";
            cbbNhanVien.ValueMember = "ID";
            cbbNhanVien.SelectedValue = 0;
        }
        private void SetComboBoxRemote()
        {
            IList<Employee> employees = _employeeService.GetAllFromRemote();
            Employee employee = new Employee { ID = 0, Name = "Chọn nhân viên" };
            employees.Add(employee);
            cbbNhanVien.DataSource = employees;
            cbbNhanVien.DisplayMember = "Name";
            cbbNhanVien.ValueMember = "ID";
            cbbNhanVien.SelectedValue = 0;
        }
        private void BillForm_Load(object sender, EventArgs e)
        {
            try
            {
                gvHoaDon.AutoGenerateColumns = false;
                cbbChiNhanh.SelectedIndex = WorkingContext.Instance.currentBranchId - 1;
                if (WorkingContext.Instance.CurrentLoginInfo.RoleName != "GIAMDOC") cbbChiNhanh.Enabled = false;
                if (WorkingContext.Instance.CurrentLoginInfo.RoleName == "NHANVIEN") cbbNhanVien.Enabled = false;
                gvHoaDon.DataSource = _billService.GetAll().Select(c => new { c.ID, c.CustomerName, c.PhoneNumber, c.CheckoutDate, c.Discount, c.Total, c.State }).ToList();
            }
            catch (Exception ex)
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
                {
                    gvHoaDon.DataSource = _billService.GetAll().Select(c => new { c.ID, c.CustomerName, c.PhoneNumber, c.CheckoutDate, c.Discount, c.Total, c.State }).ToList();
                    SetComboBox();
                }
                else
                {
                    gvHoaDon.DataSource = _billService.GetAllFromRemote().Select(c => new { c.ID, c.CustomerName, c.PhoneNumber, c.CheckoutDate, c.Discount, c.Total, c.State }).ToList();
                    SetComboBoxRemote();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra \r\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void xemChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int BranchID;
            if (cbbChiNhanh.SelectedIndex == WorkingContext.Instance.currentBranchId - 1)
                BranchID = 1;
            else BranchID = 0;
            int ID = (int)gvHoaDon.SelectedRows[0].Cells[0].Value;
            BillDetailForm form = new BillDetailForm(_unitOfWork, ID, BranchID);
            form.ShowDialog();
        }

        private void gvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;
            if (grid[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
            {
                int BillID = (int)gvHoaDon.SelectedRows[0].Cells["clID"].Value;
                if (cbbChiNhanh.SelectedIndex == WorkingContext.Instance.currentBranchId - 1)
                {
                    _billService.DeleteBill(BillID); 
                }
                else
                {
                    _billService.DeleteBillFromRemote(BillID);
                }
                MessageBox.Show("Xóa hóa đơn thành công", "Thông báo", MessageBoxButtons.OK);
                BillForm_Load(null, EventArgs.Empty);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int employeeID = (int)cbbNhanVien.SelectedValue;
            if (employeeID == 0)
            {
                if (cbbChiNhanh.SelectedIndex == WorkingContext.Instance.currentBranchId - 1)
                    gvHoaDon.DataSource = _billService.GetAll()
                        .Select(c => new { c.ID, c.CustomerName, c.PhoneNumber, c.CheckoutDate, c.Discount, c.Total, c.State })
                        .Where(c => c.CheckoutDate >= dtpFrom.Value
                        && c.CheckoutDate <= dtpTo.Value
                        && c.CustomerName.Contains(txtKhachHang.Text)
                        && c.PhoneNumber.Contains(txtSDT.Text)).ToList();
                else
                    gvHoaDon.DataSource = _billService.GetAllFromRemote()
                        .Select(c => new { c.ID, c.CustomerName, c.PhoneNumber, c.CheckoutDate, c.Discount, c.Total, c.State })
                        .Where(c => c.CheckoutDate >= dtpFrom.Value
                        && c.CheckoutDate <= dtpTo.Value
                        && c.CustomerName.Contains(txtKhachHang.Text)
                        && c.PhoneNumber.Contains(txtSDT.Text)).ToList();

            }
            else
            {
                if (cbbChiNhanh.SelectedIndex == WorkingContext.Instance.currentBranchId - 1)
                    gvHoaDon.DataSource = _billService.GetAll()
                        .Select(c => new { c.ID, c.CustomerName, c.PhoneNumber, c.CheckoutDate, c.Discount, c.Total, c.State, c.EmployeeID })
                        .Where(c => c.CheckoutDate >= dtpFrom.Value
                        && c.CheckoutDate <= dtpTo.Value
                        && c.CustomerName.Contains(txtKhachHang.Text)
                        && c.PhoneNumber.Contains(txtSDT.Text)
                        && c.EmployeeID == employeeID).ToList();
                else
                    gvHoaDon.DataSource = _billService.GetAllFromRemote()
                        .Select(c => new { c.ID, c.CustomerName, c.PhoneNumber, c.CheckoutDate, c.Discount, c.Total, c.State, c.EmployeeID })
                        .Where(c => c.CheckoutDate >= dtpFrom.Value
                        && c.CheckoutDate <= dtpTo.Value
                        && c.CustomerName.Contains(txtKhachHang.Text)
                        && c.PhoneNumber.Contains(txtSDT.Text)
                        && c.EmployeeID == employeeID).ToList();
            }    
        }

        private void txtKhachHang_TextChanged(object sender, EventArgs e)
        {
            int employeeID = (int)cbbNhanVien.SelectedValue;
            if (employeeID == 0)
            {
                if (cbbChiNhanh.SelectedIndex == WorkingContext.Instance.currentBranchId - 1)
                    gvHoaDon.DataSource = _billService.GetAll()
                        .Select(c => new { c.ID, c.CustomerName, c.PhoneNumber, c.CheckoutDate, c.Discount, c.Total, c.State })
                        .Where(c => c.CustomerName.Contains(txtKhachHang.Text) && c.PhoneNumber.Contains(txtSDT.Text)).ToList();
                else
                    gvHoaDon.DataSource = _billService.GetAllFromRemote()
                        .Select(c => new { c.ID, c.CustomerName, c.PhoneNumber, c.CheckoutDate, c.Discount, c.Total, c.State })
                        .Where(c => c.CustomerName.Contains(txtKhachHang.Text) && c.PhoneNumber.Contains(txtSDT.Text)).ToList();
            }
            else
            {
                if (cbbChiNhanh.SelectedIndex == WorkingContext.Instance.currentBranchId - 1)
                    gvHoaDon.DataSource = _billService.GetAll()
                        .Select(c => new { c.ID, c.CustomerName, c.PhoneNumber, c.CheckoutDate, c.Discount, c.Total, c.State, c.EmployeeID })
                        .Where(c => c.CustomerName.Contains(txtKhachHang.Text) && c.PhoneNumber.Contains(txtSDT.Text) && c.EmployeeID == employeeID).ToList();
                else
                    gvHoaDon.DataSource = _billService.GetAllFromRemote()
                        .Select(c => new { c.ID, c.CustomerName, c.PhoneNumber, c.CheckoutDate, c.Discount, c.Total, c.State, c.EmployeeID })
                        .Where(c => c.CustomerName.Contains(txtKhachHang.Text) && c.PhoneNumber.Contains(txtSDT.Text) && c.EmployeeID == employeeID).ToList();
            }    
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            int employeeID = (int)cbbNhanVien.SelectedValue;
            if (employeeID == 0)
            {
                if (cbbChiNhanh.SelectedIndex == WorkingContext.Instance.currentBranchId - 1)
                    gvHoaDon.DataSource = _billService.GetAll()
                        .Select(c => new { c.ID, c.CustomerName, c.PhoneNumber, c.CheckoutDate, c.Discount, c.Total, c.State })
                        .Where(c => c.CustomerName.Contains(txtKhachHang.Text) && c.PhoneNumber.Contains(txtSDT.Text)).ToList();
                else
                    gvHoaDon.DataSource = _billService.GetAllFromRemote()
                        .Select(c => new { c.ID, c.CustomerName, c.PhoneNumber, c.CheckoutDate, c.Discount, c.Total, c.State })
                        .Where(c => c.CustomerName.Contains(txtKhachHang.Text) && c.PhoneNumber.Contains(txtSDT.Text)).ToList();
            }
            else
            {
                if (cbbChiNhanh.SelectedIndex == WorkingContext.Instance.currentBranchId - 1)
                    gvHoaDon.DataSource = _billService.GetAll()
                        .Select(c => new { c.ID, c.CustomerName, c.PhoneNumber, c.CheckoutDate, c.Discount, c.Total, c.State, c.EmployeeID })
                        .Where(c => c.CustomerName.Contains(txtKhachHang.Text) && c.PhoneNumber.Contains(txtSDT.Text) && c.EmployeeID == employeeID).ToList();
                else
                    gvHoaDon.DataSource = _billService.GetAllFromRemote()
                        .Select(c => new { c.ID, c.CustomerName, c.PhoneNumber, c.CheckoutDate, c.Discount, c.Total, c.State, c.EmployeeID })
                        .Where(c => c.CustomerName.Contains(txtKhachHang.Text) && c.PhoneNumber.Contains(txtSDT.Text) && c.EmployeeID == employeeID).ToList();
            }
        }

        private void btnXemTatCa_Click(object sender, EventArgs e)
        {
            if (cbbChiNhanh.SelectedIndex == WorkingContext.Instance.currentBranchId - 1)
                gvHoaDon.DataSource = _billService.GetAll().Select(c => new { c.ID, c.CustomerName, c.PhoneNumber, c.CheckoutDate, c.Discount, c.Total, c.State }).ToList();
            else
                gvHoaDon.DataSource = _billService.GetAllFromRemote().Select(c => new { c.ID, c.CustomerName, c.PhoneNumber, c.CheckoutDate, c.Discount, c.Total, c.State }).ToList();
        }

        private void cbbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            int employeeID = 0;
            if (cbbNhanVien.SelectedValue is Employee)
                return;
            employeeID = (int)cbbNhanVien.SelectedValue;
            if (employeeID == 0)
            {
                if (cbbChiNhanh.SelectedIndex == WorkingContext.Instance.currentBranchId - 1)
                    gvHoaDon.DataSource = _billService.GetAll()
                        .Select(c => new { c.ID, c.CustomerName, c.PhoneNumber, c.CheckoutDate, c.Discount, c.Total, c.State })
                        .Where(c => c.CustomerName.Contains(txtKhachHang.Text) && c.PhoneNumber.Contains(txtSDT.Text)).ToList();
                else
                    gvHoaDon.DataSource = _billService.GetAllFromRemote()
                        .Select(c => new { c.ID, c.CustomerName, c.PhoneNumber, c.CheckoutDate, c.Discount, c.Total, c.State })
                        .Where(c => c.CustomerName.Contains(txtKhachHang.Text) && c.PhoneNumber.Contains(txtSDT.Text)).ToList();
            }
            else
            {
                if (cbbChiNhanh.SelectedIndex == WorkingContext.Instance.currentBranchId - 1)
                    gvHoaDon.DataSource = _billService.GetAll()
                        .Select(c => new { c.ID, c.CustomerName, c.PhoneNumber, c.CheckoutDate, c.Discount, c.Total, c.State, c.EmployeeID })
                        .Where(c => c.CustomerName.Contains(txtKhachHang.Text) && c.PhoneNumber.Contains(txtSDT.Text) && c.EmployeeID == employeeID).ToList();
                else
                    gvHoaDon.DataSource = _billService.GetAllFromRemote()
                        .Select(c => new { c.ID, c.CustomerName, c.PhoneNumber, c.CheckoutDate, c.Discount, c.Total, c.State, c.EmployeeID })
                        .Where(c => c.CustomerName.Contains(txtKhachHang.Text) && c.PhoneNumber.Contains(txtSDT.Text) && c.EmployeeID == employeeID).ToList();
            }    
        }
    }
}
