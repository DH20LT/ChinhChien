﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using ChinhChien.Forms_QuanLy;
using ChinhChien.DAL_DAO;

namespace ChinhChien.UI
{
    public partial class frmMainUI : Form
    {
        int TrangThaiCuaSo;
        public frmMainUI()
        {
            InitializeComponent();
            if(WindowState == FormWindowState.Normal)
            {
                TrangThaiCuaSo = 0;
            }
        }
        public string TenTaiKhoan
        {
            get;
            set;
        }
        public string TenQuan
        {
            get;
            set;
        }
        public string MaQuan
        {
            get;
            set;
        }
        public frmMainUI(string TenTaiKhoan) : this()
        {
            this.TenTaiKhoan = TenTaiKhoan;
        }

        // Hàm cũ trước khi còn trường LoaiTaiKhoan
        public frmMainUI(string TenTaiKhoan, string LoaiTaiKhoan) : this()
        {
            // Viết hàm khởi tạo này để mang theo dữ liệu khi chạy Form MainUI
            //this.LoaiTaiKhoan = LoaiTaiKhoan;
            this.TenTaiKhoan = TenTaiKhoan;
        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            //this.Text = "";
            mnsiIconTaiKhoan.Text = TenTaiKhoan;
            //lblTenQuan.Text = TenQuan;

            ibtnThongKe.Text = "THỐNG KÊ";
            //ibtnThongKe.IconChar = IconChar.Dashcube;

            //ibtn2.Text = "CHẤM CÔNG"; ibtnNhanDon.IconChar = IconChar.MoneyCheckAlt;

            ibtnNhanDon.Text = "NHẬN ĐƠN";
            //ibtnThongKe.IconChar = IconChar.Receipt;

            //ibtn2.IconChar = IconChar.Boxes;

            ibtnThucDon.Text = "THỰC ĐƠN";
            //ibtnVatTu.IconChar = IconChar.MugHot;

            //ibtn6.Text = "LỊCH LÀM";

            //ibtnNhanDon.IconChar = IconChar.Calendar;

            //ibtn2.IconChar = IconChar.PeopleCarry;

            ShowQuanInCbbChuyenQuan();
        }

        /// <method>
        ///  Hàm để hiện thị các quán khi click vào Chuyển quán
        /// </method>
        void ShowQuanInCbbChuyenQuan()
        {
            // Đổ dữ liệu vào cbbChuyenQuan
            QuanDAO quan = new QuanDAO();
            DataTable dt = quan.searchQuanByTenTaiKhoan(this.TenTaiKhoan);
            cbbChuyenQuan.DataSource = dt;
            cbbChuyenQuan.DisplayMember = "TenQuan";
            cbbChuyenQuan.ValueMember = "MaQuan";
            //cbbChuyenQuan.Text = "Chuyển quán";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form currentChildForm = null;
        private void ibtnThongKe_Click(object sender, EventArgs e)
        {
            MenuAnimation.ActivateButton(sender, MenuAnimation.RGBColors.color1, iconCurrentChildForm);
            MenuAnimation.OpenChildForm(new FormsChuQuan.FormThongKe(), ref currentChildForm, pnlChildForm, labelTittleChildForm);
        }

        // Drag The Form - using System.Runtime.InteropServices;
        [DllImport("user32")]
        private static extern bool ReleaseCapture();
        [DllImport("user32")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wp, int lp);

        private void panelTittleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (TrangThaiCuaSo == 0)
            {
                this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
                this.Location = new System.Drawing.Point(0, 0);
                TrangThaiCuaSo = 1;
            }
            else if (TrangThaiCuaSo == 1)
            {
                this.Location = new System.Drawing.Point(300, 300);
                this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width - 500, Screen.PrimaryScreen.WorkingArea.Height - 250);
                this.CenterToScreen();
                TrangThaiCuaSo = 0;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void DangXuat_Click(object sender, EventArgs e)
        {
            frmLogIn logout = new frmLogIn();
            logout.Show();
            this.Hide();
        }

        private void mnsiCaiDat_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Đang mở Cài Đặt, đợi xíu");
            MenuAnimation.OpenChildForm(new CaiDat(), ref currentChildForm, pnlChildForm, labelTittleChildForm);
        }

        private void mnsiThongTinTaiKhoan_Click(object sender, EventArgs e)
        {
            MenuAnimation.OpenChildForm(new ThongTinTaiKhoan(), ref currentChildForm, pnlChildForm, labelTittleChildForm);
        }

        private void ibtnVatTu_Click(object sender, EventArgs e)
        {
            MenuAnimation.ActivateButton(sender, MenuAnimation.RGBColors.color2, iconCurrentChildForm);
            KhoHang khoHang = new KhoHang();
            khoHang.Owner = this;
            MenuAnimation.OpenChildForm(khoHang, ref currentChildForm, pnlChildForm, labelTittleChildForm);
        }

        private void ibtnThucDon_Click(object sender, EventArgs e)
        {
            MenuAnimation.ActivateButton(sender, MenuAnimation.RGBColors.color3, iconCurrentChildForm);
            ChinhChien.Forms_ChuQuan.QuanLyMenu quanLyMenu = new ChinhChien.Forms_ChuQuan.QuanLyMenu();
            quanLyMenu.Owner = this;
            MenuAnimation.OpenChildForm
                (quanLyMenu, ref currentChildForm, pnlChildForm, labelTittleChildForm);
        }

        private void ibtnNhanSu_Click(object sender, EventArgs e)
        {
            MenuAnimation.ActivateButton(sender, MenuAnimation.RGBColors.color4, iconCurrentChildForm);
            ChinhChien.GUI.NhanSu nhanSu = new ChinhChien.GUI.NhanSu();
            nhanSu.Owner = this;
            MenuAnimation.OpenChildForm
                (nhanSu, ref currentChildForm, pnlChildForm, labelTittleChildForm);
        }

        private void ibtnNhanDon_Click(object sender, EventArgs e)
        {
            MenuAnimation.ActivateButton(sender, MenuAnimation.RGBColors.color5, iconCurrentChildForm);
            MenuAnimation.OpenChildForm
                (new ChinhChien.Forms_NhanVien.TiepNhanDonHang(), ref currentChildForm, pnlChildForm, labelTittleChildForm);
        }

        private void ibtnBaoCao_Click(object sender, EventArgs e)
        {
            MenuAnimation.ActivateButton(sender, MenuAnimation.RGBColors.color5, iconCurrentChildForm);
            MenuAnimation.OpenChildForm
                (new ChinhChien.GUI.BaoCao(), ref currentChildForm, pnlChildForm, labelTittleChildForm);
        }
    }
}