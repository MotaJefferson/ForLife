using ForLifeBiblioteca.Databases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLifeBiblioteca.Classes
{
    public class EstoqueProduto
    {
        public class Unit
        {

            #region Movimentações SQLServer

            public List<List<string>> BuscarRegistrosSQL(string Campo, string Valor)
            {

                List<List<string>> ListaBusca = new List<List<string>>();

                try
                {
                    var SQL = "SELECT * FROM TelaEstoqueProdutoW WHERE " + Campo + " LIKE '%" + Valor + "%' ";
                    var db = new SQLServerClass();
                    var Dt = db.SQLQuery(SQL);


                    for (int i = 0; i <= Dt.Rows.Count - 1; i++)
                    {

                        ListaBusca.Add(new List<string>
                        {
                            Dt.Rows[i]["nome"].ToString(),
                            Dt.Rows[i]["quantidade_atual"].ToString(),
                            Dt.Rows[i]["data_vencimento_estimado"].ToString(),
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
                    var SQL = "SELECT * FROM TelaEstoqueProdutoW";
                    var db = new SQLServerClass();
                    var Dt = db.SQLQuery(SQL);


                    for (int i = 0; i <= Dt.Rows.Count - 1; i++)
                    {


                        ListaBusca.Add(new List<string>
                        {
                            Dt.Rows[i]["nome"].ToString(),
                            Dt.Rows[i]["quantidade_atual"].ToString(),
                            Dt.Rows[i]["data_vencimento_estimado"].ToString(),
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
