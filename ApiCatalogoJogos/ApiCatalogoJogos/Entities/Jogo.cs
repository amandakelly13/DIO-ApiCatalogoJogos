using System;

namespace ApiCatalogoJogos.Entities
{
    public class JogoJaCadastradoExcepition
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Produtora { get; set; }
        public double Preco { get; set; }
    }
}