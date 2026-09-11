using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana3
{
    class Juego
    {
        public void Start()
        {
            while (true)
            {
                Console.Clear();

                //El juego tiene una cantidad fija de enemigos instanciados
                int cantidad_enemigos = 3;
                float V_e = 70;
                float D_e = 20;
                List<Enemy> enemigos = new List<Enemy>();

                for (int i = 0; i < (cantidad_enemigos); i++)
                {
                    Enemy enemigo = new Enemy(V_e, D_e);
                    enemigos.Add(enemigo);
                }

                //El jugador debe poder asignar los datos que prefiera siempre y cuando la vida y el daño no superen 100

                float V_j;
                float D_j;

                Console.WriteLine("Asigne vida:");
                V_j = int.Parse(Console.ReadLine());
                if (V_j > 100)
                {
                    Console.WriteLine("Por favor, ingrese un número menor a 100");
                    V_j = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Asigne daño:");
                D_j = int.Parse(Console.ReadLine());
                if (D_j > 100)
                {
                    Console.WriteLine("Por favor, ingrese un número menor a 100");
                    D_j = int.Parse(Console.ReadLine());
                }

                Player jugador = new Player(V_j, D_j);

                //El juego es por turnos, cada turno el jugador puede atacar un enemigo y luego 1 enemigo puede atacar al jugador en orden 
                while (V_j >= 0 && enemigos.Count > 0)
                {
                    for (int i = 0; i < enemigos.Count; i++)
                    {
                        if (enemigos[i].EstadoEnemigo())
                        {
                            Console.WriteLine("Turno del jugador, desea atacar? [y/n]");

                            switch (Console.ReadLine())
                            {
                                case "y":
                                case "Y":
                                    enemigos[i].RecibirDaño(jugador.AtaqueDMG());
                                    Console.WriteLine("El jugador ha atacado");
                                    break;

                                case "n":
                                case "N":
                                    Console.WriteLine("El jugador no ha atacado.");
                                    break;

                                default: Console.WriteLine("Valor inválido"); break;
                            }

                            //Si el enemigo está muerto, el jugador ya no debe poder atacarlo
                            if (!enemigos[i].EstadoEnemigo())
                            {
                                Console.WriteLine("Enemigo derrotado");
                                enemigos.RemoveAt(i);
                                i--;
                                continue;
                            }

                            Console.WriteLine("Turno del enemigo");
                            jugador.RecibirDano(enemigos[i].CausarDaño());
                            Console.WriteLine("El enemigo ha atacado");
                        }

                        //Si el jugador se queda sin vida, debe mostrar un mensaje indicando derrota
                        if (V_j >= 0)
                        {
                            Console.WriteLine("El jugador ha sido derrotado");
                            break;
                        }
                    }
                    
                    //Si se acaban los enemigos, debe mostrar un mensaje indicando victoria 
                    if (enemigos.Count == 0)
                    {
                        Console.WriteLine("¡Victoria!");
                    }
                }
            }
        }
    }
}