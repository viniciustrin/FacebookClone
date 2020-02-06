using System;

namespace Domain
{
    public class Atividade
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public string Categoria { get; set; }
        public string Cidade { get; set; }
        public string Local { get; set; }
    }
}
