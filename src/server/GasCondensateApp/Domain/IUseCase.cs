namespace Domain;

public interface IUseCase<in TRequest, in TPresenter>
{
    Task Execute(TPresenter presenter, TRequest request);
    Task<bool> CanExecute(TPresenter presenter, TRequest request);
}
