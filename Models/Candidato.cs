
public class Candidato{
    public int IDCandidato;
    public int IDPartido;
    public string Apellido;
    public string Nombre;
    public DateTime FechaNacimiento;
    public string Foto;
    public string Postulacion;
    public Candidato(){

    }
    public Candidato(int IDCandidato = 0, int IDPartido = 0, string Apellido = "...", string Nombre = "...", DateTime FechaNacimiento = new DateTime(), string Foto = "...", string Postulacion = "..."){
        this.IDCandidato = IDCandidato;
        this.IDPartido = IDPartido;
        this.Apellido = Apellido;
        this.Nombre = Nombre;
        this.FechaNacimiento = FechaNacimiento;
        this.Foto = Foto;
        this.Postulacion = Postulacion;
    }
}