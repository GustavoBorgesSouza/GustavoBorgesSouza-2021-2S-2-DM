using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace senai_inlock_webAPI_CodeFirst.Properties.Domains
{
    /// <summary>
    /// Classe que representa a entidade de usuários
    /// </summary>
    /// 

    [Table("Usuarios")]
    public class Usuarios
    {
        //Define que é chave primária e tem autoincremento com identity
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idUsuario { get; set; }

        [Column(TypeName = "varchar(256)")]
        [Required(ErrorMessage = "O email é obrigatório")]
        public string email { get; set; }

        //Define o tipo da coluna, que é obrigatória e requisitos da propriedade
        [Column(TypeName = "varchar(30)")]
        [Required(ErrorMessage = "A senha é obrigatória")]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "A senha deve conter de 5 a 30 caracteres")]
        public string senha { get; set; }

        public int idTipoUsuario { get; set; }



        [ForeignKey("idTipoUsuario")]
        public TiposUsuario tipoUsuario { get; set; }
    }
}
