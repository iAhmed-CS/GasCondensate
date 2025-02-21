namespace Domain;

public interface IPresenter
{
    void Success<T>(T response);
    void Error<T>(T error);
}