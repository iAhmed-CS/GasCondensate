using Domain;
using Microsoft.AspNetCore.Mvc;

namespace Controllers.Persenters;

public interface IActionResultPresenter : IPresenter
{
    IActionResult Render();
}