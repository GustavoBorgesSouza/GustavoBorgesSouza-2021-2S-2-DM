using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace senai_inlock_webAPI_CodeFirst.Properties.Domains
{
    /// <summary>
    /// Classe que representa a entidade estudios
    /// </summary>
    /// 

    [Table("Estudios")]
    public class Estudios
    {
        ///Define que será uma chave primária com autoincremento
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idEstudio { get; set; }

        //Define tipo de dados da coluna
        [Column(TypeName = "varchar(150)")]
        [Required(ErrorMessage = "O nome do estudio é obrigatorio")]
        public string nomeEstudio { get; set; }

        public List<Jogos> jogos { get; set; }
    }
}
