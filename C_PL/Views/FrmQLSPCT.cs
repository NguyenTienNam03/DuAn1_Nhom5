using B_BUS.IServices;
using B_BUS.Services;
using B_BUS.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_PL.Views
{
    public partial class FrmQLSPCT : Form
    {
        public IChiTietSPService _ictsps;
        public ISanPhamService _isps;
        public IMauSacService _imss;
        public ISizeService _isize;
        public IHangSanXuatService _ihsxs;
        public Validate _check;
        public Guid _id;
        public FrmQLSPCT()
        {
            InitializeComponent();
            _ictsps= new ChiTietSPService();
            _ihsxs= new HangSanXuatService();
            _isize= new SizeService();
            txt_linkanh.Visible = false;
            _check = new Validate();
            _imss= new MauSacService();
            _isps = new SanPhamService();
            LoadSPCT();
            LoadSP();
            LoadSize();
            LoadHSX();
            LoadMS();
            check_con.Checked = true;
            ////Reset();
        }
        public void LoadSPCT()
        {
            dtgridview_sanpham.Rows.Clear();
            dtgridview_sanpham.Columns[0].Visible= false;
            foreach(var x in _ictsps.GetAll())
            {
                var a = _isps.GetAllsp().Find(c => c.IDsp == x.IDSP);
                var b = _imss.GetAllMS().Find(c => c.IDms == x.IDms);
                var c = _isize.GetSizes().Find(c => c.id == x.IDSize);
                var d = _ihsxs.GetAllHSX().Find(c => c.ID == x.IDHSX);
                dtgridview_sanpham.Rows.Add(x.ID , x.MaCTSP , a.TenSp , b.Mau , d.TenHSX , c.SoSize ,x.anh , x.SoLuong , x.GiaNhap , x.GiaBan ,x.Trangthai);
            }
        }
        public void Timkiem(string name)
        {
            dtgridview_sanpham.Rows.Clear();
            dtgridview_sanpham.Columns[0].Visible = false;
            //var a1 = _isps.GetAllsp().Where(c => c.IDsp == ).FirstOrDefault());
            foreach (var x in _ictsps.GetAll().Where(c => c.MaCTSP.Contains(name)  ))
            {
                var a = _isps.GetAllsp().Find(c => c.IDsp == x.IDSP);
                var b = _imss.GetAllMS().Find(c => c.IDms == x.IDms);
                var c = _isize.GetSizes().Find(c => c.id == x.IDSize);
                var d = _ihsxs.GetAllHSX().Find(c => c.ID == x.IDHSX);
                dtgridview_sanpham.Rows.Add(x.ID, x.MaCTSP, a.TenSp, b.Mau, d.TenHSX, c.SoSize, x.anh, x.SoLuong, x.GiaNhap, x.GiaBan , x.Trangthai);
            }
        }

        
        public void Reset()
        {
            txt_giaban.Text = "";
            txt_gianhap.Text = "";
            txt_linkanh.Text = "";
            txt_soluong.Text = "";
            cbb_hsx.Text = "";
            cbb_mausac.Text = "";
            cbb_size.Text = "";
            cbb_tensp.Text = "";
        }
        public void LoadSP()
        {
            cbb_tensp.Items.Clear();
            foreach(var x in _isps.GetAllsp())
            {
                cbb_tensp.Items.Add(x.TenSp);
            }
        }
        public void LoadSize()
        {
            cbb_size.Items.Clear();
            foreach(var x in _isize.GetSizes())
            {
                cbb_size.Items.Add(x.SoSize);
            }
        }
        public void LoadHSX()
        {
            cbb_hsx.Items.Clear ();
            foreach(var x in _ihsxs.GetAllHSX())
            {
                cbb_hsx.Items.Add(x.TenHSX);
            }
        }
        public void LoadMS()
        {
            cbb_mausac.Items.Clear();
            foreach(var x in _imss.GetAllMS())
            {
                cbb_mausac.Items.Add(x.Mau);
            }
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            
            try
            {
                //checktrungsp();
                var tensp = _isps.GetAllsp().FirstOrDefault(c => c.TenSp == cbb_tensp.Text);
                var mausac = _imss.GetAllMS().FirstOrDefault(c => c.Mau == cbb_mausac.Text);
                var hangsx = _ihsxs.GetAllHSX().FirstOrDefault(c => c.TenHSX == cbb_hsx.Text);
                var size = _isize.GetSizes().FirstOrDefault(c => c.SoSize == Convert.ToInt32(cbb_size.Text));
                if (_ictsps.GetAll().Any(c => c.IDSP == tensp.IDsp && c.IDms == mausac.IDms && c.IDHSX == hangsx.ID && c.IDSize == size.id) == true)
                {
                    MessageBox.Show("Sản phẩm này đã có trong danh sách sản phẩm.");
                    return;
                }else 
                if (_check.CheckSoNguyenduong(txt_soluong.Text) == false)
                {
                    MessageBox.Show("Mời bạn nhập đúng số lượng.");
                    return;
                }
                else if (_check.CheckSoNguyenduong(txt_giaban.Text) == false)
                {
                    MessageBox.Show("Mời bạn nhập đúng giá bán .");
                    return;
                }
                else if (_check.CheckSoNguyenduong(txt_gianhap.Text) == false)
                {
                    MessageBox.Show("Mời bạn nhập đúng giá nhập.");
                    return;
                } else if( (decimal)Convert.ToDouble(txt_giaban.Text) < (decimal)Convert.ToDouble(txt_gianhap.Text))
                {
                    MessageBox.Show("Giá bán phải lớn hơn giá nhập.");
                    return;
                }
                else if (_check.checkRong(cbb_hsx.Text) == false || _check.checkRong(cbb_mausac.Text) == false || _check.checkRong(cbb_size.Text) == false || _check.checkRong(cbb_tensp.Text) == false)
                {
                    MessageBox.Show("Mời bạn điền đầy đủ thông tin màu sắc , hãng sản xuất , size , tên sản phẩm .");
                    return;
                }
                else
                {

                    DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm sản phẩm này không ?", "Thông báo", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        MessageBox.Show(_ictsps.AddCTSP(new A_DAL.Models.ChiTietSanPham()
                        {
                            Id = Guid.NewGuid(),
                            MaSPCT = "CTSP" + Convert.ToString(_ictsps.GetAll().Count + 1),
                            IDSP = _isps.GetAllsp().Where(c => c.TenSp == cbb_tensp.Text).Select(c => c.IDsp).FirstOrDefault(),
                            IDMauSac = _imss.GetAllMS().Where(c => c.Mau == cbb_mausac.Text).Select(c => c.IDms).FirstOrDefault(),
                            IDHSX = _ihsxs.GetAllHSX().Where(c => c.TenHSX == cbb_hsx.Text).Select(c => c.ID).FirstOrDefault(),
                            IDSize = _isize.GetSizes().Where(c => c.SoSize == Convert.ToInt32(cbb_size.Text)).Select(c => c.id).FirstOrDefault(),
                            Anh = txt_linkanh.Text,
                            SoLuong = Convert.ToInt32(txt_soluong.Text),
                            GiaBan = (decimal)Convert.ToDouble(txt_giaban.Text),
                            GiaNhap = (decimal)Convert.ToDouble(txt_gianhap.Text),
                            TrangThai = check_con.Checked == true ? "Còn hàng " : "Hết hàng",
                        }));

                        LoadSPCT();
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show("Thêm sản phẩm chi tiết thất bại.");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Mời bạn thao tác lại.");
            }
            
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                if (_check.CheckSoNguyenduong(txt_soluong.Text) == false)
                {
                    MessageBox.Show("Mời bạn nhập đúng số lượng.");
                    return;
                }
                else if (_check.CheckSoNguyenduong(txt_giaban.Text) == false)
                {
                    MessageBox.Show("Mời bạn nhập đúng giá bán .");
                    return;
                }
                else if (_check.CheckSoNguyenduong(txt_gianhap.Text) == false)
                {
                    MessageBox.Show("Mời bạn nhập đúng giá nhập.");
                    return;
                }
                else if (_check.checkRong(cbb_hsx.Text) == false || _check.checkRong(cbb_mausac.Text) == false || _check.checkRong(cbb_size.Text) == false || _check.checkRong(cbb_tensp.Text) == false)
                {
                    MessageBox.Show("Mời bạn điền đầy đủ thông tin màu sắc , hãng sản xuất , size , tên sản phẩm .");
                    return;
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có muốn cập nhật sản phẩm này không ?", "Thông báo", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        MessageBox.Show(_ictsps.UpdateCRSP(_id , new A_DAL.Models.ChiTietSanPham()
                        {
                            //Id = Guid.NewGuid(),
                            //MaSPCT = "CTSP" + Convert.ToString(_ictsps.GetAll().Count + 1),
                            IDSP = _isps.GetAllsp().Where(c => c.TenSp == cbb_tensp.Text).Select(c => c.IDsp).FirstOrDefault(),
                            IDMauSac = _imss.GetAllMS().Where(c => c.Mau == cbb_mausac.Text).Select(c => c.IDms).FirstOrDefault(),
                            IDHSX = _ihsxs.GetAllHSX().Where(c => c.TenHSX == cbb_hsx.Text).Select(c => c.ID).FirstOrDefault(),
                            IDSize = _isize.GetSizes().Where(c => c.SoSize == Convert.ToInt32(cbb_size.Text)).Select(c => c.id).FirstOrDefault(),
                            Anh = txt_linkanh.Text,
                            SoLuong = Convert.ToInt32(txt_soluong.Text),
                            GiaBan = (decimal)Convert.ToDouble(txt_giaban.Text),
                            GiaNhap = (decimal)Convert.ToDouble(txt_gianhap.Text),
                            TrangThai = check_con.Checked == true ? "Còn hàng" : "Hết hàng",
                        }));
                        LoadSPCT();
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật sản phẩm chi tiết thất bại.");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Mời bạn thao tác lại .");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xoá sản phẩm này không ?", "Thông báo ", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show(_ictsps.DeleteCTSP(_id));
                    LoadSPCT();
                    Reset();
                }
                else
                {
                    MessageBox.Show("Xoá sản phẩm thất bại.");
                }
            }
            catch
            {
                MessageBox.Show("Mời bạn thao tác lại .");
            }
        }

        private void ptb_themsp_Click(object sender, EventArgs e)
        {
            FrmSanPham frmSanPham = new FrmSanPham();
            frmSanPham.ShowDialog();
        }

        private void ptb_themms_Click(object sender, EventArgs e)
        {
            frmMauSac frmMauSac = new frmMauSac();
            frmMauSac.ShowDialog();
        }

        private void ptb_themhsx_Click(object sender, EventArgs e)
        {
            FrmHangSX frmHangSX = new FrmHangSX();
            frmHangSX.ShowDialog();
        }

        private void ptb_themsize_Click(object sender, EventArgs e)
        {
            FrmSize frmSize = new FrmSize();
            frmSize.ShowDialog();
        }

        private void txt_timkiem_KeyUp(object sender, KeyEventArgs e)
        {
            Timkiem(txt_timkiem.Text);
        }

        private void dtgridview_sanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dtgridview_sanpham.Rows[e.RowIndex];
            if (r.Cells[0].Value == null)
            {
                return;
            }else
            {
                _id = Guid.Parse(r.Cells[0].Value.ToString());
                cbb_tensp.Text = Convert.ToString(r.Cells[2].Value.ToString());
                cbb_mausac.Text = Convert.ToString(r.Cells[3].Value);
                cbb_hsx.Text = Convert.ToString(r.Cells[4].Value.ToString());
                cbb_size.Text = Convert.ToString(Convert.ToInt32(r.Cells[5].Value));
                txt_linkanh.Text = Convert.ToString(r.Cells[6].Value);

                var layanh = _ictsps.GetAll().FirstOrDefault(p => p.anh == txt_linkanh.Text);
                ptb_anh.Image = Image.FromFile(layanh.anh);

                txt_soluong.Text = Convert.ToString(Convert.ToInt32(r.Cells[7].Value));
                txt_gianhap.Text = Convert.ToString((decimal)r.Cells[8].Value);
                txt_giaban.Text = Convert.ToString((decimal)r.Cells[9].Value);
                check_con.Checked = (r.Cells[10].Value.ToString()) == "Còn hàng" ? true : false;
                check_hethang.Checked = r.Cells[10].Value.ToString() == "Hết hàng" ? true : false;
            }
        }

        private void btn_doianh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog(); 
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png ";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txt_linkanh.Text = openFileDialog.FileName;
                ptb_anh.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void check_hethang_CheckedChanged(object sender, EventArgs e)
        {
            if(check_hethang.Checked == true)
            {
                check_con.Checked = false;
            }
            else
            {
                check_con.Checked = true;
            }
        }

        private void check_con_CheckedChanged(object sender, EventArgs e)
        {
            if (check_con.Checked == true)
            {
                check_hethang.Checked = false;
            }
            else
            {
                check_hethang.Checked = true;
            }
        }

        private void ptb_loadlai_Click(object sender, EventArgs e)
        {
            Reset();
            LoadHSX();
            LoadMS();
            LoadSize();
            LoadSP();
            LoadSPCT();
        }
    }
}
