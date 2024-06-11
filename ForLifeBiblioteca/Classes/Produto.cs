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
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections;
using System.Runtime.CompilerServices;


namespace ForLifeBiblioteca.Classes
{
    public class Produto
    {
        public class Unit
        {
            [Required(ErrorMessage = "Defina um status do produto")]
            [RegularExpression("^(1|2)$", ErrorMessage = "Defina um status do produto")]
            public int StatusProduto { get; set; }

            [Required(ErrorMessage = "Nome do Produto é obrigatório")]
            public string NomeProduto { get; set; }

            [Required(ErrorMessage = "Defina o insumo origem")]
            public string InsumoOrigem { get; set; }


            [Required(ErrorMessage = "Defina uma data prevista de vencimento")]
            [RegularExpression("^(100|[1-9][0-9]?|[1-9])$", ErrorMessage = "Defina uma data prevista de vencimento")]
            public decimal DtVencimento { get; set; }

            [Required(ErrorMessage = "Defina uma data prevista de colheita")]
            [RegularExpression("^(100|[1-9][0-9]?|[1-9])$", ErrorMessage = "Defina uma data prevista de colheita")]
            public decimal DtColheita { get; set; }
            
            public int IdInsumoOrigem { get; set; }

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


            public string ToInsert(string usuario)
            {

                int idInsumo = ReturnIdInsumo(this.InsumoOrigem);

                int idUsuario = ReturnIdUsuario(usuario);

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
                SQL += ",'" + idInsumo + "'";
                SQL += ",'" + Convert.ToInt32(this.DtColheita) + "'";
                SQL += ",'" + Convert.ToInt32(this.DtVencimento) + "'";
                SQL += ",'" + idUsuario + "'";
                SQL += ",'" + Convert.ToInt32(this.StatusProduto) + "')";

                return SQL;
            }

            public string ToUpdate(string nome, string usuario)
            {

                int idInsumo = ReturnIdInsumo(this.InsumoOrigem);
                int idUsuario = ReturnIdUsuario(usuario);
                int status = 0;

                if(Convert.ToInt32(this.StatusProduto) == 1)
                {
                    status = 1;
                }
                if (Convert.ToInt32(this.StatusProduto) == 2)
                {
                    status = 0;
                }

                string SQL;

                if (BuscaProdutoExistenteSQL(nome) == true)
                {                
                    SQL = @"UPDATE Produto SET ";                    
                    SQL += "insumo_id = '" + idInsumo + "'";
                    SQL += ",periodo_colheita = '" + Convert.ToInt32(this.DtColheita) + "'";
                    SQL += ",periodo_vencimento = '" + Convert.ToInt32(this.DtVencimento) + "'";
                    SQL += ",usuario_id = '" + idUsuario + "'";
                    SQL += ",status = '" + status + "'";
                    SQL += "WHERE nome = '" + this.NomeProduto + "'";

                    return SQL;

                }
                else
                {
                    SQL = @"UPDATE Produto SET ";
                    SQL += "nome = '" + this.NomeProduto + "'";
                    SQL += ",insumo_id = '" + idInsumo + "'";
                    SQL += ",periodo_colheita = '" + Convert.ToInt32(this.DtColheita) + "'";
                    SQL += ",periodo_vencimento = '" + Convert.ToInt32(this.DtVencimento) + "'";
                    SQL += ",usuario_id = '" + idUsuario + "'";
                    SQL += ",status = '" + Convert.ToInt32(this.StatusProduto) + "'";
                    SQL += "WHERE nome = '" + this.NomeProduto + "'";

                    return SQL;
                }
                
            }

            public Unit DataRowToUnit(DataRow dr)
            {

                Unit u = new Unit();
                u.NomeProduto = dr["nome"].ToString();
                u.IdInsumoOrigem = Convert.ToInt32(dr["insumo_id"]);
                u.DtColheita = Convert.ToDecimal(dr["periodo_colheita"]);
                u.DtVencimento = Convert.ToDecimal(dr["periodo_vencimento"]);
                u.UsuarioID = Convert.ToInt32(dr["usuario_id"]);
                u.StatusProduto = Convert.ToInt32(dr["status"]);

                return u;
            }

