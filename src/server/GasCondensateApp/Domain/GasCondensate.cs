namespace Domain;

public class GasCondensate
{
    public static GasCondensate Craete (string id, string fieldName, string latitude, string longitude, 
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
    public string Latitude { get; set; } = string.Empty;
    public string Longitude { get; set; } = string.Empty;
    public decimal ProductionRate { get; set; }
    public decimal Cost { get; set; }
    public int YearOfExtraction { get; set; }
    public string MaintenanceType { get; set; } = string.Empty;
}