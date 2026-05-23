using CarloAcutis.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarloAcutis.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var milagres = new List<Milagre>
            {
                new Milagre
                {
                    Titulo = "O Milagre de Lanciano",
                    Local = "Lanciano",
                    Pais = "Itália",
                    Ano = 700,
                    Descricao = "Durante uma missa, um monge com dúvidas sobre a presença real de Cristo na Eucaristia viu o pão se transformar em carne e o vinho em sangue visíveis a olho nu. Estudos científicos modernos confirmaram que a carne é tecido cardíaco humano e o sangue é do tipo AB.",
                    ImagemUrl = ""
                },
                new Milagre
                {
                    Titulo = "O Milagre de Buenos Aires",
                    Local = "Buenos Aires",
                    Pais = "Argentina",
                    Ano = 1996,
                    Descricao = "Uma hóstia descartada foi colocada em água e começou a transformar-se em uma substância avermelhada. Análises realizadas em Nova York identificaram tecido do músculo cardíaco humano vivo, com glóbulos brancos — o que é impossível em tecido morto.",
                    ImagemUrl = ""
                },
                new Milagre
                {
                    Titulo = "O Milagre de Sokolka",
                    Local = "Sokolka",
                    Pais = "Polônia",
                    Ano = 2008,
                    Descricao = "Uma hóstia caída foi dissolvida em água por precaução. Semanas depois, uma substância vermelho-rosada apareceu no recipiente. Patologistas identificaram tecido do miocárdio humano com sinais de agonia — semelhante ao de alguém em sofrimento extremo.",
                    ImagemUrl = ""
                },
                new Milagre
                {
                    Titulo = "O Milagre de Tixtla",
                    Local = "Tixtla",
                    Pais = "México",
                    Ano = 2006,
                    Descricao = "Durante um retiro espiritual, uma hóstia começou a exsudar uma substância vermelha de dentro para fora. Análises confirmaram ser sangue humano tipo AB, o mesmo dos milagres de Lanciano e Buenos Aires.",
                    ImagemUrl = ""
                },
                new Milagre
                {
                    Titulo = "O Milagre de Chirattakonam",
                    Local = "Chirattakonam",
                    Pais = "Índia",
                    Ano = 2001,
                    Descricao = "Uma imagem de Nossa Senhora foi vista 'chorando' e hóstias consagradas foram encontradas com manchas de sangue. O episódio atraiu milhares de fiéis e foi investigado pelas autoridades eclesiásticas locais.",
                    ImagemUrl = ""
                }
            };

            var frases = new List<Frase>
            {
                new Frase
                {
                    Texto = "A Eucaristia é a minha autoestrada para o céu.",
                    Contexto = "Sobre sua devoção eucarística"
                },
                new Frase
                {
                    Texto = "Todos nascem como originais, mas muitos morrem como cópias.",
                    Contexto = "Sobre ser autêntico"
                },
                new Frase
                {
                    Texto = "A tristeza é olhar para si mesmo. A felicidade é olhar para Deus.",
                    Contexto = "Sobre a alegria cristã"
                },
                new Frase
                {
                    Texto = "Coloque Deus no centro de tudo e todo o resto virá por acréscimo.",
                    Contexto = "Sobre prioridades"
                }
            };
    
    var milagresIntercessao = new List<MilagreIntercessao>
{
    new MilagreIntercessao
    {
        Beneficiado = "Matheus Lins Vianna",
        Local = "Campo Grande, Brasil",
        Ano = 2010,
        Descricao = "Menino de 6 anos foi curado de uma malformação grave no pâncreas após orações feitas diante da imagem de Carlo Acutis na Capela São Sebastião. O caso foi reconhecido pela Igreja como milagre para a beatificação.",
        Finalidade = "Beatificação"
    },
    new MilagreIntercessao
    {
        Beneficiado = "Jovem estudante",
        Local = "Costa Rica",
        Ano = 2022,
        Descricao = "Uma jovem universitária sobreviveu a um grave acidente e teve recuperação considerada inexplicável pela medicina, após sua família rezar pedindo a intercessão de Carlo. Reconhecido para a canonização em 2024.",
        Finalidade = "Canonização"
    }
};


            var viewModel = (milagres, frases, milagresIntercessao);
            return View(viewModel);
        }
    }
}