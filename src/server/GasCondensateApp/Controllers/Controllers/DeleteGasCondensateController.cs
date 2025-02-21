using Controllers.Persenters;
using Domain.DeleteGasCondensate;
using Microsoft.AspNetCore.Mvc;

namespace Controllers.Controllers;

[ApiController]
[Route("[controller]")]
public class DeleteGasCondensateController : ControllerBase
{
    private readonly IActionResultPresenter _presenter;
    private readonly IDeleteGasCondensateUseCase _useCase;

    public DeleteGasCondensateController(
        IActionResultPresenter presenter,
        IDeleteGasCondensateUseCase useCase)
    {
        _presenter = presenter;
        _useCase = useCase;
    }


    [HttpDelete("{id}", Name = "DeleteGasCondensate")]
    public async Task<IActionResult> Delete(string id)
    {
        var request = new DeleteGasCondensateRequest(id);

        var canExecute = await _useCase.CanExecute(_presenter, request);
        if (!canExecute) return _presenter.Render();

        await _useCase.Execute(_presenter, request);
        return _presenter.Render();
    }
}
