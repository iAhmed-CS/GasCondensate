namespace Domain.UpdateGasCondensate;

public record UpdateGasCondensateRequest(string Id, string FieldName, string Latitude, string Longitude,
    decimal ProductionRate, decimal Cost, int YearOfExtraction, string MaintenanceType);