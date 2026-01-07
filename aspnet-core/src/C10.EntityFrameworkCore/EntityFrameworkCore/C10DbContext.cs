using Abp.Zero.EntityFrameworkCore;
using C10.Authorization.Roles;
using C10.Authorization.Users;
using C10.Core.DanhMuc.DM_BenhTat;
using C10.Core.DanhMuc.DM_CapToaXu;
using C10.Core.DanhMuc.DM_DanToc;
using C10.Core.DanhMuc.DM_DoTuoi;
using C10.Core.DanhMuc.DM_GhiChuRieng;
using C10.Core.DanhMuc.DM_GioiTinh;
using C10.Core.DanhMuc.DM_HinhPhatBoSung;
using C10.Core.DanhMuc.DM_HinhThucChon;
using C10.Core.DanhMuc.DM_HinhThucKhenThuong;
using C10.Core.DanhMuc.DM_HinhThucKyLuat;
using C10.Core.DanhMuc.DM_HocVan;
using C10.Core.DanhMuc.DM_KyXepLoaiCaiTao;
using C10.Core.DanhMuc.DM_LoaiPhanLoai;
using C10.Core.DanhMuc.DM_LoaiQDTDT;
using C10.Core.DanhMuc.DM_LoaiQuyetDinhTrichXuat;
using C10.Core.DanhMuc.DM_LoaiTangGiamHinhPhat;
using C10.Core.DanhMuc.DM_LyDoAnGiam;
using C10.Core.DanhMuc.DM_LyDoDinhChi;
using C10.Core.DanhMuc.DM_LyDoGiamRPN;
using C10.Core.DanhMuc.DM_LyDoKhen;
using C10.Core.DanhMuc.DM_LyDoKhongXetGiam;
using C10.Core.DanhMuc.DM_LyDoKyLuat;
using C10.Core.DanhMuc.DM_LyDoTrichXuat;
using C10.Core.DanhMuc.DM_MaPhanLoai;
using C10.Core.DanhMuc.DM_MucAnPhat;
using C10.Core.DanhMuc.DM_NgheNghiep;
using C10.Core.DanhMuc.DM_QuanHeVoiPN;
using C10.Core.DanhMuc.DM_QuocTich;
using C10.Core.DanhMuc.DM_TruongHopBat;
using C10.Core.DanhMuc.DM_XuLyBat;
using C10.DanhMuc.DM_DuocDacXa;
using C10.DanhMuc.DM_SinhConTheoMeVaoTrai;
using C10.DanhMuc.DM_TaiPham;
using C10.DanhMuc.DM_TinhTrangConTheoMeVaoTrai;
using C10.DanhMuc.DM_TinhTrangSucKhoePN;
using C10.DanhMuc.DM_TinhTrangTamDinhChi;
using C10.DanhMuc.DM_TinhTrangTrichXuat;
using C10.DanhMuc.DM_TinhTrangTron;
using C10.DanhMuc.DM_TonGiao;
using C10.DanhMuc.DM_TruongHopChet;
using C10.DanhMuc.DM_TruongHopMienHinhPhat;
using C10.DanhMuc.DM_TruongHopTha;
using C10.DanhMuc.DM_TruongHopTron;
using C10.DanhMuc.DM_XepLoaiCaiTao;
using C10.MultiTenancy;
using C10.PhamNhans;
using Microsoft.EntityFrameworkCore;

namespace C10.EntityFrameworkCore;

