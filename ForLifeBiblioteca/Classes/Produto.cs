using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using static System.Collections.Specialized.BitVector32;
using System.Diagnostics.Eventing.Reader;
using ForLifeBiblioteca.Databases;
using System.Data;
using System.Windows.Forms;


namespace ForLifeBiblioteca.Classes
{
    public class Produto
    {
        public class Unit
        {
            [Required(ErrorMessage = "Defina um status do produto")]
            public int StatusProduto { get; set; }

            [Required(ErrorMessage = "Nome do Produto é obrigatório")]
            public string NomeProduto { get; set; }

            [Required(ErrorMessage = "Defina o insumo origem")]
            public string InsumoOrigem { get; set; }


            [Required(ErrorMessage = "Defina uma data prevista de vencimento")]
            [RegularExpression("(^[1-100]$)", ErrorMessage = "Defina uma data prevista de vencimento")]
            public int DtVencimento { get; set; }

            [Required(ErrorMessage = "Defina uma data prevista de colheita")]
            [RegularExpression("(^[1-100]$)", ErrorMessage = "Defina uma data prevista de vencimento")]
            public int DtColheita { get; set; }
            public string Usuario { get; set; }


            public int IdUsuario { get; set; }
            public int IdInsumoOrigem { get; set; }

            public string UsuarioLogado = Session.Instance.UserID;

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

            public void ValidaComplemento()
            {
                if (this.DtVencimento == 0)
                {
                    throw new Exception("Insira um valor maior que 0");
                }

                if (this.DtColheita == 0)
                {
                    throw new Exception("Insira um valor maior que 0");
                }

            }

            #region Funções CRUD


            public string ToInsert()
            {
                string SQL;

                SQL = @"INSERT INTO Produto
                        (nome
                        ,insumo_id
                        ,periodo_colheita
                        ,periodo_vencimento
                        ,usuario_id
                        ,status)
                        VALUES ";
                SQL += "('" + this.NomeProduto + "'";
                SQL += ",'" + Convert.ToInt32(this.IdInsumoOrigem) + "'";
                SQL += ",'" + Convert.ToInt32(this.DtColheita) + "'";
                SQL += ",'" + Convert.ToInt32(this.DtVencimento) + "'";
                SQL += ",'" + Convert.ToInt32(this.IdUsuario) + "'";
                SQL += ",'" + Convert.ToInt32(this.StatusProduto) + "')";

                return SQL;
            }

            public string ToUpdate(string nome)
            {
                string SQL;

                SQL = @"UPDATE Produto SET ";
                SQL += "nome = '" + this.NomeProduto + "'";
                SQL += ",insumo_id = '" + Convert.ToInt32(this.IdInsumoOrigem) + "'";
                SQL += ",periodo_colheita = '" + Convert.ToInt32(this.DtColheita) + "'";
                SQL += ",periodo_vencimento = '" + Convert.ToInt32(this.DtVencimento) + "'";
                SQL += ",usuario_id = '" + Convert.ToInt32(this.IdUsuario) + "'";
                SQL += ",status = '" + Convert.ToInt32(this.StatusProduto) + "'";
                SQL += "WHERE nome = '" + this.NomeProduto + "'";

                return SQL;
            }

            public Unit DataRowToUnit(DataRow dr)
            {
                Unit u = new Unit();
                u.NomeProduto = dr["nome"].ToString();
                u.IdInsumoOrigem = Convert.ToInt32(dr["insumo_id"]);
                u.DtColheita = Convert.ToInt32(dr["periodo_colheita"]);
                u.DtVencimento = Convert.ToInt32(dr["periodo_vencimento"]);
                u.IdUsuario = Convert.ToInt32(dr["usuario_id"]);
                u.StatusProduto = Convert.ToInt32(dr["status"]);

                return u;
            }


            public Unit DataRowToUnitUsuario(DataRow dr)
            {
                Unit u = new Unit();

                u.IdUsuario = Convert.ToInt32(dr["id_usuario"]);
                u.Usuario = dr["nome"].ToString();

                return u;
            }

            public Unit DataRowToUnitInsumo(DataRow dr)
            {
                Unit u = new Unit();

                u.IdInsumoOrigem = Convert.ToInt32(dr["id_insumo"]);
                u.InsumoOrigem = dr["nome"].ToString();

                return u;
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
                        return u.IdUsuario;
                    }

                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao buscar o usuario. " + ex.Message);
                }

            }

            public int ReturnIdInsumo(string insumo)
            {

                try
                {
                    string SQL = "SELECT * FROM Insumo WHERE usuario = '" + insumo + "'";

                    var db = new SQLServerClass();
                    var Dt = db.SQLQuery(SQL);

                    if (Dt.Rows.Count == 0)
                    {
                        db.Close();
                        throw new Exception("A pesquisa não retornou valores");
                    }
                    else
                    {
                        Unit u = this.DataRowToUnitInsumo(Dt.Rows[0]);
                        return u.IdInsumoOrigem;
                    }

                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao buscar o usuario. " + ex.Message);
                }

            }

