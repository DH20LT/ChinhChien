﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ChinhChien.DAL_DAO;
using ChinhChien.GUI;

namespace ChinhChien.Forms_NhanVien
{
    public partial class TiepNhanDonHang : Form
    {
        public TiepNhanDonHang()
        {
            InitializeComponent();
            HienSanPham("Trà sữa");
        }
        string chuoiketnoi = Properties.Settings.Default.ChinhChienConnectionString;
        string sqlcode;
        string MaHoaDon;
        HoaDonDAO hoaDonDAO = new HoaDonDAO();
        ThongBao tbao = new ThongBao();

        SqlConnection ketnoi;

        public void NhapSanPham()
        {
            
        }
        private void HienMenu()
        {
            ketnoi = new SqlConnection(chuoiketnoi);
            sqlcode = "SELECT * FROM SanPham";
            ketnoi.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sqlcode, ketnoi);
            DataTable dttb = new DataTable();
            sda.Fill(dttb);
            ketnoi.Close();

            foreach (DataRow row in dttb.Rows)
            {
                var uc = new ButtonSanPham
                {
                    TenSanPham = row["TenSanPham"].ToString(),
                };
            }
        }
        
        int TaoMaHoaDon()
        {
            // Kiểm Tra Mã Hóa Đơn Mới Nhất, Lấy mã HD đó +1
            int MaHoaDonMoiNhat = hoaDonDAO.searchRecentMaHoaDon();
            return MaHoaDonMoiNhat + 1;
        }

        
        private void btnTypeTraSua_Click(object sender, EventArgs e)
        {
            HienSanPham("Trà sữa");
        }

        void HienSanPham(string Loai)
        {
            lvSanPhamTheoLoai.Items.Clear();
            string query = "SELECT TenSanPham, Gia, MaSanPham FROM SanPham where Loai = N'"+ Loai +"'";
            int i = 0;
            SqlDataReader table = DataProvider.ReturnSqlDataReader(query);
            while (table.Read())
            {
                lvSanPhamTheoLoai.Items.Add(table["TenSanPham"].ToString());
                lvSanPhamTheoLoai.Items[i].SubItems.Add(table["Gia"].ToString());
                lvSanPhamTheoLoai.Items[i].SubItems.Add(table["MaSanPham"].ToString());
                i++;
            }
            table.Close();
        }

        private void lvSanPhamTheoLoai_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //NhapCapnhatSoLuong nhapSL = new NhapCapnhatSoLuong();
            //nhapSL.ShowDialog();
            int i;
            if (!KiemTraSanPhamTonTai(lvSanPhamTheoLoai.SelectedItems[0].SubItems[1].Text.ToString(), out i))
            {
                //
                Console.WriteLine(i);
                lvThongTinHoaDon.Items.Add(lvSanPhamTheoLoai.SelectedItems[0].Text.ToString());
                lvThongTinHoaDon.Items[lvThongTinHoaDon.Items.Count - 1].SubItems.Add(lvSanPhamTheoLoai.SelectedItems[0].SubItems[1].Text.ToString());
                int DonGia = int.Parse(lvSanPhamTheoLoai.SelectedItems[0].SubItems[1].Text.ToString());
                lvThongTinHoaDon.Items[lvThongTinHoaDon.Items.Count - 1].SubItems.Add("1");
                lvThongTinHoaDon.Items[lvThongTinHoaDon.Items.Count - 1].SubItems.Add(DonGia.ToString());
                lvThongTinHoaDon.Items[lvThongTinHoaDon.Items.Count - 1].SubItems.Add(lvSanPhamTheoLoai.SelectedItems[0].SubItems[2].Text.ToString());
                tbao.Hien(lblThongBao, "Thêm một món thành công");
                tmDisableThongBao.Start();
                tmDisableThongBao.Enabled = true;

            }
            else
            {
                lvThongTinHoaDon.Items[i].SubItems[0].Text = (int.Parse(lvThongTinHoaDon.Items[i].Text) + 1).ToString();
                lblThongBao.Text = "Đã cộng dồn số lượng vào món đã tồn tại";
            }

        }

        bool KiemTraSanPhamTonTai(string TenSanPham, out int i)
        {
            // Nếu có thì cộng số lượng thêm một
            bool KetQua = false;
            for (i = 1; i < lvThongTinHoaDon.Items.Count; i++)
            {
                if (TenSanPham == lvThongTinHoaDon.Items[i].ToString())
                {
                    KetQua = true;
                    break;
                }
                else
                {
                    break;
                }
            }
            return KetQua;
        }
        
        private void btnTypeCaPhe_Click(object sender, EventArgs e)
        {
            HienSanPham("Cà phê");
        }

        private void btnThanhTien_Click(object sender, EventArgs e)
        {
            MaHoaDon = TaoMaHoaDon().ToString();
            hoaDonDAO.addHoaDon(MaHoaDon, "1111", DateTime.Now);
            foreach (ListViewItem item in lvThongTinHoaDon.Items)
            {
                hoaDonDAO.addChiTietHoaDon(item.SubItems[4].Text, MaHoaDon, int.Parse(item.SubItems[2].Text), decimal.Parse(item.SubItems[3].Text));
            }
            lblThongBao.Text = "Thêm Hóa Đơn Thành Công";
        }

        private void lvThongTinHoaDon_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void btnTypeTopping_Click(object sender, EventArgs e)
        {
            HienSanPham("Topping");
        }

        private void tmDisableThongBao_Tick(object sender, EventArgs e)
        {
            lblThongBao.Visible = false;
            tmDisableThongBao.Stop();
        }
    }
}
