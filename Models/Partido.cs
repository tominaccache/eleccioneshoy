namespace elecciones.Models;

public class Partido{
    public int IdPartido;
    public string Nombre;
    public string Logo;
    public string SitioWeb;
    public DateTime FechaFundacion;
    public int CantidadDiputados;
    public int CantidadSenadores;
    public Partido(){

    }
    public Partido(int IDPartido = 0, string Nombre = "...", string Logo = "...", string SitioWeb = "...", DateTime FechaFundacion = new DateTime(), int CantidadDiputados = 0, int CantidadSenadores = 0){
        this.IdPartido = IDPartido;
        this.Nombre = Nombre;
        this.Logo = Logo;
        this.SitioWeb = SitioWeb;
        this.FechaFundacion = FechaFundacion;
        this.CantidadDiputados = CantidadDiputados;
        this.CantidadSenadores = CantidadSenadores;
        
    }
}
