using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace C10.MasterData.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoryTableV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DM_BENH_TAT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    BT_Ten = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    BT_Ma = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    BT_Trang_Thai = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_BENH_TAT", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_CAP_TOA_XU",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    CTX_Ten = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    CTX_Ma = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    CTX_Trang_Thai = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_CAP_TOA_XU", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_DAN_TOC",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    DT_Ten = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    DT_Ma = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    DT_Trang_Thai = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_DAN_TOC", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_DO_TUOI",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    DTU_Ten = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    DTU_Ma = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    DTU_Tu_Tuoi = table.Column<int>(type: "NUMBER(10)", maxLength: 10, nullable: true),
                    DTU_Den_Tuoi = table.Column<int>(type: "NUMBER(10)", maxLength: 10, nullable: true),
                    DTU_Trang_Thai = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_DO_TUOI", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_DungChung",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    Title = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    DanToc = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    GioiTinh = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    StatusId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_DungChung", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_DUOC_DAC_XA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    DDX_Ten = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    DDX_Ma = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    DDX_Trang_Thai = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_DUOC_DAC_XA", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_GHI_CHU_RIENG",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    GCR_Ten = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    GCR_Ma = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    GCR_Trang_Thai = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_GHI_CHU_RIENG", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_GIOI_TINH",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    GT_Ten = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    GT_Ma = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    GT_Trang_Thai = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_GIOI_TINH", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_HINH_PHAT_BO_SUNG",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    HPBS_Ten = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    HPBS_Ma = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    HPBS_Trang_Thai = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_HINH_PHAT_BO_SUNG", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_HINH_THUC_CHON",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    HTC_Ten = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    HTC_Ma = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    HTC_Trang_Thai = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_HINH_THUC_CHON", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_HINH_THUC_KHEN_THUONG",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    HTKT_Ten = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    HTKT_Ma = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    HTKT_Trang_Thai = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_HINH_THUC_KHEN_THUONG", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_HINH_THUC_KY_LUAT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    HTKL_Ten = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    HTKL_Ma = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    HTKL_Trang_Thai = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_HINH_THUC_KY_LUAT", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_HOC_VAN",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    HV_Ten = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    HV_Ma = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    HV_Trang_Thai = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_HOC_VAN", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_KY_XEP_LOAI_CAI_TAO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    KXLCT_Ten = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    KXLCT_Ma = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    KXLCT_Year = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    KXLCT_FromDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    KXLCT_ToDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    KXLCT_Trang_Thai = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_KY_XEP_LOAI_CAI_TAO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_LOAI_PHAM_NHAN",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    LPN_Ma = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    LPN_Ten = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    LPN_Trang_Thai = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_LOAI_PHAM_NHAN", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_LOAI_PHAN_LOAI",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    LPL_Ten = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    LPL_Ma = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    LPL_Trang_Thai = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_LOAI_PHAN_LOAI", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_LOAI_QUYET_DINH_GIAM_GIU",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    LQDGG_Ten = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    LQDGG_Ma = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    LQDGG_Trang_Thai = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_LOAI_QUYET_DINH_GIAM_GIU", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_LOAI_QUYET_DINH_TAM_DINH_CHI",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    LQDTDC_Ten = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    LQDTDC_Ma = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    LQDTDC_Trang_Thai = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_LOAI_QUYET_DINH_TAM_DINH_CHI", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_LOAI_QUYET_DINH_TRICH_XUAT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    LQDTX_Ten = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    LQDTX_Ma = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    LQDTX_Trang_Thai = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_LOAI_QUYET_DINH_TRICH_XUAT", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_LOAI_TANG_GIAM_HINH_PHAT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    LTGHP_Ten = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    LTGHP_Ma = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    LTGHP_Trang_Thai = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_LOAI_TANG_GIAM_HINH_PHAT", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_LY_DO_AN_GIAM",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    LDAG_Ten = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    LDAG_Ma = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    LDAG_Trang_Thai = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_LY_DO_AN_GIAM", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_LY_DO_KHEN",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    LDK_Ten = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    LDK_Ma = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    LDK_Trang_Thai = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_LY_DO_KHEN", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_LY_DO_KHONG_XET_GIAM",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    LDKXG_Ten = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    LDKXG_Ma = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    LDKXG_Trang_Thai = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_LY_DO_KHONG_XET_GIAM", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_LY_DO_KY_LUAT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    LDKL_Ten = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    LDKL_Ma = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    LDKL_Trang_Thai = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_LY_DO_KY_LUAT", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_LY_DO_RIENG_GIAM_PHAM_NHAN",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    LDRGPN_Ten = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    LDRGPN_Ma = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    LDRGPN_Trang_Thai = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_LY_DO_RIENG_GIAM_PHAM_NHAN", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_LY_DO_TAM_DINH_CHI",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    LDTDC_Ten = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    LDTDC_Ma = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    LDTDC_Trang_Thai = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_LY_DO_TAM_DINH_CHI", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_LY_DO_TRICH_XUAT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    LDTX_Ten = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    LDTX_Ma = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    LDTX_Trang_Thai = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_LY_DO_TRICH_XUAT", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_MA_PHAN_LOAI",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    MPL_Ten = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    MPL_Ma = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    MPL_Trang_Thai = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_MA_PHAN_LOAI", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_MUC_AN_PHAT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    MAP_Ten = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    MAP_Ma = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    MAP_Tu_Muc_An = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    MAP_Den_Muc_An = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    MAP_Trang_Thai = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_MUC_AN_PHAT", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_NGHE_NGHIEP",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NN_Ten = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    NN_Ma = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    NN_Trang_Thai = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_NGHE_NGHIEP", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_QUAN_HE_VOI_PHAM_NHAN",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    QHVPN_Ma = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    QHVPN_Ten = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    QHVPN_Trang_Thai = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_QUAN_HE_VOI_PHAM_NHAN", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_QUOC_TICH",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    QT_Ten = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    QT_Ma = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    QT_Trang_Thai = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_QUOC_TICH", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_SINH_CON_THEO_ME_VAO_TRAI",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    SCTMVT_Ten = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    SCTMVT_Ma = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    SCTMVT_Trang_Thai = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_SINH_CON_THEO_ME_VAO_TRAI", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_TAI_PHAM",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    TP_Ten = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    TP_Ma = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    TP_Trang_Thai = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_TAI_PHAM", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_TINH_TRANG_CON_THEO_ME_VAO_TRAI",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    TTCTMVT_Ten = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    TTCTMVT_Ma = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    TTCTMVT_Trang_Thai = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_TINH_TRANG_CON_THEO_ME_VAO_TRAI", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_TINH_TRANG_SUC_KHOE_PHAM_NHAN",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    TTSKPN_Ten = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    TTSKPN_Ma = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    TTSKPN_Trang_Thai = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_TINH_TRANG_SUC_KHOE_PHAM_NHAN", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_TINH_TRANG_TAM_DINH_CHI",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    TTTDC_Ten = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    TTTDC_Ma = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    TTTDC_Trang_Thai = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_TINH_TRANG_TAM_DINH_CHI", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_TINH_TRANG_TRICH_XUAT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    TTTX_Ten = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    TTTX_Ma = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    TTTX_Trang_Thai = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_TINH_TRANG_TRICH_XUAT", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_TINH_TRANG_TRON",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    TTT_Ten = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    TTT_Ma = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    TTT_Trang_Thai = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_TINH_TRANG_TRON", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_TOI_DANH",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    TD_Ten = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    TD_Ma = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    TD_Trang_Thai = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    TD_Chuong = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: true),
                    TD_Can_Cu = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_TOI_DANH", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_TON_GIAO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    TG_Ten = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    TG_Ma = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    TG_Trang_Thai = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_TON_GIAO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_TRUONG_HOP_BAT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    THB_Ten = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    THB_Ma = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    THB_Trang_Thai = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_TRUONG_HOP_BAT", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_TRUONG_HOP_CHET",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    THC_Ten = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    THC_Ma = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    THC_Trang_Thai = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_TRUONG_HOP_CHET", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_TRUONG_HOP_CHUYEN_TRAI",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    THCT_Ten = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    THCT_Ma = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    THCT_Trang_Thai = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_TRUONG_HOP_CHUYEN_TRAI", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_TRUONG_HOP_MIEN_HINH_PHAT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    THMHP_Ten = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    THMHP_Ma = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    THMHP_Trang_Thai = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_TRUONG_HOP_MIEN_HINH_PHAT", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_TRUONG_HOP_THA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    THT_Ten = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    THT_Ma = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    THT_Trang_Thai = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_TRUONG_HOP_THA", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_TRUONG_HOP_TRON",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    THT_Ten = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    THT_Ma = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    THT_Trang_Thai = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_TRUONG_HOP_TRON", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_XEP_LOAI_CAI_TAO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    XLCT_Ten = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    XLCT_Ma = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    XLCT_Trang_Thai = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_XEP_LOAI_CAI_TAO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_XU_LY_BAT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    XLB_Ten = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    XLB_Ma = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    XLB_Trang_Thai = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_XU_LY_BAT", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DM_BENH_TAT");

            migrationBuilder.DropTable(
                name: "DM_CAP_TOA_XU");

            migrationBuilder.DropTable(
                name: "DM_DAN_TOC");

            migrationBuilder.DropTable(
                name: "DM_DO_TUOI");

            migrationBuilder.DropTable(
                name: "DM_DungChung");

            migrationBuilder.DropTable(
                name: "DM_DUOC_DAC_XA");

            migrationBuilder.DropTable(
                name: "DM_GHI_CHU_RIENG");

            migrationBuilder.DropTable(
                name: "DM_GIOI_TINH");

            migrationBuilder.DropTable(
                name: "DM_HINH_PHAT_BO_SUNG");

            migrationBuilder.DropTable(
                name: "DM_HINH_THUC_CHON");

            migrationBuilder.DropTable(
                name: "DM_HINH_THUC_KHEN_THUONG");

            migrationBuilder.DropTable(
                name: "DM_HINH_THUC_KY_LUAT");

            migrationBuilder.DropTable(
                name: "DM_HOC_VAN");

            migrationBuilder.DropTable(
                name: "DM_KY_XEP_LOAI_CAI_TAO");

            migrationBuilder.DropTable(
                name: "DM_LOAI_PHAM_NHAN");

            migrationBuilder.DropTable(
                name: "DM_LOAI_PHAN_LOAI");

            migrationBuilder.DropTable(
                name: "DM_LOAI_QUYET_DINH_GIAM_GIU");

            migrationBuilder.DropTable(
                name: "DM_LOAI_QUYET_DINH_TAM_DINH_CHI");

            migrationBuilder.DropTable(
                name: "DM_LOAI_QUYET_DINH_TRICH_XUAT");

            migrationBuilder.DropTable(
                name: "DM_LOAI_TANG_GIAM_HINH_PHAT");

            migrationBuilder.DropTable(
                name: "DM_LY_DO_AN_GIAM");

            migrationBuilder.DropTable(
                name: "DM_LY_DO_KHEN");

            migrationBuilder.DropTable(
                name: "DM_LY_DO_KHONG_XET_GIAM");

            migrationBuilder.DropTable(
                name: "DM_LY_DO_KY_LUAT");

            migrationBuilder.DropTable(
                name: "DM_LY_DO_RIENG_GIAM_PHAM_NHAN");

            migrationBuilder.DropTable(
                name: "DM_LY_DO_TAM_DINH_CHI");

            migrationBuilder.DropTable(
                name: "DM_LY_DO_TRICH_XUAT");

            migrationBuilder.DropTable(
                name: "DM_MA_PHAN_LOAI");

            migrationBuilder.DropTable(
                name: "DM_MUC_AN_PHAT");

            migrationBuilder.DropTable(
                name: "DM_NGHE_NGHIEP");

            migrationBuilder.DropTable(
                name: "DM_QUAN_HE_VOI_PHAM_NHAN");

            migrationBuilder.DropTable(
                name: "DM_QUOC_TICH");

            migrationBuilder.DropTable(
                name: "DM_SINH_CON_THEO_ME_VAO_TRAI");

            migrationBuilder.DropTable(
                name: "DM_TAI_PHAM");

            migrationBuilder.DropTable(
                name: "DM_TINH_TRANG_CON_THEO_ME_VAO_TRAI");

            migrationBuilder.DropTable(
                name: "DM_TINH_TRANG_SUC_KHOE_PHAM_NHAN");

            migrationBuilder.DropTable(
                name: "DM_TINH_TRANG_TAM_DINH_CHI");

            migrationBuilder.DropTable(
                name: "DM_TINH_TRANG_TRICH_XUAT");

            migrationBuilder.DropTable(
                name: "DM_TINH_TRANG_TRON");

            migrationBuilder.DropTable(
                name: "DM_TOI_DANH");

            migrationBuilder.DropTable(
                name: "DM_TON_GIAO");

            migrationBuilder.DropTable(
                name: "DM_TRUONG_HOP_BAT");

            migrationBuilder.DropTable(
                name: "DM_TRUONG_HOP_CHET");

            migrationBuilder.DropTable(
                name: "DM_TRUONG_HOP_CHUYEN_TRAI");

            migrationBuilder.DropTable(
                name: "DM_TRUONG_HOP_MIEN_HINH_PHAT");

            migrationBuilder.DropTable(
                name: "DM_TRUONG_HOP_THA");

            migrationBuilder.DropTable(
                name: "DM_TRUONG_HOP_TRON");

            migrationBuilder.DropTable(
                name: "DM_XEP_LOAI_CAI_TAO");

            migrationBuilder.DropTable(
                name: "DM_XU_LY_BAT");
        }
    }
}
