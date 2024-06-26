﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using ForLifeBiblioteca.Databases;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ForLifeBiblioteca.Classes
{
    public class Usuario
    {
        public class Unit
        {
            [Required(ErrorMessage = "O Tipo Usuário é obrigatório")]
            [RegularExpression("(^[1-3]$)", ErrorMessage = "O Tipo Usuário é obrigatório")]
            public int Cargo { get; set; }

            [Required(ErrorMessage = "Nome é obrigatório")]
            public string Nome { get; set; }

            [Required(ErrorMessage = "O usuário é obrigatório")]
            public string Usuario { get; set; }

            [Required(ErrorMessage = "Insira a senha")]
            public string Senha { get; set; }

            [Required(ErrorMessage = "Insira a confirmação da senha")]
            public string ConfirmarSenha { get; set; }

            public int icBloqueado { get; set; }


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
                if (this.Senha != this.ConfirmarSenha)
                {
                    throw new Exception("As senhas devem ser iguais");
                }
            }

            #region CRUD SQLServer
                
            public void IncluirSQL()
            {

                try
                {
                    if (BuscaUsuarioExistenteSQL(this.Usuario) == false)
                    {
                        string SQL;
                        SQL = this.ToInsert();
                        var db = new SQLServerClass();
                        db.SQLCommand(SQL);
                        db.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuário " + Usuario + " já existe na nossa base","ForLife",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                }
                catch (Exception ex)
                {
                    throw new Exception("Inclusão não permitida do usuário: " + this.Usuario + ", erro: " + ex.Message);
                }
               

            }

            public bool BuscaUsuarioExistenteSQL(string Usuario)
            {
                string SQL = "SELECT * FROM Usuario WHERE usuario = '" + Usuario + "'";

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

            public Unit BuscarSQL(string usuario)
            {
                try
                {
                    string SQL = "SELECT * FROM Usuario WHERE usuario = '"+ usuario + "'";

                    var db = new SQLServerClass();
                    var Dt = db.SQLQuery(SQL);

                    if(Dt.Rows.Count == 0)
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
                    throw new Exception("Erro ao buscar o cliente: " + ex.Message);
                }
            }

            public void AlterarSQL()
            {
                try
                {
                    string SQL = "SELECT * FROM Usuario WHERE usuario = '" + this.Usuario + "'";

                    var db = new SQLServerClass();
                    var Dt = db.SQLQuery(SQL);

                    if (Dt.Rows.Count == 0)
                    {
                        db.Close();
                        throw new Exception("Usuário não existe");
                    }
                    else
                    {
                        SQL = this.ToUpdate(this.Usuario);
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
                    string SQL = "SELECT * FROM Usuario WHERE usuario = '" + this.Usuario + "'";

                    var db = new SQLServerClass();
                    var Dt = db.SQLQuery(SQL);

                    if (Dt.Rows.Count == 0)
                    {
                        db.Close();
                        throw new Exception("Usuário não existe");
                    }
                    else
                    {
                        SQL = "DELETE FROM Usuario WHERE usuario = '" + this.Usuario + "'";
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
                    var SQL = "SELECT * FROM Usuario WHERE " + Campo + " LIKE '%" + Valor + "%' ";
                    var db = new SQLServerClass();
                    var Dt = db.SQLQuery(SQL);

                    for (int i = 0; i <= Dt.Rows.Count - 1; i++)
                    {
                        string Cargo = "";
                        string Bloqueado = "";

                        if(Convert.ToInt32(Dt.Rows[i]["Cargo"]) == 1)
                        {
                            Cargo = "Agricultor";

                        } else if (Convert.ToInt32(Dt.Rows[i]["Cargo"]) == 2)
                        {
                            Cargo = "Comercial";
                        }
                        else if (Convert.ToInt32(Dt.Rows[i]["Cargo"]) == 3)
                        {
                            Cargo = "Gestor";
                        }

                        if (Convert.ToInt32(Dt.Rows[i]["icBloqueado"]) == 0)
                        {
                            Bloqueado = "Desbloqueado";

                        }
                        else if (Convert.ToInt32(Dt.Rows[i]["icBloqueado"]) == 1)
                        {
                            Bloqueado = "Bloqueado";
                        }

                        //Adicionar os campos necessários da busca
                        ListaBusca.Add(new List<string> {   Dt.Rows[i]["Usuario"].ToString(),
                                                            Dt.Rows[i]["Nome"].ToString(),
                                                            Cargo,
                                                            Bloqueado
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
                    var SQL = "SELECT * FROM Usuario";
                    var db = new SQLServerClass();
                    var Dt = db.SQLQuery(SQL);

                    for(int i=0; i<=Dt.Rows.Count -1; i++)
                    {

                        string Cargo = "";
                        string Bloqueado = "";

                        if (Convert.ToInt32(Dt.Rows[i]["Cargo"]) == 1)
                        {
                            Cargo = "Agricultor";

                        }
                        else if (Convert.ToInt32(Dt.Rows[i]["Cargo"]) == 2)
                        {
                            Cargo = "Comercial";
                        }
                        else if (Convert.ToInt32(Dt.Rows[i]["Cargo"]) == 3)
                        {
                            Cargo = "Gestor";
                        }

                        if (Convert.ToInt32(Dt.Rows[i]["icBloqueado"]) == 0)
                        {
                            Bloqueado = "Desbloqueado";

                        }
                        else if (Convert.ToInt32(Dt.Rows[i]["icBloqueado"]) == 1)
                        {
                            Bloqueado = "Bloqueado";
                        }


                        //Adicionar os campos necessários da busca
                        ListaBusca.Add(new List<string> {   Dt.Rows[i]["Usuario"].ToString(),
                                                            Dt.Rows[i]["Nome"].ToString(),
                                                            Cargo,
                                                            Bloqueado
                        }) ;
                    }
                    return ListaBusca;

                }
                catch (Exception ex)
                {
                    throw new Exception("Conexão gerou o erro: " + ex.Message);
                }


            }

            #endregion

            #region Funções CRUD

            public string ToInsert()
            {
                string SQL;

                SQL = @"INSERT INTO Usuario
                        (nome
                        ,usuario
                        ,senha
                        ,cargo
                        ,icBloqueado)
                        VALUES ";
                SQL += "('" + this.Nome + "'";
                SQL += ",'" + this.Usuario + "'";
                SQL += ",'" + this.Senha + "'";
                SQL += ",'" + Convert.ToInt32(this.Cargo) + "'";
                SQL += ",'" + Convert.ToInt32(this.icBloqueado) + "')";

                return SQL;
            }
            
            public string ToUpdate(string Usuario)
            {
                string SQL;

                SQL = @"UPDATE Usuario SET ";
                SQL += "nome = '" + this.Nome + "'";
                SQL += ",senha = '" + this.Senha + "'";
                SQL += ",cargo = '" + Convert.ToInt32(this.Cargo) + "'";
                SQL += ",icBloqueado = '" + Convert.ToInt32(this.icBloqueado) + "'";
                SQL += "WHERE usuario = '" + this.Usuario + "'";

                return SQL;
            }

            public Unit DataRowToUnit (DataRow dr)
            {
                Unit u = new Unit();
                u.Nome = dr["Nome"].ToString();
                u.Usuario = dr["Usuario"].ToString();
                u.Senha = dr["Senha"].ToString();
                u.Cargo = Convert.ToInt32(dr["Cargo"]);
                u.icBloqueado = Convert.ToInt32(dr["icBloqueado"]);

                return u;
            }
                
            #endregion

        }

        public class List
        {
            public List<Unit>ListUnit {  get; set; }
        }
    }
}
