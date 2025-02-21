namespace Domain;

public class GasCondensateDto
{
    public string Id { get; set; } = string.Empty;
    public string FieldName { get; set; } = string.Empty;
    public string Latitude { get; set; } = string.Empty;
    public string Longitude { get; set; } = string.Empty;
    public decimal ProductionRate { get; set; }
    public decimal Cost { get; set; }
    public int YearOfExtraction { get; set; }
    public string MaintenanceType { get; set; } = string.Empty;
}