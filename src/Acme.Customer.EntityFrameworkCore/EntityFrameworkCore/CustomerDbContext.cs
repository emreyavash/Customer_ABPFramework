using Acme.Customer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.OpenIddict.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace Acme.Customer.EntityFrameworkCore;

[ReplaceDbContext(typeof(IIdentityDbContext))]
[ReplaceDbContext(typeof(ITenantManagementDbContext))]
[ConnectionStringName("Default")]
public class CustomerDbContext :
    AbpDbContext<CustomerDbContext>,
    IIdentityDbContext,
    ITenantManagementDbContext
{
    /* Add DbSet properties for your Aggregate Roots / Entities here. */
    public DbSet<CustomerEmail> CustomerEmails { get; set; }
    public DbSet<CustomerPaymentInfo> CustomerPaymentInfos { get; set; }
    public DbSet<CustomerPayment> CustomerPayments { get; set; }
    public DbSet<CustomerPhoneNumber> CustomerPhoneNumbers { get; set; }
    public DbSet<Customers> Customers { get; set; }
    public DbSet<EmailType> EmailTypes { get; set; }
    public DbSet<PhoneType> PhoneTypes { get; set; }
    #region Entities from the modules

    /* Notice: We only implemented IIdentityDbContext and ITenantManagementDbContext
     * and replaced them for this DbContext. This allows you to perform JOIN
     * queries for the entities of these modules over the repositories easily. You
     * typically don't need that for other modules. But, if you need, you can
     * implement the DbContext interface of the needed module and use ReplaceDbContext
     * attribute just like IIdentityDbContext and ITenantManagementDbContext.
     *
     * More info: Replacing a DbContext of a module ensures that the related module
     * uses this DbContext on runtime. Otherwise, it will use its own DbContext class.
     */

    //Identity
    public DbSet<IdentityUser> Users { get; set; }
    public DbSet<IdentityRole> Roles { get; set; }
    public DbSet<IdentityClaimType> ClaimTypes { get; set; }
    public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
    public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
    public DbSet<IdentityLinkUser> LinkUsers { get; set; }

    // Tenant Management
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }

    #endregion

    public CustomerDbContext(DbContextOptions<CustomerDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        /* Include modules to your migration db context */

        builder.ConfigurePermissionManagement();
        builder.ConfigureSettingManagement();
        builder.ConfigureBackgroundJobs();
        builder.ConfigureAuditLogging();
        builder.ConfigureIdentity();
        builder.ConfigureOpenIddict();
        builder.ConfigureFeatureManagement();
        builder.ConfigureTenantManagement();

        /* Configure your own tables/entities inside here */

       
        builder.Entity<CustomerEmail>(b =>
        {
            b.ToTable("CustomerEmails");
            b.ConfigureByConvention(); //auto configure for the base class props

            /*One to Many*/
            b.HasOne<EmailType>().WithMany().HasForeignKey(x => x.EmailTypeId).IsRequired();
            b.HasOne<Customers>().WithMany().HasForeignKey(x=>x.CustomerId).IsRequired();
        });
        builder.Entity<EmailType>(b =>
        {
            b.ToTable("EmailTypes");
            b.ConfigureByConvention(); //auto configure for the base class props
        });

        builder.Entity<CustomerPayment>(b =>
        {
            b.ToTable("CustomerPayments");
            b.ConfigureByConvention(); //auto configure for the base class props
        });
        builder.Entity<CustomerPaymentInfo>(b =>
        {
            b.ToTable("CustomerPaymentInfos");
            b.ConfigureByConvention(); //auto configure for the base class props

            /*Many to many*/
            b.HasMany(x=>x.PaymentId).WithOne().HasForeignKey(x=>x.Id).IsRequired();

            /*One to many*/
            b.HasOne<Customers>().WithMany().HasForeignKey(x => x.CustomerId).IsRequired();
        });

        builder.Entity<CustomerPhoneNumber>(b =>
        {
            b.ToTable("CustomerPhoneNumbers");
            b.ConfigureByConvention(); //auto configure for the base class props

            /* One to many*/
            b.HasOne<PhoneType>().WithMany().HasForeignKey(x=>x.PhoneTypeId).IsRequired();
            b.HasOne<Customers>().WithMany().HasForeignKey(x=> x.CustomerId).IsRequired();
        });

        builder.Entity<PhoneType>(b =>
        {
            b.ToTable("PhoneTypes");
            b.ConfigureByConvention(); //auto configure for the base class props
        });
    }
}
