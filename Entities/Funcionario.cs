using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_Funcionarios.Entities
{
    public class Funcionario : Pessoa
    {
        //propriedades (setters e getters)
        //set -> entrada de dados (atribuição)
        //get -> saída de dados (retorno)
        public string Matricula { get; set; }
        public string CPF { get; set; }
        public DateTime DataAdmissao { get; set; }
        public Departamento Departamento { get; set; } //TER-1


        
    }
}
