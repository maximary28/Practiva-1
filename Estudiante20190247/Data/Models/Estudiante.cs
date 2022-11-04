using System.ComponentModel.DataAnnotations;
namespace Estudiante.Data.Models;
public class Estudiante
{
   [Key]
    public int estudianteID { get; set;}
    public string Nombres { get; set;} = null;
    public string Apellidos { get; set;} = null;
    public double FechaNacimiento { get; set;}
    public double Matricula{ get; set;}
    public string Carrera { get; set;} = null;

   { public static Estudiante Crear (string Nombres, string Apellidos,double FechaNacimiento, double Matricula, string Carrera)
         return new Estudiante(){
           estudianteID = 0,
           Nombres = nombres,
           Apellidos = apellidos,
           FechaNacimiento = fechanacimiento,
           Matricula = matricula,
           Carrera = carrera
         };
     }
    public void Update (string Nombres, string Apellidos,double FechaNacimiento, double Matricula, string Carrera)
    {
         Nombres = nombres;
         Apellidos = apellidos;
         FechaNacimiento = fechanacimiento;
         Matricula = matricula;
         Carrera = carrera;
    }


   


}