namespace Torneo.App.Dominio
{
    public class Jugador
    {
        public int jugadorId { get; set;}
        public string Nombre { get; set;}
        public string Numero { get; set;}
        public Equipo Equipo { get; set;}
        public Posicion Posicion { get; set;}
        
    }
    
}