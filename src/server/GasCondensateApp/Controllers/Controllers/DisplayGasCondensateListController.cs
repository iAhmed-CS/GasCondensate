using Controllers.Persenters;
using Domain.DisplayGasCondensateList;
using Microsoft.AspNetCore.Mvc;

namespace Controllers.Controllers;

[ApiController]
[Route("[controller]")]
public class DisplayGasCondensateListController : ControllerBase
{
    private readonly IActionResultPresenter _presenter;
    private readonly IDisplayGasCondensateListUseCase _useCase;

    public DisplayGasCondensateListController(
        IActionResultPresenter presenter,
        IDisplayGasCondensateListUseCase useCase)
    {
        _presenter = presenter;
        _useCase = useCase;
    }


    [HttpGet(Name = "DisplayGasCondensateList")]
    public async Task<IActionResult> DisplayAll()
    {
        var canExecute = await _useCase.CanExecute(_presenter);
        if (!canExecute) return _presenter.Render();

        await _useCase.Execute(_presenter);
        return _presenter.Render();
    }
}