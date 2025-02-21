using Controllers.Persenters;
using Microsoft.AspNetCore.Mvc;

namespace Controllers.Presenters;

public class RestPresenter : IActionResultPresenter
{
    private object _response;
    private object _error = "No response recorded";

    public void Success<T>(T response)
    {
        _response = response;

    }

    public void Error<T>(T error)
    {
        _error = error;
    }

    public IActionResult Render()
    {
        if (_response != null)
        {
            return new OkObjectResult(_response);
        }

        return new BadRequestObjectResult(_error);
    }
}