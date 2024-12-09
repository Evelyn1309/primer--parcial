// crear dos clases para dos figuras geométricas que encapsule sus tipos de datos primitivos y proporcione métodos para calcular el área y el perímetro. Se recomienda revisar la carpeta de recursos.

// Clase para el círculo
    public class Circulo
    {
        // Esto esta privado para el radio 
        private double radio;

        // Constructor para inicializar el radio del círculo
        public Circulo(double radio)
        {
            this.radio = radio;
        }

        //  calculo del área del círculo
        public double CalcularArea()
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        //  calcula el perímetro 
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }
    }

    // Clase para un pentágono 
        public class Pentagono
    {
        // atributos privados  
        private double lado;
        private double apotema;

        // Constructor  del pentágono
        public Pentagono(double lado, double apotema)
        {
            this.lado = lado;
            this.apotema = apotema;
        }

        // calcula el área del pentágono
        public double CalcularArea()
        {
            return (5 * lado * apotema) / 2;
        }

        // calcula el perímetro del pentágono
        public double CalcularPerimetro()
        {
            return 5 * lado;
        }
    }

    // Clase  para probar las figuras 
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un  Circulo 
            Circulo Circulo = new Circulo(10);
            Console.WriteLine("Círculo:");
            Console.WriteLine(" ");
            Console.WriteLine("Su Área es: " + Circulo.CalcularArea());
            Console.WriteLine(" ");
            Console.WriteLine("Su Perímetro es: " + Circulo.CalcularPerimetro());
            Console.WriteLine(" ");
            Console.WriteLine($"Su perímetro es {Circulo.CalcularPerimetro()} y su área es {Circulo.CalcularArea()}");

            // Crear un  Pentagono 
            Pentagono Pentagono = new Pentagono(6, 7.5);
            Console.WriteLine("\nPentágono:");
            Console.WriteLine(" ");
            Console.WriteLine("Su Área es: " + Pentagono.CalcularArea());
            Console.WriteLine(" ");
            Console.WriteLine("Su Perímetro es: " + Pentagono.CalcularPerimetro());
            Console.WriteLine(" ");
            Console.WriteLine($"Su perímetro es {Pentagono.CalcularPerimetro()} y su área es {Pentagono.CalcularArea()}");
        }
        }
    


