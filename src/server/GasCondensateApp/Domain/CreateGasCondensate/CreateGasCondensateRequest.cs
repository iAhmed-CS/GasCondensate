namespace Domain.CreateGasCondensate;

public record CreateGasCondensateRequest(string Id, string FieldName, decimal Latitude, decimal Longitude, 
    decimal ProductionRate, decimal Cost, int YearOfExtraction, string MaintenanceType);