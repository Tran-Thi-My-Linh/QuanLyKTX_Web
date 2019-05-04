namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QLKyTucXaDbContext : DbContext
    {
        public QLKyTucXaDbContext(string db)
            : base(db)
        {
        }

        public virtual DbSet<BAIVIET> BAIVIETs { get; set; }
        public virtual DbSet<CHITIETBAOHONG> CHITIETBAOHONGs { get; set; }
        public virtual DbSet<CHITIETHOADONDDK> CHITIETHOADONDDKs { get; set; }
        public virtual DbSet<CHITIETTNXTB> CHITIETTNXTBs { get; set; }
        public virtual DbSet<DICHVU> DICHVUs { get; set; }
        public virtual DbSet<DICHVUPHONG> DICHVUPHONGs { get; set; }
        public virtual DbSet<DIENNUOC> DIENNUOCs { get; set; }
        public virtual DbSet<DOTDANGKI> DOTDANGKIs { get; set; }
        public virtual DbSet<HOADONDDK> HOADONDDKs { get; set; }
        public virtual DbSet<HOADONDICHVUDINHKI> HOADONDICHVUDINHKIs { get; set; }
        public virtual DbSet<HOADONDICHVUPHONG> HOADONDICHVUPHONGs { get; set; }
        public virtual DbSet<KHOA> KHOAs { get; set; }
        public virtual DbSet<KHOANTHUDAUVAO> KHOANTHUDAUVAOs { get; set; }
        public virtual DbSet<KHOANTHUDDK> KHOANTHUDDKs { get; set; }
        public virtual DbSet<KHUNHA> KHUNHAs { get; set; }
        public virtual DbSet<LOAITHUCHI> LOAITHUCHIs { get; set; }
        public virtual DbSet<LOP> LOPs { get; set; }
        public virtual DbSet<MANHINH> MANHINHs { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<NGUOIDUNG> NGUOIDUNGs { get; set; }
        public virtual DbSet<NGUYENVONG> NGUYENVONGs { get; set; }
        public virtual DbSet<NHOMNGUOIDUNG> NHOMNGUOIDUNGs { get; set; }
        public virtual DbSet<PHANQUYEN> PHANQUYENs { get; set; }
        public virtual DbSet<PHIEUBAOHONG> PHIEUBAOHONGs { get; set; }
        public virtual DbSet<PHIEUDANGKI> PHIEUDANGKIs { get; set; }
        public virtual DbSet<PHIEUDIENNUOC> PHIEUDIENNUOCs { get; set; }
        public virtual DbSet<PHIEULUUTRU> PHIEULUUTRUs { get; set; }
        public virtual DbSet<PHIEUNHAPXUATTHIETBI> PHIEUNHAPXUATTHIETBIs { get; set; }
        public virtual DbSet<PHONG> PHONGs { get; set; }
        public virtual DbSet<SINHVIEN> SINHVIENs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TANG> TANGs { get; set; }
        public virtual DbSet<THIETBI> THIETBIs { get; set; }
        public virtual DbSet<THIETBIPHONG> THIETBIPHONGs { get; set; }
        public virtual DbSet<THUCHI> THUCHIs { get; set; }
        public virtual DbSet<TRANGTHAIPHIEUDANGKI> TRANGTHAIPHIEUDANGKIs { get; set; }
        public virtual DbSet<UUTIEN> UUTIENs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BAIVIET>()
                .Property(e => e.NoiDung)
                .IsUnicode(false);

            modelBuilder.Entity<BAIVIET>()
                .Property(e => e.HinhAnh)
                .IsUnicode(false);

            modelBuilder.Entity<DICHVU>()
                .HasMany(e => e.DICHVUPHONGs)
                .WithRequired(e => e.DICHVU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DICHVU>()
                .HasMany(e => e.HOADONDICHVUPHONGs)
                .WithMany(e => e.DICHVUs)
                .Map(m => m.ToTable("CHITIETHOADONDICHVU").MapLeftKey("IDDichVu").MapRightKey("IDHoaDonDV"));

            modelBuilder.Entity<DICHVUPHONG>()
                .Property(e => e.IDPhong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DOTDANGKI>()
                .HasMany(e => e.KHOANTHUDDKs)
                .WithRequired(e => e.DOTDANGKI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DOTDANGKI>()
                .HasMany(e => e.PHIEUDANGKIs)
                .WithRequired(e => e.DOTDANGKI)
                .HasForeignKey(e => e.IDDotDangKy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOADONDDK>()
                .HasMany(e => e.CHITIETHOADONDDKs)
                .WithRequired(e => e.HOADONDDK)
                .HasForeignKey(e => e.IDHoaDonDDK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOADONDICHVUDINHKI>()
                .Property(e => e.IDPhong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOADONDICHVUPHONG>()
                .Property(e => e.ThanhTien)
                .IsFixedLength();

            modelBuilder.Entity<HOADONDICHVUPHONG>()
                .Property(e => e.IDPhong)
                .IsFixedLength();

            modelBuilder.Entity<HOADONDICHVUPHONG>()
                .Property(e => e.IDThuChi)
                .IsFixedLength();

            modelBuilder.Entity<HOADONDICHVUPHONG>()
                .Property(e => e.NhanVienLap)
                .IsFixedLength();

            modelBuilder.Entity<KHOA>()
                .Property(e => e.IDKhoa)
                .IsUnicode(false);

            modelBuilder.Entity<KHOANTHUDAUVAO>()
                .HasMany(e => e.KHOANTHUDDKs)
                .WithRequired(e => e.KHOANTHUDAUVAO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHOANTHUDDK>()
                .HasMany(e => e.CHITIETHOADONDDKs)
                .WithRequired(e => e.KHOANTHUDDK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOP>()
                .Property(e => e.IDLop)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LOP>()
                .Property(e => e.IDKhoa)
                .IsUnicode(false);

            modelBuilder.Entity<MANHINH>()
                .HasMany(e => e.PHANQUYENs)
                .WithRequired(e => e.MANHINH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Menu>()
                .Property(e => e.Link)
                .IsUnicode(false);

            modelBuilder.Entity<Menu>()
                .Property(e => e.Icon)
                .IsUnicode(false);

            modelBuilder.Entity<Menu>()
                .Property(e => e.ThuocTinh)
                .IsUnicode(false);

            modelBuilder.Entity<NGUOIDUNG>()
                .Property(e => e.IDNguoiDung)
                .IsUnicode(false);

            modelBuilder.Entity<NGUOIDUNG>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<NGUOIDUNG>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<NGUOIDUNG>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<NGUOIDUNG>()
                .HasMany(e => e.THUCHIs)
                .WithOptional(e => e.NGUOIDUNG)
                .HasForeignKey(e => e.IDNhanVienThuChi);

            modelBuilder.Entity<NGUYENVONG>()
                .HasMany(e => e.PHIEUDANGKIs)
                .WithOptional(e => e.NGUYENVONG)
                .HasForeignKey(e => e.NV3);

            modelBuilder.Entity<NGUYENVONG>()
                .HasMany(e => e.PHIEUDANGKIs1)
                .WithOptional(e => e.NGUYENVONG1)
                .HasForeignKey(e => e.NV2);

            modelBuilder.Entity<NGUYENVONG>()
                .HasMany(e => e.PHIEUDANGKIs2)
                .WithOptional(e => e.NGUYENVONG2)
                .HasForeignKey(e => e.NV1);

            modelBuilder.Entity<NHOMNGUOIDUNG>()
                .HasMany(e => e.PHANQUYENs)
                .WithRequired(e => e.NHOMNGUOIDUNG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEUBAOHONG>()
                .Property(e => e.IDPhong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUBAOHONG>()
                .HasMany(e => e.CHITIETBAOHONGs)
                .WithRequired(e => e.PHIEUBAOHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEUDANGKI>()
                .Property(e => e.IDSinhVien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUDIENNUOC>()
                .Property(e => e.IDPhong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEULUUTRU>()
                .Property(e => e.IDSinhVien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEULUUTRU>()
                .Property(e => e.IDPhong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUNHAPXUATTHIETBI>()
                .Property(e => e.NhanVienNhap)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUNHAPXUATTHIETBI>()
                .HasMany(e => e.CHITIETTNXTBs)
                .WithRequired(e => e.PHIEUNHAPXUATTHIETBI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHONG>()
                .Property(e => e.IDPhong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHONG>()
                .Property(e => e.NguyenVongPhong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHONG>()
                .HasMany(e => e.PHIEUBAOHONGs)
                .WithRequired(e => e.PHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHONG>()
                .HasMany(e => e.PHIEULUUTRUs)
                .WithRequired(e => e.PHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHONG>()
                .HasMany(e => e.THIETBIPHONGs)
                .WithRequired(e => e.PHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SINHVIEN>()
                .Property(e => e.IDSinhVien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SINHVIEN>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<SINHVIEN>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<SINHVIEN>()
                .Property(e => e.IDLop)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SINHVIEN>()
                .HasMany(e => e.PHIEUDANGKIs)
                .WithRequired(e => e.SINHVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SINHVIEN>()
                .HasMany(e => e.PHIEULUUTRUs)
                .WithRequired(e => e.SINHVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<THIETBI>()
                .HasMany(e => e.CHITIETBAOHONGs)
                .WithRequired(e => e.THIETBI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<THIETBI>()
                .HasMany(e => e.CHITIETTNXTBs)
                .WithRequired(e => e.THIETBI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<THIETBI>()
                .HasMany(e => e.THIETBIPHONGs)
                .WithRequired(e => e.THIETBI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<THIETBIPHONG>()
                .Property(e => e.IDPhong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<THUCHI>()
                .Property(e => e.IDNhanVienThuChi)
                .IsUnicode(false);

            modelBuilder.Entity<TRANGTHAIPHIEUDANGKI>()
                .HasMany(e => e.PHIEUDANGKIs)
                .WithOptional(e => e.TRANGTHAIPHIEUDANGKI)
                .HasForeignKey(e => e.TrangThai);
        }
    }
}
