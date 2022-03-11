using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CloseXML.Models
{
    public partial class OMS_DatabaseContext : DbContext
    {
        public OMS_DatabaseContext()
        {
        }

        public OMS_DatabaseContext(DbContextOptions<OMS_DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdmServiceContract> AdmServiceContracts { get; set; }
        public virtual DbSet<AdmServiceContractsClientDescription> AdmServiceContractsClientDescriptions { get; set; }
        public virtual DbSet<AdmServiceContractsPackingType> AdmServiceContractsPackingTypes { get; set; }
        public virtual DbSet<AdmServiceContractsServiceCategory> AdmServiceContractsServiceCategories { get; set; }
        public virtual DbSet<AllService> AllServices { get; set; }
        public virtual DbSet<CatalogClient> CatalogClients { get; set; }
        public virtual DbSet<CatalogItem> CatalogItems { get; set; }
        public virtual DbSet<CategoryHeader> CategoryHeaders { get; set; }
        public virtual DbSet<Certification> Certifications { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<ClientProgramV> ClientProgramVs { get; set; }
        public virtual DbSet<ComFee> ComFees { get; set; }
        public virtual DbSet<CommodityLibMain> CommodityLibMains { get; set; }
        public virtual DbSet<CommodityLibSub> CommodityLibSubs { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Courier> Couriers { get; set; }
        public virtual DbSet<CourierGood> CourierGoods { get; set; }
        public virtual DbSet<CustSession> CustSessions { get; set; }
        public virtual DbSet<CustStdFile> CustStdFiles { get; set; }
        public virtual DbSet<CustStdFileV> CustStdFileVs { get; set; }
        public virtual DbSet<CustUser> CustUsers { get; set; }
        public virtual DbSet<Custaddress> Custaddresses { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomsTaxis> CustomsTaxes { get; set; }
        public virtual DbSet<EmpSigFile> EmpSigFiles { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<FogetServiceSummaryV> FogetServiceSummaryVs { get; set; }
        public virtual DbSet<GetLogisticSummaryV> GetLogisticSummaryVs { get; set; }
        public virtual DbSet<GetLogisticSummaryV1> GetLogisticSummaryV1s { get; set; }
        public virtual DbSet<ImsCargoLine> ImsCargoLines { get; set; }
        public virtual DbSet<ImsCustRcvFile> ImsCustRcvFiles { get; set; }
        public virtual DbSet<ImsCustRcvLine> ImsCustRcvLines { get; set; }
        public virtual DbSet<ImsCustRcvLineSerial> ImsCustRcvLineSerials { get; set; }
        public virtual DbSet<ImsInvItem> ImsInvItems { get; set; }
        public virtual DbSet<ImsInvTxn> ImsInvTxns { get; set; }
        public virtual DbSet<ImsInvoiceDetail> ImsInvoiceDetails { get; set; }
        public virtual DbSet<ImsLocation> ImsLocations { get; set; }
        public virtual DbSet<ImsLocationDetail> ImsLocationDetails { get; set; }
        public virtual DbSet<ImsLocationType> ImsLocationTypes { get; set; }
        public virtual DbSet<ImsPoheader> ImsPoheaders { get; set; }
        public virtual DbSet<ImsPoline> ImsPolines { get; set; }
        public virtual DbSet<ImsRcvTxn> ImsRcvTxns { get; set; }
        public virtual DbSet<ImsRcvTxnHeader> ImsRcvTxnHeaders { get; set; }
        public virtual DbSet<ImsRcvTxnSerial> ImsRcvTxnSerials { get; set; }
        public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual DbSet<LogisticCategory> LogisticCategories { get; set; }
        public virtual DbSet<MsgHistory> MsgHistories { get; set; }
        public virtual DbSet<Nextnum> Nextnums { get; set; }
        public virtual DbSet<OffCmpOrd> OffCmpOrds { get; set; }
        public virtual DbSet<Office> Offices { get; set; }
        public virtual DbSet<OmsCustomerProgram> OmsCustomerPrograms { get; set; }
        public virtual DbSet<OmsProgram> OmsPrograms { get; set; }
        public virtual DbSet<OrdDiv> OrdDivs { get; set; }
        public virtual DbSet<OrdDocAirwayBill> OrdDocAirwayBills { get; set; }
        public virtual DbSet<OrdDocAirwayBillRate> OrdDocAirwayBillRates { get; set; }
        public virtual DbSet<OrdDocBillOfLading> OrdDocBillOfLadings { get; set; }
        public virtual DbSet<OrdDocBillOfLadingRate> OrdDocBillOfLadingRates { get; set; }
        public virtual DbSet<OrdDocBillRateHeader> OrdDocBillRateHeaders { get; set; }
        public virtual DbSet<OrdDocCertOfDonation> OrdDocCertOfDonations { get; set; }
        public virtual DbSet<OrdDocCertOfOrigin> OrdDocCertOfOrigins { get; set; }
        public virtual DbSet<OrdDocInsurance> OrdDocInsurances { get; set; }
        public virtual DbSet<OrdDocIntWorkOrder> OrdDocIntWorkOrders { get; set; }
        public virtual DbSet<OrdDocIntWorkOrderOut> OrdDocIntWorkOrderOuts { get; set; }
        public virtual DbSet<OrdDocMarking> OrdDocMarkings { get; set; }
        public virtual DbSet<OrdDocOtherInstr> OrdDocOtherInstrs { get; set; }
        public virtual DbSet<OrdDocPackListPiece> OrdDocPackListPieces { get; set; }
        public virtual DbSet<OrdDocPackingList> OrdDocPackingLists { get; set; }
        public virtual DbSet<OrdDocPackingListItem> OrdDocPackingListItems { get; set; }
        public virtual DbSet<OrdDocPackingListPiece> OrdDocPackingListPieces { get; set; }
        public virtual DbSet<OrdDocPakList> OrdDocPakLists { get; set; }
        public virtual DbSet<OrdDocPakListImage> OrdDocPakListImages { get; set; }
        public virtual DbSet<OrdDocPakListItem> OrdDocPakListItems { get; set; }
        public virtual DbSet<OrdDocPakListSubItem> OrdDocPakListSubItems { get; set; }
        public virtual DbSet<OrdDocPakListSubItemsSerial> OrdDocPakListSubItemsSerials { get; set; }
        public virtual DbSet<OrdDocTruckerBill> OrdDocTruckerBills { get; set; }
        public virtual DbSet<OrdDocTruckerBillRate> OrdDocTruckerBillRates { get; set; }
        public virtual DbSet<OrdDocWorkOrderInstr> OrdDocWorkOrderInstrs { get; set; }
        public virtual DbSet<OrdExtCost> OrdExtCosts { get; set; }
        public virtual DbSet<OrdFile> OrdFiles { get; set; }
        public virtual DbSet<OrdFileShip> OrdFileShips { get; set; }
        public virtual DbSet<OrdHdr> OrdHdrs { get; set; }
        public virtual DbSet<OrdLine> OrdLines { get; set; }
        public virtual DbSet<OrdLineSerial> OrdLineSerials { get; set; }
        public virtual DbSet<OrdLineSub> OrdLineSubs { get; set; }
        public virtual DbSet<OrdReply> OrdReplies { get; set; }
        public virtual DbSet<OrdRequest> OrdRequests { get; set; }
        public virtual DbSet<OrdShip> OrdShips { get; set; }
        public virtual DbSet<OrdVend> OrdVends { get; set; }
        public virtual DbSet<OrdVendLine> OrdVendLines { get; set; }
        public virtual DbSet<Packing> Packings { get; set; }
        public virtual DbSet<PreShipIn> PreShipIns { get; set; }
        public virtual DbSet<PrintOption> PrintOptions { get; set; }
        public virtual DbSet<PrintOptionType> PrintOptionTypes { get; set; }
        public virtual DbSet<PrintOptionsExtra> PrintOptionsExtras { get; set; }
        public virtual DbSet<ReturnedSerial> ReturnedSerials { get; set; }
        public virtual DbSet<Right> Rights { get; set; }
        public virtual DbSet<SelectedCity> SelectedCities { get; set; }
        public virtual DbSet<SessionLog> SessionLogs { get; set; }
        public virtual DbSet<ShipOption> ShipOptions { get; set; }
        public virtual DbSet<Shipper> Shippers { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<SurveyDetail> SurveyDetails { get; set; }
        public virtual DbSet<SurveyHeader> SurveyHeaders { get; set; }
        public virtual DbSet<TransferHeader> TransferHeaders { get; set; }
        public virtual DbSet<TransferItem> TransferItems { get; set; }
        public virtual DbSet<TransferNotePiece> TransferNotePieces { get; set; }
        public virtual DbSet<TransferSubItem> TransferSubItems { get; set; }
        public virtual DbSet<TransferSubItemsSerial> TransferSubItemsSerials { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UsersTokenCache> UsersTokenCaches { get; set; }
        public virtual DbSet<VendLibMain> VendLibMains { get; set; }
        public virtual DbSet<VendLibSub> VendLibSubs { get; set; }
        public virtual DbSet<VendTier> VendTiers { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }
        public virtual DbSet<VendorV> VendorVs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#pragma warning disable CS1030 // #warning directive
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-B4FAV92T;Database=OMS_Database; user id=sa;password=Rk@$; Trusted_Connection=false;");
#pragma warning restore CS1030 // #warning directive
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AdmServiceContract>(entity =>
            {
                entity.HasKey(e => e.ContactId)
                    .HasName("PK__admServi__7121FD352880F46D");

                entity.ToTable("admServiceContracts");

                entity.Property(e => e.ContactId).HasColumnName("contactId");

                entity.Property(e => e.ClientDescriptionId).HasColumnName("clientDescriptionID");

                entity.Property(e => e.DefaultMargin).HasColumnName("defaultMargin");

                entity.Property(e => e.DefaultServiceProvider)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("defaultServiceProvider");

                entity.Property(e => e.ServiceCategoryId).HasColumnName("serviceCategoryId");

                entity.Property(e => e.ServiceContractMame)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("serviceContractMame");

                entity.HasOne(d => d.ClientDescription)
                    .WithMany(p => p.AdmServiceContracts)
                    .HasForeignKey(d => d.ClientDescriptionId)
                    .HasConstraintName("FK__admServic__clien__5B78929E");

                entity.HasOne(d => d.ServiceCategory)
                    .WithMany(p => p.AdmServiceContracts)
                    .HasForeignKey(d => d.ServiceCategoryId)
                    .HasConstraintName("FK__admServic__servi__5C6CB6D7");
            });

            modelBuilder.Entity<AdmServiceContractsClientDescription>(entity =>
            {
                entity.HasKey(e => e.ClientDescriptionId)
                    .HasName("PK__admServi__82C15C0BECED48C2");

                entity.ToTable("admServiceContractsClientDescriptions");

                entity.Property(e => e.ClientDescriptionId).HasColumnName("clientDescriptionID");

                entity.Property(e => e.ClientDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("clientDescription");

                entity.Property(e => e.ServiceCategoryId).HasColumnName("serviceCategoryId");

                entity.HasOne(d => d.ServiceCategory)
                    .WithMany(p => p.AdmServiceContractsClientDescriptions)
                    .HasForeignKey(d => d.ServiceCategoryId)
                    .HasConstraintName("FK__admServic__servi__5D60DB10");
            });

            modelBuilder.Entity<AdmServiceContractsPackingType>(entity =>
            {
                entity.HasKey(e => e.PackingTypeId)
                    .HasName("PK__admServi__A45FD2C04BA5DEE6");

                entity.ToTable("admServiceContractsPackingTypes");

                entity.Property(e => e.PackingTypeId).HasColumnName("packingTypeId");

                entity.Property(e => e.DefaultPerCargoAddition).HasColumnName("defaultPerCargoAddition");

                entity.Property(e => e.PackingName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("packingName");
            });

            modelBuilder.Entity<AdmServiceContractsServiceCategory>(entity =>
            {
                entity.HasKey(e => e.ServiceCategoryId)
                    .HasName("PK__admServi__CB52C3323D66F643");

                entity.ToTable("admServiceContractsServiceCategories");

                entity.Property(e => e.ServiceCategoryId).HasColumnName("serviceCategoryId");

                entity.Property(e => e.ServiceCategoryName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("serviceCategoryName");
            });

            modelBuilder.Entity<AllService>(entity =>
            {
                entity.HasKey(e => new { e.OrdDivId, e.Sno });

                entity.Property(e => e.OrdDivId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OrdDivID");

                entity.Property(e => e.Sno).HasColumnName("sno");

                entity.Property(e => e.ChgEmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("chgEmID");

                entity.Property(e => e.ChgLog)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("chgLog");

                entity.Property(e => e.Consignee).HasColumnType("text");

                entity.Property(e => e.Dat)
                    .HasColumnType("datetime")
                    .HasColumnName("dat");

                entity.Property(e => e.Descr).HasColumnType("text");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.FootAdvise)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FootNb)
                    .HasColumnType("text")
                    .HasColumnName("FootNB");

                entity.Property(e => e.FxAmt).HasColumnName("fxAmt");

                entity.Property(e => e.FxCurrencyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fxCurrencyCode");

                entity.Property(e => e.FxRate).HasColumnName("fxRate");

                entity.Property(e => e.Instructions)
                    .HasColumnType("text")
                    .HasColumnName("instructions");

                entity.Property(e => e.Invoice)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.LocId).HasColumnName("LocID");

                entity.Property(e => e.Markings).HasColumnType("text");

                entity.Property(e => e.NoTypePkgs).HasColumnType("text");

                entity.Property(e => e.Notify).HasColumnType("text");

                entity.Property(e => e.PaymentTerm)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("Payment_Term");

                entity.Property(e => e.ServiceType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("serviceType");

                entity.Property(e => e.ShipCompany)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShipFullName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Shipper).HasColumnType("text");

                entity.Property(e => e.StatusDb)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StatusDB");

                entity.Property(e => e.SubmittedToAccounting).HasColumnType("smalldatetime");

                entity.Property(e => e.TotVol).HasColumnName("totVol");

                entity.Property(e => e.TotalWt).HasColumnName("totalWt");
            });

            modelBuilder.Entity<CatalogClient>(entity =>
            {
                entity.HasKey(e => new { e.CatalogId, e.CmpId })
                    .HasName("catalogClientsPK");

                entity.ToTable("catalogClients");

                entity.Property(e => e.CatalogId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CatalogID");

                entity.Property(e => e.CmpId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CmpID");

                entity.Property(e => e.ClientUnitPrice).HasColumnType("decimal(9, 2)");
            });

            modelBuilder.Entity<CatalogItem>(entity =>
            {
                entity.HasKey(e => e.CatalogId)
                    .HasName("PK__CatalogI__C2513B48930CC6F1");

                entity.ToTable("CatalogItem");

                entity.Property(e => e.CatalogId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CatalogID");

                entity.Property(e => e.ActiveFlag).HasDefaultValueSql("((1))");

                entity.Property(e => e.AvailabilityClass)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.ClientUnitPrice).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Coo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COO");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.Eccn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ECCN");

                entity.Property(e => e.ExRate).HasColumnType("decimal(5, 4)");

                entity.Property(e => e.HasStockable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Hts)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HTS");

                entity.Property(e => e.ImageName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Ipasku)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("IPASKU");

                entity.Property(e => e.ManufactureId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ManufactureID");

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.Path).IsUnicode(false);

                entity.Property(e => e.PricingClass)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ProductInfo)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ProductTierId).HasColumnName("ProductTierID");

                entity.Property(e => e.Sch)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SCH");

                entity.Property(e => e.UnitOfDimension)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnitOfMeasure)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnitOfWeight)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnspscCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VendCurrPrice).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.VendCurrency)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.VendUnitPrice).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Vendor)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CategoryHeader>(entity =>
            {
                entity.ToTable("CategoryHeader");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasColumnType("text");
            });

            modelBuilder.Entity<Certification>(entity =>
            {
                entity.HasKey(e => e.OrdDivId)
                    .HasName("PK__Certific__B532AD109FB6A320");

                entity.ToTable("Certification");

                entity.Property(e => e.OrdDivId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OrdDivID");

                entity.Property(e => e.Cdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CDate");

                entity.Property(e => e.ChgEmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("chgEmID");

                entity.Property(e => e.ChgLog)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("chgLog");

                entity.Property(e => e.FxcurCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("FXCurCode");

                entity.Property(e => e.Fxtotcost).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Invoice)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasColumnType("text");

                entity.Property(e => e.PaymentTerm)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("Payment_Term");

                entity.Property(e => e.ShipCompany)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubmittedToAccounting).HasColumnType("datetime");

                entity.Property(e => e.Usdtotcost)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("USDtotcost");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("city");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<ClientProgramV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ClientProgram_V");

                entity.Property(e => e.CmpId)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CmpID");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.IsProgram)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ParentID");

                entity.Property(e => e.ProgramId)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ProgramID");

                entity.Property(e => e.UserName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserPass)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ComFee>(entity =>
            {
                entity.HasKey(e => e.OrdDivId)
                    .HasName("PK__ComFee__B532AD10ED37B9E1");

                entity.ToTable("ComFee");

                entity.Property(e => e.OrdDivId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OrdDivID");

                entity.Property(e => e.Cdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CDate");

                entity.Property(e => e.ChgEmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("chgEmID");

                entity.Property(e => e.ChgLog)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("chgLog");

                entity.Property(e => e.FxcurCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("FXCurCode");

                entity.Property(e => e.Fxtotcost).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Invoice)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasColumnType("text");

                entity.Property(e => e.PaymentTerm)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("Payment_Term");

                entity.Property(e => e.ShipCompany)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubmittedToAccounting).HasColumnType("datetime");

                entity.Property(e => e.Usdtotcost)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("USDtotcost");
            });

            modelBuilder.Entity<CommodityLibMain>(entity =>
            {
                entity.HasKey(e => e.MainId)
                    .HasName("PK__Commodit__71F8F5AC706D3EBB");

                entity.ToTable("CommodityLibMain");

                entity.Property(e => e.MainId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MainID");

                entity.Property(e => e.MainCommodity)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CommodityLibSub>(entity =>
            {
                entity.HasKey(e => e.SubId)
                    .HasName("PK__Commodit__4D9BB86A26637597");

                entity.ToTable("CommodityLibSub");

                entity.Property(e => e.SubId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SubID");

                entity.Property(e => e.MainId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MainID");

                entity.Property(e => e.SubCommodity)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.Main)
                    .WithMany(p => p.CommodityLibSubs)
                    .HasForeignKey(d => d.MainId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CommodityLibMain_MainID");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.CtryId);

                entity.ToTable("country");

                entity.Property(e => e.CtryId).HasColumnName("CtryID");

                entity.Property(e => e.CommonName)
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDNumber");

                entity.Property(e => e.LetterCode2)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.LetterCode3)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Rank).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Courier>(entity =>
            {
                entity.HasKey(e => e.OrdDivId)
                    .HasName("PK__Courier__B532AD10E1A46601");

                entity.ToTable("Courier");

                entity.Property(e => e.OrdDivId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OrdDivID");

                entity.Property(e => e.Cdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CDate");

                entity.Property(e => e.ChgEmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("chgEmID");

                entity.Property(e => e.ChgLog)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("chgLog");

                entity.Property(e => e.FxcurCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("FXCurCode");

                entity.Property(e => e.Fxtotcost).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Invoice)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasColumnType("text");

                entity.Property(e => e.PaymentTerm)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("Payment_Term");

                entity.Property(e => e.ShipCompany)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubmittedToAccounting).HasColumnType("datetime");

                entity.Property(e => e.Usdtotcost)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("USDtotcost");
            });

            modelBuilder.Entity<CourierGood>(entity =>
            {
                entity.HasKey(e => e.OrdDivId)
                    .HasName("PK__Courier___B532AD10899F517C");

                entity.ToTable("Courier_Goods");

                entity.Property(e => e.OrdDivId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OrdDivID");

                entity.Property(e => e.Cdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CDate");

                entity.Property(e => e.ChgEmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("chgEmID");

                entity.Property(e => e.ChgLog)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("chgLog");

                entity.Property(e => e.FxcurCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("FXCurCode");

                entity.Property(e => e.Fxtotcost).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Invoice)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasColumnType("text");

                entity.Property(e => e.PaymentTerm)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("Payment_Term");

                entity.Property(e => e.ShipCompany)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubmittedToAccounting).HasColumnType("datetime");

                entity.Property(e => e.Usdtotcost)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("USDtotcost");
            });

            modelBuilder.Entity<CustSession>(entity =>
            {
                entity.ToTable("custSession");

                entity.HasIndex(e => e.SessionId, "UQ__custSess__C9F492715C09C66B")
                    .IsUnique();

                entity.Property(e => e.CustSessionId).HasColumnName("CustSessionID");

                entity.Property(e => e.BrowserFormPostUrl)
                    .IsUnicode(false)
                    .HasColumnName("BrowserFormPostURL");

                entity.Property(e => e.BuyerCookie).IsUnicode(false);

                entity.Property(e => e.BuyerIdentity).IsUnicode(false);

                entity.Property(e => e.CmpId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CmpID");

                entity.Property(e => e.OrdDivId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OrdDivID");

                entity.Property(e => e.PoXml)
                    .IsUnicode(false)
                    .HasColumnName("PoXML");

                entity.Property(e => e.SessionExpiry).HasColumnType("smalldatetime");

                entity.Property(e => e.SessionId)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SessionID");

                entity.HasOne(d => d.Cmp)
                    .WithMany(p => p.CustSessions)
                    .HasForeignKey(d => d.CmpId)
                    .HasConstraintName("FK__custSessi__CmpID__5F492382");
            });

            modelBuilder.Entity<CustStdFile>(entity =>
            {
                entity.HasKey(e => e.FileId)
                    .HasName("pk_custStdFile");

                entity.ToTable("custStdFile");

                entity.Property(e => e.FileId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("FileID");

                entity.Property(e => e.ChgEmId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("chgEmID");

                entity.Property(e => e.ChgLog)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("chgLog");

                entity.Property(e => e.ChgType)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("chgType");

                entity.Property(e => e.CmpId)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CmpID");

                entity.Property(e => e.Descr)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FileStatus)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FileType)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.UploadDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<CustStdFileV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("custStdFile_V");

                entity.Property(e => e.ChgEmId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("chgEmID");

                entity.Property(e => e.ChgLog)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("chgLog");

                entity.Property(e => e.ChgType)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("chgType");

                entity.Property(e => e.CmpId)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CmpID");

                entity.Property(e => e.Descr)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.FileGroup)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("FILE_GROUP");

                entity.Property(e => e.FileId)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("FileID");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FileOwnedCompany)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("FILE_OWNED_COMPANY");

                entity.Property(e => e.FileStatus)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FileType)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.UploadDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<CustUser>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.CmpId })
                    .HasName("PK__custUser__E8DCB3096282711F");

                entity.ToTable("custUser");

                entity.Property(e => e.UserId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("UserID");

                entity.Property(e => e.CmpId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CmpID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<Custaddress>(entity =>
            {
                entity.HasKey(e => e.AdId);

                entity.ToTable("custaddress");

                entity.Property(e => e.AdId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AdID");

                entity.Property(e => e.Address1)
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.Address3)
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.ChgEmId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("chgEmID");

                entity.Property(e => e.ChgLog)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("chgLog");

                entity.Property(e => e.ChgType)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("chgType");

                entity.Property(e => e.City)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CmpId)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CmpID");

                entity.Property(e => e.CmpName)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CmpId);

                entity.ToTable("customer");

                entity.Property(e => e.CmpId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CmpID");

                entity.Property(e => e.ChgEmId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("chgEmID");

                entity.Property(e => e.ChgLog)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("chgLog");

                entity.Property(e => e.ChgType)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("chgType");

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustDomain).IsUnicode(false);

                entity.Property(e => e.CustIdentity).IsUnicode(false);

                entity.Property(e => e.CustSharedSecret).IsUnicode(false);

                entity.Property(e => e.LastRemind).HasColumnType("smalldatetime");

                entity.Property(e => e.Office)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OfficeShare)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ParentID");

                entity.Property(e => e.StatusDb)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("StatusDB");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserPass)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomsTaxis>(entity =>
            {
                entity.HasKey(e => e.OrdDivId)
                    .HasName("PK__Customs___B532AD10478CE11B");

                entity.ToTable("Customs_Taxes");

                entity.Property(e => e.OrdDivId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OrdDivID");

                entity.Property(e => e.ChgEmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("chgEmID");

                entity.Property(e => e.ChgLog)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("chgLog");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.FormDate).HasColumnType("smalldatetime");

                entity.Property(e => e.FxAmt)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("fxAmt");

                entity.Property(e => e.FxCurrencyCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("fxCurrencyCode");

                entity.Property(e => e.FxRate).HasColumnName("fxRate");

                entity.Property(e => e.Invoice)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTerm)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("Payment_Term");

                entity.Property(e => e.ShipCompany)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.SubmittedToAccounting).HasColumnType("smalldatetime");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(9, 2)");
            });

            modelBuilder.Entity<EmpSigFile>(entity =>
            {
                entity.HasKey(e => e.FileId)
                    .HasName("PK_empSigfiles");

                entity.ToTable("empSigFile");

                entity.Property(e => e.FileId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("FileID");

                entity.Property(e => e.ChgEmId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("chgEmID");

                entity.Property(e => e.ChgLog)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("chgLog");

                entity.Property(e => e.ChgType)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("chgType");

                entity.Property(e => e.Descr)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FileStatus)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FileType)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.UploadDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmpId);

                entity.ToTable("employees");

                entity.Property(e => e.EmpId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EmpID");

                entity.Property(e => e.ChgEmId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("chgEmID");

                entity.Property(e => e.ChgLog)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("chgLog");

                entity.Property(e => e.ChgType)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("chgType");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailLogin)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailPass)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Initials)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Office)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Phone1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SignatureFileName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("signatureFileName");

                entity.Property(e => e.SignatureFileName2)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("signatureFileName2");

                entity.Property(e => e.Title)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UserPass)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FogetServiceSummaryV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FOGetServiceSummary_V");

                entity.Property(e => e.DocumentType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Document Type");

                entity.Property(e => e.FxAmt).HasColumnName("fxAmt");

                entity.Property(e => e.FxCurrencyCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fxCurrencyCode");

                entity.Property(e => e.FxRate).HasColumnName("fxRate");

                entity.Property(e => e.FxUsd)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("fxUSD");

                entity.Property(e => e.Invoice)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.OrdDivId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OrdDivID");

                entity.Property(e => e.OrdId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OrdID");

                entity.Property(e => e.Partial)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PaymentTerm)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("Payment_Term");

                entity.Property(e => e.ShipCompany)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sno).HasColumnName("sno");

                entity.Property(e => e.SubmittedToAccounting).HasColumnType("datetime");

                entity.Property(e => e.TotalCost).HasColumnName("Total Cost");

                entity.Property(e => e.VendId)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("VendID");
            });

            modelBuilder.Entity<GetLogisticSummaryV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GetLogisticSummary_V");

                entity.Property(e => e.DocumentType)
                    .IsRequired()
                    .HasMaxLength(23)
                    .IsUnicode(false)
                    .HasColumnName("Document Type");

                entity.Property(e => e.FxAmt).HasColumnName("fxAmt");

                entity.Property(e => e.FxCurrencyCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fxCurrencyCode");

                entity.Property(e => e.FxRate).HasColumnName("fxRate");

                entity.Property(e => e.FxUsd)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("fxUSD");

                entity.Property(e => e.Invoice)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.OrdDivId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OrdDivID");

                entity.Property(e => e.OrdId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OrdID");

                entity.Property(e => e.Partial)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ShipCompany)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SubmittedToAccounting).HasColumnType("datetime");

                entity.Property(e => e.TotalCost).HasColumnName("Total Cost");
            });

            modelBuilder.Entity<GetLogisticSummaryV1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GetLogisticSummary_V1");

                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.DocumentType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Document Type");

                entity.Property(e => e.FxAmt).HasColumnName("fxAmt");

                entity.Property(e => e.FxCurrencyCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fxCurrencyCode");

                entity.Property(e => e.FxRate).HasColumnName("fxRate");

                entity.Property(e => e.FxUsd)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("fxUSD");

                entity.Property(e => e.Invoice)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.LocId).HasColumnName("LocID");

                entity.Property(e => e.OrdDivId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OrdDivID");

                entity.Property(e => e.OrdId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OrdID");

                entity.Property(e => e.Partial)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ShipCompany)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sno).HasColumnName("sno");

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SubmittedToAccounting).HasColumnType("datetime");

                entity.Property(e => e.TotalCost).HasColumnName("Total Cost");
            });

            modelBuilder.Entity<ImsCargoLine>(entity =>
            {
                entity.HasKey(e => e.CargoId)
                    .HasName("PK__ims_Carg__B4E665ED7BC00BB4");

                entity.ToTable("ims_CargoLine");

                entity.Property(e => e.CargoId).HasColumnName("CargoID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.OrdLineId)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("OrdLineID");

                entity.Property(e => e.PrintQty).HasColumnName("printQty");

                entity.Property(e => e.RtheaderId).HasColumnName("RTHeaderID");

                entity.Property(e => e.UnAllocate).HasDefaultValueSql("('FALSE')");

                entity.Property(e => e.UnitofMeasure)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitofWeight)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");

                entity.HasOne(d => d.Rtheader)
                    .WithMany(p => p.ImsCargoLines)
                    .HasForeignKey(d => d.RtheaderId)
                    .HasConstraintName("FK__ims_Cargo__RTHea__603D47BB");
            });

            modelBuilder.Entity<ImsCustRcvFile>(entity =>
            {
                entity.HasKey(e => e.FileId)
                    .HasName("PK__ims_Cust__6F0F989F73702420");

                entity.ToTable("ims_CustRcvFile");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Descr)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FileType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RtheaderId).HasColumnName("RTHeaderID");

                entity.Property(e => e.TicketId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TicketID");
            });

            modelBuilder.Entity<ImsCustRcvLine>(entity =>
            {
                entity.HasKey(e => e.CrlineId)
                    .HasName("PK__ims_Cust__15080250F6F523BB");

                entity.ToTable("ims_CustRcvLine");

                entity.Property(e => e.CrlineId).HasColumnName("CRLineID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Currency)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Descr)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InvNumber)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ItemId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ItemID");

                entity.Property(e => e.LocId).HasColumnName("LocID");

                entity.Property(e => e.RcvNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RtheaderId).HasColumnName("RTHeaderID");

                entity.Property(e => e.ServPro)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");

                entity.HasOne(d => d.Rtheader)
                    .WithMany(p => p.ImsCustRcvLines)
                    .HasForeignKey(d => d.RtheaderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ims_CustR__RTHea__61316BF4");
            });

            modelBuilder.Entity<ImsCustRcvLineSerial>(entity =>
            {
                entity.HasKey(e => e.SerialNum)
                    .HasName("PK__ims_Cust__EB2672A35841304C");

                entity.ToTable("ims_CustRcvLineSerial");

                entity.Property(e => e.SerialNum)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CrlineId).HasColumnName("CRLineID");

                entity.Property(e => e.LocId).HasColumnName("LocID");
            });

            modelBuilder.Entity<ImsInvItem>(entity =>
            {
                entity.HasKey(e => e.InvItemId)
                    .HasName("PK__ims_InvI__1BB29F3C5A5C9C8A");

                entity.ToTable("ims_InvItem");

                entity.HasIndex(e => new { e.ItemId, e.BatchId, e.LocationId, e.OnHandType, e.CmpId, e.UnitCost }, "ucCodes")
                    .IsUnique();

                entity.Property(e => e.InvItemId).HasColumnName("InvItemID");

                entity.Property(e => e.BatchId)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("BatchID");

                entity.Property(e => e.CmpId)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CmpID")
                    .HasDefaultValueSql("('0000')");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ItemId)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ItemID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.OnHandType)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ImsInvItems)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ims_InvIt__ItemI__6225902D");
            });

            modelBuilder.Entity<ImsInvTxn>(entity =>
            {
                entity.HasKey(e => e.InvTxnId)
                    .HasName("PK__ims_InvT__6A971267630CC7F5");

                entity.ToTable("ims_InvTxn");

                entity.Property(e => e.InvTxnId).HasColumnName("InvTxnID");

                entity.Property(e => e.Action)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BatchId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("BatchID");

                entity.Property(e => e.CmpId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CmpID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FromLocId).HasColumnName("FromLocID");

                entity.Property(e => e.InvItemId).HasColumnName("InvItemID");

                entity.Property(e => e.ItemId)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ItemID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.LocationName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ocqty).HasColumnName("OCQty");

                entity.Property(e => e.OnHandType)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('INV')");

                entity.Property(e => e.PoheaderId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("POHeaderID");

                entity.Property(e => e.TxnDate).HasColumnType("smalldatetime");

                entity.Property(e => e.TxnType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.VendId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("VendID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ImsInvTxns)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ims_InvTx__ItemI__640DD89F");
            });

            modelBuilder.Entity<ImsInvoiceDetail>(entity =>
            {
                entity.HasKey(e => e.InvoiceId)
                    .HasName("PK__ims_Invo__D796AAD5BDBA8643");

                entity.ToTable("ims_InvoiceDetails");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.ChgLog)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("chgLog");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNum)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.PoheaderId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("POHeaderID");

                entity.Property(e => e.SubmittoAccount).HasColumnType("datetime");

                entity.HasOne(d => d.Poheader)
                    .WithMany(p => p.ImsInvoiceDetails)
                    .HasForeignKey(d => d.PoheaderId)
                    .HasConstraintName("FK__ims_Invoi__POHea__6319B466");
            });

            modelBuilder.Entity<ImsLocation>(entity =>
            {
                entity.HasKey(e => e.LocId)
                    .HasName("PK__ims_loca__6A46DEE914D66E9B");

                entity.ToTable("ims_location");

                entity.HasIndex(e => e.LocCode, "UQ__ims_loca__6867D54B43E616C4")
                    .IsUnique();

                entity.Property(e => e.LocId).HasColumnName("LocID");

                entity.Property(e => e.Address)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HasClient).HasColumnName("HasCLIENT");

                entity.Property(e => e.HasFca).HasColumnName("HasFCA");

                entity.Property(e => e.HasFob).HasColumnName("HasFOB");

                entity.Property(e => e.HasInv).HasColumnName("HasINV");

                entity.Property(e => e.Initial)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.LocCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocTypeId).HasColumnName("LocTypeID");

                entity.Property(e => e.NonAllocInvFlag).HasColumnName("non_alloc_inv_flag");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SecondName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode2)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.LocType)
                    .WithMany(p => p.ImsLocations)
                    .HasForeignKey(d => d.LocTypeId)
                    .HasConstraintName("FK__ims_locat__LocTy__6501FCD8");
            });

            modelBuilder.Entity<ImsLocationDetail>(entity =>
            {
                entity.HasKey(e => e.Ldid)
                    .HasName("PK__ims_loca__61F2580EEA716C45");

                entity.ToTable("ims_locationDetail");

                entity.Property(e => e.Ldid).HasColumnName("LDID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LocId).HasColumnName("LocID");

                entity.Property(e => e.LocTypeId).HasColumnName("LocTypeID");

                entity.HasOne(d => d.Loc)
                    .WithMany(p => p.ImsLocationDetails)
                    .HasForeignKey(d => d.LocId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ims_locat__LocID__65F62111");

                entity.HasOne(d => d.LocType)
                    .WithMany(p => p.ImsLocationDetails)
                    .HasForeignKey(d => d.LocTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ims_locat__LocTy__66EA454A");
            });

            modelBuilder.Entity<ImsLocationType>(entity =>
            {
                entity.HasKey(e => e.LocTypeId)
                    .HasName("PK__ims_loca__CFA3E453A60AB9C4");

                entity.ToTable("ims_locationType");

                entity.HasIndex(e => e.LocTypeCode, "UQ__ims_loca__E162DC542B201DF4")
                    .IsUnique();

                entity.Property(e => e.LocTypeId).HasColumnName("LocTypeID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.DisplayPacklist).HasDefaultValueSql("('FALSE')");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('L')");

                entity.Property(e => e.ItemType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocTypeCode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LocTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<ImsPoheader>(entity =>
            {
                entity.HasKey(e => e.PoheaderId)
                    .HasName("PK__ims_POHe__7363CCCBA48B0AA6");

                entity.ToTable("ims_POHeader");

                entity.HasIndex(e => e.Ponum, "UQ__ims_POHe__52687408D8A35EDE")
                    .IsUnique();

                entity.Property(e => e.PoheaderId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("POHeaderID");

                entity.Property(e => e.BillAddress1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillAttn)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BillCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillFirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillLocation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BillPostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BillRegion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillSecondName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Buyer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Buyer2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CmpId)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CmpID");

                entity.Property(e => e.Contact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LocId).HasColumnName("LocID");

                entity.Property(e => e.LocTypeId).HasColumnName("LocTypeID");

                entity.Property(e => e.OnAbout)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTerm)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Podate)
                    .HasColumnType("date")
                    .HasColumnName("PODate");

                entity.Property(e => e.Podescr)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("PODescr");

                entity.Property(e => e.Ponum)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PONum");

                entity.Property(e => e.Postatus)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("POStatus");

                entity.Property(e => e.Potype)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("POType")
                    .HasDefaultValueSql("('INV')");

                entity.Property(e => e.RequestedDate).HasColumnType("date");

                entity.Property(e => e.ShipAddress1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipAttn)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShipCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipFirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipLocation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShipPostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShipRegion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipSecondName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipmentBydate)
                    .HasColumnType("date")
                    .HasColumnName("ShipmentBYDate");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.VendId)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("VendID");

                entity.HasOne(d => d.Vend)
                    .WithMany(p => p.ImsPoheaders)
                    .HasForeignKey(d => d.VendId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ims_POHea__VendI__67DE6983");
            });

            modelBuilder.Entity<ImsPoline>(entity =>
            {
                entity.HasKey(e => e.PolineId)
                    .HasName("PK__ims_POLi__07B9D342F581B9FD");

                entity.ToTable("ims_POLine");

                entity.HasIndex(e => e.PolineNum, "UQ__ims_POLi__BDEB50D2ED9D4158")
                    .IsUnique();

                entity.Property(e => e.PolineId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("POLineID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.FxCurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ItemId)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ItemID");

                entity.Property(e => e.LocId).HasColumnName("LocID");

                entity.Property(e => e.NcQty).HasColumnName("ncQty");

                entity.Property(e => e.Notes)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.PoheaderId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("POHeaderID");

                entity.Property(e => e.PolineNum)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("POLineNum");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ImsPolines)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ims_POLin__ItemI__69C6B1F5");

                entity.HasOne(d => d.Loc)
                    .WithMany(p => p.ImsPolines)
                    .HasForeignKey(d => d.LocId)
                    .HasConstraintName("FK__ims_POLin__LocID__6ABAD62E");

                entity.HasOne(d => d.Poheader)
                    .WithMany(p => p.ImsPolines)
                    .HasForeignKey(d => d.PoheaderId)
                    .HasConstraintName("FK__ims_POLin__POHea__68D28DBC");
            });

            modelBuilder.Entity<ImsRcvTxn>(entity =>
            {
                entity.HasKey(e => e.RcvTxnId)
                    .HasName("PK__ims_RcvT__C425DAEA7B825587");

                entity.ToTable("ims_RcvTxn");

                entity.Property(e => e.RcvTxnId).HasColumnName("RcvTxnID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ItemId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ItemID");

                entity.Property(e => e.LocId).HasColumnName("LocID");

                entity.Property(e => e.NcDescr)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("ncDescr");

                entity.Property(e => e.NcReason)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ncReason");

                entity.Property(e => e.NcResolve).HasColumnName("ncResolve");

                entity.Property(e => e.NonAllocInv).HasColumnName("non_alloc_inv");

                entity.Property(e => e.PoheaderId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("POHeaderID");

                entity.Property(e => e.PolineId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("POLineID");

                entity.Property(e => e.RcvNum)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ReceivedDate).HasColumnType("date");

                entity.Property(e => e.RtheaderId).HasColumnName("RTHeaderID");

                entity.Property(e => e.ServPro)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SublineStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupInvNum)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ImsRcvTxns)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK__ims_RcvTx__ItemI__6D9742D9");

                entity.HasOne(d => d.Loc)
                    .WithMany(p => p.ImsRcvTxns)
                    .HasForeignKey(d => d.LocId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ims_RcvTx__LocID__6E8B6712");

                entity.HasOne(d => d.Poheader)
                    .WithMany(p => p.ImsRcvTxns)
                    .HasForeignKey(d => d.PoheaderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ims_RcvTx__POHea__6BAEFA67");

                entity.HasOne(d => d.Poline)
                    .WithMany(p => p.ImsRcvTxns)
                    .HasForeignKey(d => d.PolineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ims_RcvTx__POLin__6CA31EA0");
            });

            modelBuilder.Entity<ImsRcvTxnHeader>(entity =>
            {
                entity.HasKey(e => e.RtheaderId)
                    .HasName("PK__ims_Rcv___C295BC45DA046C13");

                entity.ToTable("ims_Rcv_Txn_Header");

                entity.Property(e => e.RtheaderId).HasColumnName("RTHeaderID");

                entity.Property(e => e.CmpId)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CmpID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Descr)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FileType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("HeaderID");

                entity.Property(e => e.LocId).HasColumnName("LocID");

                entity.Property(e => e.LocTypeId).HasColumnName("LocTypeID");

                entity.Property(e => e.Notes).HasColumnType("text");

                entity.Property(e => e.Ocaddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OCaddress");

                entity.Property(e => e.OrderDate).HasColumnType("smalldatetime");

                entity.Property(e => e.RcvDate).HasColumnType("smalldatetime");

                entity.Property(e => e.RcvNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RcvType)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('S')");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Vendor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ImsRcvTxnSerial>(entity =>
            {
                entity.HasKey(e => e.SerialNum)
                    .HasName("PK__ims_RcvT__EB2672A349B3F552");

                entity.ToTable("ims_RcvTxnSerial");

                entity.Property(e => e.SerialNum)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CmpId)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CmpID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ItemId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ItemID");

                entity.Property(e => e.LocId).HasColumnName("LocID");

                entity.Property(e => e.OnHandType)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PolineId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("POLineID");

                entity.Property(e => e.RcvTxnId).HasColumnName("RcvTxnID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ImsRcvTxnSerials)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK__ims_RcvTx__ItemI__6F7F8B4B");

                entity.HasOne(d => d.RcvTxn)
                    .WithMany(p => p.ImsRcvTxnSerials)
                    .HasForeignKey(d => d.RcvTxnId)
                    .HasConstraintName("FK__ims_RcvTx__RcvTx__7073AF84");
            });

            modelBuilder.Entity<InvoiceDetail>(entity =>
            {
                entity.HasKey(e => e.InvoiceId)
                    .HasName("Invoice_ID");

                entity.ToTable("invoiceDetails");

                entity.HasIndex(e => new { e.OrdDivId, e.Iotype, e.ServiceType }, "nci_wi_invoiceDetails_2C878F7BCB17B352AEB1F2F3920B3AED");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.ChgLog)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("chgLog");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNum)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Iotype)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("IOType");

                entity.Property(e => e.OrdDivId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OrdDivID");

                entity.Property(e => e.OrdRecall)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceType)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Sno).HasColumnName("sno");

                entity.Property(e => e.SubmittoAccount).HasColumnType("datetime");

                entity.Property(e => e.TotProIoamt).HasColumnName("TotProIOamt");

                entity.Property(e => e.VendId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VendID");

                entity.Property(e => e.VendIoamt).HasColumnName("VendIOamt");
            });

            modelBuilder.Entity<LogisticCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryName)
                    .HasName("PK_LogisticCategory");

                entity.ToTable("logisticCategory");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("categoryName");

                entity.Property(e => e.ParentId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("parentID");
            });

            modelBuilder.Entity<MsgHistory>(entity =>
            {
                entity.HasKey(e => e.MsgId)
                    .HasName("PK_MsgHistory");

                entity.ToTable("msgHistory");

                entity.HasIndex(e => new { e.MsgCategory, e.OrdId }, "nci_wi_msgHistory_C6C7590FB7DD7641774B32A98E0EAEE9");

                entity.Property(e => e.MsgId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("MsgID");

                entity.Property(e => e.Control).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("createdBy");

                entity.Property(e => e.DateSubmit).HasColumnType("smalldatetime");

                entity.Property(e => e.Document)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Message).HasColumnType("text");

                entity.Property(e => e.MsgCategory)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MsgType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrdId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OrdID");

                entity.Property(e => e.Partial)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Vendor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Nextnum>(entity =>
            {
                entity.HasKey(e => e.Prefix)
                    .HasName("PK_NextNum");

                entity.ToTable("nextnum");

                entity.Property(e => e.Prefix)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Descr)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NextVal)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OffCmpOrd>(entity =>
            {
                entity.HasKey(e => new { e.OffId, e.CmpId });

                entity.ToTable("offCmpOrd");

                entity.Property(e => e.OffId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("offID");

                entity.Property(e => e.CmpId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CmpID");

                entity.Property(e => e.NextOrd).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Office>(entity =>
            {
                entity.HasKey(e => e.OffId);

                entity.ToTable("offices");

                entity.Property(e => e.OffId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("offID");

                entity.Property(e => e.CmpAddress1)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CmpAddress2)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CmpCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CmpCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CmpEmail)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CmpFax)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CmpName)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CmpPhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CmpPostCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CmpRegion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CmpReportName)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.WebmailUrl)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("WebmailURL");
            });

            modelBuilder.Entity<OmsCustomerProgram>(entity =>
            {
                entity.HasKey(e => e.CustProgId)
                    .HasName("PK__omsCusto__FE0D130346C5CBBA");

                entity.ToTable("omsCustomer_Program");

                entity.HasIndex(e => new { e.CmpId, e.ProgramId }, "uq_Customer_Program")
                    .IsUnique();

                entity.Property(e => e.CustProgId).HasColumnName("CustProgID");

                entity.Property(e => e.CmpId)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CmpID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Location)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ProgramId)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ProgramID");

                entity.Property(e => e.ProgramUser1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProgramUser2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserPass)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cmp)
                    .WithMany(p => p.OmsCustomerPrograms)
                    .HasForeignKey(d => d.CmpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__omsCustom__CmpID__7167D3BD");

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.OmsCustomerPrograms)
                    .HasForeignKey(d => d.ProgramId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__omsCustom__Progr__725BF7F6");
            });

            modelBuilder.Entity<OmsProgram>(entity =>
            {
                entity.HasKey(e => e.ProgramId)
                    .HasName("PK__omsProgr__752560381743E281");

                entity.ToTable("omsProgram");

                entity.Property(e => e.ProgramId)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ProgramID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ProgramDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProgramName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<OrdDiv>(entity =>
            {
                entity.ToTable("ordDiv");

                entity.HasIndex(e => e.OrdId, "nci_wi_ordDiv_603098CFEBFB498C617AA910D948C991");

                entity.Property(e => e.OrdDivId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OrdDivID");

                entity.Property(e => e.ApprovalSchedulePickUp)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("approvalSchedulePickUp");

                entity.Property(e => e.ArriveFriedForwarder).HasColumnType("smalldatetime");

                entity.Property(e => e.Attachments).HasDefaultValueSql("((0))");

                entity.Property(e => e.AwbinstructionsSent)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("AWBInstructionsSent");

                entity.Property(e => e.BillAddress1)
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.BillAddress2)
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.BillAddress3)
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.BillCity)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.BillCompany)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.BillCountry)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.BillEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BillFax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillFirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillLastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillPostCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillRegion)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.BillTitle)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BookingDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Carrier)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ChgEmId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("chgEmID");

                entity.Property(e => e.ChgLog)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("chgLog");

                entity.Property(e => e.ChgType)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("chgType");

                entity.Property(e => e.CompanyPo)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("CompanyPO");

                entity.Property(e => e.Delivered).HasColumnType("smalldatetime");

                entity.Property(e => e.Descr)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.DestServicePro)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationCity)
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.Dispached).HasColumnType("smalldatetime");

                entity.Property(e => e.DispatchFromIpa)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DispatchFromIPA");

                entity.Property(e => e.EstDelivDate).HasColumnType("smalldatetime");

                entity.Property(e => e.FobnamedLocation).HasColumnName("FOBNamedLocation");

                entity.Property(e => e.FobnamedPlace)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("FOBNamedPlace");

                entity.Property(e => e.FtAcknowledge).HasColumnType("text");

                entity.Property(e => e.FtBankDetails).HasColumnType("text");

                entity.Property(e => e.FtDeliverTo).HasColumnType("text");

                entity.Property(e => e.FtDelivery).HasColumnType("text");

                entity.Property(e => e.FtDeliveryDelay).HasColumnType("text");

                entity.Property(e => e.FtOnAbout).HasColumnType("text");

                entity.Property(e => e.FtPaymentTerms).HasColumnType("text");

                entity.Property(e => e.FtPriceValidity).HasColumnType("text");

                entity.Property(e => e.FtQuestionsContact).HasColumnType("text");

                entity.Property(e => e.FtShipmentBy).HasColumnType("text");

                entity.Property(e => e.FtSig).HasColumnType("text");

                entity.Property(e => e.FtTransitTime).HasColumnType("text");

                entity.Property(e => e.HasAwb)
                    .HasColumnName("HasAWB")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HasBfl).HasColumnName("HasBFL");

                entity.Property(e => e.HasBol)
                    .HasColumnName("HasBOL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HasCer).HasColumnName("HasCER");

                entity.Property(e => e.HasCfe).HasColumnName("HasCFE");

                entity.Property(e => e.HasCod)
                    .HasColumnName("HasCOD")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HasCog).HasColumnName("HasCOG");

                entity.Property(e => e.HasCoo).HasColumnName("HasCOO");

                entity.Property(e => e.HasCou).HasColumnName("HasCOU");

                entity.Property(e => e.HasCtx).HasColumnName("HasCTX");

                entity.Property(e => e.HasIns).HasColumnName("HasINS");

                entity.Property(e => e.HasIwo).HasColumnName("HasIWO");

                entity.Property(e => e.HasMak).HasColumnName("HasMAK");

                entity.Property(e => e.HasOth).HasColumnName("HasOTH");

                entity.Property(e => e.HasPac).HasColumnName("HasPAC");

                entity.Property(e => e.HasPkl)
                    .HasColumnName("HasPKL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HasPsi).HasColumnName("HasPSI");

                entity.Property(e => e.HasTkb).HasColumnName("HasTKB");

                entity.Property(e => e.HasTl).HasColumnName("HasTL");

                entity.Property(e => e.HasWoi).HasColumnName("HasWOI");

                entity.Property(e => e.HdRe)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HdrOnBehalf).HasColumnType("text");

                entity.Property(e => e.InvHeader)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastItemDelivered).HasColumnType("smalldatetime");

                entity.Property(e => e.Nb)
                    .HasColumnType("text")
                    .HasColumnName("NB");

                entity.Property(e => e.O00date)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("O00Date");

                entity.Property(e => e.O01date)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("O01Date");

                entity.Property(e => e.O03date)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("O03Date");

                entity.Property(e => e.O04date)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("O04Date");

                entity.Property(e => e.O05date)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("O05Date");

                entity.Property(e => e.O07date)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("O07Date");

                entity.Property(e => e.O08date)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("O08Date");

                entity.Property(e => e.O09date)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("O09Date");

                entity.Property(e => e.O0cdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("O0CDate");

                entity.Property(e => e.O0fdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("O0FDate");

                entity.Property(e => e.O11date)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("O11Date");

                entity.Property(e => e.O12date)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("O12Date");

                entity.Property(e => e.O13date)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("O13Date");

                entity.Property(e => e.O14date)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("O14Date");

                entity.Property(e => e.O15date)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("O15Date");

                entity.Property(e => e.O17date)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("O17Date");

                entity.Property(e => e.O18date)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("O18Date");

                entity.Property(e => e.O99date)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("O99Date");

                entity.Property(e => e.OrdDate).HasColumnType("smalldatetime");

                entity.Property(e => e.OrdDeadline).HasColumnType("smalldatetime");

                entity.Property(e => e.OrdDiv1).HasColumnName("OrdDiv");

                entity.Property(e => e.OrdExTotal)
                    .HasColumnType("decimal(9, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OrdFtTotal)
                    .HasColumnType("decimal(9, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OrdId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OrdID");

                entity.Property(e => e.OrdTotal)
                    .HasColumnType("decimal(9, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OrdVendTotal)
                    .HasColumnType("decimal(9, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderCompleted).HasColumnType("smalldatetime");

                entity.Property(e => e.OriginServicePro)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PickUpRequested).HasColumnType("smalldatetime");

                entity.Property(e => e.PriceValidDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Processed).HasColumnType("smalldatetime");

                entity.Property(e => e.ProgramId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ProgramID");

                entity.Property(e => e.PromDelivDate).HasColumnType("smalldatetime");

                entity.Property(e => e.QuotedArrivalDate).HasColumnType("smalldatetime");

                entity.Property(e => e.QuotedShipDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ShipAddress1)
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.ShipAddress2)
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.ShipAddress3)
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.ShipCity)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ShipCompany)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ShipCountry)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ShipFax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipFirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipLastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipPostCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipRegion)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ShipTitle)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SigFileName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("sigFileName");

                entity.Property(e => e.StatusDb)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("StatusDB");

                entity.Property(e => e.StatusDeadline).HasColumnType("smalldatetime");

                entity.Property(e => e.StatusOr)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("StatusOR");

                entity.Property(e => e.StatusOrlast)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("StatusORLast");

                entity.Property(e => e.TotalType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TotalTypeTo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransitServicePro)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.User1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.User2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VendorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VendorID");

                entity.Property(e => e.Version)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.WarehousePackCompleted).HasColumnType("smalldatetime");

                entity.Property(e => e.WorkOrdertoWarehouse).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<OrdDocAirwayBill>(entity =>
            {
                entity.HasKey(e => e.OrdDivId);

                entity.ToTable("ordDoc_AirwayBill");

                entity.Property(e => e.OrdDivId)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Airline)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.AirportofDeparture)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.AirportofDestination)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.ApproxDim).HasColumnType("text");

                entity.Property(e => e.CargoOnHand)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ChgEmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("chgEmID");

                entity.Property(e => e.ChgLog)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("chgLog");

                entity.Property(e => e.Consignee).HasColumnType("text");

                entity.Property(e => e.Exist).HasDefaultValueSql("((1))");

                entity.Property(e => e.FootAdvise)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FootNb)
                    .HasColumnType("text")
                    .HasColumnName("FootNB");

                entity.Property(e => e.FormDate).HasColumnType("smalldatetime");

                entity.Property(e => e.FxCurrencyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fxCurrencyCode");

                entity.Property(e => e.FxRate).HasColumnName("fxRate");

                entity.Property(e => e.FxTransportOrderAmt).HasColumnName("fxTransportOrderAmt");

                entity.Property(e => e.Invoice)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Markings).HasColumnType("text");

                entity.Property(e => e.MasterShipmentNum)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("masterShipmentNum");

                entity.Property(e => e.Notify).HasColumnType("text");

                entity.Property(e => e.OrdName)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTerm)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("Payment_Term");

                entity.Property(e => e.PhoneContact)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceofDelivery)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceofReciept)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.RatePerKg)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RefNum)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("refNum");

                entity.Property(e => e.RefNumbers)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.Routing)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.ShipCompany)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ShipFullName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Shipper).HasColumnType("text");

                entity.Property(e => e.StatusDb)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("StatusDB");

                entity.Property(e => e.SubmittedToAccounting).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<OrdDocAirwayBillRate>(entity =>
            {
                entity.HasKey(e => e.RateId)
                    .HasName("PK__ordDoc_A__58A7CCBCFE63E277");

                entity.ToTable("ordDoc_AirwayBill_Rates");

                entity.Property(e => e.RateId).HasColumnName("RateID");

                entity.Property(e => e.Currency)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyTotal).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Fxrate).HasColumnName("FXRate");

                entity.Property(e => e.Item)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Minimum).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.OrdDivId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OrdDivID");

                entity.Property(e => e.Rate).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.UnitOfMeasure)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Usdtotal)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("USDTotal");

                entity.HasOne(d => d.OrdDiv)
                    .WithMany(p => p.OrdDocAirwayBillRates)
                    .HasForeignKey(d => d.OrdDivId)
                    .HasConstraintName("FK__ordDoc_Ai__OrdDi__73501C2F");
            });

            modelBuilder.Entity<OrdDocBillOfLading>(entity =>
            {
                entity.HasKey(e => new { e.OrdDivId, e.Sno });

                entity.ToTable("ordDoc_BillOfLading");

                entity.Property(e => e.OrdDivId)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Sno).HasColumnName("sno");

                entity.Property(e => e.CargoOnHand).IsUnicode(false);

                entity.Property(e => e.Carrier)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.ChgEmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("chgEmID");

                entity.Property(e => e.ChgLog)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("chgLog");

                entity.Property(e => e.Consignee).HasColumnType("text");

                entity.Property(e => e.ContainerNum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContainerWeight)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Exist).HasDefaultValueSql("((1))");

                entity.Property(e => e.FootAdvise)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FootNb)
                    .HasColumnType("text")
                    .HasColumnName("FootNB");

                entity.Property(e => e.FormDate).HasColumnType("smalldatetime");

                entity.Property(e => e.FreightPayableAt)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FxCurrencyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fxCurrencyCode");

                entity.Property(e => e.FxRate).HasColumnName("fxRate");

                entity.Property(e => e.FxTransportOrderAmt).HasColumnName("fxTransportOrderAmt");

                entity.Property(e => e.Instructions).HasColumnType("text");

                entity.Property(e => e.Invoice)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Markings).HasColumnType("text");

                entity.Property(e => e.MasterShipmentNum)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("masterShipmentNum");

                entity.Property(e => e.NoTypePkgs).HasColumnType("text");

                entity.Property(e => e.Notify).HasColumnType("text");

                entity.Property(e => e.PaymentTerm)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("Payment_Term");

                entity.Property(e => e.PlaceOfDelivery)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceofReceipt)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.PortOfDischarge)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PortOfLoading)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RefNum)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("refNum");

                entity.Property(e => e.RefNumbers)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.Routing)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.SeaQty)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SeaType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SealNum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipCompany)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShipFullName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Shipper).HasColumnType("text");

                entity.Property(e => e.StatusDb)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("StatusDB");

                entity.Property(e => e.SubmittedToAccounting).HasColumnType("smalldatetime");

                entity.Property(e => e.TransporTerms)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.Vessel)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VoyageNum)
                    .HasMaxLength(225)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdDocBillOfLadingRate>(entity =>
            {
                entity.HasKey(e => e.BillRateId)
                    .HasName("PK__ordDoc_B__3B1A241F1F2C3F41");

                entity.ToTable("ordDoc_BillOfLading_Rates");

                entity.Property(e => e.BillRateId).HasColumnName("BillRateID");

                entity.Property(e => e.Currency)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyTotal).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Fxrate).HasColumnName("FXRate");

                entity.Property(e => e.Item)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Minimum).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.OrdDivId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OrdDivID");

                entity.Property(e => e.Rate).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Sno).HasColumnName("sno");

                entity.Property(e => e.UnitOfMeasure)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Usdtotal)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("USDTotal");

                entity.HasOne(d => d.OrdDiv)
                    .WithMany(p => p.OrdDocBillOfLadingRates)
                    .HasForeignKey(d => d.OrdDivId)
                    .HasConstraintName("FK__ordDoc_Bi__OrdDi__74444068");
            });

            modelBuilder.Entity<OrdDocBillRateHeader>(entity =>
            {
                entity.HasKey(e => e.BillHearderId)
                    .HasName("PK__ordDoc_B__E92FC73293B6DBB8");

                entity.ToTable("ordDoc_BillRateHeaders");

                entity.Property(e => e.BillType)
                    .IsRequired()
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.Currency)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fxrate).HasColumnName("FXRate");

                entity.Property(e => e.Name)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.UnitofMeasure)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdDocCertOfDonation>(entity =>
            {
                entity.HasKey(e => e.OrdDivId);

                entity.ToTable("ordDoc_CertOfDonation");

                entity.Property(e => e.OrdDivId)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.DescrOfGoods)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.DonationsFrom)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Exist).HasDefaultValueSql("((1))");

                entity.Property(e => e.ForThePeople)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FormDate).HasColumnType("smalldatetime");

                entity.Property(e => e.FromCustom)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Project)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectRef)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.StatusDb)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("StatusDB");

                entity.Property(e => e.ToCustom)
                    .HasMaxLength(75)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdDocCertOfOrigin>(entity =>
            {
                entity.HasKey(e => e.OrdDivId)
                    .HasName("PK__ordDoc_C__B532ACF0195A3BB9");

                entity.ToTable("ordDoc_CertOfOrigin");

                entity.Property(e => e.OrdDivId)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Buyer).IsUnicode(false);

                entity.Property(e => e.Certification).IsUnicode(false);

                entity.Property(e => e.ClientPo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ClientPO");

                entity.Property(e => e.Consignee)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.CountryOfDest)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CountryOfOrg)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfCert).HasColumnType("datetime");

                entity.Property(e => e.DateofInvoice).HasColumnType("datetime");

                entity.Property(e => e.DescrOfGoods)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.Exporter).IsUnicode(false);

                entity.Property(e => e.FromCustom)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Nb)
                    .HasColumnType("text")
                    .HasColumnName("NB");

                entity.Property(e => e.ShipDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Shippedvia)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SignedBy)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.TermsofPayment)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.ToCustom)
                    .HasMaxLength(75)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdDocInsurance>(entity =>
            {
                entity.HasKey(e => e.OrdDivId);

                entity.ToTable("ordDoc_Insurance");

                entity.Property(e => e.OrdDivId)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ChgEmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("chgEmID");

                entity.Property(e => e.ChgLog)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("chgLog");

                entity.Property(e => e.Consignee).HasColumnType("text");

                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Exist).HasDefaultValueSql("((1))");

                entity.Property(e => e.FootAdvise)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FootNb)
                    .HasColumnType("text")
                    .HasColumnName("FootNB");

                entity.Property(e => e.FormDate).HasColumnType("smalldatetime");

                entity.Property(e => e.FxAmt).HasColumnName("fxAmt");

                entity.Property(e => e.FxCurrencyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fxCurrencyCode");

                entity.Property(e => e.FxRate).HasColumnName("fxRate");

                entity.Property(e => e.Instructions).HasColumnType("text");

                entity.Property(e => e.Invoice)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Markings).HasColumnType("text");

                entity.Property(e => e.NoTypePkgs).HasColumnType("text");

                entity.Property(e => e.Notify).HasColumnType("text");

                entity.Property(e => e.PaymentTerm)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("Payment_Term");

                entity.Property(e => e.ShipCompany)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShipFullName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Shipper).HasColumnType("text");

                entity.Property(e => e.StatusDb)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("StatusDB");

                entity.Property(e => e.SubmittedToAccounting).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<OrdDocIntWorkOrder>(entity =>
            {
                entity.HasKey(e => e.OrdDivId)
                    .HasName("PK__ordDoc_I__B532AD107FA41002");

                entity.ToTable("ordDoc_IntWorkOrder");

                entity.Property(e => e.OrdDivId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OrdDivID");

                entity.Property(e => e.ActualDkg)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("ActualDKG");

                entity.Property(e => e.BuyerEstCost).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.BuyerSell).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.ChgEmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("chgEmID");

                entity.Property(e => e.ChgLog)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("chgLog");

                entity.Property(e => e.EstDkg)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("EstDKG");

                entity.Property(e => e.EstPieceType)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FormDate).HasColumnType("datetime");

                entity.Property(e => e.FxCurrencyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fxCurrencyCode");

                entity.Property(e => e.FxRate).HasColumnName("fxRate");

                entity.Property(e => e.FxTransportOrderAmt).HasColumnName("fxTransportOrderAmt");

                entity.Property(e => e.InsuranceRequired)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Invoice)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTerm)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("Payment_Term");

                entity.Property(e => e.RestrictedDimensions)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RestrictedWeight)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShipCompany)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialNotes).IsUnicode(false);

                entity.Property(e => e.SubmittedToAccounting).HasColumnType("datetime");

                entity.Property(e => e.VendorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VendorID");

                entity.Property(e => e.WarehouseActualCost).HasColumnType("decimal(9, 2)");
            });

            modelBuilder.Entity<OrdDocIntWorkOrderOut>(entity =>
            {
                entity.ToTable("ordDoc_IntWorkOrder_Out");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Dkg)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("DKG");

                entity.Property(e => e.FileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FileType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Height).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Length).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.OrdDivId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OrdDivID");

                entity.Property(e => e.PieceType)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RefId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("RefID");

                entity.Property(e => e.Uom)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("UOM");

                entity.Property(e => e.Uow)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("UOW");

                entity.Property(e => e.WarehouseCost).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.WeightLbs).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Width).HasColumnType("decimal(5, 2)");
            });

            modelBuilder.Entity<OrdDocMarking>(entity =>
            {
                entity.HasKey(e => e.OrdDivId)
                    .HasName("PK__ordDoc_M__B532ACF02F94C1B6");

                entity.ToTable("ordDoc_Markings");

                entity.Property(e => e.OrdDivId)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Attn)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ATTN");

                entity.Property(e => e.ClientPo)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("ClientPO");

                entity.Property(e => e.Consignee).HasColumnType("text");

                entity.Property(e => e.Shipper).HasColumnType("text");
            });

            modelBuilder.Entity<OrdDocOtherInstr>(entity =>
            {
                entity.HasKey(e => e.OrdDivId);

                entity.ToTable("ordDoc_OtherInstr");

                entity.Property(e => e.OrdDivId)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ChgEmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("chgEmID");

                entity.Property(e => e.ChgLog)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("chgLog");

                entity.Property(e => e.Consignee).HasColumnType("text");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Exist).HasDefaultValueSql("((1))");

                entity.Property(e => e.FootAdvise)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FootNb)
                    .HasColumnType("text")
                    .HasColumnName("FootNB");

                entity.Property(e => e.FormDate).HasColumnType("smalldatetime");

                entity.Property(e => e.FxAmt).HasColumnName("fxAmt");

                entity.Property(e => e.FxCurrencyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fxCurrencyCode");

                entity.Property(e => e.FxRate).HasColumnName("fxRate");

                entity.Property(e => e.Instructions).HasColumnType("text");

                entity.Property(e => e.Invoice)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Markings).HasColumnType("text");

                entity.Property(e => e.NoTypePkgs).HasColumnType("text");

                entity.Property(e => e.Notify).HasColumnType("text");

                entity.Property(e => e.PaymentTerm)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("Payment_Term");

                entity.Property(e => e.ShipCompany)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShipFullName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Shipper).HasColumnType("text");

                entity.Property(e => e.StatusDb)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("StatusDB");

                entity.Property(e => e.SubmittedToAccounting).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<OrdDocPackListPiece>(entity =>
            {
                entity.ToTable("ordDoc_PackList_Piece");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Height).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Image).IsUnicode(false);

                entity.Property(e => e.Length).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.OrdDivId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OrdDivID");

                entity.Property(e => e.Path).HasColumnType("text");

                entity.Property(e => e.PieceType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RefId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("RefID");

                entity.Property(e => e.TransferId).HasColumnName("TransferID");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Uom)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("UOM");

                entity.Property(e => e.Uow)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("UOW");

                entity.Property(e => e.WeightKgs).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.WeightLbs).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Width).HasColumnType("decimal(9, 2)");
            });

            modelBuilder.Entity<OrdDocPackingList>(entity =>
            {
                entity.HasKey(e => e.OrdDivId);

                entity.ToTable("ordDoc_PackingList");

                entity.Property(e => e.OrdDivId)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Exist).HasDefaultValueSql("((1))");

                entity.Property(e => e.Field1)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Field2)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Field3)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Field4)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Field5)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Field5Show).HasDefaultValueSql("((0))");

                entity.Property(e => e.Field6)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Field6Show).HasDefaultValueSql("((0))");

                entity.Property(e => e.FormDate).HasColumnType("smalldatetime");

                entity.Property(e => e.HdRe)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ShipAttn)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ShipTo).HasColumnType("text");

                entity.Property(e => e.SoldAttn)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.SoldTo).HasColumnType("text");

                entity.Property(e => e.StatusDb)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("StatusDB");
            });

            modelBuilder.Entity<OrdDocPackingListItem>(entity =>
            {
                entity.HasKey(e => new { e.ItemId, e.OrdDivId, e.PieceNo });

                entity.ToTable("ordDoc_PackingList_Item");

                entity.Property(e => e.ItemId).ValueGeneratedOnAdd();

                entity.Property(e => e.OrdDivId)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.ItemOrder).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<OrdDocPackingListPiece>(entity =>
            {
                entity.HasKey(e => new { e.OrdDivId, e.PieceNo });

                entity.ToTable("ordDoc_PackingList_Piece");

                entity.Property(e => e.OrdDivId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdDocPakList>(entity =>
            {
                entity.HasKey(e => e.OrdDivId)
                    .HasName("PK__ordDoc_P__B532ACF0640C6933");

                entity.ToTable("ordDoc_PakList");

                entity.Property(e => e.OrdDivId)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ClientPo)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("ClientPO");

                entity.Property(e => e.Exist).HasDefaultValueSql("((1))");

                entity.Property(e => e.FormDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Hd)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("HD");

                entity.Property(e => e.HdRe)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nb)
                    .IsUnicode(false)
                    .HasColumnName("NB");

                entity.Property(e => e.ShipAttn).IsUnicode(false);

                entity.Property(e => e.ShipTo).IsUnicode(false);

                entity.Property(e => e.SigFileName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("sigFileName");

                entity.Property(e => e.SoldAttn).IsUnicode(false);

                entity.Property(e => e.SoldTo).IsUnicode(false);
            });

            modelBuilder.Entity<OrdDocPakListImage>(entity =>
            {
                entity.HasKey(e => e.DocId)
                    .HasName("PK__ordDoc_P__3EF1888D8669A9F3");

                entity.ToTable("ordDoc_PakList_Images");

                entity.Property(e => e.DocId).HasColumnName("DocID");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ImagePath).IsUnicode(false);

                entity.Property(e => e.OrdDivId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OrdDivID");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdDocPakListItem>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("pk_ordDoc_PakList_Item_pid");

                entity.ToTable("ordDoc_PakList_Item");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Notes).HasColumnType("text");

                entity.Property(e => e.OrdDivId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.OrdLineId)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("OrdLineID");

                entity.Property(e => e.TransferId).HasColumnName("TransferID");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdDocPakListSubItem>(entity =>
            {
                entity.ToTable("ordDoc_PakList_SubItems");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.ItemType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ManufactureId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ManufactureID");

                entity.Property(e => e.Notes).HasColumnType("text");

                entity.Property(e => e.OrdDivId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrdLineId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("OrdLineID");

                entity.Property(e => e.PieceId).HasColumnName("PieceID");

                entity.Property(e => e.ProductInfo)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TransferId).HasColumnName("TransferID");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.OrdDocPakListSubItems)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Sub_Items");

                entity.HasOne(d => d.Piece)
                    .WithMany(p => p.OrdDocPakListSubItems)
                    .HasForeignKey(d => d.PieceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Items_Piece");
            });

            modelBuilder.Entity<OrdDocPakListSubItemsSerial>(entity =>
            {
                entity.HasKey(e => e.SerialNum)
                    .HasName("PK__ordDoc_P__EB2672A361308A48");

                entity.ToTable("ordDoc_PakList_SubItems_Serial");

                entity.Property(e => e.SerialNum)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.OrdDocPakListSubItemsSerials)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK__ordDoc_PakLi__ID__7720AD13");
            });

            modelBuilder.Entity<OrdDocTruckerBill>(entity =>
            {
                entity.HasKey(e => new { e.OrdDivId, e.Sno })
                    .HasName("PK__ordDoc_T__C8EF5AB4AD51DD68");

                entity.ToTable("ordDoc_TruckerBill");

                entity.Property(e => e.OrdDivId)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Sno).HasColumnName("sno");

                entity.Property(e => e.CargoOnHand)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.ChgEmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("chgEmID");

                entity.Property(e => e.ChgLog)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("chgLog");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Exist).HasDefaultValueSql("((1))");

                entity.Property(e => e.FormDate).HasColumnType("smalldatetime");

                entity.Property(e => e.FxCurrencyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fxCurrencyCode");

                entity.Property(e => e.FxRate).HasColumnName("fxRate");

                entity.Property(e => e.FxTransportOrderAmt).HasColumnName("fxTransportOrderAmt");

                entity.Property(e => e.Invoice)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Ipa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IPA");

                entity.Property(e => e.LiftgateRequired)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.MasterShipmentNum)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("masterShipmentNum");

                entity.Property(e => e.Nb)
                    .HasColumnType("text")
                    .HasColumnName("NB");

                entity.Property(e => e.PaymentTerm)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("Payment_Term");

                entity.Property(e => e.PickupLocation).IsUnicode(false);

                entity.Property(e => e.PickupTime)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceofDelivery)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceofReceipt)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.RefNum)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("refNum");

                entity.Property(e => e.RefNums)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.ShipAddress1)
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.ShipAddress2)
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.ShipAddress3)
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.ShipAttn)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ShipATTN");

                entity.Property(e => e.ShipCity)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ShipCompany)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ShipCompny2)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.ShipCountry)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ShipFirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipLastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipPostCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipRegion)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.SubmittedToAccounting).HasColumnType("datetime");

                entity.Property(e => e.TotalTransportOrderAmt).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.TruckingLine)
                    .HasMaxLength(225)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdDocTruckerBillRate>(entity =>
            {
                entity.HasKey(e => e.TruckerRateId)
                    .HasName("PK__ordDoc_T__81E139D487F669E3");

                entity.ToTable("ordDoc_TruckerBill_Rates");

                entity.Property(e => e.TruckerRateId).HasColumnName("TruckerRateID");

                entity.Property(e => e.Currency)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyTotal).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Fxrate).HasColumnName("FXRate");

                entity.Property(e => e.Item)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Minimum).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.OrdDivId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OrdDivID");

                entity.Property(e => e.Rate).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Sno).HasColumnName("sno");

                entity.Property(e => e.UnitOfMeasure)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Usdtotal)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("USDTotal");

                entity.HasOne(d => d.OrdDiv)
                    .WithMany(p => p.OrdDocTruckerBillRates)
                    .HasForeignKey(d => d.OrdDivId)
                    .HasConstraintName("FK__ordDoc_Tr__OrdDi__7814D14C");
            });

            modelBuilder.Entity<OrdDocWorkOrderInstr>(entity =>
            {
                entity.HasKey(e => e.OrdDivId);

                entity.ToTable("ordDoc_WorkOrderInstr");

                entity.Property(e => e.OrdDivId)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ActualDkg)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("ActualDKG");

                entity.Property(e => e.BuyerEstCost).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.BuyerSell).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Consignee).HasColumnType("text");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Dimensions).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.EstDkg)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("EstDKG");

                entity.Property(e => e.EstPieceType)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Exist).HasDefaultValueSql("((1))");

                entity.Property(e => e.FootAdvise)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FootNb)
                    .HasColumnType("text")
                    .HasColumnName("FootNB");

                entity.Property(e => e.FormDate).HasColumnType("smalldatetime");

                entity.Property(e => e.FxAmt).HasColumnName("fxAmt");

                entity.Property(e => e.FxCurrencyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fxCurrencyCode");

                entity.Property(e => e.FxRate).HasColumnName("fxRate");

                entity.Property(e => e.Instructions).HasColumnType("text");

                entity.Property(e => e.InsuranceReq)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Markings).HasColumnType("text");

                entity.Property(e => e.NoTypePkgs).HasColumnType("text");

                entity.Property(e => e.Notify).HasColumnType("text");

                entity.Property(e => e.ShipCompany)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShipFullName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Shipper).HasColumnType("text");

                entity.Property(e => e.StatusDb)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("StatusDB");

                entity.Property(e => e.SubmittedToAccounting).HasColumnType("smalldatetime");

                entity.Property(e => e.WarehouseActCost).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Weight).HasColumnType("decimal(9, 2)");
            });

            modelBuilder.Entity<OrdExtCost>(entity =>
            {
                entity.ToTable("ordExtCost");

                entity.HasIndex(e => e.OrdDivId, "nci_wi_ordExtCost_6C97A0C4C4DD397DE8D5C43C321472D0");

                entity.Property(e => e.OrdExtCostId)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("OrdExtCostID");

                entity.Property(e => e.Amt)
                    .HasColumnType("decimal(9, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Descr)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.OrdDivId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OrdDivID");
            });

            modelBuilder.Entity<OrdFile>(entity =>
            {
                entity.HasKey(e => e.FileId)
                    .HasName("PK_ordfiles");

                entity.ToTable("ordFile");

                entity.HasIndex(e => e.OrdDivId, "nci_wi_ordFile_6C97A0C4C4DD397DE8D5C43C321472D0");

                entity.Property(e => e.FileId)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("FileID");

                entity.Property(e => e.ChgEmId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("chgEmID");

                entity.Property(e => e.ChgLog)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("chgLog");

                entity.Property(e => e.ChgType)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("chgType");

                entity.Property(e => e.Descr)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FileStatus)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FileType)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OrdDivId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OrdDivID");

                entity.Property(e => e.UploadDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<OrdFileShip>(entity =>
            {
                entity.HasKey(e => new { e.FileId, e.OrdShipId });

                entity.ToTable("ordFileShip");

                entity.Property(e => e.FileId)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("FileID");

                entity.Property(e => e.OrdShipId)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("OrdShipID");
            });

            modelBuilder.Entity<OrdHdr>(entity =>
            {
                entity.HasKey(e => e.OrdId);

                entity.ToTable("ordHdr");

                entity.Property(e => e.OrdId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OrdID");

                entity.Property(e => e.AltEmpId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AltEmpID");

                entity.Property(e => e.ChgEmId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("chgEmID");

                entity.Property(e => e.ChgLog)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("chgLog");

                entity.Property(e => e.ChgType)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("chgType");

                entity.Property(e => e.CmpId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CmpID");

                entity.Property(e => e.Company)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyPo)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("CompanyPO");

                entity.Property(e => e.EmpId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EmpID")
                    .HasDefaultValueSql("('none')");

                entity.Property(e => e.LastRemind).HasColumnType("smalldatetime");

                entity.Property(e => e.Office)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OfficeLetterhead)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OfficeShare)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrdDate).HasColumnType("smalldatetime");

                entity.Property(e => e.OrdDeadline).HasColumnType("smalldatetime");

                entity.Property(e => e.OrdName)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.OrdTotal).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.OrdValue)
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.ProgramId)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ProgramID");

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.OrdHdrs)
                    .HasForeignKey(d => d.ProgramId)
                    .HasConstraintName("FK__ordHdr__ProgramI__7908F585");
            });

            modelBuilder.Entity<OrdLine>(entity =>
            {
                entity.ToTable("ordLine");

                entity.HasIndex(e => e.OrdDivId, "nci_wi_ordLine_6C97A0C4C4DD397DE8D5C43C321472D0");

                entity.Property(e => e.OrdLineId)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("OrdLineID");

                entity.Property(e => e.ChgEmId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("chgEmID");

                entity.Property(e => e.ChgLog)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("chgLog");

                entity.Property(e => e.ChgType)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("chgType");

                entity.Property(e => e.Confirm)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Coo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COO");

                entity.Property(e => e.Descr)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DimHeight).HasDefaultValueSql("((0))");

                entity.Property(e => e.DimLength).HasDefaultValueSql("((0))");

                entity.Property(e => e.DimWeight).HasDefaultValueSql("((0))");

                entity.Property(e => e.DimWidth).HasDefaultValueSql("((0))");

                entity.Property(e => e.Eccn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ECCN");

                entity.Property(e => e.Hts)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HTS");

                entity.Property(e => e.ImageName).IsUnicode(false);

                entity.Property(e => e.ItemId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ItemID");

                entity.Property(e => e.LastRemind).HasColumnType("smalldatetime");

                entity.Property(e => e.ManufactureId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ManufactureID");

                entity.Property(e => e.NcQty).HasColumnName("ncQty");

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.OnOrder)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OrdDivId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OrdDivID");

                entity.Property(e => e.ParentLineId)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ParentLineID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Path).IsUnicode(false);

                entity.Property(e => e.PriceCustExt).HasDefaultValueSql("((0))");

                entity.Property(e => e.PriceCustUnit).HasDefaultValueSql("((0))");

                entity.Property(e => e.PriceVendExt).HasDefaultValueSql("((0))");

                entity.Property(e => e.PriceVendUnit).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.Qty).HasDefaultValueSql("((0))");

                entity.Property(e => e.Receipt).IsUnicode(false);

                entity.Property(e => e.Sch)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SCH");

                entity.Property(e => e.Status)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('L01')");

                entity.Property(e => e.Tier2Id).HasColumnName("Tier2ID");

                entity.Property(e => e.UnitOfDimension)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnitOfMeasure)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnitOfWeight)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnspscCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VendCurrencyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vendCurrencyCode");

                entity.Property(e => e.VendCurrencyPrice).HasColumnName("vendCurrencyPrice");

                entity.Property(e => e.VendExchangeRate).HasColumnName("vendExchangeRate");

                entity.Property(e => e.VendId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("VendID");
            });

            modelBuilder.Entity<OrdLineSerial>(entity =>
            {
                entity.HasKey(e => e.SerialNum)
                    .HasName("PK__ordLineS__EB2672A3C3CF0DCA");

                entity.ToTable("ordLineSerial");

                entity.HasIndex(e => e.OrdLineId, "nci_wi_ordLineSerial_773735B09F9E5E6601F70BF0014E5308");

                entity.Property(e => e.SerialNum)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.HasAlloc).HasDefaultValueSql("('FALSE')");

                entity.Property(e => e.LineSubId).HasColumnName("LineSubID");

                entity.Property(e => e.LocId).HasColumnName("LocID");

                entity.Property(e => e.OrdLineId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OrdLineID");
            });

            modelBuilder.Entity<OrdLineSub>(entity =>
            {
                entity.HasKey(e => e.LineSubId)
                    .HasName("PK__ordLineS__150B7A8B4DACF214");

                entity.ToTable("ordLineSub");

                entity.HasIndex(e => e.OrdLineId, "nci_wi_ordLineSub_B6737C1D71100D41FFA2EE49772BD49D");

                entity.Property(e => e.LineSubId).HasColumnName("LineSubID");

                entity.Property(e => e.AllocateId).HasColumnName("AllocateID");

                entity.Property(e => e.CmpId)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CmpID");

                entity.Property(e => e.Date)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("date");

                entity.Property(e => e.DispatchLoc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FromOnHandOc)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("FromOnHandOC");

                entity.Property(e => e.InvoiceNum).IsUnicode(false);

                entity.Property(e => e.IparecNum)
                    .IsUnicode(false)
                    .HasColumnName("IPARecNum");

                entity.Property(e => e.LocId).HasColumnName("LocID");

                entity.Property(e => e.NcDescr)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("ncDescr");

                entity.Property(e => e.NcReason)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ncReason");

                entity.Property(e => e.NcResolve).HasColumnName("ncResolve");

                entity.Property(e => e.NonAllocInv).HasColumnName("non_alloc_inv");

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.OnHandLocId).HasColumnName("OnHandLocID");

                entity.Property(e => e.OnHandType)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.OrdLineId)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("OrdLineID");

                entity.Property(e => e.PickedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PickedDate).HasColumnType("date");

                entity.Property(e => e.QtyReceived).HasColumnName("qtyReceived");

                entity.Property(e => e.RtheaderId).HasColumnName("RTHeaderID");

                entity.Property(e => e.SerialNumAllocDate)
                    .HasColumnType("date")
                    .HasColumnName("SerialNum_AllocDate");

                entity.Property(e => e.ServiceProviderNum)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SublineStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubmittedToAccounting).HasColumnType("smalldatetime");

                entity.Property(e => e.TotalValue)
                    .HasColumnName("totalValue")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UnitValue)
                    .HasColumnName("unitValue")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.OrdLine)
                    .WithMany(p => p.OrdLineSubs)
                    .HasForeignKey(d => d.OrdLineId)
                    .HasConstraintName("FK__ordLineSu__OrdLi__79FD19BE");
            });

            modelBuilder.Entity<OrdReply>(entity =>
            {
                entity.ToTable("ordReply");

                entity.Property(e => e.OrdReplyId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OrdReplyID");

                entity.Property(e => e.CompanyPo)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("CompanyPO");

                entity.Property(e => e.Control).HasDefaultValueSql("((0))");

                entity.Property(e => e.CorrespondenceTopic)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("createdBy");

                entity.Property(e => e.DateSubmit).HasColumnType("smalldatetime");

                entity.Property(e => e.Message).HasColumnType("text");

                entity.Property(e => e.Name)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.OrdId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OrdID");

                entity.Property(e => e.Partial)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReplyType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdRequest>(entity =>
            {
                entity.HasKey(e => new { e.CmpId, e.Item });

                entity.ToTable("ordRequest");

                entity.Property(e => e.CmpId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CmpID");

                entity.Property(e => e.AvailabilityClass)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.DateAdded).HasColumnType("smalldatetime");

                entity.Property(e => e.Descr)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FileDescr)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ItemId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ItemID");

                entity.Property(e => e.Notes).HasColumnType("text");

                entity.Property(e => e.PricingClass)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ProductInfo)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TotalPrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.UnitPrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.VendId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("VendID");
            });

            modelBuilder.Entity<OrdShip>(entity =>
            {
                entity.ToTable("ordShip");

                entity.Property(e => e.OrdShipId)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("OrdShipID");

                entity.Property(e => e.ChgEmId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("chgEmID");

                entity.Property(e => e.ChgLog)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("chgLog");

                entity.Property(e => e.ChgType)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("chgType");

                entity.Property(e => e.Consignee)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryDate).HasColumnType("smalldatetime");

                entity.Property(e => e.EstArDate).HasColumnType("smalldatetime");

                entity.Property(e => e.EstDelivDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Etadate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("ETADate");

                entity.Property(e => e.FdDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FdDestination)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FdFlightNo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FdMasterAwb)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("FdMasterAWB");

                entity.Property(e => e.FdMasterBlno)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("FdMasterBLNo");

                entity.Property(e => e.FdMasterGen)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FdNotes).HasColumnType("text");

                entity.Property(e => e.FdPieces)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastRemind).HasColumnType("smalldatetime");

                entity.Property(e => e.OrdDivId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OrdDivID");

                entity.Property(e => e.ShipDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ShipId).HasColumnName("ShipID");

                entity.Property(e => e.ShipOptionId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ShipOptionID");

                entity.Property(e => e.ShipperHead)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.SiteUrl)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SiteURL");

                entity.Property(e => e.TrackNum)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdVend>(entity =>
            {
                entity.HasKey(e => new { e.OrdId, e.VendId, e.OrdRecall });

                entity.ToTable("ordVend");

                entity.HasIndex(e => e.OrdDivId, "nci_wi_ordVend_059CD9756BD1282DD2778A9648BF6469");

                entity.Property(e => e.OrdId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OrdID");

                entity.Property(e => e.VendId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("VendID");

                entity.Property(e => e.OrdRecall)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.AtCost).HasDefaultValueSql("((0))");

                entity.Property(e => e.BillAddress1)
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.BillAddress2)
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.BillAddress3)
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.BillCity)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.BillCompany)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.BillCountry)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.BillEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BillFax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillFirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillLastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillPostCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillRegion)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.BillTitle)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ChgEmId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("chgEmID");

                entity.Property(e => e.ChgLog)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("chgLog");

                entity.Property(e => e.ChgType)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("chgType");

                entity.Property(e => e.ChgVendDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("chgVendDate");

                entity.Property(e => e.ChgVendEmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("chgVendEmID");

                entity.Property(e => e.ConfirmNum)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyAbbr)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.FtAcknowledge).HasColumnType("text");

                entity.Property(e => e.FtDelivery).HasColumnType("text");

                entity.Property(e => e.FtOnAbout).HasColumnType("text");

                entity.Property(e => e.FtQuestionsContact).HasColumnType("text");

                entity.Property(e => e.FtShipmentBy).HasColumnType("text");

                entity.Property(e => e.FxAmt).HasColumnName("fxAmt");

                entity.Property(e => e.FxCurrencyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fxCurrencyCode");

                entity.Property(e => e.FxRate).HasColumnName("fxRate");

                entity.Property(e => e.HdrOnBehalf).HasColumnType("text");

                entity.Property(e => e.Invoice)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Ipa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IPA");

                entity.Property(e => e.LocId).HasColumnName("LocID");

                entity.Property(e => e.LocType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LocTypeId).HasColumnName("LocTypeID");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LotDesc)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Nb)
                    .HasColumnType("text")
                    .HasColumnName("NB");

                entity.Property(e => e.OffId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("offID");

                entity.Property(e => e.OrdDate).HasColumnType("smalldatetime");

                entity.Property(e => e.OrdDivId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("OrdDivID");

                entity.Property(e => e.OrdExTotal)
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OrdFtTotal)
                    .HasColumnType("decimal(9, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OrdTotal)
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OrdVendType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((1))")
                    .IsFixedLength(true);

                entity.Property(e => e.PaymentTerms)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Performance)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("performance");

                entity.Property(e => e.RequestedDate).HasColumnType("date");

                entity.Property(e => e.ShipAddress1)
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.ShipAddress2)
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.ShipAddress3)
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.ShipCity)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ShipCompany)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ShipCountry)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ShipFax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipFirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipLastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipPostCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipRegion)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ShipTitle)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.StatusConfirmedHelper)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.StatusDb)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("StatusDB");

                entity.Property(e => e.SubmittedToAccounting).HasColumnType("smalldatetime");

                entity.Property(e => e.TotalType)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TotalTypeTo)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.VendPo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VendPO");
            });

            modelBuilder.Entity<OrdVendLine>(entity =>
            {
                entity.HasKey(e => new { e.OrdRecall, e.OrdLineId });

                entity.ToTable("ordVendLine");

                entity.Property(e => e.OrdRecall)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.OrdLineId)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("OrdLineID");
            });

            modelBuilder.Entity<Packing>(entity =>
            {
                entity.HasKey(e => e.OrdDivId)
                    .HasName("PK__Packing__B532AD104C6E100B");

                entity.ToTable("Packing");

                entity.Property(e => e.OrdDivId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OrdDivID");

                entity.Property(e => e.Cdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CDate");

                entity.Property(e => e.ChgEmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("chgEmID");

                entity.Property(e => e.ChgLog)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("chgLog");

                entity.Property(e => e.FxcurCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("FXCurCode");

                entity.Property(e => e.Fxtotcost).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Invoice)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasColumnType("text");

                entity.Property(e => e.PaymentTerm)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("Payment_Term");

                entity.Property(e => e.ShipCompany)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubmittedToAccounting).HasColumnType("datetime");

                entity.Property(e => e.Usdtotcost)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("USDtotcost");
            });

            modelBuilder.Entity<PreShipIn>(entity =>
            {
                entity.HasKey(e => e.OrdDivId)
                    .HasName("PK__PreShipI__B532AD10BB020492");

                entity.Property(e => e.OrdDivId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OrdDivID");

                entity.Property(e => e.Cdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CDate");

                entity.Property(e => e.ChgEmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("chgEmID");

                entity.Property(e => e.ChgLog)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("chgLog");

                entity.Property(e => e.FxcurCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("FXCurCode");

                entity.Property(e => e.Fxtotcost).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Invoice)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasColumnType("text");

                entity.Property(e => e.PaymentTerm)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("Payment_Term");

                entity.Property(e => e.ShipCompany)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubmittedToAccounting).HasColumnType("datetime");

                entity.Property(e => e.Usdtotcost)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("USDtotcost");
            });

            modelBuilder.Entity<PrintOption>(entity =>
            {
                entity.HasKey(e => new { e.OptionType, e.OptionValue })
                    .HasName("PK_PrintOptions");

                entity.ToTable("printOptions");

                entity.Property(e => e.OptionType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OptionValue)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OptionDefaultValue)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OptionDesc).IsUnicode(false);

                entity.Property(e => e.OptionUrl)
                    .HasColumnType("text")
                    .HasColumnName("OptionURL");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updateDate");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("updatedBy");
            });

            modelBuilder.Entity<PrintOptionType>(entity =>
            {
                entity.HasKey(e => e.OptionType)
                    .HasName("PK__printOpt__5C1E8A5D7FDB87E8");

                entity.ToTable("printOptionTypes");

                entity.Property(e => e.OptionType)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updateDate");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("updatedBy");
            });

            modelBuilder.Entity<PrintOptionsExtra>(entity =>
            {
                entity.ToTable("PrintOptions_Extra");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy).IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Value).IsUnicode(false);
            });

            modelBuilder.Entity<ReturnedSerial>(entity =>
            {
                entity.HasKey(e => e.ReturnId)
                    .HasName("PK__Returned__F445E988F2BDF7E7");

                entity.ToTable("Returned_Serials");

                entity.Property(e => e.ReturnId).HasColumnName("ReturnID");

                entity.Property(e => e.FileType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LineSubId).HasColumnName("LineSubID");

                entity.Property(e => e.LocId).HasColumnName("LocID");

                entity.Property(e => e.ReturnFlag).HasDefaultValueSql("('FALSE')");

                entity.Property(e => e.SerialNum)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SubId).HasColumnName("SubID");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Right>(entity =>
            {
                entity.HasKey(e => e.RgId);

                entity.ToTable("rights");

                entity.Property(e => e.RgId)
                    .ValueGeneratedNever()
                    .HasColumnName("rgID");

                entity.Property(e => e.AccessKey)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Descr)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Level)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SelectedCity>(entity =>
            {
                entity.ToTable("SelectedCity");

                entity.Property(e => e.SelectedCityId).HasColumnName("SelectedCityID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<SessionLog>(entity =>
            {
                entity.ToTable("SessionLog");

                entity.Property(e => e.SessionLogId).HasColumnName("SessionLogID");

                entity.Property(e => e.CmpId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CmpID");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RequestXml)
                    .IsUnicode(false)
                    .HasColumnName("RequestXML");

                entity.Property(e => e.ResponseXml)
                    .IsUnicode(false)
                    .HasColumnName("ResponseXML");

                entity.Property(e => e.SessionId)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SessionID");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.SessionLogs)
                    .HasPrincipalKey(p => p.SessionId)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SessionLo__Sessi__7AF13DF7");
            });

            modelBuilder.Entity<ShipOption>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("shipOptions");

                entity.HasIndex(e => e.ShipOptionId, "ci_azure_fixup_dbo_shipOptions")
                    .IsClustered();

                entity.Property(e => e.ShipOption1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ShipOption");

                entity.Property(e => e.ShipOptionId).HasColumnName("ShipOptionID");
            });

            modelBuilder.Entity<Shipper>(entity =>
            {
                entity.HasKey(e => e.ShipId);

                entity.ToTable("shippers");

                entity.Property(e => e.ShipId)
                    .ValueGeneratedNever()
                    .HasColumnName("ShipID");

                entity.Property(e => e.BaseUrl)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("BaseURL");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TrackUrl)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("TrackURL");

                entity.Property(e => e.UserName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UserPass)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.HasKey(e => e.StatusCode);

                entity.ToTable("status");

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Descr)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Status");
            });

            modelBuilder.Entity<SurveyDetail>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Category).HasColumnType("text");

                entity.Property(e => e.ConfirmNum)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.IpaclientService).HasColumnName("IPAClientService");

                entity.Property(e => e.Ipafinance).HasColumnName("IPAFinance");

                entity.Property(e => e.Ipawarehouse).HasColumnName("IPAWarehouse");

                entity.Property(e => e.Notes).HasColumnType("text");

                entity.HasOne(d => d.ConfirmNumNavigation)
                    .WithMany(p => p.SurveyDetails)
                    .HasForeignKey(d => d.ConfirmNum)
                    .HasConstraintName("fk_sur_ConfirmNum");
            });

            modelBuilder.Entity<SurveyHeader>(entity =>
            {
                entity.HasKey(e => e.ConfirmNum)
                    .HasName("PK__SurveyHe__AD389722940217CD");

                entity.ToTable("SurveyHeader");

                entity.Property(e => e.ConfirmNum)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ChgEmId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("chgEmID");

                entity.Property(e => e.ChgLog)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("chgLog");

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Telephone)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TransferHeader>(entity =>
            {
                entity.HasKey(e => e.TransferId)
                    .HasName("PK__Transfer__954901715E5A3BDA");

                entity.Property(e => e.TransferId).HasColumnName("TransferID");

                entity.Property(e => e.ClientPo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ClientPO");

                entity.Property(e => e.CompletionDate).HasColumnType("datetime");

                entity.Property(e => e.FileDescr)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FileNo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FromShipAddress1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FromShipAddress2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FromShipAddress3)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FromShipAttn)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("FromShipATTN");

                entity.Property(e => e.FromShipCity)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FromShipCountry)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FromShipFirstName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FromShipPhone)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FromShipPostCode)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FromShipRegion)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FromShipSecondName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FxCurrencyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fxCurrencyCode");

                entity.Property(e => e.ImageName).IsUnicode(false);

                entity.Property(e => e.LineSubId).HasColumnName("LineSubID");

                entity.Property(e => e.Nb)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NB");

                entity.Property(e => e.OrdDivId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OrdDivID");

                entity.Property(e => e.Path).IsUnicode(false);

                entity.Property(e => e.SigFileName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("sigFileName");

                entity.Property(e => e.Sno).HasColumnName("sno");

                entity.Property(e => e.ToFacilityName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ToShipAddress1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ToShipAddress2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ToShipAddress3)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ToShipAttn)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ToShipATTN");

                entity.Property(e => e.ToShipCity)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ToShipCountry)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ToShipFirstName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ToShipPhone)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ToShipPostCode)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ToShipRegion)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ToShipSecondName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TransferDate).HasColumnType("datetime");

                entity.Property(e => e.TransferRef)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TransferItem>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK__Transfer__727E83EB76A4B7B3");

                entity.ToTable("Transfer_Item");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LineSubId).HasColumnName("LineSubID");

                entity.Property(e => e.Notes).HasColumnType("text");

                entity.Property(e => e.OrdDivId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OrdDivID");

                entity.Property(e => e.TransferId).HasColumnName("TransferID");
            });

            modelBuilder.Entity<TransferNotePiece>(entity =>
            {
                entity.ToTable("TransferNote_Piece");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Height).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Length).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LineSubId).HasColumnName("LineSubID");

                entity.Property(e => e.OrdDivId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OrdDivID");

                entity.Property(e => e.PieceType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransferId).HasColumnName("TransferID");

                entity.Property(e => e.Uom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UOM");

                entity.Property(e => e.Uow)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UOW");

                entity.Property(e => e.WeightKgs).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.WeightLbs).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Width).HasColumnType("decimal(5, 2)");
            });

            modelBuilder.Entity<TransferSubItem>(entity =>
            {
                entity.HasKey(e => e.SubItemId)
                    .HasName("PK__Transfer__8A6B75A5FA365441");

                entity.ToTable("Transfer_SubItems");

                entity.Property(e => e.SubItemId).HasColumnName("SubItemID");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.LineSubId).HasColumnName("LineSubID");

                entity.Property(e => e.Notes)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OrdDivId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OrdDivID");

                entity.Property(e => e.PieceId).HasColumnName("PieceID");

                entity.Property(e => e.TransferId).HasColumnName("TransferID");
            });

            modelBuilder.Entity<TransferSubItemsSerial>(entity =>
            {
                entity.HasKey(e => e.SerialNum)
                    .HasName("PK__Transfer__EB2672A396396563");

                entity.ToTable("Transfer_SubItems_Serials");

                entity.Property(e => e.SerialNum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubItemId).HasColumnName("SubItemID");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.Property(e => e.UserId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("UserID");

                entity.Property(e => e.Address1)
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.Address3)
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasMaxLength(750)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DefaultCmpId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("DefaultCmpID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.UserPass)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UsersTokenCache>(entity =>
            {
                entity.HasKey(e => e.TokenId)
                    .HasName("PK__UsersTok__658FEE8AF50D17B6");

                entity.ToTable("UsersTokenCache");

                entity.Property(e => e.TokenId).HasColumnName("TokenID");

                entity.Property(e => e.CacheBits)
                    .HasMaxLength(7000)
                    .HasColumnName("cacheBits")
                    .IsFixedLength(true);

                entity.Property(e => e.Uniquecookie)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("uniquecookie");

                entity.Property(e => e.UserId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("userID");
            });

            modelBuilder.Entity<VendLibMain>(entity =>
            {
                entity.HasKey(e => e.VendTier1Id)
                    .HasName("vendLibMainPK");

                entity.ToTable("vendLibMain");

                entity.HasIndex(e => e.VendTier1, "vendLibMainUK")
                    .IsUnique();

                entity.Property(e => e.VendTier1Id).HasColumnName("vendTier1ID");

                entity.Property(e => e.VendTier1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vendTier1");
            });

            modelBuilder.Entity<VendLibSub>(entity =>
            {
                entity.HasKey(e => e.VendTier2Id)
                    .HasName("vendLibSubPK");

                entity.ToTable("vendLibSub");

                entity.HasIndex(e => new { e.VendTier1Id, e.VendTier2 }, "vendLibSubUK")
                    .IsUnique();

                entity.Property(e => e.VendTier2Id).HasColumnName("vendTier2ID");

                entity.Property(e => e.VendTier1Id).HasColumnName("vendTier1ID");

                entity.Property(e => e.VendTier2)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vendTier2");
            });

            modelBuilder.Entity<VendTier>(entity =>
            {
                entity.HasKey(e => new { e.VendId, e.VendTier2Id })
                    .HasName("vendTiersPK");

                entity.ToTable("vendTiers");

                entity.Property(e => e.VendId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("vendID");

                entity.Property(e => e.VendTier2Id).HasColumnName("vendTier2ID");
            });

            modelBuilder.Entity<Vendor>(entity =>
            {
                entity.HasKey(e => e.VendId);

                entity.ToTable("vendor");

                entity.Property(e => e.VendId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("VendID");

                entity.Property(e => e.AcctNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Address3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ChgEmId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("chgEmID");

                entity.Property(e => e.ChgLog)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("chgLog");

                entity.Property(e => e.ChgType)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("chgType");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).HasColumnType("text");

                entity.Property(e => e.Company)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Descr).HasColumnType("text");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstNamePri)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstNameSec)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastNamePri)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastNameSec)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Misc)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OnHand).HasDefaultValueSql("('FALSE')");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Product).HasColumnType("text");

                entity.Property(e => e.Region)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.StatusDb)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("StatusDB")
                    .HasDefaultValueSql("('LIV')");

                entity.Property(e => e.TitlePri)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TitleSec)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.VendStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vendStatus");

                entity.Property(e => e.VendTier2Id)
                    .HasColumnName("vendTier2ID")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<VendorV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vendor_v");

                entity.Property(e => e.AcctNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Address3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ChgEmId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("chgEmID");

                entity.Property(e => e.ChgLog)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("chgLog");

                entity.Property(e => e.ChgType)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("chgType");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).HasColumnType("text");

                entity.Property(e => e.Company)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Descr).HasColumnType("text");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstNamePri)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstNameSec)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastNamePri)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastNameSec)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Misc)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Product).HasColumnType("text");

                entity.Property(e => e.Region)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.StatusDb)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("StatusDB");

                entity.Property(e => e.TitlePri)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TitleSec)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.VendId)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("VendID");

                entity.Property(e => e.VendTier)
                    .IsRequired()
                    .HasMaxLength(101)
                    .IsUnicode(false)
                    .HasColumnName("vendTier");

                entity.Property(e => e.VendTier1Id).HasColumnName("vendTier1ID");

                entity.Property(e => e.VendTier2Id).HasColumnName("vendTier2ID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
