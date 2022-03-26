using System;

namespace DTO
{
    public class TextoDTO : IDisposable
    {
        public TextoDTO()
        {
            Texto = string.Empty;
        }
        public string Texto { get; set; }
        
        public void Dispose()
        {
            Texto = string.Empty;
            Texto = null;
        }
    }
}