public class C10DbContext : AbpZeroDbContext<Tenant, Role, User, C10DbContext>
{
    /* Define a DbSet for each entity of the application */
    DbSet<DM_BenhTat> DM_BenhTats { get; set; }
    DbSet<DM_CapToaXu> DM_CapToaXus { get; set; }
    DbSet<DM_DanToc> DM_DanTocs { get; set; }
    DbSet<DM_GhiChuRieng> DM_GhiChuRiengs { get; set; }
    DbSet<DM_GioiTinh> DM_GioiTinhs { get; set; }
    DbSet<DM_HinhPhatBoSung> DM_HinhPhatBoSungs { get; set; }
    DbSet<DM_HinhThucChon> DM_HinhThucChons { get; set; }
    DbSet<DM_HinhThucKhenThuong> DM_HinhThucKhenThuongs { get; set; }
    DbSet<DM_HinhThucKyLuat> DM_HinhThucKyLuats { get; set; }
    DbSet<DM_XuLyBat> DM_XuLyBats { get; set; }
    DbSet<DM_HocVan> DM_HocVans { get; set; }
    DbSet<DM_KyXepLoaiCaiTao> DM_KyXepLoaiCaiTaos { get; set; }
    DbSet<DM_LoaiQuyetDinhTrichXuat> DM_LoaiQuyetDinhTrichXuats { get; set; }
    DbSet<DM_LoaiQDTDT> DM_LoaiQDTDTs { get; set; }
    DbSet<DM_LoaiTangGiamHinhPhat> DM_LoaiTangGiamHinhPhats { get; set; }
    DbSet<DM_LyDoGiamRPN> DM_LyDoGiamRPNs { get; set; }
    DbSet<DM_LyDoKhen> DM_LyDoKhens { get; set; }
    DbSet<DM_LyDoKhongXetGiam> DM_LyDoKhongXetGiams { get; set; }
    DbSet<DM_LyDoKyLuat> DM_LyDoKyLuats { get; set; }
    DbSet<DM_LyDoTrichXuat> DM_LyDoTrichXuats { get; set; }
    DbSet<DM_LyDoDinhChi> DM_LyDoDinhChis { get; set; }
    DbSet<DM_LyDoAnGiam> DM_LyDoAnGiams { get; set; }
    DbSet<DM_MaPhanLoai> DM_MaPhanLoais { get; set; }
    DbSet<DM_QuanHeVoiPN> DM_QuanHeVoiPNs { get; set; }
    DbSet<DM_NgheNghiep> DM_NgheNghieps { get; set; }
    DbSet<DM_LoaiPhanLoai> DM_LoaiPhanLoais { get; set; }
    DbSet<DM_QuocTich> DM_QuocTiches { get; set; }
    DbSet<DM_MucAnPhat> DM_MucAnPhats { get; set; }
    DbSet<DM_TruongHopBat> DM_TruongHopBats { get; set; }
    DbSet<DM_DoTuoi> DM_DoTuois { get; set; }
    DbSet<DM_TruongHopChet> DM_TruongHopChets { get; set; }
    DbSet<DM_TruongHopMienHinhPhat> DM_TruongHopMienHinhPhats { get; set; }
    DbSet<DM_SinhConTheoMeVaoTrai> DM_SinhConTheoMeVaoTrais { get; set; }
    DbSet<DM_TruongHopTha> DM_TruongHopThas { get; set; }
    DbSet<DM_TruongHopTron> DM_TruongHopTrons { get; set; }
    DbSet<DM_TaiPham> DM_TaiPhams { get; set; }
    DbSet<DM_TinhTrangConTheoMeVaoTrai> DM_TinhTrangConTheoMeVaoTrais { get; set; }
    DbSet<DM_TinhTrangSucKhoePN> DM_TinhTrangSucKhoePNs { get; set; }
    DbSet<DM_TinhTrangTrichXuat> DM_TinhTrangTrichXuats { get; set; }
    DbSet<DM_TinhTrangTron> DM_TinhTrangTrons { get; set; }
    DbSet<DM_TinhTrangTamDinhChi> DM_TinhTrangTamDinhChis { get; set; }
    DbSet<DM_TonGiao> DM_TonGiaos { get; set; }
    DbSet<DM_XepLoaiCaiTao> DM_XepLoaiCaiTaos { get; set; }
    DbSet<DM_DuocDacXa> DM_DuocDacXas { get; set; } 
    public DbSet<DanhMucPhamNhan> DanhMucPhamNhans { get; set; }

    public C10DbContext(DbContextOptions<C10DbContext> options)
        : base(options)
    {
    }
}
