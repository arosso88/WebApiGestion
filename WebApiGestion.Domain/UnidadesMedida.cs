namespace WebApiGestion.Domain
{
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;

    public class UnidadesMedida
    {
        [Key]
        public int ume_Id { get; set; }

        public string ume_Codigo { get; set; }

        public string ume_Descripcion { get; set; }
    }
}
