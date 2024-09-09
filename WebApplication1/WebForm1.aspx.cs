using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary1;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTinhLuong_Click(object sender, EventArgs e)
        {
            int send = 0;
            try
            {
                double ngay_lam = double.Parse(txtSoNgayLam.Text);
                send = 1;
                double tinhcong = double.Parse(txtTienCong.Text);
                SalaryCalculator calculator = new SalaryCalculator();
                double tongTien = calculator.CalculateSalary(ngay_lam, tinhcong);

                string ketqua = $"{tongTien} VND";
                lblTongLuong.Text = $"{ketqua}";
            }
            catch (Exception ex)
            {
                switch (send)
                {
                    case 0:
                        lblTongLuong.Text = "Có lỗi khi nhập số giờ";
                        break;
                    case 1:
                        lblTongLuong.Text = "Có lỗi khi chọn loại máy";
                        break;
                    case 2:
                        lblTongLuong.Text = "Có lỗi khi nhập thông tin điều hòa";
                        break;
                    default:
                        lblTongLuong.Text = $"Có lỗi không xác định: {ex.Message}";
                        break;
                }

            }
            }
    }
}