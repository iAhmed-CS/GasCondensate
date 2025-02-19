namespace Domain;

public class RoleBasedAccess
{
    public static class Operators
    {
        public const string ViewProductionRates = "View Production Rates";
        public const string UpdateProductionRates = "Update Production Rates";
    }

    public static class Engineers
    {
        public const string UpdateMaintenanceRecords = "Update Maintenance Records";
    }

    public static class Admins
    {
        public const string FullAccess = "Full Access";
    }
}
