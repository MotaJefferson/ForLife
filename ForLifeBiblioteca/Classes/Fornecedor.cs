using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data;
using ForLifeBiblioteca.Databases;
using System.Windows.Forms;

namespace ForLifeBiblioteca.Classes
{
    public class Fornecedor
    {
        public class Unit
        {
            [Required(ErrorMessage = "Defina um status do fornecedor")]
            [RegularExpression("^(1|2)$", ErrorMessage = "Defina um status do fornecedor")]
            public int StatusFornecedor { get; set; }

            [Required(ErrorMessage = "Nome fantasia é obrigatório")]
            public string NomeFantasia { get; set; }

            [Required(ErrorMessage = "Razão social é obrigatório")]
            public string RazaoSocial { get; set; }

            [Required(ErrorMessage = "CNPJ é obrigatório")]
            [RegularExpression(@"^\d+$", ErrorMessage = "CNPJ é obrigatório")]
            public string CNPJ { get; set; }


            public int UsuarioID { get; set; }
            string UsuarioLogado = Session.Instance.UserID;

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

            public string ToInsert(string usuario)
            {
                int status = 0;
                int idUsuario = ReturnIdUsuario(usuario);
                

                if (Convert.ToInt32(this.StatusFornecedor) == 1)
                {
                    status = 1;
                }
                if (Convert.ToInt32(this.StatusFornecedor) == 2)
                {
                    status = 0;
                }

                string SQL;

                SQL = @"INSERT INTO Fornecedor
                        (usuario_id
                        ,CNPJ
                        ,nome
                        ,razao_social
                        ,status)
                        VALUES ";
                SQL += "('" + idUsuario + "'";
                SQL += ",'" + this.CNPJ + "'";
                SQL += ",'" + this.NomeFantasia + "'";
                SQL += ",'" + this.RazaoSocial + "'";
                SQL += ",'" + status + "')";

                return SQL;
            }

            public string ToUpdate(string nome, string usuario)
            {
                int idUsuario = ReturnIdUsuario(usuario);
                int status = 0;
                

                if (Convert.ToInt32(this.StatusFornecedor) == 1)
                {
                    status = 1;
                }
                if (Convert.ToInt32(this.StatusFornecedor) == 2)
                {
                    status = 0;
                }

                string SQL;

                if (BuscaFornecedorExistenteSQL(nome) == true)
                {
                    SQL = @"UPDATE Fornecedor SET ";
                    SQL += "usuario_id = '" + idUsuario + "'";
                    SQL += ",nome = '" + this.NomeFantasia + "'";
                    SQL += ",razao_social = '" + this.RazaoSocial + "'";
                    SQL += ",status = '" + status + "'";
                    SQL += "WHERE CNPJ = '" + this.CNPJ + "'";

                    return SQL;
                }
                else
                {
                    SQL = @"UPDATE Fornecedor SET ";
                    SQL += "usuario_id = '" + idUsuario + "'";
                    SQL += ",CNPJ = '" + this.CNPJ + "'";
                    SQL += ",nome = '" + this.NomeFantasia + "'";
                    SQL += ",razao_social = '" + this.RazaoSocial + "'";
                    SQL += ",status = '" + status + "'";
                    SQL += "WHERE CNPJ = '" + this.CNPJ + "'";

                    return SQL;
                }
            }

            public Unit DataRowToUnit(DataRow dr)
            {
                Unit u = new Unit();

                u.UsuarioID = Convert.ToInt32(dr["usuario_id"]);
                u.CNPJ = dr["CNPJ"].ToString();
                u.NomeFantasia = dr["nome"].ToString();
                u.RazaoSocial = dr["razao_social"].ToString();
                u.StatusFornecedor = Convert.ToInt32(dr["status"]);

                return u;
            }

            public Unit DataRowToUnitUsuario(DataRow dr)
            {
                Unit u = new Unit();

                u.UsuarioID = Convert.ToInt32(dr["id_usuario"]);
                u.UsuarioLogado = dr["nome"].ToString();

                return u;
            }

            public bool BuscaFornecedorExistenteSQL(string fornecedor)
            {
                string SQL = "SELECT * FROM Fornecedor WHERE nome = '" + fornecedor + "'";

                var db = new SQLServerClass();
                var Dt = db.SQLQuery(SQL);

                if (Dt.Rows.Count == 0)
                {
                    db.Close();
                    return false;
                }
                else
                {
                    return true;
                }
            }

            public int ReturnIdUsuario(string usuario)
            {
                try
                {
                    string SQL = "SELECT * FROM Usuario WHERE usuario = '" + usuario + "'";

                    var db = new SQLServerClass();
                    var Dt = db.SQLQuery(SQL);

                    if (Dt.Rows.Count == 0)
                    {
                        db.Close();
                        throw new Exception("A pesquisa não retornou valores");
                    }
                    else
                    {
                        Unit u = this.DataRowToUnitUsuario(Dt.Rows[0]);
                        return u.UsuarioID;
                    }

                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao buscar o usuario. " + ex.Message);
                }
            }

            #endregion


            #region Funções CRUD SQLServer

