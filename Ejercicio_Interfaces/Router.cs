

namespace Ejercicio_Interfaces
{
    internal class Router : IEnrutador
    {

        public string IP { get; set; }
        public string Nombre { get; set; }
        public int PuertoLocal { get; set; }
        public int PuertoRemoto { get; set; }
        public bool IPEstatica { get; set; }

        public Router(string IP, int PuertoLocal, int PuertoRemoto, bool IPEstatica)
        {
            this.IP = IP;
            this.PuertoLocal = PuertoLocal;
            this.PuertoRemoto = PuertoRemoto;
            this.IPEstatica = IPEstatica;
        }

        public void Imprimir()
        {
            Console.WriteLine($"Direccion IP: {IP}");
            Console.WriteLine($"Puerto Local: {PuertoLocal}");
            Console.WriteLine($"Puerto Remoto: {PuertoRemoto}");
            Console.WriteLine($"La IP es testaica: {(IPEstatica ? "Si" : "No")}");
        }
    }
}
