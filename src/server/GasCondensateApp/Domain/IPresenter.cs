namespace Domain;

public interface IPresenter<in T>
{
    void Success(T response);
    void Error(T error);
}