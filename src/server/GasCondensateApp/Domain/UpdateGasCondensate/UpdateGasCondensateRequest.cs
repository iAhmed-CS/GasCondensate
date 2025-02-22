namespace Domain.UpdateGasCondensate;

public record UpdateGasCondensateRequest(string Id, string FieldName, decimal Latitude, decimal Longitude,
    decimal ProductionRate, decimal Cost, int YearOfExtraction, string MaintenanceType);