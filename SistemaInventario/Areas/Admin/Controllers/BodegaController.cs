using Microsoft.AspNetCore.Mvc;
using SistemaInventario.AccesoDatos.Repositorio;
using SistemaInventario.AccesoDatos.Repositorio.IRepositorio;

namespace SistemaInventario.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BodegaController : Controller
    {

        private readonly IUnidadTrabajo _unidadtrabajo;
        private object todos;

        public BodegaController(IUnidadTrabajo unidadtrabajo)
        {
            _unidadtrabajo = unidadtrabajo;

        }

        public IActionResult Index()
        {
            return View();
        }


        #region API


        [HttpGet]
        public async Task<IActionResult> ObtenerTodos()
        {
            var lista = await _unidadtrabajo.Bodega.ObtenerTodos();
            return Json(new { data = todos });
        }
        


        #endregion

    }
}
