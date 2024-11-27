using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssistenteNFS.Models
{
    public class Servicos
    {
        public Servicos()
        {
            this.Id = 0;
            this._TempId = "";
            this.ValorDesconto = 0;
            this.IdEstruturaPadraoCNAE = null;
            this.IdServicoLei116 = null;
            this.DescricaoCNAE = null;
            this.DescricaoLei = null;
            this.Quantidade = 1;
            this.FlPermiteTrocaMunInc = false;
            this.FlMunicipioIncidenciaTomador = false;
            this.IdEconomicoParceiro = null;
            this.IdRelacaoEconomicoParceiro = null;
            this.PercentualRetencao = null;
            this.ValorRetidoBaseCalculoISSQN = 0;
            this.NomeRazaoSocialParceiro = "";
            this.TipoPessoaParceiro = "";
            this.CpfCnpjParceiro = "";
            this.InscricaoMunicipalParceiro = "";
        }

        public int Id { get; set; }
        public int? IdEstruturaPadraoCNAE { get; set; }
        public int? IdServicoLei116 { get; set; }
        public string Servico { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorBruto { get; set; }
        public decimal ValorLiquido { get; set; }
        public decimal ValorDesconto { get; set; }
        public decimal ValorRetidoBaseCalculoISSQN { get; set; }
        public string _TempId { get; set; }
        public string DescricaoCNAE { get; set; }
        public string DescricaoLei { get; set; }
        public int Quantidade { get; set; }
        public bool FlPermiteTrocaMunInc { get; set; }
        public bool FlMunicipioIncidenciaTomador { get; set; }
        public int? IdEconomicoParceiro { get; set; }
        public int? IdRelacaoEconomicoParceiro { get; set; }
        public int? PercentualRetencao { get; set; }
        public string NomeRazaoSocialParceiro { get; set; }
        public string TipoPessoaParceiro { get; set; }
        public string CpfCnpjParceiro { get; set; }
        public string InscricaoMunicipalParceiro { get; set; }
    }

    public class NotaFiscal
    {
        public string IdPessoaPrestador { get; set; }
        public int TipoPessoaPrestador { get; set; }
        public string IdClassificacaoAbrasf { get; set; }
        public string NomePrestador { get; set; }
        public string CpfCnpjPrestador { get; set; }
        public string InscricaoPrestador { get; set; }
        public int PorteEmpresarial { get; set; }
        public string NomeClassificacaoAbrasfPrestador { get; set; }
        public bool OptanteSIMEIPrestador { get; set; }
        public bool ImunePrestador { get; set; }
        public bool OptanteSimplesNacionalPrestador { get; set; }
        public bool ImpedidoRecolherISSQNPeloSimplesNacionalPrestador { get; set; }
        public int SimplesNacionalAliquotaISSQN { get; set; }
        public int? PercentualBeneficio { get; set; }
        public int? ChaveDigital { get; set; }
        public int IdUnidadeGestora { get; set; }
        public int IdEconomicoPrestador { get; set; }
        public bool MicroEmpresarioIndividual { get; set; }
        public int? Numero { get; set; }
        public int? IdNfseSubstituida { get; set; }
        public string NumeroNfseSubstituida { get; set; }
        public bool OutraAtividadeEconomica { get; set; }
        public int IdItem116 { get; set; }
        public int IdEstruturaAtividadeEconomica { get; set; }
        public string CodigoItem116AtividadeEconomica { get; set; }
        public int IdExigibilidade { get; set; }
        public string BeneficioProcesso { get; set; }
        public int? LeiEspecifica { get; set; }
        public string _TempId { get; set; }
        public bool AlterarNome { get; set; }
        public bool Estrangeiro { get; set; }
        public int? IdEconomicoTomador { get; set; }
        public int? InscricaoEstadualTomador { get; set; }
        public string EmailTomador { get; set; }
        public string TelefoneTomador { get; set; }
        public string AtualizadoReceita { get; set; }
        public string InscricaoMunicipalTomador { get; set; }
        public bool CheckEnderecoManual { get; set; }
        public Object Endereco { get; set; }
        public string LocalEstrangeiro { get; set; }
        public string TipoLogradouroTomador { get; set; }
        public string LogradouroTomador { get; set; }
        public string NumeroTomador { get; set; }
        public string ComplementoTomador { get; set; }
        public string BairroTomador { get; set; }
        public int? NumeroRps { get; set; }
        public int? DataRps { get; set; }
        public int? ModeloRps { get; set; }
        public string SerieRps { get; set; }
        public string TipoRps { get; set; }
        public decimal ValorPIS { get; set; }
        public decimal ValorCOFINS { get; set; }
        public decimal ValorINSS { get; set; }
        public decimal ValorIRRF { get; set; }
        public decimal ValorCSLL { get; set; }
        public decimal ValorOutras { get; set; }
        public Object FracaoPIS { get; set; }
        public Object FracaoCOFINS { get; set; }
        public Object FracaoINSS { get; set; }
        public Object FracaoIRRF { get; set; }
        public Object FracaoCSLL { get; set; }
        public Object FracaoOutras { get; set; }
        public bool ISSQNRetido { get; set; }
        public int IdResponsavelISSQN { get; set; }
        public int? IdIntermediario { get; set; }
        public string NomeRazaoSocialIntermediario { get; set; }
        public string TipoPessoaIntermediario { get; set; }
        public string CpfCnpjIntermediario { get; set; }
        public string InscricaoMunicipalIntermediario { get; set; }
        public string ObservacaoAliquotaISSQNEspecialEconomicoResumo { get; set; }
        public string ObservacaoAliquotaISSQNEspecialEconomicoResumoAuxiliar { get; set; }
        public string ObservacaoAliquotaISSQNEspecialEconomicoPrestador { get; set; }
        public string ObservacaoAliquotaISSQNEspecialEconomicoTomador { get; set; }
        public string ObservacaoAliquotaISSQNEspecialEconomicoIntermediario { get; set; }
        public string AliquotaISSQNEspecialEconomicoPrestador { get; set; }
        public string AliquotaISSQNEspecialEconomicoTomador { get; set; }
        public string AliquotaISSQNEspecialEconomicoIntermediario { get; set; }
        public decimal ValorTotalDescontos { get; set; }
        public decimal ValorTotalRetencoes { get; set; }
        public decimal ValorTotalDeducaoConstrucaoCivil { get; set; }
        public decimal ValorTotalDeducaoSubcontratacao { get; set; }
        public int PorcentagemAbatimento { get; set; }
        public decimal TotalISSQNRecolher { get; set; }
        public int IdMunicipioIncidencia { get; set; }
        public int CodigoIbgeMunicipioIncidencia { get; set; }
        public int IdEconomico { get; set; }
        public int IdRegimeTributacao { get; set; }
        public int IdMunicipioUnidadeGestora { get; set; }
        public string NomeRegimeTributacaoPrestador { get; set; }
        public int IdAtividadeEconomicaPrincipal { get; set; }
        public int IdCNAEPrincipal { get; set; }
        public int IdItem116Principal { get; set; }
        public int TipoPessoa { get; set; }
        public int IdPais { get; set; }
        public int CodigoPaisTomador { get; set; }
        public string NomePaisTomador { get; set; }
        public decimal AliquotaISSQN { get; set; }
        public string DataEmissao { get; set; }
        public string Observacao { get; set; }
        public int IdPessoaTomador { get; set; }
        public string NomeRazaoSocialTomador { get; set; }
        public string CPFCNPJTomador { get; set; }
        public string CepTomador { get; set; }
        public string IdEnderecamentoPostal { get; set; }
        public int IdEstado { get; set; }
        public string NomeEstadoTomador { get; set; }
        public string SiglaEstadoTomador { get; set; }
        public int IdMunicipio { get; set; }
        public int CodigoIbgeMunicipioTomador { get; set; }
        public string NomeMunicipioTomador { get; set; }
        public string DescricaoEndereco { get; set; }
        public decimal ValorTotalServicos { get; set; }
        public decimal ValorTotalLiquido { get; set; }
        public decimal BaseCalculoISSQN { get; set; }
        public decimal TotalISSQNCalculado { get; set; }
        public List<Servicos> Servicos { get; set; }
    }
}
