
namespace Domain.CreateGasCondensate;

public class CreateGasCondensateUseCase : ICreateGasCondensateUseCase
{
    private readonly IGasCondensateGateway _gasCondensateGateway;

    public CreateGasCondensateUseCase(IGasCondensateGateway gasCondensateGateway)
    {
        _gasCondensateGateway = gasCondensateGateway;
    }

    public Task<bool> CanExecute(IPresenter presenter, CreateGasCondensateRequest request)
    {
        return Task.FromResult(true);
    }

    public Task Execute(IPresenter presenter, CreateGasCondensateRequest request)
    {
        var gasCondenstate = GasCondensate.Craete(request.Id, request.FieldName, request.Latitude, request.Longitude,
            request.ProductionRate, request.Cost, request.YearOfExtraction, request.MaintenanceType);
        _gasCondensateGateway.Add(gasCondenstate);

        presenter.Success(new EmptyResponse());

        return Task.CompletedTask;
    }
}