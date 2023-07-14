using System.Data.SqlClient;
using Dapper;
namespace elecciones.Models;

public static class BD
{
    private static string _connectionString = "Server=localhost; DataBase=elecciones;Trusted_Connection=True;";
    
     public static int AgregarCandidato(Candidato can){
        int r;
        using(SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "INSERT INTO Candidato(IDPartido, Apellido, Nombre, FechaNacimiento, Foto, Postulacion) VALUES (@pIDPartido, @pApellido, @pNombre, @pFechaNacimiento, @pFoto, @pPostulacion);";
            r = db.Execute(sql, new {pIdPartido = can.IDPartido, pApellido = can.Apellido, pNombre = can.Nombre, pFechaNacimiento = can.FechaNacimiento, pFoto = can.Foto, pPostulacion = can.Postulacion});
        }
        return r;
    }
    
    public static int EliminarCandidato(int IdCandidato){
        int RegistrosEliminados=0;
        string sql="DELETE FROM Candidato WHERE IdCandidato=@pCandidato";
        using(SqlConnection db= new SqlConnection(_connectionString))
        {
            RegistrosEliminados= db.Execute(sql, new {pCandidato = IdCandidato});
        }
        return RegistrosEliminados;
    }

    public static Partido VerInfoPartido(int IdPartido){
        Partido part;
        using(SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM Partido WHERE IdPartido = @pIdPartido";
            part = db.QueryFirstOrDefault<Partido>(sql, new {pIDPartido = IdPartido});
        }
        return part;
    }

    public static Candidato VerInfoCandidato(int IdCandidato){
          Candidato candidato = null;
        using(SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM Candidato WHERE IdCandidato = @pCandidatoElegido";    
            candidato = db.QueryFirstOrDefault(sql, new {pCandidatoElegido = IdCandidato});
        }
        return candidato;
    }

    public static List<Partido> ListarPartidos(){
        List<Partido> part;
        using(SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM Partido";
            part = db.Query<Partido>(sql).ToList();
        }
        return part;
    }

    public static List<Candidato> ListarCandidatos(int IdPartido){
        List<Candidato> candidatos = new List<Candidato>();
        using(SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM Candidato WHERE IdPartido = @ElegirPartido";    
            candidatos = db.Query<Candidato>(sql, new {ElegirPartido = IdPartido}).ToList();
        }
        return candidatos;
    }

}
    
