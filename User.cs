using System;

namespace TryCatch
{
    public class User
    {
        public string app = "Whatsapp";
        public bool Confirmar {get;set;}
        public void Autorizar(){

            Console.WriteLine($"O {app} pode acessar sua camera? true = sim | false = não");

            try{

                Confirmar = bool.Parse(Console.ReadLine ());
            }catch(Exception){
                
                Console.WriteLine("Tente novamente");
            }

        }
    }
}