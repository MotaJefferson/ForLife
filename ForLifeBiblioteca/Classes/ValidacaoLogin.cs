using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using ForLifeBiblioteca.Databases;
using System.Data;

namespace ForLifeBiblioteca.Classes
{
    public class ValidacaoLogin
    {

        [Required(ErrorMessage = "Insira o usuário")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Insira a senha")]
        public string Password { get; set; }

        public void ValidaClasse()
        {
            ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(this, context, results, true);

            if (isValid == false)
            {
                StringBuilder sbrErros = new StringBuilder();
                foreach (var ValidationResult in results)
                {
                    sbrErros.AppendLine(ValidationResult.ErrorMessage);
                }
                throw new ValidationException(sbrErros.ToString());
            }
        }

        #region Funções CRUD

        public ValidacaoLogin DataRowToUnit (DataRow dr)
        {
            ValidacaoLogin validacao = new ValidacaoLogin();

            validacao.Login = dr["usuario"].ToString();
            validacao.Password = dr["senha"].ToString();

            return validacao;
        }

        public string RetornaUsuario(string usuario)
        {

            string SQL;
            string retorno = null;

            SQL = "SELECT * FROM Usuario WHERE usuario = '"+ usuario +"'";

            var db = new SQLServerClass();
            var Dt = db.SQLQuery(SQL);

            if (Dt.Rows.Count == 0)
            {
                db.Close();
                throw new Exception("Usuário incorreto ou inexistente");
            }
            else
            { 
                ValidacaoLogin V = this.DataRowToUnit(Dt.Rows[0]);

                retorno = V.Login;

                return retorno;
            }

        }

        public string RetornaSenha(string usuario)
        {

            string SQL;
            string retorno;

            SQL = "SELECT * FROM Usuario WHERE usuario = '" + usuario + "'";

            var db = new SQLServerClass();
            var Dt = db.SQLQuery(SQL);

            if (Dt.Rows.Count == 0)
            {
                db.Close();
                throw new Exception("Usuário incorreto ou inexistente");
            }
            else
            {
                ValidacaoLogin V = this.DataRowToUnit(Dt.Rows[0]);

                retorno = V.Password;

                return retorno;
            }

        }

        #endregion

    }
}
