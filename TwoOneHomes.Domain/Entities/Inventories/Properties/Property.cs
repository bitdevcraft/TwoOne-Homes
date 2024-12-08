using TwoOneHomes.Domain.Entities.Accounts;
using TwoOneHomes.Domain.Entities.Inventories.PaymentPlans;
using TwoOneHomes.Domain.Entities.Inventories.Properties.Enums;

namespace TwoOneHomes.Domain.Entities.Inventories.Properties;

public class Property : BaseProperty
{
    public Property(Account account) : base(account)
    {
    }


    // Common
    public bool IsFurnished { get; set; }
    public string? Remarks { get; set; }
    public string? LocationView { get; set; }
    public decimal BalconyAreaSqFt { get; set; }
    public decimal CommonAreaSqFt { get; set; }
    public decimal UnitAreaSqFt { get; set; }
    public PropertyUseType UseType { get; set; }

    // Type-Unit
    public string? BuildingNo { get; set; }
    public int BuildingFloorCount { get; set; }
    public string? UnitNumber { get; set; }
    public string? Floor { get; set; }
    public int RoomCount { get; set; }
    public int BathroomCount { get; set; }
    public int ParkingCount { get; set; }

    
    // Type-Villa
    public string? VillaNumber { get; set; }

    // Type-Plot
    public string? PlotNumber { get; set; }
    
    // Category-Selling
    public decimal? PricePerSqFt { get; set; }
   
    private double? _areaSqFt; // Backing field for square feet
    private double? _areaSqM;  // Backing field for square meters
    private const double ConversionFactor = 10.7639; // Conversion factor: 1 square meter = 10.7639 square feet

    public double? AreaSqFt
    {
        get => _areaSqFt ?? (_areaSqM.HasValue ? _areaSqM * ConversionFactor : null);
        set
        {
            _areaSqFt = value;
            _areaSqM = value.HasValue ? value / ConversionFactor : null;
        }
    }

    public double? AreaSqM
    {
        get => _areaSqM ?? (_areaSqFt.HasValue ? _areaSqFt / ConversionFactor : null);
        set
        {
            _areaSqM = value;
            _areaSqFt = value.HasValue ? value * ConversionFactor : null;
        }
    }
    
    public PaymentPlan? PaymentPlan { get; set; }
    public Ulid? PaymentPlanId { get; set; }
    
    // Category-Rental
    public decimal RentalPrice { get; set; }
    public int MaxOccupancy { get; set; }
    public string? Rules { get; set; }
    
    
    // Category-Leasing
    public decimal LeasePrice { get; set; }
    public int LeaseDurationMonths { get; set; }
    public PropertyLeasePaymentTerm LeasePaymentTerm { get; set; }
}