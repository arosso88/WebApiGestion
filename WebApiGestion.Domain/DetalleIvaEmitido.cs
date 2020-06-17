namespace WebApiGestion.Domain
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class DetalleIvaEmitido
    {
        [Key]
        public int die_Id { get; set; }

        public int die_cem_Id { get; set; }

        public int die_cia_Id { get; set; }

        public decimal die_PorcentajeIva { get; set; }

        public decimal die_ImporteIva { get; set; }

        public decimal die_ImponibleIva { get; set; }

        [ForeignKey(nameof(die_cem_Id))]
        public virtual ComprobantesEmitidos ComprobantesEmitidos { get; set; }
    }
}