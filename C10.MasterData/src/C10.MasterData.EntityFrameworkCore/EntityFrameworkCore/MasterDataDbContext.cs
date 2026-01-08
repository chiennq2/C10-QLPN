using Abp.EntityFrameworkCore;
using C10.MasterData.Domain.DanhMuc.DM_BenhTat;
using C10.MasterData.Domain.DanhMuc.DM_CapToaXu;
using C10.MasterData.Domain.DanhMuc.DM_DanToc;
using C10.MasterData.Domain.DanhMuc.DM_DoTuoi;
using C10.MasterData.Domain.DanhMuc.DM_DuocDacXa;
using C10.MasterData.Domain.DanhMuc.DM_GhiChuRieng;
using C10.MasterData.Domain.DanhMuc.DM_GioiTinh;
using C10.MasterData.Domain.DanhMuc.DM_HinhPhatBoSung;
using C10.MasterData.Domain.DanhMuc.DM_HinhThucChon;
using C10.MasterData.Domain.DanhMuc.DM_HinhThucKhenThuong;
using C10.MasterData.Domain.DanhMuc.DM_HinhThucKyLuat;
using C10.MasterData.Domain.DanhMuc.DM_HocVan;
using C10.MasterData.Domain.DanhMuc.DM_KyXepLoaiCaiTao;
using C10.MasterData.Domain.DanhMuc.DM_LoaiPhanLoai;
using C10.MasterData.Domain.DanhMuc.DM_LoaiQDTDC;
using C10.MasterData.Domain.DanhMuc.DM_LoaiQuyetDinhTrichXuat;
using C10.MasterData.Domain.DanhMuc.DM_LoaiTangGiamHinhPhat;
using C10.MasterData.Domain.DanhMuc.DM_LyDoAnGiam;
using C10.MasterData.Domain.DanhMuc.DM_LyDoGiamRPN;
using C10.MasterData.Domain.DanhMuc.DM_LyDoKhen;
using C10.MasterData.Domain.DanhMuc.DM_LyDoKhongXetGiam;
using C10.MasterData.Domain.DanhMuc.DM_LyDoKyLuat;
using C10.MasterData.Domain.DanhMuc.DM_LyDoTrichXuat;
using C10.MasterData.Domain.DanhMuc.DM_MaPhanLoai;
using C10.MasterData.Domain.DanhMuc.DM_MucAnPhat;
using C10.MasterData.Domain.DanhMuc.DM_NgheNghiep;
using C10.MasterData.Domain.DanhMuc.DM_LoaiPhamNhan;
using C10.MasterData.Domain.DanhMuc.DM_QuanHeVoiPN;
using C10.MasterData.Domain.DanhMuc.DM_QuocTich;
using C10.MasterData.Domain.DanhMuc.DM_SinhConTheoMeVaoTrai;
using C10.MasterData.Domain.DanhMuc.DM_TaiPham;
using C10.MasterData.Domain.DanhMuc.DM_TinhTrangConTheoMeVaoTrai;
using C10.MasterData.Domain.DanhMuc.DM_TinhTrangSucKhoePN;
using C10.MasterData.Domain.DanhMuc.DM_TinhTrangTamDinhChi;
using C10.MasterData.Domain.DanhMuc.DM_TinhTrangTrichXuat;
using C10.MasterData.Domain.DanhMuc.DM_TinhTrangTron;
using C10.MasterData.Domain.DanhMuc.DM_TonGiao;
using C10.MasterData.Domain.DanhMuc.DM_TruongHopBat;
using C10.MasterData.Domain.DanhMuc.DM_TruongHopChet;
using C10.MasterData.Domain.DanhMuc.DM_TruongHopMienHinhPhat;
using C10.MasterData.Domain.DanhMuc.DM_TruongHopTha;
using C10.MasterData.Domain.DanhMuc.DM_TruongHopTron;
using C10.MasterData.Domain.DanhMuc.DM_XepLoaiCaiTao;
using C10.MasterData.Domain.DanhMuc.DM_XuLyBat;
using C10.MasterData.DungChung;
using Microsoft.EntityFrameworkCore;
using C10.MasterData.Domain.DanhMuc.DM_LoaiQuyetDinhGiamGiu;
using C10.MasterData.Domain.DanhMuc.DM_LyDoTamDinhChi;
using C10.MasterData.Domain.DanhMuc.DM_TruongHopChuyenTrai;
using C10.MasterData.Domain.DanhMuc.DM_ToiDanh;

namespace C10.MasterData.EntityFrameworkCore;

