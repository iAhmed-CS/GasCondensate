namespace Domain.CreateGasCondensate;

[RequiredAction(RoleBasedAccess.Admins.FullAccess)]
[ActionType(ActionTypes.Create)]
public interface ICreateGasCondensateUseCase : IUseCase<CreateGasCondensateRequest, IPresenter<CreateGasCondensateResponse>>
{
}
