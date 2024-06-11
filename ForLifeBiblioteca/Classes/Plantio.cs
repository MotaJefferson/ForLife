using ForLifeBiblioteca.Databases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForLifeBiblioteca.Classes
{
    public class Plantio
    {

        public class Unit
        {
            public int IdInsumo { get; set; }
            public string InsumoNome { get; set; }
            public int IdProduto { get; set; }
            public string ProdutoNome { get; set; }
            public int QtdPlantio { get; set; }
            public string DtPlantio { get; set; }
            public string DtColheita { get; set; }
            public string DtVencimento { get; set; }
            public string DtBaixa { get; set; }


            #region Funções CRUD
            /*
            public string ToInsert(string usuario)
            {


                string SQL;

                SQL = @"INSERT INTO Plantio
                            (insumo_id
                            ,produto_id
                            ,quantidade_plantio
                            ,data_plantio
                            ,data_colheita
                            ,data_vencimento_estimado
                            ,data_baixa)
                            VALUES ";
                SQL += "('" + this.NomeProduto + "'";
                SQL += ",'" + idInsumo + "'";
                SQL += ",'" + Convert.ToInt32(this.DtColheita) + "'";
                SQL += ",'" + Convert.ToInt32(this.DtVencimento) + "'";
                SQL += ",'" + idUsuario + "'";
                SQL += ",'" + Convert.ToInt32(this.StatusProduto) + "')";

                return SQL;
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
            */

            public Unit DataRowToUnit(DataRow dr)
            {

                Unit u = new Unit();
                u.ProdutoNome = dr["nome"].ToString();
                u.QtdPlantio = Convert.ToInt32(dr["qtdPlantio"]);

                return u;
            }

            public Unit DataRowToUnitProduto(DataRow dr)
            {

                Unit u = new Unit();
                u.IdProduto = Convert.ToInt32(dr["id_produto"]);
                u.ProdutoNome = dr["nome"].ToString();

                return u;
            }


            public string ReturnNomeProduto(int idproduto)
            {

                try
                {
                    string SQL = "SELECT * FROM Produto WHERE id_produto = '" + idproduto + "'";

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
                        return u.ProdutoNome;
                    }

                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao buscar o produto. " + ex.Message);
                }

            }

            public int ReturnIdProduto(string produto)
            {

                try
                {
                    string SQL = "SELECT TOP 1 * FROM Produto WHERE nome LIKE '%" +produto+ "%' ";

                    var db = new SQLServerClass();
                    var Dt = db.SQLQuery(SQL);

                    if (Dt.Rows.Count == 0)
                    {
                        db.Close();
                        throw new Exception("A pesquisa não retornou valores");
                    }
                    else
                    {
                        Unit u = this.DataRowToUnitProduto(Dt.Rows[0]);
                        return u.IdProduto;
                    }

                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao buscar o produto. " + ex.Message);
                }

            }


            #endregion

            #region CRUD SQLServer


            public List<List<string>> BuscarVariosSQL(string Campo, int Valor)
            {
                List<List<string>> ListaBusca = new List<List<string>>();

                string NomeProduto = ReturnNomeProduto(Valor);

                MessageBox.Show(NomeProduto);

                try
                {
                    var SQL = "SELECT * FROM Plantio WHERE " + Campo + " LIKE '%" + Valor + "%' ";
                    var db = new SQLServerClass();
                    var Dt = db.SQLQuery(SQL);

                    
                    for (int i = 0; i <= Dt.Rows.Count - 1; i++)
                    {

                        Convert.ToInt32(Dt.Rows[i]["produto_id"]);

                        //Adicionar os campos necessários da busca
                        ListaBusca.Add(new List<string>
                        {
                            NomeProduto,
                            Dt.Rows[i]["qtdPlantio"].ToString(),
                            Dt.Rows[i]["data_colheita"].ToString(),
                            Dt.Rows[i]["data_validade"].ToString(),

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
    }
        
}
