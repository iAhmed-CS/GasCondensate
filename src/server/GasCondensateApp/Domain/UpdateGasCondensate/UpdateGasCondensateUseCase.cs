namespace Domain.UpdateGasCondensate;

public class UpdateGasCondensateUseCase : IUpdateGasCondensateUseCase
{
    private readonly IGasCondensateGateway _gasCondensateGateway;

    public UpdateGasCondensateUseCase(IGasCondensateGateway gasCondensateGateway)
    {
        _gasCondensateGateway = gasCondensateGateway;
    }

    public Task<bool> CanExecute(IPresenter presenter, UpdateGasCondensateRequest request)
    {
        return Task.FromResult(true);
    }

    public Task Execute(IPresenter presenter, UpdateGasCondensateRequest request)
    {
        var gasCondenstate = GasCondensate.Craete(request.Id, request.FieldName, request.Latitude, request.Longitude,
            request.ProductionRate, request.Cost, request.YearOfExtraction, request.MaintenanceType);
        _gasCondensateGateway.Update(gasCondenstate);

        presenter.Success(new EmptyResponse());

        return Task.CompletedTask;
    }
}