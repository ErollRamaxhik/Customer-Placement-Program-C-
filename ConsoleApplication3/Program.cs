using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static Random rd = new Random(DateTime.Now.Millisecond);

        public static void rmize(int musteri_sayisi, Bilgiler bilgi)
        {


            int x = 0, y = 0;

            string[] ad = { "Zuhal", "Meral", "Omer", "Erdal", "Bashir", "Berk", "Eymen",
                               "Recep", "Sinem", "Cem", "Ali", "Baki", "Selim", "Salem", "Rufat", 
                               "Haris", "Levent", "Sezgin", "Yusuf", "Olcay" };
            string[] soyad = { "Ivedik", "Ramacik", "Kavlak", "Baymaz", "Salaj", "Yazici", 
                               "Topal", "Agovic", "Panduklu", "Muric", "Kilic", "Kalac", 
                               "Dacic", "Pala", "Rugova", "Pristina", "Petito", "Korkmaz", "Yildiz", "Karacaoglu" };

            x = rd.Next(0, 19);
            y = rd.Next(0, 19);
           

            bilgi.ad = ad[x];
            bilgi.soyad = soyad[y];


        }



        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int musteri_sayisi;
            do
            {
                Console.WriteLine("Gelen Musteri Sayisini Giriniz");
                musteri_sayisi = Convert.ToInt32(Console.ReadLine());

            } while (musteri_sayisi < 0 || musteri_sayisi > 90);

            Bilgiler[] bilgi = new Bilgiler[musteri_sayisi];



            Bilgiler[,] besedort = new Bilgiler[5, 4];
            Bilgiler[,] ikiyeon = new Bilgiler[2, 10];
            Bilgiler[,] ucesekiz = new Bilgiler[3, 8];

            for (int i = 0; i < musteri_sayisi; i++)
            {

                bilgi[i] = new Bilgiler();

                rmize(musteri_sayisi, bilgi[i]);

            }

            float bb, ll;
            int besedortsayac, ikiyeonsayac, ucesekizsayac;

            bb = musteri_sayisi * 0.3f;
            double b = Math.Ceiling(bb);
            ll = musteri_sayisi * 0.3f;
            double l = Math.Ceiling(ll);

            besedortsayac = (int)b;
            ikiyeonsayac = (int)l;

            ucesekizsayac = musteri_sayisi - (besedortsayac + ikiyeonsayac);
            int test = 0;
            int sayac = 0;
            int satir = besedort.GetLength(0);
            int sutun = besedort.GetLength(1);

            for (int i = 0; i < sutun; i++)
            {
                for (int j = 0; j < satir; j++)
                {
                    if (sayac == besedortsayac)
                        continue;

                    besedort[j, i] = bilgi[test];
                    test = test + 1;
                    sayac = sayac + 1;



                }
            }
            int musteri_control = musteri_sayisi;
            int yuzde_sayac = 0;
            float yuzde;
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Musteri Sayisi :" + musteri_sayisi);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("5 x 4 Masa Musterileri :");
            Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Green;
            
            if (musteri_control < 1)
                Console.WriteLine("Musteri Mevcut Degil !!!");
            else
            {
                for (int i = 0; i < satir; i++)
                {
                    if (besedort[i, 0] != null)
                    {
                        Console.WriteLine("");
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine(i + 1 + ".Masa :");
                        Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Green;
                    }


                    for (int j = 0; j < sutun; j++)
                    {
                        yuzde_sayac++;
                        if (besedort[i, j] == null)
                        {
                            yuzde_sayac--;
                            if (j + 1 == sutun && besedort[i,0]!=null)
                            {
                                yuzde = (float)(yuzde_sayac / (float)sutun) * 100;
                                Console.BackgroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Doluluk Yuzdesi :" + yuzde + "%");
                                Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Green;
                                yuzde_sayac = 0;
                            }
                            continue;
                        }
                        Console.WriteLine(j + 1 + "." + besedort[i, j].ad + " " + besedort[i, j].soyad);
                        musteri_control = musteri_control - 1;

                        if (j + 1 == sutun && besedort[i, 0] != null)
                        {
                            yuzde = (float)(yuzde_sayac / (float)sutun) * 100;
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Doluluk Yuzdesi :" + yuzde + "%");                            
                            Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Green;
                            yuzde_sayac = 0;
                        }


                    }

                }
            }
            if (musteri_control < 1)
            {
                Console.WriteLine("");
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("2 x 10 Masa Musterileri :");
                Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Musteri Mevcut Degil !!!");
            }
            else
            {
                int sayac2 = 0;
                satir = ikiyeon.GetLength(0);
                sutun = ikiyeon.GetLength(1);
                for (int i = 0; i < sutun; i++)
                {
                    for (int j = 0; j < satir; j++)
                    {

                        if (sayac2 == ikiyeonsayac)
                            continue;

                        ikiyeon[j, i] = bilgi[test];
                        test = test + 1;
                        sayac2 = sayac2 + 1;




                    }
                }
                Console.WriteLine("");
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("2 x 10 Masa Musterileri :");
                Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Green;
                for (int i = 0; i < satir; i++)
                {
                    if (ikiyeon[i, 0] != null)
                    {
                        Console.WriteLine("");
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine(i + 1 + ".Masa :");
                        Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Green;
                    }


                    for (int j = 0; j < sutun; j++)
                    {
                        yuzde_sayac++;
                        if (ikiyeon[i, j] == null)
                        {
                            
                            
                                yuzde_sayac--;
                                if (j + 1 == sutun && ikiyeon[i, 0] != null)
                                {
                                    yuzde = (float)(yuzde_sayac / (float)sutun) * 100;
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("Doluluk Yuzdesi :" + yuzde + "%");                                    
                                    Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Green;
                                    yuzde_sayac = 0;
                                
                            }
                            continue;
                        }


                        Console.WriteLine(j + 1 + "." + ikiyeon[i, j].ad + " " + ikiyeon[i, j].soyad);
                        musteri_control = musteri_control - 1;
                        if (j + 1 == sutun && ikiyeon[i, 0] != null)
                        {
                            yuzde = (float)(yuzde_sayac / (float)sutun) * 100;
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Doluluk Yuzdesi :" + yuzde+"%");
                            Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Green;
                            yuzde_sayac = 0;
                        }
                    }

                }
            }

            if (musteri_control < 1)
            {
                Console.WriteLine("");
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("3 x 8 Masa Musterileri :");
                Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Musteri Mevcut Degil !!!");
            }
            else
            {
                int sayac3 = 0;
            satir = ucesekiz.GetLength(0);
            sutun = ucesekiz.GetLength(1);
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (sayac3 == ucesekizsayac)
                        continue;

                    ucesekiz[j, i] = bilgi[test];
                    test = test + 1;
                    sayac3 = sayac3 + 1;
                }
            }
            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("3 x 8 Masa Musterileri :");
                Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Green;
                for (int k = 0; k < satir; k++)
                {
                    if (ucesekiz[k, 0] != null)
                    {
                        Console.WriteLine("");
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine(k + 1 + ".Masa");
                        Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Green;
                    }
                        

                    for (int j = 0; j < sutun; j++)
                    {
                        yuzde_sayac++;
                        if (ucesekiz[k,j] == null)
                        {
                            yuzde_sayac--;
                            if (j + 1 == sutun && ucesekiz[k, 0] != null)
                            {
                                yuzde = (float)(yuzde_sayac / (float)sutun) * 100;
                                Console.BackgroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Doluluk Yuzdesi :" + yuzde + "%");
                                Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Green;
                                yuzde_sayac = 0;
                            }
                            continue;
                        }
                        Console.WriteLine(j+1+"."+ucesekiz[k,j].ad + " " + ucesekiz[k,j].soyad);
                        musteri_control = musteri_control - 1;
                        if (j + 1 == sutun && ucesekiz[k, 0] != null)
                        {
                            yuzde = (float)(yuzde_sayac / (float)sutun) * 100;
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Doluluk Yuzdesi :" + yuzde + "%");
                            Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Green;
                            yuzde_sayac = 0;
                        }
                    }

                }
            }
            
                int test2 = test;
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\nAyakta kalanlar :");
                Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Green;
                if (musteri_sayisi - test == 0)
                    Console.WriteLine("Yok");
                for (int i = 0; i < (musteri_sayisi - test);i++)
                {
                    
                    Console.WriteLine(i+1+"."+bilgi[test2].ad + " " + bilgi[test2].soyad);
                    test2 = test2 + 1;
                    
                }

                double index = (double)(musteri_sayisi - test) / 4;
               double index2 = Math.Ceiling(index);




               Console.WriteLine("");
                Console.WriteLine(index2+" (4x4) Masa Adeti Gerekmektedir.");
           
                    
    

                Console.ReadLine();

            




        }
    }
}
