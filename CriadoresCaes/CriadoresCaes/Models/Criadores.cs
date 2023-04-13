namespace CriadoresCaes.Models
{
    /// <summary>
    /// Dados dos criadores dos animais
    /// </summary>
    public class Criadores
    {

        public Criadores()
        {
            //Inicializar a lista de animais do criador
            ListaAnimais = new HashSet<Animais>();
            //Inicializar a lista de Raças que o criador cria
            ListaRacas = new HashSet<Racas>();
        }

        public int Id { get; set; }

        /// <summary>
        /// Nome do criador
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// nome pelo qual o criador é conhecido no mercado de venda de animais
        /// </summary>
        public string NomeComercial { get; set; }

        /// <summary>
        /// morada do criador
        /// </summary>
        public string Morada { get; set; }

        /// <summary>
        /// Código Postal
        /// </summary>
        public string CodPostal { get; set; }

        /// <summary>
        /// Email do criador
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Telemóvel do Criador
        /// </summary>
        public string Telemovel { get; set; }


        /* --------------------------------------------------------------------------
         * relacionamento associados ao Criador
         */

        /// <summary>
        /// Lista dis animais associados ao Criador
        /// </summary>
        public ICollection<Animais> ListaAnimais { get; set; }

        /// <summary>
        /// lista das raças que um Criador cria
        /// </summary>
        public ICollection<Racas> ListaRacas { get; set; }

    }
}
