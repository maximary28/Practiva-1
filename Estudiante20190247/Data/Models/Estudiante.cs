
namespace Estudiantes.Data.Models;
public class Estudiante
{
   
    public int estudianteID { get; set;}
    public string Nombre { get; set;} = null;
    public string Apellido { get; set;} = null;
    public DateTime FechaNacimiento { get; set;}
    public double Matricula{ get; set;}
    public string CarreraID { get; set;} 

   

}