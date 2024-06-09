using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using static System.Collections.Specialized.BitVector32;
using System.Diagnostics.Eventing.Reader;
using ForLife;
using ForLifeBiblioteca.Databases;
using System.Data;


namespace ForLifeBiblioteca.Classes
{
    internal class Produto
    {
        public class Unit
        {
            [Required(ErrorMessage = "Defina um status do produto")]
            public int StatusProduto { get; set; }

            [Required(ErrorMessage = "Nome do Produto é obrigatório")]
            public string NomeProduto {  get; set; }

            [Required(ErrorMessage = "Defina o insumo origem")]
            public string InsumoOrigem { get; set; }
            

            [Required(ErrorMessage = "Defina uma data prevista de vencimento")]
            [RegularExpression("(^[1-100]$)", ErrorMessage = "Defina uma data prevista de vencimento")]
            public int DtVencimento { get; set; }

            [Required(ErrorMessage = "Defina uma data prevista de colheita")]
            [RegularExpression("(^[1-100]$)", ErrorMessage = "Defina uma data prevista de vencimento")]
            public int DtColheita {  get; set; }
            public string  Usuario { get; set; }


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
                SQL += "('" + this.NomeProduto +"'";
                SQL += ",'" + Convert.ToInt32(this.IdInsumoOrigem) + "'";
                SQL += ",'" + Convert.ToInt32(this.DtColheita) + "'";
                SQL += ",'" + Convert.ToInt32(this.DtVencimento) + "'";
                SQL += ",'" + Convert.ToInt32(this.IdUsuario) + "'";
                SQL += ",'" + Convert.ToInt32(this.StatusProduto) +"')";

                return SQL;
            }

            /*
            public string ToUpdate(string nome)
            {
                string SQL;

                SQL = @"UPDATE Produto SET ";
                SQL += "nome = '" + this.NomeProduto + "'";
                SQL += ",periodo_colheita = '" + Convert.ToInt32(this.DtColheita) + "'";
                SQL += ",periodo_vencimento = '" + Convert.ToInt32(this.DtVencimento) + "'";
                SQL += ",status = '" + Convert.ToInt32(this.icBloqueado) + "'";
                SQL += "WHERE usuario = '" + this.Usuario + "'";

            }
            */
            public Unit DataRowToUnitUsuario (DataRow dr)
            {
                Unit u = new Unit();

                u.IdUsuario = Convert.ToInt32(dr["id_usuario"]);

                return u;
            }

            public Unit DataRowToUnitInsumo(DataRow dr)
            {
                Unit u = new Unit();

                u.IdInsumoOrigem = Convert.ToInt32(dr["id_insumo"]);

                return u;
            }

            #endregion

            #region CRUD SQLServer

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

            #endregion

        }

        public class List
        {
            public List<Unit> ListUnit { get; set; }
        }
    }
}
