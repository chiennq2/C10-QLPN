using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace C10.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoryTables : Migration
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
                    BT_NoiDung = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: true),
                    BT_Code = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: true),
                    BT_IsActive = table.Column<bool>(type: "NUMBER(1)", nullable: false),
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
                    CTX_NoiDung = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: true),
                    CTX_Code = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: true),
                    CTX_IsActive = table.Column<bool>(type: "NUMBER(1)", nullable: false),
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
                    DT_NoiDung = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: true),
                    DT_Code = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: true),
                    DT_IsActive = table.Column<bool>(type: "NUMBER(1)", nullable: false),
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
                    DT_NoiDung = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: true),
                    DT_Code = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: true),
                    DT_TuDoTuoi = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    DT_DenDoTuoi = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    DT_IsActive = table.Column<bool>(type: "NUMBER(1)", nullable: false),
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
                name: "DM_DUOC_DAC_XA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    DDX_NoiDung = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: true),
                    DDX_Code = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: true),
                    DDX_IsActive = table.Column<bool>(type: "NUMBER(1)", nullable: false),
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
                    GCR_NoiDung = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: true),
                    GCR_Code = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: true),
                    GCR_IsActive = table.Column<bool>(type: "NUMBER(1)", nullable: false),
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
                    GT_NoiDung = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: true),
                    GT_Code = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: true),
                    GT_IsActive = table.Column<bool>(type: "NUMBER(1)", nullable: false),
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
                    HPBS_NoiDung = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: true),
                    HPBS_Code = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: true),
                    HPBS_IsActive = table.Column<bool>(type: "NUMBER(1)", nullable: false),
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
                    HTC_NoiDung = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: true),
                    HTC_Code = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: true),
                    HTC_IsActive = table.Column<bool>(type: "NUMBER(1)", nullable: false),
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
                    HTKT_NoiDung = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: true),
                    HTKT_Code = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: true),
                    HTKT_IsActive = table.Column<bool>(type: "NUMBER(1)", nullable: false),
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
                    HTKL_NoiDung = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: true),
                    HTKL_Code = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: true),
                    HTKL_IsActive = table.Column<bool>(type: "NUMBER(1)", nullable: false),
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
                    HV_NoiDung = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: true),
                    HV_Code = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: true),
                    HV_IsActive = table.Column<bool>(type: "NUMBER(1)", nullable: false),
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
                    XLCT_NoiDung = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: true),
                    XLCT_Code = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: true),
                    XLCT_Year = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    XLCT_FromDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    XLCT_ToDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    XLCT_IsActive = table.Column<bool>(type: "NUMBER(1)", nullable: false),
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
                name: "DM_LOAI_PHAN_LOAI",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    LPL_NoiDung = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: true),
                    LPL_Code = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: true),
                    LPL_IsActive = table.Column<bool>(type: "NUMBER(1)", nullable: false),
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
                name: "DM_LOAI_QUYET_DINH_TAM_DINH_TRI",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    LQDTDT_NoiDung = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: true),
                    LQDTDT_Code = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: true),
                    LQDTDT_IsActive = table.Column<bool>(type: "NUMBER(1)", nullable: false),
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
                    table.PrimaryKey("PK_DM_LOAI_QUYET_DINH_TAM_DINH_TRI", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_LOAI_QUYET_DINH_TRICH_XUAT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    LQDTX_NoiDung = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: true),
                    LQDTX_Code = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: true),
                    LQDTX_IsActive = table.Column<bool>(type: "NUMBER(1)", nullable: false),
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
                    LTGHP_NoiDung = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: true),
                    LTGHP_Code = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: true),
                    LTGHP_IsActive = table.Column<bool>(type: "NUMBER(1)", nullable: false),
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
                    LDAG_NoiDung = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: true),
                    LDAG_Code = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: true),
                    LDAG_IsActive = table.Column<bool>(type: "NUMBER(1)", nullable: false),
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
                name: "DM_LY_DO_DINH_CHI",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    LDDC_NoiDung = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: true),
                    LDDC_Code = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: true),
                    LDDC_IsActive = table.Column<bool>(type: "NUMBER(1)", nullable: false),
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
                    table.PrimaryKey("PK_DM_LY_DO_DINH_CHI", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DM_LY_DO_KHEN",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    LDK_NoiDung = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: true),
                    LDK_Code = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: true),
                    LDK_IsActive = table.Column<bool>(type: "NUMBER(1)", nullable: false),
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
                    LDKXG_NoiDung = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: true),
                    LDKXG_Code = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: true),
                    LDKXG_IsActive = table.Column<bool>(type: "NUMBER(1)", nullable: false),
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
                    LDKL_NoiDung = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: true),
                    LDKL_Code = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: true),
                    LDKL_IsActive = table.Column<bool>(type: "NUMBER(1)", nullable: false),
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
                    LDRGPN_NoiDung = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: true),
                    LDRGPN_Code = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: true),
                    LDRGPN_IsActive = table.Column<bool>(type: "NUMBER(1)", nullable: false),
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
                name: "DM_LY_DO_TRICH_XUAT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    LDTX_NoiDung = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: true),
                    LDTX_Code = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: true),
                    LDTX_IsActive = table.Column<bool>(type: "NUMBER(1)", nullable: false),
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
                    MPL_NoiDung = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: true),
                    MPL_Code = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: true),
                    MPL_IsActive = table.Column<bool>(type: "NUMBER(1)", nullable: false),
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
                    MAP_NoiDung = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: true),
                    MAP_Code = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: true),
                    MAP_TuMucAn = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    MAP_DenMucAn = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    MAP_IsActive = table.Column<bool>(type: "NUMBER(1)", nullable: false),
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
                    NN_NoiDung = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: true),
                    NN_Code = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: true),
                    NN_IsActive = table.Column<bool>(type: "NUMBER(1)", nullable: false),
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
                    QHVPN_Code = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: true),
                    QHVPN_NoiDung = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: true),
                    QHVPN_GioiTinhId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    QHVPN_IsActive = table.Column<bool>(type: "NUMBER(1)", nullable: false),
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
                    QT_NoiDung = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: true),
                    QT_Code = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: true),
                    QT_IsActive = table.Column<bool>(type: "NUMBER(1)", nullable: false),
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
                    SCTMVT_NoiDung = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: true),
                    SCTMVT_Code = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: true),
                    SCTMVT_IsActive = table.Column<bool>(type: "NUMBER(1)", nullable: false),
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
                    TP_NoiDung = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: true),
                    TP_Code = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: true),
                    TP_IsActive = table.Column<bool>(type: "NUMBER(1)", nullable: false),
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
                    TTCTMVT_NoiDung = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: true),
                    TTCTMVT_Code = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: true),
                    TTCTMVT_IsActive = table.Column<bool>(type: "NUMBER(1)", nullable: false),
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
                    TTSKPN_NoiDung = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: true),
                    TTSKPN_Code = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: true),
                    TTSKPN_IsActive = table.Column<bool>(type: "NUMBER(1)", nullable: false),
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
                    TTTDC_NoiDung = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: true),
                    TTTDC_Code = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: true),
                    TTTDC_IsActive = table.Column<bool>(type: "NUMBER(1)", nullable: false),
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
                    TTTX_NoiDung = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: true),
                    TTTX_Code = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: true),
                    TTTX_IsActive = table.Column<bool>(type: "NUMBER(1)", nullable: false),
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
                    TTT_NoiDung = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: true),
                    TTT_Code = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: true),
                    TTT_IsActive = table.Column<bool>(type: "NUMBER(1)", nullable: false),
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
                name: "DM_TON_GIAO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    TG_NoiDung = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: true),
                    TG_Code = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: true),
                    TG_IsActive = table.Column<bool>(type: "NUMBER(1)", nullable: false),
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
                    THB_NoiDung = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: true),
                    THB_Code = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: true),
                    THB_IsActive = table.Column<bool>(type: "NUMBER(1)", nullable: false),
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
                    THC_NoiDung = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: true),
                    THC_Code = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: true),
                    THC_IsActive = table.Column<bool>(type: "NUMBER(1)", nullable: false),
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
                name: "DM_TRUONG_HOP_MIEN_HINH_PHAT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    THMHP_NoiDung = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: true),
                    THMHP_Code = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: true),
                    THMHP_IsActive = table.Column<bool>(type: "NUMBER(1)", nullable: false),
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
                    THT_NoiDung = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: true),
                    THT_Code = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: true),
                    THT_IsActive = table.Column<bool>(type: "NUMBER(1)", nullable: false),
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
                    THT_NoiDung = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: true),
                    THT_Code = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: true),
                    THT_IsActive = table.Column<bool>(type: "NUMBER(1)", nullable: false),
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
                    XLCT_NoiDung = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: true),
                    XLCT_Code = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: true),
                    XLCT_IsActive = table.Column<bool>(type: "NUMBER(1)", nullable: false),
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
                    XLB_NoiDung = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: true),
                    XLB_Code = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: true),
                    XLB_IsActive = table.Column<bool>(type: "NUMBER(1)", nullable: false),
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
                name: "DM_LOAI_PHAN_LOAI");

            migrationBuilder.DropTable(
                name: "DM_LOAI_QUYET_DINH_TAM_DINH_TRI");

            migrationBuilder.DropTable(
                name: "DM_LOAI_QUYET_DINH_TRICH_XUAT");

            migrationBuilder.DropTable(
                name: "DM_LOAI_TANG_GIAM_HINH_PHAT");

            migrationBuilder.DropTable(
                name: "DM_LY_DO_AN_GIAM");

            migrationBuilder.DropTable(
                name: "DM_LY_DO_DINH_CHI");

            migrationBuilder.DropTable(
                name: "DM_LY_DO_KHEN");

            migrationBuilder.DropTable(
                name: "DM_LY_DO_KHONG_XET_GIAM");

            migrationBuilder.DropTable(
                name: "DM_LY_DO_KY_LUAT");

            migrationBuilder.DropTable(
                name: "DM_LY_DO_RIENG_GIAM_PHAM_NHAN");

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
                name: "DM_TON_GIAO");

            migrationBuilder.DropTable(
                name: "DM_TRUONG_HOP_BAT");

            migrationBuilder.DropTable(
                name: "DM_TRUONG_HOP_CHET");

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
