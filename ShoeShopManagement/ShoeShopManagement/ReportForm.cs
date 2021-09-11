using ShoeShopManagement.BLL.Report;
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
    public partial class ReportForm : Form
    {
        private IUnitOfWork _unitOfWork;
        private IReportService _reportService;
        private ISalesReportService _salesReportService;
        public ReportForm(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _reportService = new ReportService(_unitOfWork);
            _salesReportService = new SalesReportService(_unitOfWork);
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            try
            {
                numSLToiThieu.Value = 5;
                gvMatHangDaBan.AutoGenerateColumns = false;
                gvSapHet.AutoGenerateColumns = false;
                cbbChiNhanh.SelectedIndex = WorkingContext.Instance.currentBranchId - 1;
                cbbChiNhanhSapHet.SelectedIndex = WorkingContext.Instance.currentBranchId - 1;
                if (WorkingContext.Instance.CurrentLoginInfo.RoleName != "GIAMDOC")
                {
                    cbbChiNhanh.Enabled = false;
                    cbbChiNhanhSapHet.Enabled = false;
                }
                gvMatHangDaBan.DataSource = _reportService.GetProductReport();
                gvSapHet.DataSource = _reportService.GetProductEmpty((int)numSLToiThieu.Value);
                SalesReportModel salesInfo = _salesReportService.GetSalesReport();
                lblSoDonHang.Text = salesInfo.SoLuong.ToString();
                lblTongTienBan.Text = salesInfo.TongBanHang.ToString();
                lblTongTienGiamGia.Text = salesInfo.TongGiamGia.ToString();
                lblTongDoanhThu.Text = (salesInfo.TongBanHang - salesInfo.TongGiamGia).ToString();
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
                    gvMatHangDaBan.DataSource = _reportService.GetProductReport();
                    SalesReportModel salesInfo = _salesReportService.GetSalesReport();
                    lblSoDonHang.Text = salesInfo.SoLuong.ToString();
                    lblTongTienBan.Text = salesInfo.TongBanHang.ToString();
                    lblTongTienGiamGia.Text = salesInfo.TongGiamGia.ToString();
                    lblTongDoanhThu.Text = (salesInfo.TongBanHang - salesInfo.TongGiamGia).ToString();
                }
                else if (cbbChiNhanh.SelectedIndex == 2)
                {
                    IList<ProductReportModel> list = _reportService.GetProductReport().Union(_reportService.GetProductReportFromRemote()).ToList();
                    gvMatHangDaBan.DataSource = list.GroupBy(k => k.Name).Select(c => new ProductReportModel
                    {
                        Name = c.Key,
                        Quantity = c.Sum(x => x.Quantity),
                        IntoMoney = c.Sum(x => x.IntoMoney)
                    }).ToList();
                    SalesReportModel salesInfo1 = _salesReportService.GetSalesReport();
                    SalesReportModel salesInfo2 = _salesReportService.GetSalesReportFromRemote();
                    lblSoDonHang.Text = (salesInfo1.SoLuong + salesInfo2.SoLuong).ToString();
                    lblTongTienBan.Text = (salesInfo1.TongBanHang + salesInfo2.TongBanHang).ToString();
                    lblTongTienGiamGia.Text = (salesInfo1.TongGiamGia + salesInfo2.TongGiamGia).ToString();
                    lblTongDoanhThu.Text = ((salesInfo1.TongBanHang - salesInfo1.TongGiamGia) + (salesInfo2.TongBanHang - salesInfo2.TongGiamGia)).ToString();
                }
                else
                {
                    gvMatHangDaBan.DataSource = _reportService.GetProductReportFromRemote();
                    SalesReportModel salesInfo = _salesReportService.GetSalesReportFromRemote();
                    lblSoDonHang.Text = salesInfo.SoLuong.ToString();
                    lblTongTienBan.Text = salesInfo.TongBanHang.ToString();
                    lblTongTienGiamGia.Text = salesInfo.TongGiamGia.ToString();
                    lblTongDoanhThu.Text = (salesInfo.TongBanHang - salesInfo.TongGiamGia).ToString();
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra \r\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbChiNhanh.SelectedIndex == WorkingContext.Instance.currentBranchId - 1)
                {
                    gvMatHangDaBan.DataSource = _reportService.GetProductReportByDate(dtpFrom.Value, dtpTo.Value);
                    SalesReportModel salesInfo = _salesReportService.GetSalesReportByDate(dtpFrom.Value, dtpTo.Value);
                    lblSoDonHang.Text = salesInfo.SoLuong.ToString();
                    lblTongTienBan.Text = salesInfo.TongBanHang.ToString();
                    lblTongTienGiamGia.Text = salesInfo.TongGiamGia.ToString();
                    lblTongDoanhThu.Text = (salesInfo.TongBanHang - salesInfo.TongGiamGia).ToString();
                }
                else if (cbbChiNhanh.SelectedIndex == 2)
                {
                    IList<ProductReportModel> list = _reportService.GetProductReportByDate(dtpFrom.Value, dtpTo.Value).Union(_reportService.GetProductReportByDateFromRemote(dtpFrom.Value, dtpTo.Value)).ToList();
                    gvMatHangDaBan.DataSource = list.GroupBy(k => k.Name).Select(c => new ProductReportModel
                    {
                        Name = c.Key,
                        Quantity = c.Sum(x => x.Quantity),
                        IntoMoney = c.Sum(x => x.IntoMoney)
                    }).ToList();
                    SalesReportModel salesInfo1 = _salesReportService.GetSalesReportByDate(dtpFrom.Value, dtpTo.Value);
                    SalesReportModel salesInfo2 = _salesReportService.GetSalesReportByDateFromRemote(dtpFrom.Value, dtpTo.Value);
                    lblSoDonHang.Text = (salesInfo1.SoLuong + salesInfo2.SoLuong).ToString();
                    lblTongTienBan.Text = (salesInfo1.TongBanHang + salesInfo2.TongBanHang).ToString();
                    lblTongTienGiamGia.Text = (salesInfo1.TongGiamGia + salesInfo2.TongGiamGia).ToString();
                    lblTongDoanhThu.Text = ((salesInfo1.TongBanHang - salesInfo1.TongGiamGia) + (salesInfo2.TongBanHang - salesInfo2.TongGiamGia)).ToString();
                }
                else
                {
                    gvMatHangDaBan.DataSource = _reportService.GetProductReportByDateFromRemote(dtpFrom.Value, dtpTo.Value);
                    SalesReportModel salesInfo = _salesReportService.GetSalesReportByDateFromRemote(dtpFrom.Value, dtpTo.Value);
                    lblSoDonHang.Text = salesInfo.SoLuong.ToString();
                    lblTongTienBan.Text = salesInfo.TongBanHang.ToString();
                    lblTongTienGiamGia.Text = salesInfo.TongGiamGia.ToString();
                    lblTongDoanhThu.Text = (salesInfo.TongBanHang - salesInfo.TongGiamGia).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không có hóa đơn nào trong khoảng thời gian này", "Thông báo", MessageBoxButtons.OK);
                lblSoDonHang.Text = "";
                lblTongDoanhThu.Text = "";
                lblTongTienBan.Text = "";
                lblTongTienGiamGia.Text = "";
            }
        }

        private void cbbChiNhanhSapHet_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbChiNhanhSapHet.SelectedIndex == WorkingContext.Instance.currentBranchId - 1)
                {
                    gvSapHet.DataSource = _reportService.GetProductEmpty((int)numSLToiThieu.Value).Select(c=> new { c.Name, c.Price, c.Quantity, c.Size }).ToList();
                }
                else
                {
                    gvSapHet.DataSource = _reportService.GetProductEmptyFromRemote((int)numSLToiThieu.Value).Select(c => new { c.Name, c.Price, c.Quantity, c.Size }).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra \r\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void numSLToiThieu_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbChiNhanhSapHet.SelectedIndex == WorkingContext.Instance.currentBranchId - 1)
                {
                    gvSapHet.DataSource = _reportService.GetProductEmpty((int)numSLToiThieu.Value).Select(c => new { c.Name, c.Price, c.Quantity, c.Size }).ToList();
                }
                else
                {
                    gvSapHet.DataSource = _reportService.GetProductEmptyFromRemote((int)numSLToiThieu.Value).Select(c => new { c.Name, c.Price, c.Quantity, c.Size }).ToList();
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
