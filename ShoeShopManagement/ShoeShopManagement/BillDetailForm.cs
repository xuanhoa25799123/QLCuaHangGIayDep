using ShoeShopManagement.BLL.BillDetails;
using ShoeShopManagement.BLL.Bills;
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
    public partial class BillDetailForm : Form
    {
        private IUnitOfWork _unitOfWork;
        private IBillDetailService _billDetailService;
        private IBillService _billService;
        private int BranchID;
        private IList<BillDetailModel> _listbillDetail;
        private Bill _billInfo;
        public BillDetailForm(IUnitOfWork unitOfWork, int billID, int branchID)
        {
            _unitOfWork = unitOfWork;
            BranchID = branchID;
            _billService = new BillService(_unitOfWork);
            _billDetailService = new BillDetailService(_unitOfWork);
            if (BranchID == 1)
            {
                _billInfo = _billDetailService.GetBillByID(billID);
                _listbillDetail = _billDetailService.GetBillDetailByBill(billID);
            }
            else
            {
                _billInfo = _billDetailService.GetBillByIDFromRemote(billID);
                _listbillDetail = _billDetailService.GetBillDetailByBillRemote(billID);
            }
            InitializeComponent();
        }

        private void BillDetailForm_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.AutoGenerateColumns = false;
                txtHoTenKhach.Text = _billInfo.CustomerName;
                txtSDT.Text = _billInfo.PhoneNumber;
                txtNgayLap.Text = _billInfo.CheckoutDate.Date.ToString();
                txtGiamGia.Text = _billInfo.Discount.ToString();
                txtTienHang.Text = _billInfo.Total.ToString();
                txtTongThanhTien.Text = (_billInfo.Total - _billInfo.Discount).ToString();
                if (_billInfo.State == false)
                    txtTrangThai.Text = "OK";
                else
                    txtTrangThai.Text = "Đã xóa/hủy";
                dataGridView1.DataSource = _listbillDetail.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra \r\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuyDon_Click(object sender, EventArgs e)
        {
            if (BranchID == 1)
                _billService.DeleteBill(_billInfo.ID);
            else
                _billService.DeleteBillFromRemote(_billInfo.ID);
            BillDetailForm_Load(null, EventArgs.Empty);
        }
    }
}
