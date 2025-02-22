namespace Domain;

public class GasCondensateDto
{
    public string Id { get; set; } = string.Empty;
    public string FieldName { get; set; } = string.Empty;
    public decimal Latitude { get; set; }
    public decimal Longitude { get; set; }
    public decimal ProductionRate { get; set; }
    public decimal Cost { get; set; }
    public int YearOfExtraction { get; set; }
    public string MaintenanceType { get; set; } = string.Empty;
}