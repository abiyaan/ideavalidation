namespace IdeaValidation.Core.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class IdeaValidationContext : DbContext
    {
        public IdeaValidationContext()
            : base("name=IdeaValidationContext")
        {
        }

        public virtual DbSet<AddressType> AddressTypes { get; set; }
        public virtual DbSet<Business_HSN_Mapping> Business_HSN_Mapping { get; set; }
        public virtual DbSet<BusinessAddress> BusinessAddresses { get; set; }
        public virtual DbSet<Business> Businesses { get; set; }
        public virtual DbSet<BusinessFinance> BusinessFinances { get; set; }
        public virtual DbSet<BusinessType> BusinessTypes { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<HSN> HSNs { get; set; }
        public virtual DbSet<HSN_CustomerMapping> HSN_CustomerMapping { get; set; }
        public virtual DbSet<HSN_SupplierMapping> HSN_SupplierMapping { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<BusinessStatus> BusinessStatuses { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AddressType>()
                .Property(e => e.TypeName)
                .IsUnicode(false);

            modelBuilder.Entity<AddressType>()
                .Property(e => e.TypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<AddressType>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<AddressType>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Business_HSN_Mapping>()
                .Property(e => e.Section)
                .IsUnicode(false);

            modelBuilder.Entity<Business_HSN_Mapping>()
                .Property(e => e.Chapter)
                .IsUnicode(false);

            modelBuilder.Entity<Business_HSN_Mapping>()
                .Property(e => e.ProductCode)
                .IsUnicode(false);

            modelBuilder.Entity<Business_HSN_Mapping>()
                .Property(e => e.DataSourceName)
                .IsUnicode(false);

            modelBuilder.Entity<Business_HSN_Mapping>()
                .Property(e => e.ApprovedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Business_HSN_Mapping>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Business_HSN_Mapping>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<BusinessAddress>()
                .Property(e => e.AddressType)
                .IsUnicode(false);

            modelBuilder.Entity<BusinessAddress>()
                .Property(e => e.AddressLine1)
                .IsUnicode(false);

            modelBuilder.Entity<BusinessAddress>()
                .Property(e => e.AddressLine2)
                .IsUnicode(false);

            modelBuilder.Entity<BusinessAddress>()
                .Property(e => e.CityName)
                .IsUnicode(false);

            modelBuilder.Entity<BusinessAddress>()
                .Property(e => e.StateName)
                .IsUnicode(false);

            modelBuilder.Entity<BusinessAddress>()
                .Property(e => e.CountryName)
                .IsUnicode(false);

            modelBuilder.Entity<BusinessAddress>()
                .Property(e => e.DataSourceName)
                .IsUnicode(false);

            modelBuilder.Entity<BusinessAddress>()
                .Property(e => e.ApprovedBy)
                .IsUnicode(false);

            modelBuilder.Entity<BusinessAddress>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<BusinessAddress>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Business>()
                .Property(e => e.RegistrationNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Business>()
                .Property(e => e.RegisteredProvince)
                .IsUnicode(false);

            modelBuilder.Entity<Business>()
                .Property(e => e.RegisteredCountry)
                .IsUnicode(false);

            modelBuilder.Entity<Business>()
                .Property(e => e.Website)
                .IsUnicode(false);

            modelBuilder.Entity<Business>()
                .Property(e => e.EmailID)
                .IsUnicode(false);

            modelBuilder.Entity<Business>()
                .Property(e => e.BusinessType)
                .IsFixedLength();

            modelBuilder.Entity<Business>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Business>()
                .Property(e => e.DataSourceName)
                .IsUnicode(false);

            modelBuilder.Entity<Business>()
                .Property(e => e.ApprovedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Business>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Business>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Business>()
                .HasMany(e => e.Business_HSN_Mapping)
                .WithRequired(e => e.Business)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Business>()
                .HasMany(e => e.BusinessAddresses)
                .WithRequired(e => e.Business)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Business>()
                .HasMany(e => e.BusinessFinances)
                .WithRequired(e => e.Business)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BusinessFinance>()
                .Property(e => e.Networth)
                .HasPrecision(18, 4);

            modelBuilder.Entity<BusinessFinance>()
                .Property(e => e.PnL)
                .HasPrecision(18, 4);

            modelBuilder.Entity<BusinessFinance>()
                .Property(e => e.Sale)
                .HasPrecision(18, 4);

            modelBuilder.Entity<BusinessFinance>()
                .Property(e => e.DataSourceName)
                .IsUnicode(false);

            modelBuilder.Entity<BusinessFinance>()
                .Property(e => e.ApprovedBy)
                .IsUnicode(false);

            modelBuilder.Entity<BusinessFinance>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<BusinessFinance>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<BusinessType>()
                .Property(e => e.TypeName)
                .IsUnicode(false);

            modelBuilder.Entity<BusinessType>()
                .Property(e => e.TypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Categories)
                .WithOptional(e => e.Parent)
                .HasForeignKey(e => e.ParentID);

            modelBuilder.Entity<City>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<City>()
                .Property(e => e.CityCode)
                .IsUnicode(false);

            modelBuilder.Entity<City>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<City>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.CurrencyName)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.States)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HSN>()
                .Property(e => e.Section)
                .IsUnicode(false);

            modelBuilder.Entity<HSN>()
                .Property(e => e.Chapter)
                .IsUnicode(false);

            modelBuilder.Entity<HSN>()
                .Property(e => e.ProductCode)
                .IsUnicode(false);

            modelBuilder.Entity<HSN_CustomerMapping>()
                .Property(e => e.Product_Code)
                .IsUnicode(false);

            modelBuilder.Entity<HSN_CustomerMapping>()
                .Property(e => e.Customer_Codes)
                .IsUnicode(false);

            modelBuilder.Entity<HSN_CustomerMapping>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<HSN_CustomerMapping>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<HSN_SupplierMapping>()
                .Property(e => e.Product_Code)
                .IsUnicode(false);

            modelBuilder.Entity<HSN_SupplierMapping>()
                .Property(e => e.Supplier_Codes)
                .IsUnicode(false);

            modelBuilder.Entity<HSN_SupplierMapping>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<HSN_SupplierMapping>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<State>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<State>()
                .Property(e => e.StateCode)
                .IsUnicode(false);

            modelBuilder.Entity<State>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<State>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);
        }
    }
}
