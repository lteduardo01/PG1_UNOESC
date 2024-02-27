using System;
    string message1 = null;
        string message2 = null;
// inicializar a string vazia
            string message3 = System.String.Empty;//"";
// Declarar uma string com valor implicito
                var message4 = "Uma mensagem aleatoria";
Console.WriteLine(message4);
//concatenate strings
    string concat = (message1 == null ?"" : message1) + " " + message2 + " " + message3 + " " + message4;
        Console.WriteLine("\n" + concat); 
            Console .WriteLine("A temperatura hoje {º} é {1} ºC", DateTime.Now, 23); 
                string nome = string.Empty;
                    Console.WriteLine("Qual é o seu nome");
                        nome = Console.ReadLine();
                            string resultado = $"oi, (nome) ! Pare de jaguarice";
                                Console.WriteLine(resultado);