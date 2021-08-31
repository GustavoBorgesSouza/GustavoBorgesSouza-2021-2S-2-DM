using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_rental_webAPI.Properties.Domains
{
    /// <summary>
    /// Classe que representa a entidade veiculo do BD
    /// </summary>
    public class VeiculoDomain
    {
        public int IdVeiculo { get; set; }
        public int IdEmpresa { get; set; }
        public int IdModelo { get; set; }
        public string CorVeiculo { get; set; }

        public EmpresaDomain Empresa { get; set; }
        public ModeloDomain Modelo { get; set; }

    }
}
