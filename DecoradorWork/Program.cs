using System;
using System.Collections.Generic;
using DecoradorWork.Models;

namespace DecoradorWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int c;
            double total = 0;
            int pedidos = 0;
            char more = '1';
            var pedido = new List<IHelado>();
            var vasos = new List<IHelado> { new Barquillo(), new Canasta(), new Vaso() };
            while (more != 's')
            {
                Console.Clear();
                c = 0;
                Console.WriteLine("Helados");
                Console.WriteLine("Recipiente");
                foreach (var vaso in vasos)
                {
                    c++;
                    Console.WriteLine($"{c}: {vaso.GetDescripcion()}......{vaso.GetCosto()}");
                }
                var read = int.Parse(Console.ReadKey().KeyChar.ToString());
                switch (read)
                {
                    case 1:
                        pedido.Add(new Barquillo());
                        break;
                    case 2:
                        pedido.Add(new Canasta());
                        break;
                    case 3:
                        pedido.Add(new Vaso());
                        break;
                }
                Console.Clear();
                Console.WriteLine("Cuantos Sabores de nieve?, Max 5 bolas");
                var val = int.Parse(Console.ReadKey().KeyChar.ToString());
                while (val > 5)
                {
                    Console.Clear();
                    Console.WriteLine("Max 5 bolas, otra vez");
                    val = int.Parse(Console.ReadKey().KeyChar.ToString());
                }
                for (int i = 0; i < val; i++)
                {
                    Console.Clear();
                    Console.WriteLine($"Bola {i + 1}");
                    Console.WriteLine($"1. Limon...........$5.0");
                    Console.WriteLine($"2. Fresa...........$5.0");
                    Console.WriteLine($"3. Mango...........$6.0");
                    Console.WriteLine($"4. Chocolate.......$8.0");
                    Console.WriteLine($"5. ChocoChips......$8.0");
                    Console.WriteLine($"6. Vainilla........$7.0");
                    read = int.Parse(Console.ReadKey().KeyChar.ToString());
                    switch (read)
                    {
                        case 1:
                            pedido[pedidos] = new Limon(pedido[pedidos]);
                            break;
                        case 2:
                            pedido[pedidos] = new Fresa(pedido[pedidos]);
                            break;
                        case 3:
                            pedido[pedidos] = new Mango(pedido[pedidos]);
                            break;
                        case 4:
                            pedido[pedidos] = new Chocolate(pedido[pedidos]);
                            break;
                        case 5:
                            pedido[pedidos] = new ChocoChips(pedido[pedidos]);
                            break;
                        case 6:
                            pedido[pedidos] = new Vainilla(pedido[pedidos]);
                            break;
                    }

                }
                Console.Clear();
                Console.WriteLine("Ingredientes Extras? [s][n]");
                var extra = Console.ReadKey().KeyChar;
                if (extra is 's')
                {
                    Console.Clear();
                    Console.WriteLine("Cuantos Ingredientes extras?,3 Max");
                    val = int.Parse(Console.ReadKey().KeyChar.ToString());
                    while (val > 3)
                    {
                        Console.Clear();
                        Console.WriteLine("Max 3, otra vez");
                        val = int.Parse(Console.ReadKey().KeyChar.ToString());
                    }
                    for (int i = 0; i < val; i++)
                    {
                        Console.Clear();
                        Console.WriteLine($"Ingrediente Extra {i + 1}");
                        Console.WriteLine($"1. Chocolate Liquido...... $0.0");
                        Console.WriteLine($"2. ChocoKrispis............$0.50");
                        Console.WriteLine($"3. Lunetas.................$0.70");
                        Console.WriteLine($"4. ChispasColores..........$0.20");
                        Console.WriteLine($"5. Fresas..................$7.0");
                        Console.WriteLine($"6. Platano.................$5.0");
                        read = int.Parse(Console.ReadKey().KeyChar.ToString());
                        switch (read)
                        {
                            case 1:
                                pedido[pedidos] = new ChocolateLiquido(pedido[pedidos]);
                                break;
                            case 2:
                                pedido[pedidos] = new ChocoKrispis(pedido[pedidos]);
                                break;
                            case 3:
                                pedido[pedidos] = new Lunetas(pedido[pedidos]);
                                break;
                            case 4:
                                pedido[pedidos] = new ChispasColores(pedido[pedidos]);
                                break;
                            case 5:
                                pedido[pedidos] = new Fresas(pedido[pedidos]);
                                break;
                            case 6:
                                pedido[pedidos] = new Platano(pedido[pedidos]);
                                break;
                        }
                    }
                }
                Console.Clear();
                Console.WriteLine("Desea Finalizar su compra? [s][n]");
                more = Console.ReadKey().KeyChar;
                if (more != 's') pedidos++;
            }
            Console.Clear();
            Console.WriteLine("Su Pedido");
            foreach (var ped in pedido)
            {
                total += ped.GetCosto();
                Console.WriteLine($"{ped.GetDescripcion()}...............${ped.GetCosto()}");
            }
            Console.WriteLine($"Total ${total}");
        }
    }
}
