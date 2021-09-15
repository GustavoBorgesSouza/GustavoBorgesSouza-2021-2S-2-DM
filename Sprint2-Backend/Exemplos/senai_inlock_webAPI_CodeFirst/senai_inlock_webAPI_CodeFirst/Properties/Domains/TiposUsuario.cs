using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace senai_inlock_webAPI_CodeFirst.Properties.Domains
{
    /// <summary>
    /// Classe que representa a entidade tipoUsuario
    /// </summary>
    
    [Table("TiposUsuario")]
    public class TiposUsuario
    {
        //Define que será uma chave primária
        [Key]
        //Define o autoincremento, assim como o IDENTITY
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idTipoUsuario { get; set; }

        //Define que é uma coluna e o tipo de dadp
        [Column(TypeName = "varchar(150)")]
        //Define que é uma propriedade obrigatória
        [Required(ErrorMessage = "O titulo do tipo de usuário é obrigatório")]
        public string titulo { get; set; }
    }
}