            public void IncluirSQL(string usuario)
            {
                try
                {
                    if (BuscaFornecedorExistenteSQL(this.NomeFantasia) == true)
                    {

                        if (MessageBox.Show("Fornecedor " + NomeFantasia + " já existe na nossa base, deseja alterar o cadastro?", "ForLife", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            AlterarSQL(usuario);
                        }
                        else
                        {
                            MessageBox.Show("As alterações não serão salvas", "ForLife", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                    }
                    else
                    {
                        string SQL;
                        SQL = this.ToInsert(usuario);
                        var db = new SQLServerClass();
                        db.SQLCommand(SQL);
                        db.Close();
                    }

                }
                catch (Exception ex)
                {
                    throw new Exception("Inclusão não permitida do fornecedor: " + this.NomeFantasia + ", erro: " + ex.Message);
                }
            }

            public Unit BuscarSQL(string fornecedor)
            {
                try
                {
                    string SQL = "SELECT * FROM Fornecedor WHERE nome = '" + fornecedor + "'";

                    var db = new SQLServerClass();
                    var Dt = db.SQLQuery(SQL);

                    if (Dt.Rows.Count == 0)
                    {
                        db.Close();
                        throw new Exception("A pesquisa não retornou valores");
                    }
                    else
                    {
                        Unit u = this.DataRowToUnit(Dt.Rows[0]);
                        return u;
                    }

                }

                catch (Exception ex)
                {
                    throw new Exception("Erro ao buscar o produto. " + ex.Message);
                }
            }

            public void AlterarSQL(string usuario)
            {
                try
                {
                    string SQL = "SELECT * FROM Fornecedor WHERE nome = '" + this.NomeFantasia + "'";

                    var db = new SQLServerClass();
                    var Dt = db.SQLQuery(SQL);

                    if (Dt.Rows.Count == 0)
                    {
                        db.Close();
                        throw new Exception("Fornecedor não existe");
                    }
                    else
                    {
                        SQL = this.ToUpdate(this.NomeFantasia, usuario);
                        db.SQLCommand(SQL);
                        db.Close();
                    }

                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao alterar o produto: " + ex.Message);
                }
            }

            public void ApagarSQL()
            {
                try
                {
                    string SQL = "SELECT * FROM Fornecedor WHERE nome = '" + this.NomeFantasia + "'";

                    var db = new SQLServerClass();
                    var Dt = db.SQLQuery(SQL);

                    if (Dt.Rows.Count == 0)
                    {
                        db.Close();
                        throw new Exception("Fornecedor não existe");
                    }
                    else
                    {
                        SQL = "DELETE FROM Fornecedor WHERE nome = '" + this.NomeFantasia + "'";
                        db.SQLCommand(SQL);
                        db.Close();
                    }

                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao excluir o fornecedor: " + ex.Message);
                }
            }

            public List<List<string>> BuscarVariosSQL(string Campo, string Valor)
            {

                List<List<string>> ListaBusca = new List<List<string>>();

                try
                {
                    var SQL = "SELECT * FROM Fornecedor WHERE " + Campo + " LIKE '%" + Valor + "%' ";
                    var db = new SQLServerClass();
                    var Dt = db.SQLQuery(SQL);


                    for (int i = 0; i <= Dt.Rows.Count - 1; i++)
                    {
                        
                        string status = null;

                        if (Convert.ToInt32(Dt.Rows[i]["status"]) == 1)
                        {
                            status = "Ativo";
                        }

                        else if (Convert.ToInt32(Dt.Rows[i]["status"]) == 0)
                        {
                            status = "Inativo";
                        }

                        //Nome Fantasia, Razão Social, CNPJ, Status
                        ListaBusca.Add(new List<string>
                        {
                            Dt.Rows[i]["nome"].ToString(),
                            Dt.Rows[i]["razao_social"].ToString(),
                            Dt.Rows[i]["CNPJ"].ToString(),
                            status
                        });
                    }
                    return ListaBusca;

                }
                catch (Exception ex)
                {
                    throw new Exception("Conexão gerou o erro: " + ex.Message);
                }
            }

            public List<List<string>> BuscarTodosSQL()
            {
                List<List<string>> ListaBusca = new List<List<string>>();

                try
                {
                    var SQL = "SELECT * FROM Fornecedor";
                    var db = new SQLServerClass();
                    var Dt = db.SQLQuery(SQL);


                    for (int i = 0; i <= Dt.Rows.Count - 1; i++)
                    {

                        string status = null;


                        if (Convert.ToInt32(Dt.Rows[i]["status"]) == 1)
                        {
                            status = "Ativo";
                        }

                        else if (Convert.ToInt32(Dt.Rows[i]["status"]) == 0)
                        {
                            status = "Inativo";
                        }

                        //Nome Fantasia, Razão Social, CNPJ, Status
                        ListaBusca.Add(new List<string>
                        {
                            Dt.Rows[i]["nome"].ToString(),
                            Dt.Rows[i]["razao_social"].ToString(),
                            Dt.Rows[i]["CNPJ"].ToString(),
                            status
                        });



                    }
                    return ListaBusca;

                }
                catch (Exception ex)
                {
                    throw new Exception("Conexão gerou o erro: " + ex.Message);
                }
            }

            #endregion

        }

        public class List
        {
            public List<Unit> ListUnit { get; set; }

        }
    }
}
