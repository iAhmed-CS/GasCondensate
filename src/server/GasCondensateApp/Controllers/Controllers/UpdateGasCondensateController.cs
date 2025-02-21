using Controllers.Persenters;
using Domain.UpdateGasCondensate;
using Microsoft.AspNetCore.Mvc;

namespace Controllers.Controllers;

[ApiController]
[Route("[controller]")]
public class UpdateGasCondensateController : ControllerBase
{
    private readonly IActionResultPresenter _presenter;
    private readonly IUpdateGasCondensateUseCase _useCase;

    public UpdateGasCondensateController(
        IActionResultPresenter presenter,
        IUpdateGasCondensateUseCase useCase)
    {
        _presenter = presenter;
        _useCase = useCase;
    }


    [HttpPut(Name = "UpdateGasCondensate")]
    public async Task<IActionResult> Update(UpdateGasCondensateRequest request)
    {
        var canExecute = await _useCase.CanExecute(_presenter, request);
        if (!canExecute) return _presenter.Render();

        await _useCase.Execute(_presenter, request);
        return _presenter.Render();
    }
}