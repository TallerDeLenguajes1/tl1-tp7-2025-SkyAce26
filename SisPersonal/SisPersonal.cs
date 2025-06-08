namespace EspacioEmpleados
{
    public enum Cargos
    {
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }

    public class Empleado
    {
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private char estadoCivil;
        private DateTime ingresoEmpresa;
        private double sueldoBasico;
        private Cargos cargo;

    public Empleado(string nombre, string apellido, DateTime nacimiento, char estadoCivil, DateTime ingreso, string sueldo, Cargos cargo)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.fechaNacimiento = nacimiento;
        this.estadoCivil = estadoCivil;
        this.ingresoEmpresa = ingreso;
        this.sueldoBasico = double.Parse(sueldo.Replace(".", ""));
        this.cargo = cargo;
    }

    public int GetEdad()
    {
        return System.DateTime.Now.Year - fechaNacimiento.Year ;
    }

    public int GetAntiguedad()
    {
        return System.DateTime.Now.Year - ingresoEmpresa.Year;
    }

    public int GetAniosJubilarse()
    {
        return 65 - GetEdad();
    }

    public double CalcularSalario()
    {
        double adicional;
        int antiguedad = GetAntiguedad();

        if (antiguedad <= 20)
        {
            adicional = sueldoBasico * 0.01 * antiguedad;
        }
        else
        {
            adicional = sueldoBasico * 0.25;
        }

        if (cargo == Cargos.Ingeniero || cargo == Cargos.Especialista)
        {
            adicional *= 1.5;
        }

        if (estadoCivil == 'c' || estadoCivil == 'C')
        {
            adicional += 150000;
        }

        return sueldoBasico + adicional;
    }

    public string Datos()
    {
        return $"Nombre: {nombre} {apellido}\nEdad: {GetEdad()}\nAntigüedad: {GetAntiguedad()} años\nCargo: {cargo}\nSueldo Final: {CalcularSalario():N2}\nAños para jubilarse: {GetAniosJubilarse()}";
    }
}
}