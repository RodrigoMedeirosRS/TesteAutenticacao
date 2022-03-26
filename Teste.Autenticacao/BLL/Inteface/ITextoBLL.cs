using System.Threading.Tasks;

using DTO;

namespace BLL.Inteface
{
    public interface ITextoBLL
    {
        Task<TextoDTO> Responder(TextoDTO textoDTO);
    }
}