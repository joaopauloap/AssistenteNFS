using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace AssistenteNFS.Models
{
    public class Pessoa
    {

        public Pessoa()
        {
            this.IdSexo = null;
            this.IdTipoTelefone = null;
            this.Ddi = null;
            this.Ddd = null;
            this.NumeroTelefone = null;
            this.Ramal = "";
            this.Email = "";
            this.IdBairro = null;
            this.Bairro = "";
            this.IdTipoLogradouro = null;
            this.IdLogradouro = null;
            this.Logradouro = "";
            this.IdDistrito = null;
            this.Distrito = "";
            this.LocalNaturalidadeEstrangeiro = "";
            this.Numero = "";
            this.Complemento = "";
            this.Pais = "BRASIL";
        }

        public int IdTipoPessoa { get; set; }
        public string CpfCnpj { get; set; }
        public string NomeRazaoSocial { get; set; }
        public int? IdSexo { get; set; }
        public int? IdTipoTelefone { get; set; }
        public string Ddi { get; set; }
        public string Ddd { get; set; }
        public string NumeroTelefone { get; set; }
        public string Ramal { get; set; }
        public string Email { get; set; }
        public int IdPaisNaturalidade { get; set; }
        public int IdEstadoNaturalidade { get; set; }
        public int IdMunicipioNaturalidade { get; set; }
        public int? IdBairro { get; set; }
        public string Bairro { get; set; }
        public int? IdTipoLogradouro { get; set; }
        public int? IdLogradouro { get; set; }
        public string Logradouro { get; set; }
        public int IdEnderecamentoPostal { get; set; }
        public int? IdDistrito { get; set; }
        public string Distrito { get; set; }
        public string LocalNaturalidadeEstrangeiro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
    }
}
