

namespace Ejercicio_Interfaces
{
    internal class Switch : IEnrutador
    {
        public bool EsCapa2 { get; set; }
        public string Nombre { get; set; }
        public string Modelo { get; set; }
        
        public Switch(bool EsCapa2, string Nombre, string Modelo)
        {
            this.EsCapa2 = EsCapa2;
            this.Nombre = Nombre;
            this.Modelo = Modelo;
        }


        public void Imprimir()
        {
            Console.WriteLine($"Es capa 2: {(EsCapa2 ? "Si" : "No")}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Modelo: {Modelo}");    
        }
    }
}
