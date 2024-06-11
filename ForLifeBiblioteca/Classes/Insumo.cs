using ForLifeBiblioteca.Databases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ForLifeBiblioteca.Classes
{
    public class Insumo
    {
        public class Unit
        {
            [Required(ErrorMessage = "Defina um status do insumo")]
            [RegularExpression("^(1|2)$", ErrorMessage = "Defina um status do insumo")]
            public int StatusInsumo { get; set; }

            [Required(ErrorMessage = "Nome do Insumo é obrigatório")]
            public string NomeInsumo { get; set; }

            [Required(ErrorMessage = "Defina um status do insumo")]
            [RegularExpression("^(1|2)$", ErrorMessage = "Defina um status do insumo")]
            public int TipoInsumo { get; set; }

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
                string tipo = null;
                int idUsuario = ReturnIdUsuario(usuario);

                if (this.StatusInsumo == 1)
                {
                    tipo = "Semente";
                }
                if (this.StatusInsumo == 2)
                {
                    tipo = "Muda";
                }

                string SQL;

                SQL = @"INSERT INTO Insumo
                        (nome
                        ,tipo
                        ,ativo
                        ,usuario_id)
                        VALUES ";
                SQL += "('" + this.NomeInsumo + "'";
                SQL += ",'" + tipo + "'";
                SQL += ",'" + Convert.ToInt32(this.StatusInsumo) + "'";
                SQL += ",'" + idUsuario + "')";

                return SQL;
            }

            public string ToUpdate(string nome, string usuario)
            {
                string tipo = null;
                int idUsuario = ReturnIdUsuario(usuario);
                int status = 0;

                if (this.StatusInsumo == 1)
                {
                    tipo = "Semente";
                }
                if (this.StatusInsumo == 2)
                {
                    tipo = "Muda";
                }

                if (Convert.ToInt32(this.StatusInsumo) == 1)
                {
                    status = 1;
                }
                if (Convert.ToInt32(this.StatusInsumo) == 2)
                {
                    status = 0;
                }

                string SQL;

                if (BuscaInsumoExistenteSQL(nome) == true)
                {
                    SQL = @"UPDATE Insumo SET ";
                    SQL += "tipo = '" + tipo + "'";
                    SQL += ",ativo = '" + status + "'";
                    SQL += ",usuario_id = '" + idUsuario + "'";
                    SQL += "WHERE nome = '" + this.NomeInsumo + "'";

                    return SQL;
                }
                else
                {
                    SQL = @"UPDATE Insumo SET ";
                    SQL += "nome = '" + tipo + "'";
                    SQL += ",tipo = '" + tipo + "'";
                    SQL += ",ativo = '" + status + "'";
                    SQL += ",usuario_id = '" + idUsuario + "'";
                    SQL += "WHERE nome = '" + this.NomeInsumo + "'";

                    return SQL;
                }
            }

            public Unit DataRowToUnit(DataRow dr)
            {
                Unit u = new Unit();

                int tipoInsumo = 0;

                if(dr["tipo"].ToString() == "Semente")
                {
                    tipoInsumo = 1;
                }

                if (dr["tipo"].ToString() == "Muda")
                {
                    tipoInsumo = 2;
                }

                u.NomeInsumo = dr["nome"].ToString();
                u.TipoInsumo = tipoInsumo;
                u.StatusInsumo = Convert.ToInt32(dr["status"]);

                return u;
            }

            public Unit DataRowToUnitUsuario(DataRow dr)
            {
                Unit u = new Unit();

                u.UsuarioID = Convert.ToInt32(dr["id_usuario"]);
                u.UsuarioLogado = dr["nome"].ToString();

                return u;
            }

            public bool BuscaInsumoExistenteSQL(string insumo)
            {
                string SQL = "SELECT * FROM Insumo WHERE nome = '" + insumo + "'";

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
                    if (BuscaInsumoExistenteSQL(this.NomeInsumo) == true)
                    {

                        if (MessageBox.Show("Insumo " + NomeInsumo + " já existe na nossa base, deseja alterar o cadastro?", "ForLife", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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
                    throw new Exception("Inclusão não permitida do insumo: " + this.NomeInsumo + ", erro: " + ex.Message);
                }
            }

            public Unit BuscarSQL(string insumo)
            {
                try
                {
                    string SQL = "SELECT * FROM Insumo WHERE nome = '" + insumo + "'";

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
                    string SQL = "SELECT * FROM Insumo WHERE nome = '" + this.NomeInsumo + "'";

                    var db = new SQLServerClass();
                    var Dt = db.SQLQuery(SQL);

                    if (Dt.Rows.Count == 0)
                    {
                        db.Close();
                        throw new Exception("Insumo não existe");
                    }
                    else
                    {
                        SQL = this.ToUpdate(this.NomeInsumo, usuario);
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
                    string SQL = "SELECT * FROM Produto WHERE nome = '" + this.NomeInsumo + "'";

                    var db = new SQLServerClass();
                    var Dt = db.SQLQuery(SQL);

                    if (Dt.Rows.Count == 0)
                    {
                        db.Close();
                        throw new Exception("Insumo não existe");
                    }
                    else
                    {
                        SQL = "DELETE FROM Insumo WHERE nome = '" + this.NomeInsumo + "'";
                        db.SQLCommand(SQL);
                        db.Close();
                    }

                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao excluir o insumo: " + ex.Message);
                }
            }

            public List<List<string>> BuscarVariosSQL(string Campo, string Valor)
            {
                List<List<string>> ListaBusca = new List<List<string>>();

                try
                {
                    var SQL = "SELECT * FROM Insumo WHERE " + Campo + " LIKE '%" + Valor + "%' ";
                    var db = new SQLServerClass();
                    var Dt = db.SQLQuery(SQL);


                    for (int i = 0; i <= Dt.Rows.Count - 1; i++)
                    {
                        string tipo = null;
                        string status = null;

                        if (Convert.ToInt32(Dt.Rows[i]["tipo"]) == 1)
                        {
                            tipo = "Semente";

                        }
                        if (Convert.ToInt32(Dt.Rows[i]["tipo"]) == 2)
                        {
                            tipo = "Muda";
                        }

                        if(Convert.ToInt32(Dt.Rows[i]["ativo"]) == 1)
                        {
                            status = "Ativo";
                        }

                        if (Convert.ToInt32(Dt.Rows[i]["ativo"]) == 2)
                        {
                            status = "Inativo";
                        }

                        //Adicionar os campos necessários da busca
                        ListaBusca.Add(new List<string>
                        {
                            Dt.Rows[i]["nome"].ToString(),
                            tipo,
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
                    var SQL = "SELECT * FROM Insumo";
                    var db = new SQLServerClass();
                    var Dt = db.SQLQuery(SQL);


                    for (int i = 0; i <= Dt.Rows.Count - 1; i++)
                    {
                        string tipo = null;
                        string status = null;

                        if (Convert.ToInt32(Dt.Rows[i]["tipo"]) == 1)
                        {
                            tipo = "Semente";

                        }
                        if (Convert.ToInt32(Dt.Rows[i]["tipo"]) == 2)
                        {
                            tipo = "Muda";
                        }

                        if (Convert.ToInt32(Dt.Rows[i]["ativo"]) == 1)
                        {
                            status = "Ativo";
                        }

                        if (Convert.ToInt32(Dt.Rows[i]["ativo"]) == 2)
                        {
                            status = "Inativo";
                        }

                        //Adicionar os campos necessários da busca
                        ListaBusca.Add(new List<string>
                        {
                            Dt.Rows[i]["nome"].ToString(),
                            tipo,
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
