
namespace Domain.DisplayGasCondensateList;

public class DisplayGasCondensateListUseCase : IDisplayGasCondensateListUseCase
{
    private readonly IGasCondensateGateway _gasCondensateGateway;

    public DisplayGasCondensateListUseCase(IGasCondensateGateway gasCondensateGateway)
    {
        _gasCondensateGateway = gasCondensateGateway;
    }

    public Task<bool> CanExecute(IPresenter presenter)
    {
        return Task.FromResult(true);
    }

    public Task Execute(IPresenter presenter)
    {
        var gasCondensateList = _gasCondensateGateway.GetAll();

        var gasCondensateListDto = new List<GasCondensateDto>();
        foreach (var gasCondensate in gasCondensateList)
        {
            var gasCondenstateDto = new GasCondensateDto
            {
                Id = gasCondensate.Id,
                FieldName = gasCondensate.FieldName,
                Latitude = gasCondensate.Latitude,
                Longitude = gasCondensate.Longitude,
                ProductionRate = gasCondensate.ProductionRate,
                Cost = gasCondensate.Cost,
                YearOfExtraction = gasCondensate.YearOfExtraction,
                MaintenanceType = gasCondensate.MaintenanceType
            };
            gasCondensateListDto.Add(gasCondenstateDto);
        }

        var response = new DisplayGasCondensateListResponse(gasCondensateListDto);
        presenter.Success(response);

        return Task.CompletedTask;
    }
}