public class MasterDataDbContext : AbpDbContext
{
    public DbSet<DM_BenhTat> DM_BenhTats { get; set; }
    public DbSet<DM_CapToaXu> DM_CapToaXus { get; set; }
    public DbSet<DM_DanToc> DM_DanTocs { get; set; }
    public DbSet<DM_GhiChuRieng> DM_GhiChuRiengs { get; set; }
    public DbSet<DM_GioiTinh> DM_GioiTinhs { get; set; }
    public DbSet<DM_HinhPhatBoSung> DM_HinhPhatBoSungs { get; set; }
    public DbSet<DM_HinhThucChon> DM_HinhThucChons { get; set; }
    public DbSet<DM_HinhThucKhenThuong> DM_HinhThucKhenThuongs { get; set; }
    public DbSet<DM_HinhThucKyLuat> DM_HinhThucKyLuats { get; set; }
    public DbSet<DM_XuLyBat> DM_XuLyBats { get; set; }
    public DbSet<DM_HocVan> DM_HocVans { get; set; }
    public DbSet<DM_KyXepLoaiCaiTao> DM_KyXepLoaiCaiTaos { get; set; }
    public DbSet<DM_LoaiQuyetDinhGiamGiu> DM_LoaiQuyetDinhGiamGius { get; set; }
    public DbSet<DM_LoaiQuyetDinhTrichXuat> DM_LoaiQuyetDinhTrichXuats { get; set; }
    public DbSet<DM_LoaiQDTDC> DM_LoaiQDTDCs { get; set; }
    public DbSet<DM_LoaiTangGiamHinhPhat> DM_LoaiTangGiamHinhPhats { get; set; }
    public DbSet<DM_LoaiPhamNhan> DM_LoaiPhamNhans { get; set; }
    public DbSet<DM_LyDoGiamRPN> DM_LyDoGiamRPNs { get; set; }
    public DbSet<DM_LyDoKhen> DM_LyDoKhens { get; set; }
    public DbSet<DM_LyDoKhongXetGiam> DM_LyDoKhongXetGiams { get; set; }
    public DbSet<DM_LyDoKyLuat> DM_LyDoKyLuats { get; set; }
    public DbSet<DM_LyDoTrichXuat> DM_LyDoTrichXuats { get; set; }
    public DbSet<DM_LyDoTamDinhChi> DM_LyDoTamDinhChis { get; set; }
    public DbSet<DM_LyDoAnGiam> DM_LyDoAnGiams { get; set; }
    public DbSet<DM_MaPhanLoai> DM_MaPhanLoais { get; set; }
    public DbSet<DM_QuanHeVoiPN> DM_QuanHeVoiPNs { get; set; }
    public DbSet<DM_NgheNghiep> DM_NgheNghieps { get; set; }
    public DbSet<DM_LoaiPhanLoai> DM_LoaiPhanLoais { get; set; }
    public DbSet<DM_QuocTich> DM_QuocTiches { get; set; }
    public DbSet<DM_MucAnPhat> DM_MucAnPhats { get; set; }
    public DbSet<DM_DoTuoi> DM_DoTuois { get; set; }
    public DbSet<DM_TruongHopBat> DM_TruongHopBats { get; set; }
    public DbSet<DM_TruongHopChuyenTrai> DM_TruongHopChuyenTrais { get; set; }
    public DbSet<DM_TruongHopChet> DM_TruongHopChets { get; set; }
    public DbSet<DM_TruongHopMienHinhPhat> DM_TruongHopMienHinhPhats { get; set; }
    public DbSet<DM_SinhConTheoMeVaoTrai> DM_SinhConTheoMeVaoTrais { get; set; }
    public DbSet<DM_TruongHopTha> DM_TruongHopThas { get; set; }
    public DbSet<DM_TruongHopTron> DM_TruongHopTrons { get; set; }
    public DbSet<DM_TaiPham> DM_TaiPhams { get; set; }
    public DbSet<DM_TinhTrangConTheoMeVaoTrai> DM_TinhTrangConTheoMeVaoTrais { get; set; }
    public DbSet<DM_TinhTrangSucKhoePN> DM_TinhTrangSucKhoePNs { get; set; }
    public DbSet<DM_TinhTrangTrichXuat> DM_TinhTrangTrichXuats { get; set; }
    public DbSet<DM_TinhTrangTron> DM_TinhTrangTrons { get; set; }
    public DbSet<DM_TinhTrangTamDinhChi> DM_TinhTrangTamDinhChis { get; set; }
    public DbSet<DM_TonGiao> DM_TonGiaos { get; set; }
    public DbSet<DM_XepLoaiCaiTao> DM_XepLoaiCaiTaos { get; set; }
    public DbSet<DM_DuocDacXa> DM_DuocDacXas { get; set; }
    public DbSet<DM_ToiDanh> DM_ToiDanhs { get; set; }
    public MasterDataDbContext(DbContextOptions<MasterDataDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<DM_DungChung>();
        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {
            foreach (var property in entityType.GetProperties())
            {
                // Kiểm tra nếu thuộc tính là kiểu bool
                if (property.ClrType == typeof(bool) || property.ClrType == typeof(bool?))
                {
                    // Ép kiểu cột thành NUMBER(1)
                    property.SetColumnType("NUMBER(1)");
                }
            }
        }
    }
}
