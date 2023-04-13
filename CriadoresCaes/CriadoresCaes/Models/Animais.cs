using System.ComponentModel.DataAnnotations.Schema;

namespace CriadoresCaes.Models
{
    /// <summary>
    /// descrição dos cães 
    /// </summary>
    public class Animais
    {
        public int Id { get; set; }

        /// <summary>
        /// nome do cão
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// data de nascimento do cão/cadela
        /// </summary>
        public DateTime DataNascimento  { get; set;}

        /// <summary>
        /// data de compra do cão/cadela
        /// </summary>
        public DateTime Datacompra { get; set; }

        /// <summary>
        /// sexo do animal:
        /// F - Fêmea
        /// M - Macho
        /// </summary>
        public string Sexo { get; set; }

        /// <summary>
        /// LOP do registo do animal
        /// </summary>
        public string NumLOP { get; set; }

        /* ------------------------------------------------------------------------- 
         * Criação das chaves forasteiras
         * ------------------------------------------------------------------------- */

        /// <summary>
        /// FK para o Criador do cão/cadela
        /// </summary>
        [ForeignKey(nameof(Criador))]
        public int CriadorFK { get; set; }  


        public Criadores Criador { get; set; } //efetivamente, esta é que é a FK

        /*
         * O uso de [anotadores] server para formatar o comportamento dos 'objetos por ele referenciados
         * estes 'objetos' podem ser:
         *  - atributos
         *  - funções (métodos)
         *  - classes
         */

    }
}
