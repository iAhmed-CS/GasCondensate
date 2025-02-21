using Controllers.Persenters;
using Domain.CreateGasCondensate;
using Microsoft.AspNetCore.Mvc;

namespace Controllers.Controllers;

[ApiController]
[Route("[controller]")]
public class CreateGasCondensateController : ControllerBase
{
    private readonly IActionResultPresenter _presenter;
    private readonly ICreateGasCondensateUseCase _useCase;

    public CreateGasCondensateController(
        IActionResultPresenter presenter, 
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
