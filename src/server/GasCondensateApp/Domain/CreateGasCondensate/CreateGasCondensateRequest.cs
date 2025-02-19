namespace Domain.CreateGasCondensate;

public record CreateGasCondensateRequest(string FieldName, string Latitude, string Longitude, 
    decimal ProductionRate, decimal Cost, int YearOfExtraction, string MaintenanceType);