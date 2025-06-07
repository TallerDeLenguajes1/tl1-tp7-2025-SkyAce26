namespace EspacioCalculadora
{
    public class Calculadora
    {
        private double dato;
        public Calculadora(double dato = 0)
        {
            this.dato = dato;
        }
        public void Sumar(double termino)
        {
            dato += termino;
        }
        public void Restar(double termino)
        {
            dato -= termino;
        }
        public void Multiplicar(double termino)
        {
            dato *= termino;
        }
        public void Dividir(double termino)
        {
            if (termino != 0)
            {
                dato /= termino;
            }
            else
            {
                Console.WriteLine("No se puede dividir por cero.");
            }
        }
        public void Limpiar()
        {
            dato = 0;
        }
        public double GetResultado()
        {
            return dato;
        }        
    }

}
