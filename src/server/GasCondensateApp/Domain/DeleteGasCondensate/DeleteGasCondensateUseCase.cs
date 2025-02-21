namespace Domain.DeleteGasCondensate;

public class DeleteGasCondensateUseCase : IDeleteGasCondensateUseCase
{
    private readonly IGasCondensateGateway _gasCondensateGateway;

    public DeleteGasCondensateUseCase(IGasCondensateGateway gasCondensateGateway)
    {
        _gasCondensateGateway = gasCondensateGateway;
    }

    public Task<bool> CanExecute(IPresenter presenter, DeleteGasCondensateRequest request)
    {
        return Task.FromResult(true);
    }

    public Task Execute(IPresenter presenter, DeleteGasCondensateRequest request)
    {
        _gasCondensateGateway.Delete(request.id);

        presenter.Success(new EmptyResponse());

        return Task.CompletedTask;
    }
}
