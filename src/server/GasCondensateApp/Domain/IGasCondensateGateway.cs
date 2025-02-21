namespace Domain;

public interface IGasCondensateGateway
{
    void Add(GasCondensate gasCondensate);

    List<GasCondensate> GetAll();

    GasCondensate Get(string id);

    void Delete(string id);

    void Update(GasCondensate gasCondensate);
}