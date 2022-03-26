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
            var url = "http://192.168.200.152:8080/TesteAutenticacao/Testar";
            var requisicao = new Requisicao();

            while(true)
            {
                var mensagem = ObterMensagemDeEnvio();
                if (mensagem.Texto.ToUpper() == "SAIR")
                    break;
                var retorno = requisicao.ExecutarPost<TextoDTO, TextoDTO>(url, mensagem, "compuletra", "vistoriapro");
                Console.WriteLine(retorno.Texto);
            }
        }
        static TextoDTO ObterMensagemDeEnvio()
        {
            var mensagem  = "Ola mundo seguro!";
            //var mensagem = Console.ReadLine();
            return new TextoDTO()
            {
                Texto = mensagem
            };
        }
    }
}