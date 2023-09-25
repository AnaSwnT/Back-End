namespace Sesi.Model{
    
    public class pantera{
        public decimal tamanho { get; set; }    

        public int peso { get; set; }

        public string cor { get; set; }

        public string especie { get; set; }

        public string alimentaçao { get; set; }

        public void Correr(){
            Console.WriteLine("A Pantera está correndo");
        }

        public void Cacar(){
            Console.WriteLine("A Pantera está caçando");
        }

        public void Reproduzir(){
            Console.WriteLine("A Pantera está reproduzindo");
        }
    }
}