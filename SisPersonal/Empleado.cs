namespace SisPersonal;
//using System.Dynamic;
enum  Cargo : int
{
    
    Administrativo = 1,
    Auxiliar = 2,
    Ingeniero = 3,
    Especialista = 4,
    Investigador=5,

}
public class Empleado
{
    
    private string nombre;
    private  string apellido;
    private DateTime Fecha_de_nacimiento ;
    private char estadocivil;
    private DateTime Fecha_de_ingreso_empresa;
    private  double SueldoBasico;

    private  Cargo cargo;
    public string Nombre1 { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public DateTime Fecha_de_nacimiento1 { get => Fecha_de_nacimiento; set => Fecha_de_nacimiento = value; }
    public char EstadoCivil { get => estadocivil; set => estadocivil = value; }
    public DateTime Fecha_de_ingreso_empresa1 { get => Fecha_de_ingreso_empresa; set => Fecha_de_ingreso_empresa = value; }
    public double SueldoBasico1 { get => SueldoBasico; set => SueldoBasico = value; }
    internal Cargo Cargo { get => cargo; set => cargo = value; }


    public int antiguedad
    {
        get => DateTime.Today.Year - Fecha_de_ingreso_empresa.Year ;

    }
    public int edad
    {
        get => DateTime.Today.Year - Fecha_de_nacimiento.Year;
    }
    public int jubilar
    {
        get => 65 - edad;
    }
    public double adicional
    {
     get{
         double adicional;


         if(antiguedad <= 20){
         adicional = (SueldoBasico*0.01)* antiguedad;
            }else{
          adicional = (SueldoBasico*0.25);
         }
         if(cargo == Cargo.Ingeniero || cargo == Cargo.Especialista)
            {
                adicional = adicional* 0.50;
            };
          if(estadocivil == 'c')
            {
                adicional = adicional + 150000;
            };
            return adicional;
       }
    }
public double salarios{
    
     get{
        double salarios;
         salarios = SueldoBasico + adicional;
     return salarios;
     } 
  } 
}