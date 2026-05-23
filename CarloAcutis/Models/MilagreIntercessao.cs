namespace CarloAcutis.Models
{
    public class MilagreIntercessao
    {
        public string Beneficiado { get; set; }
        public string Local { get; set; }
        public int Ano { get; set; }
        public string Descricao { get; set; }
        public string Finalidade { get; set; } // "Beatificação" ou "Canonização"
    }
}
