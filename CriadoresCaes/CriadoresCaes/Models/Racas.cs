namespace CriadoresCaes.Models
{
    /// <summary>
    /// Descrição das raças de cães
    /// </summary>
    public class Racas
    {

        public Racas()
        {
            ListaAnimais = new HashSet<Animais>();
            ListaCriadores = new HashSet<Criadores>();
        }

        /// <summary>
        /// PK
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Denominação da Raça
        /// </summary>
        public string Nome { get; set; }

        // ------------------------------------------------------

        /// <summary>
        /// Lista de animais que pertencem à Raça escolhida
        /// </summary>
        public ICollection<Animais> ListaAnimais { get; set; }

        /// <summary>
        /// lista de criadores da Raça
        /// </summary>
        public ICollection<Criadores> ListaCriadores { get; set;}
    }
}
