using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDeDados;

namespace CamadaDeInteracoes
{
    class BLL_Feedback
    {

        public void EnviarFeedback(string nome, string inst, string message)
        {
            Conexao con = new Conexao();
            string Sql = $@"INSERT INTO `feedback`(`id`, `profissional`, `instituicao`, `mensagem`) VALUES (null,'{nome}','{inst}','{message}')";


            con.ExecutarComando(Sql);

        }

    }
}
