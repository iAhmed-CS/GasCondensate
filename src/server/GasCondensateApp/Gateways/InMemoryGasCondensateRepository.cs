using Domain;

namespace Gateways;

public class InMemoryGasCondensateRepository : IGasCondensateGateway
{
    public static List<GasCondensate> GasCondensateList = new()
    {
        new()
            {
                Id = "1",
                FieldName = "Al Wusta 1",
                Latitude = 21.12346M,
                Longitude = 55.123456M,
                ProductionRate = 800M,
                Cost = 500000M,
                YearOfExtraction = 2022,
                MaintenanceType = "M1"
            },
            new()
            {
                Id = "2",
                FieldName = "North Oman",
                Latitude = 22.65432M,
                Longitude = 56.654321M,
                ProductionRate = 1200M,
                Cost = 1200000M,
                YearOfExtraction = 2021,
                MaintenanceType = "M2"
            },
            new()
            {
                Id = "3",
                FieldName = "South Block",
                Latitude = 20.98765M,
                Longitude = 54.987654M,
                ProductionRate = 1500M,
                Cost = 1500000M,
                YearOfExtraction = 2020,
                MaintenanceType = "M3"
            },
            new()
            {
                Id = "4",
                FieldName = "West Basin",
                Latitude = 23.45679M,
                Longitude = 57.123456M,
                ProductionRate = 600M,
                Cost = 600000M,
                YearOfExtraction = 2021,
                MaintenanceType = "M4"
            }
    };

    public void Add(GasCondensate gasCondensate)
    {
        GasCondensateList.Add(gasCondensate);
    }

    public void Delete(string id)
    {
        var gasCondensate = Get(id);
        GasCondensateList.Remove(gasCondensate);
    }

    public GasCondensate Get(string id)
    {
        return GasCondensateList.First(gasCondensate => gasCondensate.Id == id);
    }

    public List<GasCondensate> GetAll()
    {
        return GasCondensateList;
    }

    public void Update(GasCondensate gasCondensate)
    {
        Delete(gasCondensate.Id);
        Add(gasCondensate);
    }
}