            public Unit DataRowToUnitUsuario(DataRow dr)
            {
                Unit u = new Unit();

                u.UsuarioID = Convert.ToInt32(dr["id_usuario"]);
                u.UsuarioLogado = dr["nome"].ToString();

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
                        return u.UsuarioID;
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
                    string SQL = "SELECT * FROM Insumo WHERE id_insumo = '" + id + "'";

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
                    throw new Exception("Erro ao buscar o insumo. " + ex.Message);
                }

            }

            public bool BuscaProdutoExistenteSQL(string Produto)
            {
                string SQL = "SELECT * FROM Produto WHERE nome = '" + Produto + "'";

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

            public void IncluirSQL(string usuario)
            {
                
                //int idUsuario = ReturnIdUsuario(usuario);

                try
                {
                    if (BuscaProdutoExistenteSQL(this.NomeProduto) == true)
                    {

                        if (MessageBox.Show("Produto " + NomeProduto + " já existe na nossa base, deseja alterar o cadastro?", "ForLife", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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

            public void AlterarSQL(string usuario)
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
                        SQL = this.ToUpdate(this.NomeProduto, usuario);
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
                        throw new Exception("Produto não existe");
                    }
                    else
                    {
                        SQL = "DELETE FROM Produto WHERE nome = '" + this.NomeProduto + "'";
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
                        string Insumo = ReturnNomeInsumo(Convert.ToInt32(Dt.Rows[i]["insumo_id"]));

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


                    /* IMPLEMENTAR QUANDO FIZER O INSUMO.CS, BUSCAR ATRAVÉS DO BUSCARVARIOSSQL DO INSUMO
                    if (Campo == "insumo_id")
                    {
                        
                        

                    } else
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
                        
                    }*/

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
                        string Insumo = ReturnNomeInsumo(Convert.ToInt32(Dt.Rows[i]["insumo_id"]));

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

            public List<List<string>> BuscarVariosInsumoSQL(string Valor)
            {
                List<List<string>> ListaBusca = new List<List<string>>();

                try
                {
                    var SQL = "SELECT * FROM Insumo WHERE nome LIKE '%" + Valor + "%' ";
                    var db = new SQLServerClass();
                    var Dt = db.SQLQuery(SQL);


                    for (int i = 0; i <= Dt.Rows.Count - 1; i++)
                    {
                        
                        //Adicionar os campos necessários da busca
                        ListaBusca.Add(new List<string>
                        {
                            Dt.Rows[i]["nome"].ToString(),
                            Dt.Rows[i]["tipo"].ToString()

                        });
                    }
                    return ListaBusca;

                }
                catch (Exception ex)
                {
                    throw new Exception("Conexão gerou o erro: " + ex.Message);
                }
            }

            public List<List<string>> ListaInsumosSQL()
            {
                List<List<string>> ListaBusca = new List<List<string>>();

                try
                {
                    var SQL = "SELECT name FROM Insumo";
                    var db = new SQLServerClass();
                    var Dt = db.SQLQuery(SQL);


                    for (int i = 0; i <= Dt.Rows.Count - 1; i++)
                    {
                        ListaBusca.Add(new List<string>
                        {
                            Dt.Rows[i]["nome"].ToString(),

                        });
                    }
                    return ListaBusca;

                }
                catch (Exception ex)
                {
                    throw new Exception("Conexão gerou o erro: " + ex.Message);
                }
            }

            public string BuscarInsumoSQL(string Insumo)
            {
                try
                {
                    string insumo;

                    string SQL = "SELECT * FROM Insumo WHERE nome = '" + Insumo + "'";

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

                        insumo = u.InsumoOrigem;

                        return insumo;
                    }

                }

                catch (Exception ex)
                {
                    throw new Exception("Erro ao buscar o produto. " + ex.Message);
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