using Controllers.Persenters;
using Domain.CreateGasCondensate;
using Microsoft.AspNetCore.Mvc;

namespace Controllers.Controllers;

[ApiController]
[Route("create-gas-condensate")]
public class CreateGasCondensateController : ControllerBase
{
    private readonly IActionResultPresenter<CreateGasCondensateResponse> _presenter;
    private readonly ICreateGasCondensateUseCase _useCase;

    public CreateGasCondensateController(
        IActionResultPresenter<CreateGasCondensateResponse> presenter, 
        ICreateGasCondensateUseCase useCase)
    {
        _presenter = presenter;
        _useCase = useCase;
    }


    [HttpPost(Name = "CreateGasCondensate")]
    public async Task<IActionResult> Create(CreateGasCondensateRequest request)
    {
        var canExecute = await _useCase.CanExecute(_presenter, request);
        if (!canExecute) return _presenter.Render();

        await _useCase.Execute(_presenter, request);
        return _presenter.Render();
    }
}
