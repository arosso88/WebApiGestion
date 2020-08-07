namespace WebApiGestion.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using EF;
    using Services;

    [Route("[controller]")]
    [ApiController]
    public class ControladorBaseController : ControllerBase
    {
        [ApiExplorerSettings(IgnoreApi = true)]
        public void SetearDBContext(IService service) =>
            service.DBContext = DbHelper.GetDBContext(this.ObtenerServidor(), this.ObtenerBD());

        [ApiExplorerSettings(IgnoreApi = true)]
        public void DisposeDBContext(GestionStockContext dbContext) => dbContext.Dispose();

        [ApiExplorerSettings(IgnoreApi = true)]
        private string ObtenerServidor()
        {
            var nombreServidor = this.HttpContext.Request.Headers["nombreServidor"];
            var instanciaSQL = this.HttpContext.Request.Headers["instanciaSQL"];

            return string.Concat(nombreServidor, "\\", instanciaSQL);
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        private string ObtenerBD() => this.HttpContext.Request.Headers["bd"];
    }
}