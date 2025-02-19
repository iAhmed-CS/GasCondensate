using Domain;
using Microsoft.AspNetCore.Mvc;

namespace Controllers.Persenters;

public interface IActionResultPresenter<in T> : IPresenter<T>
{
    IActionResult Render();
}