            public string ReturnNomeInsumo(int id)
            {

                try
                {
                    string SQL = "SELECT * FROM Insumo WHERE id_usuario = '" + id + "'";

                    var db = new SQLServerClass();
                    var Dt = db.SQLQuery(SQL);

                    if (Dt.Rows.Count == 0)
                    {
                        db.Close();
                        throw new Exception("A pesquisa não retornou valores");
                    }
                    else
                    {
                        Unit u = this.DataRowToUnitInsumo(Dt.Rows[0]);
                        return u.InsumoOrigem;
                    }

                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao buscar o usuario. " + ex.Message);
                }

            }

            public bool BuscaProdutoExistenteSQL(string Produto)
            {
                string SQL = "SELECT * FROM Produto WHERE usuario = '" + Produto + "'";

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

            #endregion


            #region CRUD SQLServer

            public void IncluirSQL()
            {
                try
                {
                    if (BuscaProdutoExistenteSQL(this.NomeProduto) == false)
                    {

                        string SQL;
                        SQL = this.ToInsert();
                        var db = new SQLServerClass();
                        db.SQLCommand(SQL);
                        db.Close();

                    }
                    else
                    {
                        MessageBox.Show("Produto " + NomeProduto + " já existe na nossa base", "ForLife", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Inclusão não permitida do produto: " + this.NomeProduto + ", erro: " + ex.Message);
                }
            }

            public Unit BuscarSQL(string Produto)
            {
                try
                {
                    string SQL = "SELECT * FROM Produto WHERE nome = '" + Produto + "'";

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

            public void AlterarSQL()
            {
                try
                {
                    string SQL = "SELECT * FROM Produto WHERE nome = '" + this.NomeProduto + "'";

                    var db = new SQLServerClass();
                    var Dt = db.SQLQuery(SQL);

                    if (Dt.Rows.Count == 0)
                    {
                        db.Close();
                        throw new Exception("Produto não existe");
                    }
                    else
                    {
                        SQL = this.ToUpdate(this.NomeProduto);
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
                    string SQL = "SELECT * FROM Produto WHERE nome = '" + this.NomeProduto + "'";

                    var db = new SQLServerClass();
                    var Dt = db.SQLQuery(SQL);

                    if (Dt.Rows.Count == 0)
                    {
                        db.Close();
                        throw new Exception("Usuário não existe");
                    }
                    else
                    {
                        SQL = "DELETE FROM Produto WHERE nome = '" + this.Usuario + "'";
                        db.SQLCommand(SQL);
                        db.Close();
                    }

                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao excluir o produto: " + ex.Message);
                }

            }

            public List<List<string>> BuscarVariosSQL(string Campo, string Valor)
            {
                List<List<string>> ListaBusca = new List<List<string>>();

                try
                {
                    var SQL = "SELECT * FROM Produto WHERE " + Campo + " LIKE '%" + Valor + "%' ";
                    var db = new SQLServerClass();
                    var Dt = db.SQLQuery(SQL);


                    for (int i = 0; i <= Dt.Rows.Count - 1; i++)
                    {
                        string Status = "";
                        string Insumo = ReturnNomeInsumo(Convert.ToInt32(Dt.Rows[i]["id_insumo"]));

                        if (Convert.ToInt32(Dt.Rows[i]["status"]) == 0)
                        {
                            Status = "Inativo";

                        }
                        else if (Convert.ToInt32(Dt.Rows[i]["status"]) == 1)
                        {
                            Status = "Ativo";
                        }

                        //Adicionar os campos necessários da busca
                        ListaBusca.Add(new List<string>
                        {
                            Dt.Rows[i]["nome"].ToString(),
                            Insumo,
                            Status

                        });
                    }
                    return ListaBusca;

                }
                catch (Exception ex)
                {
                    throw new Exception("Conexão gerou o erro: " + ex.Message);
                }
            }

            public List<List<string>> ListaInsumoSQL()
            {
                List<List<string>> ListaBusca = new List<List<string>>();

                try
                {
                    var SQL = "SELECT nome FROM Insumo";
                    var db = new SQLServerClass();
                    var Dt = db.SQLQuery(SQL);


                    for (int i = 0; i <= Dt.Rows.Count - 1; i++)
                    {

                        ListaBusca.Add(new List<string>
                        {
                            Dt.Rows[i]["nome"].ToString()
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
                    var SQL = "SELECT * FROM Produto";
                    var db = new SQLServerClass();
                    var Dt = db.SQLQuery(SQL);


                    for (int i = 0; i <= Dt.Rows.Count - 1; i++)
                    {
                        string Status = "";
                        string Insumo = ReturnNomeInsumo(Convert.ToInt32(Dt.Rows[i]["id_insumo"]));

                        if (Convert.ToInt32(Dt.Rows[i]["status"]) == 0)
                        {
                            Status = "Inativo";

                        }
                        else if (Convert.ToInt32(Dt.Rows[i]["status"]) == 1)
                        {
                            Status = "Ativo";
                        }

                        //Adicionar os campos necessários da busca
                        ListaBusca.Add(new List<string>
                        {
                            Dt.Rows[i]["nome"].ToString(),
                            Insumo,
                            Status

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