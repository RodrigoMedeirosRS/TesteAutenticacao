using System;
using System.Threading;

using DTO;
using BibliotecaViva.SAL;

namespace PROG
{
    static class Program
    {
        static void Main()
        {
            var url = string.Empty;
            var requisicao = new Requisicao();
            var retorno = requisicao.ExecutarPost<TextoDTO, TextoDTO>(url, ObterMensagemDeEnvio());
            Console.WriteLine(retorno.Texto);
        }
        static TextoDTO ObterMensagemDeEnvio()
        {
            var mensagem = Console.ReadLine();
            return new TextoDTO()
            {
                Texto = mensagem
            };
        }
    }
}