using ForLifeBiblioteca.Databases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForLifeBiblioteca.Classes
{
    public class Cliente
    {
        public class Unit
        {
            [Required(ErrorMessage = "Defina um status do cliente")]
            [RegularExpression("^(1|2)$", ErrorMessage = "Defina um status do cliente")]
            public int StatusCliente { get; set; }

            [Required(ErrorMessage = "Insira o nome completo")]
            public string NomeCompleto { get; set; }

            [Required(ErrorMessage = "Insira o CPF")]
            [RegularExpression(@"^\d+$", ErrorMessage = "Insira o CPF completo")]
            public string CPF {  get; set; }

            //[Required(ErrorMessage = "Insira o Celular")]
            //[RegularExpression(@"^\d+$", ErrorMessage = "Insira o Celular")]
            public string Celular { get; set; }

            public string Logadouro { get; set; }
            public string NumEndereco {  get; set; }
            public string Complemento { get; set; }
            public string Bairro { get; set; }
            public string Cidade { get; set; }
            public string UF { get; set; }

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

                if (Convert.ToInt32(this.StatusCliente) == 1)
                {
                    status = 1;
                }
                if (Convert.ToInt32(this.StatusCliente) == 2)
                {
                    status = 0;
                }

                string SQL;

                SQL = @"INSERT INTO Cliente
                        (nome
                        ,CPF
                        ,telefone
                        ,logadouro
                        ,numero
                        ,complemento
                        ,bairro
                        ,cidade
                        ,UF
                        ,status)
                        VALUES ";
                SQL += "('" + this.NomeCompleto + "'";
                SQL += ",'" + this.CPF + "'";
                SQL += ",'" + this.Celular + "'";
                SQL += ",'" + this.Logadouro + "'";
                SQL += ",'" + this.NumEndereco + "'";
                SQL += ",'" + this.Complemento + "'";
                SQL += ",'" + this.Bairro + "'";
                SQL += ",'" + this.Cidade + "'";
                SQL += ",'" + this.UF + "'";
                SQL += ",'" + status + "')";

                return SQL;
            }

            public string ToUpdate(string nome, string usuario)
            {
                int status = 0;
                string SQL;

                if (Convert.ToInt32(this.StatusCliente) == 1)
                {
                    status = 1;
                }
                if (Convert.ToInt32(this.StatusCliente) == 2)
                {
                    status = 0;
                }

                if(BuscaClienteExistenteSQL(nome) == true)
                {
                    SQL = @"UPDATE Cliente SET ";
                    SQL += "nome = '" + this.NomeCompleto + "'";
                    SQL += ",telefone = '" + this.Celular + "'";
                    SQL += ",logadouro = '" + this.Logadouro + "'";
                    SQL += ",numero = '" + this.NumEndereco + "'";
                    SQL += ",complemento = '" + this.Complemento + "'";
                    SQL += ",bairro = '" + this.Bairro + "'";
                    SQL += ",cidade = '" + this.Cidade + "'";
                    SQL += ",UF = '" + this.UF + "'";
                    SQL += ",status = '" + status + "'";
                    SQL += "WHERE CPF = '" + this.CPF + "'";

                    return SQL;
                }
                else
                {
                    SQL = @"UPDATE Cliente SET ";
                    SQL += "nome = '" + this.NomeCompleto + "'";
                    SQL += ",CPF = '" + this.CPF + "'";
                    SQL += ",telefone = '" + this.Celular + "'";
                    SQL += ",logadouro = '" + this.Logadouro + "'";
                    SQL += ",numero = '" + this.NumEndereco + "'";
                    SQL += ",complemento = '" + this.Complemento + "'";
                    SQL += ",bairro = '" + this.Bairro + "'";
                    SQL += ",cidade = '" + this.Cidade + "'";
                    SQL += ",UF = '" + this.UF + "'";
                    SQL += ",status = '" + status + "'";
                    SQL += "WHERE CPF = '" + this.CPF + "'";

                    return SQL;
                }
                
            }

            public Unit DataRowToUnit(DataRow dr)
            {
                Unit u = new Unit();

                u.NomeCompleto = dr["nome"].ToString();
                u.CPF = dr["CPF"].ToString();
                u.Celular = dr["telefone"].ToString();
                u.Logadouro = dr["logadouro"].ToString();
                u.NumEndereco = dr["numero"].ToString();
                u.Complemento = dr["complemento"].ToString();
                u.Bairro = dr["bairro"].ToString();
                u.Cidade = dr["cidade"].ToString();
                u.UF = dr["UF"].ToString();
                u.StatusCliente = Convert.ToInt32(dr["status"]);

                return u;
            }

            public Unit DataRowToUnitUsuario(DataRow dr)
            {
                Unit u = new Unit();

                u.UsuarioID = Convert.ToInt32(dr["id_usuario"]);
                u.UsuarioLogado = dr["nome"].ToString();

                return u;
            }

            public bool BuscaClienteExistenteSQL(string cliente)
            {
                string SQL = "SELECT * FROM Cliente WHERE nome = '" + cliente + "'";

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
                    if (BuscaClienteExistenteSQL(this.NomeCompleto) == true)
                    {

                        if (MessageBox.Show("Cliente " + NomeCompleto + " já existe na nossa base, deseja alterar o cadastro?", "ForLife", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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
                    throw new Exception("Inclusão não permitida do cliente: " + this.NomeCompleto + ", erro: " + ex.Message);
                }
            }

            public Unit BuscarSQL(string cliente)
            {
                try
                {
                    string SQL = "SELECT * FROM Cliente WHERE nome = '" + cliente + "'";

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
                    throw new Exception("Erro ao buscar o cliente. " + ex.Message);
                }
            }

            public void AlterarSQL(string usuario)
            {
                try
                {
                    string SQL = "SELECT * FROM Cliente WHERE nome = '" + this.NomeCompleto + "'";

                    var db = new SQLServerClass();
                    var Dt = db.SQLQuery(SQL);

                    if (Dt.Rows.Count == 0)
                    {
                        db.Close();
                        throw new Exception("Cliente não existe");
                    }
                    else
                    {
                        SQL = this.ToUpdate(this.NomeCompleto, usuario);
                        db.SQLCommand(SQL);
                        db.Close();
                    }

                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao alterar o cliente: " + ex.Message);
                }
            }

            public void ApagarSQL()
            {
                try
                {
                    string SQL = "SELECT * FROM Cliente WHERE nome = '" + this.NomeCompleto + "'";

                    var db = new SQLServerClass();
                    var Dt = db.SQLQuery(SQL);

                    if (Dt.Rows.Count == 0)
                    {
                        db.Close();
                        throw new Exception("Cliente não existe");
                    }
                    else
                    {
                        SQL = "DELETE FROM Cliente WHERE nome = '" + this.NomeCompleto + "'";
                        db.SQLCommand(SQL);
                        db.Close();
                    }

                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao excluir o cliente: " + ex.Message);
                }
            }


            public List<List<string>> BuscarVariosSQL(string Campo, string Valor)
            {

                List<List<string>> ListaBusca = new List<List<string>>();

                try
                {
                    var SQL = "SELECT * FROM Cliente WHERE " + Campo + " LIKE '%" + Valor + "%' ";
                    var db = new SQLServerClass();
                    var Dt = db.SQLQuery(SQL);


                    for (int i = 0; i <= Dt.Rows.Count - 1; i++)
                    {
                        string endereco = null;
                        string status = null;

                        if (Convert.ToInt32(Dt.Rows[i]["status"]) == 1)
                        {
                            status = "Ativo";
                        }

                        else if (Convert.ToInt32(Dt.Rows[i]["status"]) == 0)
                        {
                            status = "Inativo";
                        }

                        endereco = Dt.Rows[i]["logadouro"].ToString() + ", " +
                                   Dt.Rows[i]["numero"].ToString() + " - " +
                                   Dt.Rows[i]["complemento"].ToString() +" - " +
                                   Dt.Rows[i]["bairro"].ToString() +" - " +
                                   Dt.Rows[i]["UF"].ToString();

                        //Nome, Telefone, Endereco, Cidade , Status
                        ListaBusca.Add(new List<string>
                        {
                            Dt.Rows[i]["nome"].ToString(),
                            Dt.Rows[i]["CPF"].ToString(),
                            Dt.Rows[i]["telefone"].ToString(),
                            endereco,
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
                    var SQL = "SELECT * FROM Cliente";
                    var db = new SQLServerClass();
                    var Dt = db.SQLQuery(SQL);


                    for (int i = 0; i <= Dt.Rows.Count - 1; i++)
                    {
                        string endereco = null;
                        string status = null;

                        if (Convert.ToInt32(Dt.Rows[i]["status"]) == 1)
                        {
                            status = "Ativo";
                        }

                        else if (Convert.ToInt32(Dt.Rows[i]["status"]) == 0)
                        {
                            status = "Inativo";
                        }

                        endereco = Dt.Rows[i]["logadouro"].ToString() + ", " +
                                   Dt.Rows[i]["numero"].ToString() + " - " +
                                   Dt.Rows[i]["complemento"].ToString() + " - " +
                                   Dt.Rows[i]["bairro"].ToString() + " - " +
                                   Dt.Rows[i]["UF"].ToString();

                        //Nome, Telefone, Endereco, Cidade , Status
                        ListaBusca.Add(new List<string>
                        {
                            Dt.Rows[i]["nome"].ToString(),
                            Dt.Rows[i]["telefone"].ToString(),
                            Dt.Rows[i]["CPF"].ToString(),
                            endereco,
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
