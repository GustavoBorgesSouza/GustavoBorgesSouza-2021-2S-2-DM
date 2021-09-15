using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace senai_inlock_webAPI_CodeFirst.Properties.Domains
{
    /// <summary>
    /// Classe que representa a entidade jogos
    /// </summary>
    /// 

    [Table("Jogos")]
    public class Jogos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idjogo { get; set; }

        [Column(TypeName = "varchar(150)")]
        [Required(ErrorMessage = "O nome do jogo é obrigatório")]
        public string nomejogo { get; set; }

        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage ="A descricao é obrigatória")]
        public string descricao { get; set; }

        [Column(TypeName = "DATE")]
        [Required(ErrorMessage ="é obrigatorio informar a data de lancamento")]
        public DateTime dataLancamento { get; set; }

        [Column(TypeName ="DECIMAL(10,2)")]
        [Required(ErrorMessage ="É necessário informar um valor")]
        public decimal valor { get; set; }

        [Required(ErrorMessage ="É necessário informar o estúdio que produziu o jogo")]
        public int idEstudio { get; set; }

        [ForeignKey("idEstudio")]
        public Estudios estudio { get; set; }
    }
}
