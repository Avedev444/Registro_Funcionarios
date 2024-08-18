using Registro_Funcionarios.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Registro_Funcionarios.Repositories
{
    public class FuncionarioRepositoryXML : FuncionarioRepositoryAbstract
    {
        public override void ExportarDados(Funcionario funcionario)
        {
            //serializando os dados do funcionario para XML
            var xml = new XmlSerializer(funcionario.GetType());
            string path = $"c:\\temp\\funcionario_{funcionario.Id}.xml";

            //gravando um arquivo XML contendo os dados do funcionario
            using (var writer = new StreamWriter(path))
            {
                //escrevendo os dados no arquivo
                xml.Serialize(writer, funcionario);
            }

        }
    }
}
