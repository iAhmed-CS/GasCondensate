namespace Domain;

public class GasCondensate
{
    public static GasCondensate Craete (string id, string fieldName, decimal latitude, decimal longitude, 
        decimal productionRate, decimal cost, int yearOfExtraction, string maintenanceType)
    {
        return new GasCondensate
        {
            Id = id,
            FieldName = fieldName,
            Latitude = latitude,
            Longitude = longitude,
            ProductionRate = productionRate,
            Cost = cost,
            YearOfExtraction = yearOfExtraction,
            MaintenanceType = maintenanceType,
        };
    }

    public string Id { get; set; } = string.Empty;
    public string FieldName { get; set; } = string.Empty;
    public decimal Latitude { get; set; }
    public decimal Longitude { get; set; }
    public decimal ProductionRate { get; set; }
    public decimal Cost { get; set; }
    public int YearOfExtraction { get; set; }
    public string MaintenanceType { get; set; } = string.Empty;
}