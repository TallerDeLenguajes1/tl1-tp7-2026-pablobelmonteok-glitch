using SisPersonal;
Empleado empleado = new Empleado(); 

empleado.Nombre1 = "Pablo";
empleado.Apellido = "Belmonte";
empleado.Cargo = Cargo.Administrativo;
empleado.EstadoCivil = 'c' ;
empleado.Fecha_de_ingreso_empresa1 = DateTime.Today.AddYears(-30); 
empleado.Fecha_de_nacimiento1 = DateTime.Today.AddYears(-48);
empleado.SueldoBasico1 = 1000000;
Empleado[] empleados = new Empleado[3];

empleados[0] = new Empleado();
empleados[0].Nombre1 = "Pablo";
empleados[0].Apellido = "Belmonte";
empleados[0].Cargo = Cargo.Administrativo;
empleados[0].EstadoCivil = 'c' ;
empleados[0].Fecha_de_ingreso_empresa1 = DateTime.Today.AddYears(-30); 
empleados[0].Fecha_de_nacimiento1 = DateTime.Today.AddYears(-48);
empleados[0].SueldoBasico1 = 1000000;

empleados[1] = new Empleado();
empleados[1].Nombre1 = "Juan";
empleados[1].Apellido = "Landa";
empleados[1].Cargo = Cargo.Auxiliar;
empleados[1].EstadoCivil = 'c' ;
empleados[1].Fecha_de_ingreso_empresa1 = DateTime.Today.AddYears(-20); 
empleados[1].Fecha_de_nacimiento1 = DateTime.Today.AddYears(-48);
empleados[1].SueldoBasico1 = 500000;

empleados[2] = new Empleado();
empleados[2].Nombre1 = "Alberto";
empleados[2].Apellido = "Mendez";
empleados[2].Cargo = Cargo.Ingeniero;
empleados[2].EstadoCivil = 'c' ;
empleados[2].Fecha_de_ingreso_empresa1 = DateTime.Today.AddYears(-30); 
empleados[2].Fecha_de_nacimiento1 = DateTime.Today.AddYears(-55);
empleados[2].SueldoBasico1 = 1000000;
double total=0;
for (int i = 0; i < 3; i++)
{
    total = total + empleados[i].salarios;
}
int max = 100,jubiladoprox=0;
for (int i = 0; i < 3; i++)
{
    if (empleados[i].jubilar < max)
    {
        max = empleados[i].jubilar;
        jubiladoprox = i;
    }
}

Console.WriteLine("Empleado proximo/a a jubilarse:" +total);
Console.WriteLine("Nombre:"+empleados[jubiladoprox].Nombre1);
Console.WriteLine("Apellido"+empleados[jubiladoprox].Apellido);
Console.WriteLine("Cargo:"+empleados[jubiladoprox].Cargo);
Console.WriteLine("Estado civil:"+empleados[jubiladoprox].EstadoCivil);
Console.WriteLine("Fecha de ingreso:"+empleados[jubiladoprox].Fecha_de_ingreso_empresa1);
Console.WriteLine("Fecha de nacimiento:"+empleados[jubiladoprox].Fecha_de_nacimiento1);
Console.WriteLine("Antiguedad:"+empleados[jubiladoprox].antiguedad);
Console.WriteLine("Sueldo basico:"+empleados[jubiladoprox].SueldoBasico1);
Console.WriteLine("Edad:"+empleados[jubiladoprox].edad);
Console.WriteLine("Tiempo a jubilar:"+empleados[jubiladoprox].jubilar);


Console.WriteLine("Total en salarios:" +total);
