using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using DTO;
using BLL;
using BLL.Inteface;
using API.Interface;

namespace BibliotecaViva.CTRL
{
    [Route("TesteAutenticacao")]
    [ApiController]
    public class TesteCTRL : Controller
    {
        private IRequisicao _Requisicao { get; set; }
        private ITextoBLL _BLL { get; set; }
        
        public TesteCTRL(IRequisicao requisicao, ITextoBLL bLL)
        {
            _Requisicao = requisicao;
            _BLL = bLL;
        }

        [HttpPost("Testar")]
        public async Task<TextoDTO> Testar(TextoDTO texto)
        {
            return _Requisicao.ExecutarRequisicao<TextoDTO, TextoDTO>(texto, _BLL.Responder).Result;
        }
    }
}