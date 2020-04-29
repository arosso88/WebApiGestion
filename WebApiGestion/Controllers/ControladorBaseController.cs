namespace WebApiGestion.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using EF;
    using Services;

    [Route("[controller]")]
    [ApiController]
    public class ControladorBaseController : ControllerBase
    {
        public void SetearDBContext(IService service) =>
            service.DBContext = DbHelper.GetDBContext(this.ObtenerServidor(), this.ObtenerBD());

        public void DisposeDBContext(GestionStockContext dbContext) => dbContext.Dispose();

        private string ObtenerServidor()
        {
            var nombreServidor = this.HttpContext.Request.Headers["nombreServidor"];
            var instanciaSQL = this.HttpContext.Request.Headers["instanciaSQL"];

            return string.Concat(nombreServidor, "\\", instanciaSQL);
        }

        private string ObtenerBD() => this.HttpContext.Request.Headers["bd"];
    }
}