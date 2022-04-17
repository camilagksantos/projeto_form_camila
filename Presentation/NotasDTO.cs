using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_form_camila.Presentation
{
    internal class NotasDTO
    {
        public String TurmaDesignacao { get; set; }
        public int IdNota { get; set; }
        public int IdAluno { get; set; }
        public String NomeAluno { get; set; }
        public String DisciplinaDesignacao { get; set; }
        public DateTime DataAtribuicao { get; set; }
        public decimal ValorNota { get; set; }
    }
}
