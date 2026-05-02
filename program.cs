using System ;
 namespace Notas
 {
    public class Program 
    {
        public static void Main() 
        {
            double Dolar = saldo * 4.96 ; 
            double Euro = saldo * 5.81; 
            Console.WriteLine (@"
   ____  ______  __  _                 _    
 |  _ \/ ___\ \/ / | |__   __ _ _ __ | | __
 | | | \___ \\  /  | '_ \ / _` | '_ \| |/ /
 | |_| |___) /  \  | |_) | (_| | | | |   < 
 |____/|____/_/\_\ |_.__/ \__,_|_| |_|_|\_\
                                           
                                                              
            ") ;
            Console.WriteLine ("Digite sua senha: ") ;
            dynamic senha= Convert.ToInt32(Console.ReadLine()) ; 
            Console.WriteLine ("Digite sua senha novamente: ") ;
            dynamic senha2= Convert.ToInt32(Console.ReadLine()) ; 
            if (senha2 != senha)
            {
                Console.WriteLine ("A senha está errada, Programa finalizado.") ;
            }
            else
            {
                Console.WriteLine ("Bem Vindo!") ; 
            }


            Console.WriteLine ("==========ESCOLHA SUA OPÇÃO==============") ; 
            Console.WriteLine ("1- Ver saldo ") ; 
            Console.WriteLine ("2- Configurações") ; 
            Console.WriteLine ("3- nenhuma ") ; 
            int choice = Convert.ToInt32 (Console.ReadLine()) ; 
            switch (choice)
            {
                case 1: 
                 Console.WriteLine ("Digite seu saldo: ") ; 
                 double saldo= Convert.ToDouble (Console.ReadLine) ; 
                 Console.WriteLine ("\n Seu saldo atual é de: ") ; 
                 Console.WriteLine ( saldo ) ; 
                 Console.WriteLine ("Deseja ver a sua conversão? S/N") ;
                 string choice2 = Console.ReadLine() ; 
                  if (choice2 == S)
                    {
                        Console.WriteLine ("==========CONVERSÕES============") ; 
                        Console.WriteLine ("1- Real -> Euro") ; 
                        Console.WriteLine ("2- Real -> Dolar") ; 
                        int conversion = Convert.ToInt32 (Console.ReadLine()) ;
                        if (conversion == 1)
                        {
                            Console.WriteLine ($"Seu saldo em Euros é: {Euro}") ; 
                        }
                        else
                        {
                            Console.WriteLine ($"Seu saldo em $ é: {Dolar}") ; 
                        }
                    }
                 break ; 

                 case 2: 
                   Console.WriteLine ("Configurações principais") ;
                   Console.WriteLine ("Voltar pra primeira página? s/n") ;
                   string choice3= Console.ReadLine() ; 
                   if (choice3 == s )
                    {
                        Console.WriteLine ("Progama finalizado.") ; 
                    }
                   break ; 

                   case 3: 
                     Console.WriteLine ("Programa finalizado") ;
                     break ; 

            }
                
            


        
    }
 }
 }