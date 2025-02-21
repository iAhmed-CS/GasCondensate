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
                Latitude = "21.12346",
                Longitude = "55.123456",
                ProductionRate = 800M,
                Cost = 500000M,
                YearOfExtraction = 2022,
                MaintenanceType = "M1"
            },
            new()
            {
                Id = "2",
                FieldName = "North Oman",
                Latitude = "22.65432",
                Longitude = "56.654321",
                ProductionRate = 1200M,
                Cost = 1200000M,
                YearOfExtraction = 2021,
                MaintenanceType = "M2"
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
