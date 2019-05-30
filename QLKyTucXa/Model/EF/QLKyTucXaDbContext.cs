namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QLKyTucXaDbContext : DbContext
    {
        public QLKyTucXaDbContext()
            : base("name=QLKyTucXaDbContext")
        {
        }

        public virtual DbSet<BAIVIET> BAIVIETs { get; set; }
        public virtual DbSet<CHITIETBAOHONG> CHITIETBAOHONGs { get; set; }
        public virtual DbSet<CHITIETHOADONDDK> CHITIETHOADONDDKs { get; set; }
        public virtual DbSet<CHITIETHOADONPHONG> CHITIETHOADONPHONGs { get; set; }
        public virtual DbSet<CHITIETTNXTB> CHITIETTNXTBs { get; set; }
        public virtual DbSet<DICHVU> DICHVUs { get; set; }
        public virtual DbSet<DICHVUPHONG> DICHVUPHONGs { get; set; }
        public virtual DbSet<DOTDANGKI> DOTDANGKIs { get; set; }
        public virtual DbSet<HOADONPHONG> HOADONPHONGs { get; set; }
        public virtual DbSet<KHOA> KHOAs { get; set; }
        public virtual DbSet<KHOANTHUDAUVAO> KHOANTHUDAUVAOs { get; set; }
        public virtual DbSet<KHOANTHUDDK> KHOANTHUDDKs { get; set; }
        public virtual DbSet<KHUNHA> KHUNHAs { get; set; }
        public virtual DbSet<LOAITHUCHI> LOAITHUCHIs { get; set; }
        public virtual DbSet<LOP> LOPs { get; set; }
        public virtual DbSet<MANHINH> MANHINHs { get; set; }
        public virtual DbSet<NGUOIDUNG> NGUOIDUNGs { get; set; }
        public virtual DbSet<NGUYENVONG> NGUYENVONGs { get; set; }
        public virtual DbSet<NHOMNGUOIDUNG> NHOMNGUOIDUNGs { get; set; }
        public virtual DbSet<PHANQUYEN> PHANQUYENs { get; set; }
        public virtual DbSet<PHIEUBAOHONG> PHIEUBAOHONGs { get; set; }
        public virtual DbSet<PHIEUDANGKI> PHIEUDANGKIs { get; set; }
        public virtual DbSet<PHIEUDIENNUOC> PHIEUDIENNUOCs { get; set; }
        public virtual DbSet<PHIEULUUTRU> PHIEULUUTRUs { get; set; }
        public virtual DbSet<PHIEUXINROI> PHIEUXINROIs { get; set; }
        public virtual DbSet<PHONG> PHONGs { get; set; }
        public virtual DbSet<SINHVIEN> SINHVIENs { get; set; }
        public virtual DbSet<TANG> TANGs { get; set; }
        public virtual DbSet<THIETBI> THIETBIs { get; set; }
        public virtual DbSet<THIETBIPHONG> THIETBIPHONGs { get; set; }
        public virtual DbSet<THUCHI> THUCHIs { get; set; }
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
                .HasMany(e => e.CHITIETHOADONPHONGs)
                .WithRequired(e => e.DICHVU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DICHVU>()
                .HasMany(e => e.DICHVUPHONGs)
                .WithRequired(e => e.DICHVU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DICHVU>()
                .HasMany(e => e.PHIEUDIENNUOCs)
                .WithRequired(e => e.DICHVU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DICHVUPHONG>()
                .Property(e => e.IDPhong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DICHVUPHONG>()
                .Property(e => e.GhiChu)
                .IsFixedLength();

            modelBuilder.Entity<DOTDANGKI>()
                .HasMany(e => e.KHOANTHUDDKs)
                .WithRequired(e => e.DOTDANGKI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DOTDANGKI>()
                .HasMany(e => e.PHIEUDANGKIs)
                .WithRequired(e => e.DOTDANGKI)
                .HasForeignKey(e => e.IDDotDangKy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOADONPHONG>()
                .Property(e => e.IDPhong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOADONPHONG>()
                .HasMany(e => e.CHITIETHOADONPHONGs)
                .WithRequired(e => e.HOADONPHONG)
                .WillCascadeOnDelete(false);

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

            modelBuilder.Entity<LOAITHUCHI>()
                .HasMany(e => e.THUCHIs)
                .WithRequired(e => e.LOAITHUCHI)
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
                .WithRequired(e => e.NGUOIDUNG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NGUYENVONG>()
                .HasMany(e => e.SINHVIENs)
                .WithOptional(e => e.NGUYENVONG)
                .HasForeignKey(e => e.NV1);

            modelBuilder.Entity<NGUYENVONG>()
                .HasMany(e => e.SINHVIENs1)
                .WithOptional(e => e.NGUYENVONG1)
                .HasForeignKey(e => e.NV2);

            modelBuilder.Entity<NGUYENVONG>()
                .HasMany(e => e.SINHVIENs2)
                .WithOptional(e => e.NGUYENVONG2)
                .HasForeignKey(e => e.NV3);

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

            modelBuilder.Entity<PHIEULUUTRU>()
                .HasMany(e => e.PHIEUXINROIs)
                .WithRequired(e => e.PHIEULUUTRU)
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
                .HasMany(e => e.DICHVUPHONGs)
                .WithRequired(e => e.PHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHONG>()
                .HasMany(e => e.HOADONPHONGs)
                .WithRequired(e => e.PHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHONG>()
                .HasMany(e => e.PHIEUBAOHONGs)
                .WithRequired(e => e.PHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHONG>()
                .HasMany(e => e.PHIEUDIENNUOCs)
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
                .Property(e => e.MatKhau)
                .IsFixedLength();

            modelBuilder.Entity<SINHVIEN>()
                .HasMany(e => e.PHIEUDANGKIs)
                .WithRequired(e => e.SINHVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SINHVIEN>()
                .HasMany(e => e.PHIEULUUTRUs)
                .WithRequired(e => e.SINHVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TANG>()
                .HasMany(e => e.PHONGs)
                .WithRequired(e => e.TANG)
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
                .Property(e => e.IDNguoiDung)
                .IsUnicode(false);

            modelBuilder.Entity<THUCHI>()
                .Property(e => e.IDPhong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<THUCHI>()
                .Property(e => e.IDSinhVien)
                .IsUnicode(false);

            modelBuilder.Entity<THUCHI>()
                .HasMany(e => e.CHITIETHOADONDDKs)
                .WithRequired(e => e.THUCHI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<THUCHI>()
                .HasMany(e => e.CHITIETTNXTBs)
                .WithRequired(e => e.THUCHI)
                .WillCascadeOnDelete(false);
        }
    }
}
