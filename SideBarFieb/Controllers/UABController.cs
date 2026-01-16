using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SideBarFieb.Models;

namespace SideBarFieb.Controllers
{
    [Route("uab")]
    public class UABController : Controller
    {
        [HttpGet("")]
        [HttpGet("{parametro}")]
        public IActionResult Index(string parametro)
        {
            var dados = parametro switch
            {
                "texto_2" => "banana do texto 2",
                "texto_3" => "abobrinha do texto 3",
                "texto_4" => "chuchu do texto 4",
                _ => "A Universidade Aberta do Brasil é um sistema integrado por universidades públicas que oferece cursos de nível superior para camadas da população que têm dificuldade de acesso à formação universitária, por meio do uso da metodologia da educação a distância. O público em geral é atendido, mas os professores que atuam na educação básica têm prioridade de formação, seguidos dos dirigentes, gestores e trabalhadores em educação básica dos estados, municípios e do Distrito Federal.\n" +
                "O Sistema UAB foi instituído pelo Decreto 5.800, de 8 de junho de 2006, para \"o desenvolvimento da modalidade de educação a distância, com a finalidade de expandir e interiorizar a oferta de cursos e programas de educação superior no País\". Fomenta a modalidade de educação a distância nas instituições públicas de ensino superior, bem como apóia pesquisas em metodologias inovadoras de ensino superior respaldadas em tecnologias de informação e comunicação. Além disso, incentiva a colaboração entre a União e os entes federativos e estimula a criação de centros de formação permanentes por meio dos polos de apoio presencial em localidades estratégicas.\n" +
                "Assim, o Sistema UAB propicia a articulação, a interação e a efetivação de iniciativas que estimulam a parceria dos três níveis governamentais (federal, estadual e municipal) com as universidades públicas e demais organizações interessadas, enquanto viabiliza mecanismos alternativos para o fomento, a implantação e a execução de cursos de graduação e pós-graduação de forma consorciada. Ao plantar a semente da universidade pública de qualidade em locais distantes e isolados, incentiva o desenvolvimento de municípios com baixos IDH e IDEB. Desse modo, funciona como um eficaz instrumento para a universalização do acesso ao ensino superior e para a requalificação do professor em outras disciplinas, fortalecendo a escola no interior do Brasil, minimizando a concentração de oferta de cursos de graduação nos grandes centros urbanos e evitando o fluxo migratório para as grandes cidades."

            };

            ViewData["Texto"] = dados;

            return View();
        }

        
    }
}
