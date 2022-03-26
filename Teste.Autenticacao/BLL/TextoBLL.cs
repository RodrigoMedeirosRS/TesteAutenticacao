using System.Threading.Tasks;

using DTO;
using BLL.Inteface;

namespace BLL
{
    public class TextoBLL : ITextoBLL
    {
        public async Task<TextoDTO> Responder(TextoDTO textoDTO)
        {
            return new TextoDTO()
            {
                Texto = "Texto: " + textoDTO.Texto + " recebido"
            };
        }
    }
}
