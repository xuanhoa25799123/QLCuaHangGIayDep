using ShoeShopManagement.BLL.Employees;
using ShoeShopManagement.BLL.Statistic;
using ShoeShopManagement.DAL;
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
    public partial class StatisticForm : Form
    {
        private IUnitOfWork _unitOfWork;
        private ICustomerStatisticService customerStatisticService;
        private IEmployeeStatisticService employeeStatisticService;
        private IProductStatisticService productStatisticService;
        private IEmployeeService employeeService;
        public StatisticForm(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            customerStatisticService = new CustomerStatisticService(_unitOfWork);
            employeeStatisticService = new EmployeeStatisticService(_unitOfWork);
            productStatisticService = new ProductStatisticService(_unitOfWork);
            employeeService = new EmployeeService(_unitOfWork);
            InitializeComponent();
        }

        private void StatisticForm_Load(object sender, EventArgs e)
        {
            try
            {
                gvNhanVienBest.AutoGenerateColumns = false;
                gvNhanVienWorst.AutoGenerateColumns = false;
                gvSanPhamDTCao.AutoGenerateColumns = false;
                gvSPBanChay.AutoGenerateColumns = false;
                cbbChiNhanh.SelectedIndex = WorkingContext.Instance.currentBranchId - 1;
                cbbChiNhanhKH.SelectedIndex = WorkingContext.Instance.currentBranchId - 1;
                cbbChiNhanhNV.SelectedIndex = WorkingContext.Instance.currentBranchId - 1;
                if (WorkingContext.Instance.CurrentLoginInfo.RoleName != "GIAMDOC")
                {
                    cbbChiNhanh.Enabled = false;
                    cbbChiNhanhKH.Enabled = false;
                    cbbChiNhanhNV.Enabled = false;
                }
                gvKHMuaNhieu.DataSource = customerStatisticService.GetMostBuyCustomer();
                gvNhanVienBest.DataSource = employeeStatisticService.GetMostSellEmployee();
                gvNhanVienWorst.DataSource = employeeStatisticService.GetNoSellEmployee().Select(c => new { c.Name, c.PhoneNumber, c.BranchName }).ToList();
                gvSanPhamDTCao.DataSource = productStatisticService.GetMostSalesProduct();
                gvSPBanChay.DataSource = productStatisticService.GetHotProduct();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra \r\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void cbbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Now;
            dtpTo.Value = DateTime.Now;
            try
            {
                if (cbbChiNhanh.SelectedIndex == WorkingContext.Instance.currentBranchId - 1)
                {
                    gvSanPhamDTCao.DataSource = productStatisticService.GetMostSalesProduct();
                    gvSPBanChay.DataSource = productStatisticService.GetHotProduct();
                }
                else if (cbbChiNhanh.SelectedIndex == 2)
                {
                    IList<ProductStatisticModel> listMSP = productStatisticService.GetMostSalesProduct().Union(productStatisticService.GetMostSalesProductFromRemote()).ToList();
                    gvSanPhamDTCao.DataSource = listMSP.GroupBy(k => k.Name).Select(c => new ProductStatisticModel
                    {
                        Name = c.Key,
                        Total = c.Sum(x=>x.Total)
                    }).Take(5).ToList();
                    IList<ProductStatisticModel> listHP = productStatisticService.GetHotProduct().Union(productStatisticService.GetHotProductFromRemote()).ToList();
                    gvSPBanChay.DataSource = listHP.GroupBy(k => k.Name).Select(c => new ProductStatisticModel
                    {
                        Name = c.Key,
                        Total = c.Sum(x => x.Total)
                    }).Take(5).ToList();
                }
                else
                {
                    gvSanPhamDTCao.DataSource = productStatisticService.GetMostSalesProductFromRemote();
                    gvSPBanChay.DataSource = productStatisticService.GetHotProductFromRemote();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra \r\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void btnTheoNgay_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbChiNhanh.SelectedIndex == WorkingContext.Instance.currentBranchId - 1)
                {
                    gvSanPhamDTCao.DataSource = productStatisticService.GetHotProductByDate(dtpFrom.Value, dtpTo.Value);
                    gvSPBanChay.DataSource = productStatisticService.GetHotProductByDate(dtpFrom.Value, dtpTo.Value);
                }
                else if (cbbChiNhanh.SelectedIndex == 2)
                {
                    IList<ProductStatisticModel> listMSP = productStatisticService.GetMostSalesProductByDate(dtpFrom.Value, dtpTo.Value).Union(productStatisticService.GetMostSalesProductByDateFromRemote(dtpFrom.Value, dtpTo.Value)).ToList();
                    gvSanPhamDTCao.DataSource = listMSP.GroupBy(k => k.Name).Select(c => new ProductStatisticModel
                    {
                        Name = c.Key,
                        Total = c.Sum(x => x.Total)
                    }).Take(5).ToList();
                    IList<ProductStatisticModel> listHP = productStatisticService.GetHotProductByDate(dtpFrom.Value, dtpTo.Value).Union(productStatisticService.GetHotProductByDateFromRemote(dtpFrom.Value, dtpTo.Value)).ToList();
                    gvSPBanChay.DataSource = listHP.GroupBy(k => k.Name).Select(c => new ProductStatisticModel
                    {
                        Name = c.Key,
                        Total = c.Sum(x => x.Total)
                    }).Take(5).ToList();
                }
                else
                {
                    gvSanPhamDTCao.DataSource = productStatisticService.GetHotProductByDateFromRemote(dtpFrom.Value, dtpTo.Value);
                    gvSPBanChay.DataSource = productStatisticService.GetHotProductByDateFromRemote(dtpFrom.Value, dtpTo.Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra \r\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void btnTKeKH_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbChiNhanhKH.SelectedIndex == WorkingContext.Instance.currentBranchId - 1)
                {
                    gvKHMuaNhieu.DataSource = customerStatisticService.GetMostBuyCustomerByDate(dtpFromKH.Value, dtpToKH.Value);
                }
                else if (cbbChiNhanhKH.SelectedIndex == 2)
                {
                    IList<CustomerStatisticModel> listCtm = customerStatisticService.GetMostBuyCustomerByDate(dtpFromKH.Value, dtpToKH.Value).Union(customerStatisticService.GetMostBuyCustomerByDateFromRemote(dtpFromKH.Value, dtpToKH.Value)).ToList();
                    gvKHMuaNhieu.DataSource = listCtm.GroupBy(k => new { k.CustomerName, k.PhoneNumber }).Select(c => new CustomerStatisticModel
                    {
                        CustomerName = c.Key.CustomerName,
                        PhoneNumber = c.Key.PhoneNumber,
                        Total = c.Sum(x => x.Total)
                    }).OrderByDescending(c => c.Total).Take(10).ToList();
                }
                else
                {
                    gvKHMuaNhieu.DataSource = customerStatisticService.GetMostBuyCustomerByDateFromRemote(dtpFromKH.Value, dtpToKH.Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra \r\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void cbbChiNhanhKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtpFromKH.Value = DateTime.Now;
            dtpToKH.Value = DateTime.Now;
            try
            {
                if (cbbChiNhanhKH.SelectedIndex == WorkingContext.Instance.currentBranchId - 1)
                {
                    gvKHMuaNhieu.DataSource = customerStatisticService.GetMostBuyCustomer();
                }
                else if (cbbChiNhanhKH.SelectedIndex == 2)
                {
                    IList<CustomerStatisticModel> listCtm = customerStatisticService.GetMostBuyCustomer().Union(customerStatisticService.GetMostBuyCustomerFromRemote()).ToList();
                    gvKHMuaNhieu.DataSource = listCtm.GroupBy(k => new { k.CustomerName, k.PhoneNumber }).Select(c => new CustomerStatisticModel
                    {
                        CustomerName = c.Key.CustomerName,
                        PhoneNumber = c.Key.PhoneNumber,
                        Total = c.Sum(x => x.Total)
                    }).OrderByDescending(c=>c.Total).Take(10).ToList();
                }
                else
                {
                    gvKHMuaNhieu.DataSource = customerStatisticService.GetMostBuyCustomerFromRemote();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra \r\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void btnTKeNV_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbChiNhanhNV.SelectedIndex == WorkingContext.Instance.currentBranchId - 1)
                {
                    gvNhanVienBest.DataSource = employeeStatisticService.GetMostSellEmployeeByDate(dtpFromNV.Value, dtpToNV.Value);
                    gvNhanVienWorst.DataSource = employeeStatisticService.GetNoSellEmployeeByDate(dtpFromNV.Value, dtpToNV.Value).Select(c => new { c.Name, c.PhoneNumber, c.BranchName }).ToList();
                }
                else if (cbbChiNhanhNV.SelectedIndex == 2)
                {
                    gvNhanVienBest.DataSource = employeeStatisticService.GetMostSellEmployeeByDate(dtpFromNV.Value, dtpToNV.Value).Union(employeeStatisticService.GetMostSellEmployeeByDateFromRemote(dtpFromNV.Value, dtpToNV.Value)).OrderByDescending(c => c.TotalMoney).Take(5).ToList();
                    gvNhanVienWorst.DataSource = employeeStatisticService.GetNoSellEmployeeByDate(dtpFromNV.Value, dtpToNV.Value).Union(employeeStatisticService.GetNoSellEmployeeByDateFromRemote(dtpFromNV.Value, dtpToNV.Value)).Select(c => new { c.Name, c.PhoneNumber, c.BranchName }).ToList();
                }
                else
                {
                    gvNhanVienBest.DataSource = employeeStatisticService.GetMostSellEmployeeByDateFromRemote(dtpFromNV.Value, dtpToNV.Value);
                    gvNhanVienWorst.DataSource = employeeStatisticService.GetNoSellEmployeeByDateFromRemote(dtpFromNV.Value, dtpToNV.Value).Select(c => new { c.Name, c.PhoneNumber, c.BranchName }).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra \r\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void cbbChiNhanhNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtpFromNV.Value = DateTime.Now;
            dtpToNV.Value = DateTime.Now;
            try
            {
                if (cbbChiNhanhNV.SelectedIndex == WorkingContext.Instance.currentBranchId - 1)
                {
                    gvNhanVienBest.DataSource = employeeStatisticService.GetMostSellEmployee();
                    gvNhanVienWorst.DataSource = employeeStatisticService.GetNoSellEmployee().Select(c => new { c.Name, c.PhoneNumber, c.BranchName }).ToList();
                }
                else if (cbbChiNhanhNV.SelectedIndex == 2)
                {
                    gvNhanVienBest.DataSource = employeeStatisticService.GetMostSellEmployee().Union(employeeStatisticService.GetMostSellEmployeeFromRemote()).OrderByDescending(c=>c.TotalMoney).Take(5).ToList();
                    gvNhanVienWorst.DataSource = employeeStatisticService.GetNoSellEmployee().Union(employeeStatisticService.GetNoSellEmployeeFromRemote()).Select(c => new { c.Name, c.PhoneNumber, c.BranchName }).ToList();
                }
                else
                {
                    gvNhanVienBest.DataSource = employeeStatisticService.GetMostSellEmployeeFromRemote();
                    gvNhanVienWorst.DataSource = employeeStatisticService.GetNoSellEmployeeFromRemote().Select(c => new { c.Name, c.PhoneNumber, c.BranchName }).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra \r\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
        }
    }
}
