using System;

namespace MyProgram
{
    class Program
    {
        static void Main()
        {

            string[] biyomlar = { "Yağmur Ormanında", "Çölde", "Bataklıkta", "Issız Adada" };

            string[] orman_yiyecekler = { "avladığın hayvanların eti", "küçük böcekler", "yabani meyveler", "yenebilir otlar" };
            string[] çöl_yiyecekler = { "avladığın hayvanların eti", "zeytin", "kaktüs meyvesi", "hurma" };
            string[] bataklık_yiyecekler = { "avladığın hayvanların eti", "küçük böcekler", "yabani meyveler", "otlar" };
            string[] ada_yiyecekler = { "avladığın hayvanların eti", "hindistan cevizi", "yabani meyveler", "mango", };

            string[] orman_nedeni = { "jaguar", "tarantula", "candiru", "zehirli ok kurbağası", "sivri sinek", "açlık", "susuzluk" };
            string[] çöl_nedeni = { "akrep", "boynuzlu engerek", "çita", "sırtlan", "hipotermi", "açlık", "susuzluk" };
            string[] bataklık_nedeni = { "timsah", "anakonda", "kırkayak", "yabani domuz", "parazit", "açlık", "susuzluk" };
            string[] ada_nedeni = { "yılan", "akrep", "yabani domuz", "puma", "kan kaybı", "açlık", "susuzluk" };

            string[] orman_barınaklar = { "ağaç evde", "kulübede", "mağarada", "barakada" };
            string[] çöl_barınaklar = { "vahada", "hamakta", "mağarada", "barakada" };
            string[] bataklık_barınaklar = { "ağaç üstünde", "kulübede", "oyukta", "barakada" };
            string[] ada_barınaklar = { "ağaç evde", "kulübede", "mağarada", "barakada" };

            string[] faith = { "hayatta", "kurtarıldı", "hayatta değil" };

            string[] gelişmeler = { "ilkel balta yaptın", "barınak buldun", "hazine buldun" };

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Random rastgelebiyom = new Random();
            int biyom = rastgelebiyom.Next(0, biyomlar.Length);
            //(biyomlar[biyom]);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Random rastgeleormanyiyecek = new Random();
            int food1 = rastgeleormanyiyecek.Next(0, orman_yiyecekler.Length);
            //(orman_yiyecekler[food1]);

            Random rastgeleçölyiyecek = new Random();
            int food2 = rastgeleçölyiyecek.Next(0, çöl_yiyecekler.Length);
            //(çöl_yiyecekler[food2]);

            Random rastgelebataklıkyiyecek = new Random();
            int food3 = rastgelebataklıkyiyecek.Next(0, bataklık_yiyecekler.Length);
            //(bataklık_yiyecekler[food3]);

            Random rastgeleadayiyecek = new Random();
            int food4 = rastgeleadayiyecek.Next(0, ada_yiyecekler.Length);
            //(ada_yiyecekler[food4]);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Random rastgeleormaneden = new Random();
            int neden1 = rastgeleormaneden.Next(0, orman_nedeni.Length);
            //(orman_nedeni[neden1]);

            Random rastgeleçölneden = new Random();
            int neden2 = rastgeleçölneden.Next(0, çöl_nedeni.Length);
            //(çöl_nedeni[neden2]);

            Random rastgelebataklıkneden = new Random();
            int neden3 = rastgelebataklıkneden.Next(0, bataklık_nedeni.Length);
            //(bataklık_nedeni[neden3]);

            Random rastgeleadaneden = new Random();
            int neden4 = rastgeleadaneden.Next(0, ada_nedeni.Length);
            //(ada_nedeni[neden4]);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Random rastgeleormanbarınak = new Random();
            int barınak1 = rastgeleormanbarınak.Next(0, orman_barınaklar.Length);
            //(orman_barınaklar[barınak1]);

            Random rastgeleçölbarınak = new Random();
            int barınak2 = rastgeleçölbarınak.Next(0, çöl_barınaklar.Length);
            //(çöl_barınaklar[barınak2]);

            Random rastgelebataklıkbarınak = new Random();
            int barınak3 = rastgelebataklıkbarınak.Next(0, bataklık_barınaklar.Length);
            //(bataklık_barınaklar[barınak3]);

            Random rastgeleadabarınak = new Random();
            int barınak4 = rastgeleadabarınak.Next(0, ada_barınaklar.Length);
            //(ada_barınaklar[barınak4]);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Random rastgelekader = new Random();
            int kader = rastgelekader.Next(0, faith.Length);
            //(faith[kader]);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Random rastgele = new Random();
            int liveday = rastgele.Next(0, 365);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            //Güncellemede bi ara getirirsin!
            /* Random rastgelegelişme = new Random();
             int gelişmedays = rastgelegelişme.Next(0, 365);

             Random rastgelegelişmek = new Random();
             int gelişme = rastgelegelişmek.Next(0, gelişmeler.Length);*/


            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            if (faith[kader] == "kurtarıldı")
            {
                if (biyomlar[biyom] == "Yağmur Ormanında")
                {
                    Console.WriteLine("Özel Uçağın ile seyahatin sırasında uçak brezilya açıklarında kaza yapıyor\n" +
                        "kazadan sonra kendine geldiğinde sadece kendinin sağ çıktığını farkediyorsun\n" +
                        "Etrafına bakındığında {0} mahsur kaldığını anlıyorsun ve {1}ki maceran başlamış oluyor \n" +
                        "{2} ki ana yemeğin {3} \n" +
                        "{4} yaşıyorsun \n",
                     biyomlar[biyom], biyomlar[biyom], biyomlar[biyom], orman_yiyecekler[food1], orman_barınaklar[barınak1]);
                    Console.WriteLine("{0} gündür hayattasın şans eseri gezintiye çıktığında araştırma ekiplerinin kampını buldun ve kurtuldun!", liveday);
                }

                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                if (biyomlar[biyom] == "Çölde")
                {
                    Console.WriteLine("Afrika'da ki tur gezisi sırasında ekibinden ayrı düştün\n" +
                        "üzerinde herhangi bir iletişim aracı olmadığından dolayı tek başına kaldığını farkediyorsun\n" +
                        "{0} Mahsur kalıyorsun ve {1}ki maceran başlamış oluyor\n" +
                        "{2} ki ana yemeğin {3}\n" +
                        "{4} yaşıyorsun",
                     biyomlar[biyom], biyomlar[biyom], biyomlar[biyom], çöl_yiyecekler[food2], çöl_barınaklar[barınak2]);
                    Console.WriteLine("{0} gündür hayattasın şans eseri bedevilerle karşılaştın ve kurtuldun!", liveday);
                }

                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                if (biyomlar[biyom] == "Bataklıkta")
                {
                    Console.WriteLine("Balık tutmaya gittiğin {0} kayığının su alıp batıyor\n" +
                        "boğulmaktan kıl payı kurtuluyorsun ama iletişim araçların su yüzünden bozuluyor\n" +
                        "{1} mahsur kalıyorsun ve {2}ki maceran böylece başlamış oluyor\n" +
                        "{3} ki ana yemeğin {4} \n{5} yaşıyorsun \n",
                    biyomlar[biyom], biyomlar[biyom], biyomlar[biyom], biyomlar[biyom], bataklık_yiyecekler[food3], bataklık_barınaklar[barınak3]);
                    Console.WriteLine("{0} gündür hayattasın ve şans eseri bataklıktaki nehirden geçmekte olan yerlilere ait tekneye yetişip kurtuldun!", liveday);
                }

                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                if (biyomlar[biyom] == "Issız Adada")
                {
                    Console.WriteLine("Deniz biyoloğu olarak araştırma için okyanusa açıldıktan sonra\n" +
                        "hava kötüleşiyor ve gemin alabora oluyor gözlerini açtığında kendini\n" +
                        "{0} buluyorsun ve böylece ada maceran başlamış oluyor\n" +
                        "{1} ki ana yemeğin {2}\n" +
                        "{3} yaşıyorsun",
                    biyomlar[biyom], biyomlar[biyom], ada_yiyecekler[food4], ada_barınaklar[barınak4]);
                    Console.WriteLine("{0} gündür hayattasın ve şans eseri sahile yazdığın imdat çağrısını gören keşif uçağı tarafından kurtarıldın!", liveday);
                }

            }
            else if (faith[kader] == "hayatta değil")
            {

                if (biyomlar[biyom] == "Yağmur Ormanında" && orman_nedeni[neden1] == "jaguar")
                {
                    Console.WriteLine("Özel Uçağın ile seyahatin sırasında uçak brezilya açıklarında kaza yapıyor\n" +
                         "kazadan sonra kendine geldiğinde sadece kendinin sağ çıkıtığını farkediyorsun\n" +
                         "Etrafına bakındığında {0} mahsur kaldığını anlıyorsun ve {1}ki maceran başlamış oluyor \n" +
                         "{2} ki ana yemeğin {3} \n" +
                         "{4} yaşıyorsun \n" +
                         "{5} tarafından saldırıya uğradın ve öldün ",
                    biyomlar[biyom], biyomlar[biyom], biyomlar[biyom], orman_yiyecekler[food1], orman_barınaklar[barınak1], orman_nedeni[neden1]);
                    Console.WriteLine("{0} gün hayatta kalabildin!", liveday);

                }

                if (biyomlar[biyom] == "Yağmur Ormanında" && orman_nedeni[neden1] == "tarantula")
                {
                    Console.WriteLine("Özel Uçağın ile seyahatin sırasında uçak brezilya açıklarında kaza yapıyor\n" +
                        "kazadan sonra kendine geldiğinde sadece kendinin sağ çıkıtığını farkediyorsun\n" +
                        "Etrafına bakındığında {0} mahsur kaldığını anlıyorsun ve {1}ki maceran başlamış oluyor \n" +
                        "{2} ki ana yemeğin {3} \n{4} yaşıyorsun \n{5} tarafından sokuldun ve zehirlenerek öldün ",
                    biyomlar[biyom], biyomlar[biyom], biyomlar[biyom], orman_yiyecekler[food1], orman_barınaklar[barınak1], orman_nedeni[neden1]);
                    Console.WriteLine("{0} gün hayatta kalabildin!", liveday);
                }

                if (biyomlar[biyom] == "Yağmur Ormanında" && orman_nedeni[neden1] == "candiru")
                {
                    Console.WriteLine("Özel Uçağın ile seyahatin sırasında uçak brezilya açıklarında kaza yapıyor\n" +
                        "kazadan sonra kendine geldiğinde sadece kendinin sağ çıkıtığını farkediyorsun\n" +
                        "Etrafına bakındığında {0} mahsur kaldığını anlıyorsun ve {1}ki maceran başlamış oluyor \n" +
                        "{2} ki ana yemeğin {3} \n{4} yaşıyorsun \nSuyu kaynatmadan içtiğin için {5} paraziti tarafından organların iflas etti ve öldün",
                    biyomlar[biyom], biyomlar[biyom], biyomlar[biyom], orman_yiyecekler[food1], orman_barınaklar[barınak1], orman_nedeni[neden1]);
                    Console.WriteLine("{0} gün hayatta kalabildin!", liveday);
                }

                if (biyomlar[biyom] == "Yağmur Ormanında" && orman_nedeni[neden1] == "zehirli ok kurbağası")
                {
                    Console.WriteLine("Özel Uçağın ile seyahatin sırasında uçak brezilya açıklarında kaza yapıyor\n" +
                        "kazadan sonra kendine geldiğinde sadece kendinin sağ çıkıtığını farkediyorsun\n" +
                        "Etrafına bakındığında {0} mahsur kaldığını anlıyorsun ve {1}ki maceran başlamış oluyor \n" +
                        "{2} ki ana yemeğin {3} \n{4} yaşıyorsun \nAçlıktan yakaladığın {5}na dokunduğun için zehirlenerek öldün ",
                    biyomlar[biyom], biyomlar[biyom], biyomlar[biyom], orman_yiyecekler[food1], orman_barınaklar[barınak1], orman_nedeni[neden1]);
                    Console.WriteLine("{0} gün hayatta kalabildin!", liveday);
                }

                if (biyomlar[biyom] == "Yağmur Ormanında" && orman_nedeni[neden1] == "sivri sinek")
                {
                    Console.WriteLine("Özel Uçağın ile seyahatin sırasında uçak brezilya açıklarında kaza yapıyor\n" +
                        "kazadan sonra kendine geldiğinde sadece kendinin sağ çıkıtığını farkediyorsun\n" +
                        "Etrafına bakındığında {0} mahsur kaldığını anlıyorsun ve {1}ki maceran başlamış oluyor \n" +
                        "{2} ki ana yemeğin {3} \n{4} yaşıyorsun \n{5} tarafından sokuldun ve sıtma hastalığına yakalanarak öldün ",
                    biyomlar[biyom], biyomlar[biyom], biyomlar[biyom], orman_yiyecekler[food1], orman_barınaklar[barınak1], orman_nedeni[neden1]);
                    Console.WriteLine("{0} gün hayatta kalabildin!", liveday);
                }

                if (biyomlar[biyom] == "Yağmur Ormanında" && orman_nedeni[neden1] == "açlık")
                {
                    Console.WriteLine("Özel Uçağın ile seyahatin sırasında uçak brezilya açıklarında kaza yapıyor\n" +
                        "kazadan sonra kendine geldiğinde sadece kendinin sağ çıkıtığını farkediyorsun\n" +
                        "Etrafına bakındığında {0} mahsur kaldığını anlıyorsun ve {1}ki maceran başlamış oluyor \n" +
                        "{2} ki ana yemeğin {3} \n{4} yaşıyorsun \nuzun zamandır yemek yemediğin için {5}tan öldün ",
                    biyomlar[biyom], biyomlar[biyom], orman_yiyecekler[food1], orman_barınaklar[barınak1], orman_nedeni[neden1]);
                    Console.WriteLine("{0} gün hayatta kalabildin!", liveday);
                }

                if (biyomlar[biyom] == "Yağmur Ormanında" && orman_nedeni[neden1] == "susuzluk")
                {
                    Console.WriteLine("Özel Uçağın ile seyahatin sırasında uçak brezilya açıklarında kaza yapıyor\n" +
                        "kazadan sonra kendine geldiğinde sadece kendinin sağ çıkıtığını farkediyorsun\n" +
                        "Etrafına bakındığında {0} mahsur kaldığını anlıyorsun ve {1}ki maceran başlamış oluyor \n" +
                        "{2} ki ana yemeğin {3} \n{4} yaşıyorsun \nuzun zamandır su tüketmediğin için {5}tan böbreğin iflas etti ve öldün ",
                    biyomlar[biyom], biyomlar[biyom], biyomlar[biyom], orman_yiyecekler[food1], orman_barınaklar[barınak1], orman_nedeni[neden1]);
                    Console.WriteLine("{0} gün hayatta kalabildin!", liveday);
                }

                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                if (biyomlar[biyom] == "Çölde" && çöl_nedeni[neden2] == "akrep")
                {
                    Console.WriteLine("Afrika'da ki tur gezisi sırasında ekibinden ayrı düştün\n" +
                        "üzerinde herhangi bir iletişim aracı olmadığından dolayı tek başına kaldığını farkediyorsun\n" +
                        "{0} Mahsur kalıyorsun ve {1}ki maceran başlamış oluyor\n" +
                        "{2} ki ana yemeğin {3} \n{4} yaşıyorsun \nKestirirken {5} tarafından sokuldun ve zehirlenerek öldün ",
                    biyomlar[biyom], biyomlar[biyom], biyomlar[biyom], çöl_yiyecekler[food2], çöl_barınaklar[barınak2], çöl_nedeni[neden2]);
                    Console.WriteLine("{0} gün hayatta kalabildin!", liveday);
                }

                if (biyomlar[biyom] == "Çölde" && çöl_nedeni[neden2] == "boynuzlu engerek")
                {
                    Console.WriteLine("Afrika'da ki tur gezisi sırasında ekibinden ayrı düştün\n" +
                        "üzerinde herhangi bir iletişim aracı olmadığından dolayı tek başına kaldığını farkediyorsun\n" +
                        "{0} Mahsur kalıyorsun ve {1}ki maceran başlamış oluyor\n" +
                        "{2} ki ana yemeğin {3} \n{4} yaşıyorsun \n{5} dolaşırken kuma gizlenmiş olan {6} yılanını görmeden üstüne bastın ve \n boynuzlu engerek tarafından sokularak acı içinde öldün ",
                    biyomlar[biyom], biyomlar[biyom], biyomlar[biyom], çöl_yiyecekler[food2], çöl_barınaklar[barınak2], biyomlar[biyom], çöl_nedeni[neden2]);
                    Console.WriteLine("{0} gün hayatta kalabildin!", liveday);
                }

                if (biyomlar[biyom] == "Çölde" && çöl_nedeni[neden2] == "çita")
                {
                    Console.WriteLine("Afrika'da ki tur gezisi sırasında ekibinden ayrı düştün\n" +
                        "üzerinde herhangi bir iletişim aracı olmadığından dolayı tek başına kaldığını farkediyorsun\n" +
                        "{0} Mahsur kalıyorsun ve {1}ki maceran başlamış oluyor\n" +
                        "{2} ki ana yemeğin {3} \n{4} yaşıyorsun \nuzun zamandan beri aç olan {5} seni farketti ve sana saldırdırarak seni öldürdü ",
                    biyomlar[biyom], biyomlar[biyom], biyomlar[biyom], çöl_yiyecekler[food2], çöl_barınaklar[barınak2], çöl_nedeni[neden2]);
                    Console.WriteLine("{0} gün hayatta kalabildin!", liveday);
                }

                if (biyomlar[biyom] == "Çölde" && çöl_nedeni[neden2] == "sırtlan")
                {
                    Console.WriteLine("Afrika'da ki tur gezisi sırasında ekibinden ayrı düştün\n" +
                        "üzerinde herhangi bir iletişim aracı olmadığından dolayı tek başına kaldığını farkediyorsun\n" +
                        "{0} Mahsur kalıyorsun ve {1}ki maceran başlamış oluyor\n" +
                        "{2} ki ana yemeğin {3} \n{4} yaşıyorsun \n{5} sürüsü tarafından saldırıya uğradın ve öldün ",
                    biyomlar[biyom], biyomlar[biyom], biyomlar[biyom], çöl_yiyecekler[food2], çöl_barınaklar[barınak2], çöl_nedeni[neden2]);
                    Console.WriteLine("{0} gün hayatta kalabildin!", liveday);
                }

                if (biyomlar[biyom] == "Çölde" && çöl_nedeni[neden2] == "hipotermi")
                {
                    Console.WriteLine("Afrika'da ki tur gezisi sırasında ekibinden ayrı düştün\n" +
                        "üzerinde herhangi bir iletişim aracı olmadığından dolayı tek başına kaldığını farkediyorsun\n" +
                        "{0} Mahsur kalıyorsun ve {1}ki maceran başlamış oluyor\n" +
                        "{2} ki ana yemeğin {3} \n{4} yaşıyorsun \ngece soğuğunda ateş yakıp ısınamadığın için {5} geçirip öldün ",
                    biyomlar[biyom], biyomlar[biyom], biyomlar[biyom], çöl_yiyecekler[food2], çöl_barınaklar[barınak2], çöl_nedeni[neden2]);
                    Console.WriteLine("{0} gün hayatta kalabildin!", liveday);
                }

                if (biyomlar[biyom] == "Çölde" && çöl_nedeni[neden2] == "açlık")
                {
                    Console.WriteLine("Afrika'da ki tur gezisi sırasında ekibinden ayrı düştün\n" +
                        "üzerinde herhangi bir iletişim aracı olmadığından dolayı tek başına kaldığını farkediyorsun\n" +
                        "{0} Mahsur kalıyorsun ve {1}ki maceran başlamış oluyor\n" +
                        "{2} ki ana yemeğin {3} \n{4} yaşıyorsun \nuzun zamandır yemek yemediğin için {5}tan öldün",
                    biyomlar[biyom], biyomlar[biyom], biyomlar[biyom], çöl_yiyecekler[food2], çöl_barınaklar[barınak2], çöl_nedeni[neden2]);
                    Console.WriteLine("{0} gün hayatta kalabildin!", liveday);
                }

                if (biyomlar[biyom] == "Çölde" && çöl_nedeni[neden2] == "susuzluk")
                {
                    Console.WriteLine("Afrika'da ki tur gezisi sırasında ekibinden ayrı düştün\n" +
                        "üzerinde herhangi bir iletişim aracı olmadığından dolayı tek başına kaldığını farkediyorsun\n" +
                        "{0} Mahsur kalıyorsun ve {1}ki maceran başlamış oluyor\n" +
                        "{2} ki ana yemeğin {3} \n{4} yaşıyorsun \nuzun zamandır su tüketmediğin için {5}tan böbreğin iflas etti ve öldün ",
                    biyomlar[biyom], biyomlar[biyom], biyomlar[biyom], çöl_yiyecekler[food2], çöl_barınaklar[barınak2], çöl_nedeni[neden2]);
                    Console.WriteLine("{0} gün hayatta kalabildin!", liveday);
                }

                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                if (biyomlar[biyom] == "Bataklıkta" && bataklık_nedeni[neden3] == "timsah")
                {
                    Console.WriteLine("Balık tutmaya gittiğin {0} kayığının su alıp batıyor\n" +
                        "boğulmaktan kıl payı kurtuluyorsun ama iletişim araçların su yüzünden bozuluyor\n" +
                        "{1} mahsur kalıyorsun ve {2}ki maceran başlamış oluyor\n" +
                        "{3} ki ana yemeğin {4} \n{5} yaşıyorsun \nnehire su almak için geldiğin sırada gizlenmiş olan\n {6} tarafından saldırıya uğradın ve öldün ",
                    biyomlar[biyom], biyomlar[biyom], biyomlar[biyom], biyomlar[biyom], bataklık_yiyecekler[food3], bataklık_barınaklar[barınak3], bataklık_nedeni[neden3]);
                    Console.WriteLine("{0} gün hayatta kalabildin!", liveday);
                }

                if (biyomlar[biyom] == "Bataklıkta" && bataklık_nedeni[neden3] == "anakonda")
                {
                    Console.WriteLine("Balık tutmaya gittiğin {0} kayığının su alıp batıyor\n" +
                        "boğulmaktan kıl payı kurtuluyorsun ama iletişim araçların su yüzünden bozuluyor\n" +
                        "{1} mahsur kalıyorsun ve {2}ki maceran başlamış oluyor\n" +
                        "{3} ki ana yemeğin {4} \n{5} yaşıyorsun \ngezintiye çıktığın sırada {6} tarafından saldırıya uğradın ve öldün ",
                    biyomlar[biyom], biyomlar[biyom], biyomlar[biyom], biyomlar[biyom], bataklık_yiyecekler[food3], bataklık_barınaklar[barınak3], bataklık_nedeni[neden3]);
                    Console.WriteLine("{0} gün hayatta kalabildin!", liveday);
                }

                if (biyomlar[biyom] == "Bataklıkta" && bataklık_nedeni[neden3] == "kırk ayak")
                {
                    Console.WriteLine("Balık tutmaya gittiğin {0} kayığının su alıp batıyor\n" +
                        "boğulmaktan kıl payı kurtuluyorsun ama iletişim araçların su yüzünden bozuluyor\n" +
                        "{1} mahsur kalıyorsun ve {2}ki maceran başlamış oluyor\n" +
                        "{3} ki ana yemeğin {4} \n{5} yaşıyorsun \n{6} uyuduğun sırada {7} tarafından sokuldun ve öldün",
                    biyomlar[biyom], biyomlar[biyom], biyomlar[biyom], biyomlar[biyom], bataklık_yiyecekler[food3], bataklık_barınaklar[barınak3], bataklık_barınaklar[barınak3], bataklık_barınaklar[barınak3], bataklık_nedeni[neden3]);
                    Console.WriteLine("{0} gün hayatta kalabildin!", liveday);
                }

                if (biyomlar[biyom] == "Bataklıkta" && bataklık_nedeni[neden3] == "yabani domuz")
                {
                    Console.WriteLine("Balık tutmaya gittiğin {0} kayığının su alıp batıyor\n" +
                        "boğulmaktan kıl payı kurtuluyorsun ama iletişim araçların su yüzünden bozuluyor\n" +
                        "{1} mahsur kalıyorsun ve {2}ki maceran başlamış oluyor\n" +
                        "{3} ki ana yemeğin {4} \n{5} yaşıyorsun \nyemek ararken {6} sürüsünün avlanma alanına girdiğin için sürünün saldırısına uğradın ve öldürüldün ",
                    biyomlar[biyom], biyomlar[biyom], biyomlar[biyom], biyomlar[biyom], bataklık_yiyecekler[food3], bataklık_barınaklar[barınak3], bataklık_nedeni[neden3]);
                    Console.WriteLine("{0} gün hayatta kalabildin!", liveday);
                }

                if (biyomlar[biyom] == "Bataklıkta" && bataklık_nedeni[neden3] == "parazit")
                {
                    Console.WriteLine("Balık tutmaya gittiğin {0} kayığının su alıp batıyor\n" +
                        "boğulmaktan kıl payı kurtuluyorsun ama iletişim araçların su yüzünden bozuluyor\n" +
                        "{1} mahsur kalıyorsun ve {2}ki maceran başlamış oluyor\n" +
                        "{3} ki ana yemeğin {4} \n{5} yaşıyorsun \nBataklık suyunu kaynatmadan içtiğin için bağırsağında oluşan {6}lerden dolayı öldün ",
                    biyomlar[biyom], biyomlar[biyom], biyomlar[biyom], biyomlar[biyom], bataklık_yiyecekler[food3], bataklık_barınaklar[barınak3], bataklık_nedeni[neden3]);
                    Console.WriteLine("{0} gün hayatta kalabildin!", liveday);
                }

                if (biyomlar[biyom] == "Bataklıkta" && bataklık_nedeni[neden3] == "açlık")
                {
                    Console.WriteLine("Balık tutmaya gittiğin {0} kayığının su alıp batıyor\n" +
                        "boğulmaktan kıl payı kurtuluyorsun ama iletişim araçların su yüzünden bozuluyor\n" +
                        "{1} mahsur kalıyorsun ve {2}ki maceran başlamış oluyor\n" +
                        "{3} ki ana yemeğin {4} \n{5} yaşıyorsun \nuzun zamandır yemek yemediğin için {6}tan öldün",
                    biyomlar[biyom], biyomlar[biyom], biyomlar[biyom], biyomlar[biyom], bataklık_yiyecekler[food3], bataklık_barınaklar[barınak3], bataklık_nedeni[neden3]);
                    Console.WriteLine("{0} gün hayatta kalabildin!", liveday);
                }

                if (biyomlar[biyom] == "Bataklıkta" && bataklık_nedeni[neden3] == "susuzluk")
                {
                    Console.WriteLine("Balık tutmaya gittiğin {0} kayığının su alıp batıyor\n" +
                        "boğulmaktan kıl payı kurtuluyorsun ama iletişim araçların su yüzünden bozuluyor\n" +
                        "{1} mahsur kalıyorsun ve {2}ki maceran başlamış oluyor\n" +
                        "{3} ki ana yemeğin {4} \n{5} yaşıyorsun \nuzun zamandır su tüketmediğin için {6}tan böbreğin iflas etti ve öldün ",
                    biyomlar[biyom], biyomlar[biyom], biyomlar[biyom], biyomlar[biyom], bataklık_yiyecekler[food3], bataklık_barınaklar[barınak3], bataklık_nedeni[neden3]);
                    Console.WriteLine("{0} gün hayatta kalabildin!", liveday);
                }

                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                if (biyomlar[biyom] == "Issız Adada" && ada_nedeni[neden4] == "yılan")
                {
                    Console.WriteLine("Deniz biyoloğu olarak araştırma için okyanusa açıldıktan sonra\n" +
                        "hava kötüleşiyor ve gemin alabora oluyor gözlerini açtığında kendini\n" +
                        "{0} buluyorsun ve böylece ada maceran başlamış oluyor\n" +
                        "{1} ki ana yemeğin {2} \n{3} yaşıyorsun \nadayı keşif yaptığın sırada {4} tarafından sokuldun ve zehirlendiğin için öldün",
                    biyomlar[biyom], biyomlar[biyom], ada_yiyecekler[food4], ada_barınaklar[barınak4], ada_nedeni[neden4]);
                    Console.WriteLine("{0} gün hayatta kalabildin!", liveday);
                }

                if (biyomlar[biyom] == "Issız Adada" && ada_nedeni[neden4] == "akrep")
                {
                    Console.WriteLine("Deniz biyoloğu olarak araştırma için okyanusa açıldıktan sonra\n" +
                        "hava kötüleşiyor ve gemin alabora oluyor gözlerini açtığında kendini\n" +
                        "{0} buluyorsun ve böylece ada maceran başlamış oluyor\n" +
                        "{1} ki ana yemeğin {2} \n{3} yaşıyorsun \n{4} tarafından sokularak öldün",
                    biyomlar[biyom], biyomlar[biyom], ada_yiyecekler[food4], ada_barınaklar[barınak4], ada_nedeni[neden4]);
                    Console.WriteLine("{0} gün hayatta kalabildin!", liveday);
                }

                if (biyomlar[biyom] == "Issız Adada" && ada_nedeni[neden4] == "yabani domuz")
                {
                    Console.WriteLine("Deniz biyoloğu olarak araştırma için okyanusa açıldıktan sonra\n" +
                        "hava kötüleşiyor ve gemin alabora oluyor gözlerini açtığında kendini\n" +
                        "{0} buluyorsun ve böylece ada maceran başlamış oluyor\n" +
                        "{1} ki ana yemeğin {2} \n{3} yaşıyorsun \n" +
                        "{4}ları sinirlendirdiğin için sana saldırdılar ve kan kaybından öldün",
                    biyomlar[biyom], biyomlar[biyom], ada_yiyecekler[food4], ada_barınaklar[barınak4], ada_nedeni[neden4]);
                    Console.WriteLine("{0} gün hayatta kalabildin!", liveday);
                }

                if (biyomlar[biyom] == "Issız Adada" && ada_nedeni[neden4] == "puma")
                {
                    Console.WriteLine("Deniz biyoloğu olarak araştırma için okyanusa açıldıktan sonra\n" +
                        "hava kötüleşiyor ve gemin alabora oluyor gözlerini açtığında kendini\n" +
                        "{0} buluyorsun ve böylece ada maceran başlamış oluyor\n" +
                        "{1} ki ana yemeğin {2} \n{3} yaşıyorsun \nadada yaşayan {4} tarafından ansızın saldırıya uğradın ve öldürüldün",
                    biyomlar[biyom], biyomlar[biyom], ada_yiyecekler[food4], ada_barınaklar[barınak4], ada_nedeni[neden4]);
                    Console.WriteLine("{0} gün hayatta kalabildin!", liveday);
                }

                if (biyomlar[biyom] == "Issız Adada" && ada_nedeni[neden4] == "kan kaybı")
                {
                    Console.WriteLine("Deniz biyoloğu olarak araştırma için okyanusa açıldıktan sonra\n" +
                        "hava kötüleşiyor ve gemin alabora oluyor gözlerini açtığında kendini\n" +
                        "{0} buluyorsun ve böylece ada maceran başlamış oluyor\n" +
                        "{1} ki ana yemeğin {2} \n{3} yaşıyorsun \nkayalıkta gezinirken sivri bir taşa basarak ayağını derin kestin\n" +
                        "hemofili hastalığın olduğu için akan kan durmadı ve {4}dan dolayı öldün",
                    biyomlar[biyom], biyomlar[biyom], ada_yiyecekler[food4], ada_barınaklar[barınak4], ada_nedeni[neden4]);
                    Console.WriteLine("{0} gün hayatta kalabildin!", liveday);
                }

                if (biyomlar[biyom] == "Issız Adada" && ada_nedeni[neden4] == "açlık")
                {
                    Console.WriteLine("Deniz biyoloğu olarak araştırma için okyanusa açıldıktan sonra\n" +
                        "hava kötüleşiyor ve gemin alabora oluyor gözlerini açtığında kendini\n" +
                        "{0} buluyorsun ve böylece ada maceran başlamış oluyor\n" +
                        "{1} ki ana yemeğin {2} \n{3} yaşıyorsun \nuzun zamandır yemek yemediğin için {4}tan öldün",
                    biyomlar[biyom], biyomlar[biyom], ada_yiyecekler[food4], ada_barınaklar[barınak4], ada_nedeni[neden4]);
                    Console.WriteLine("{0} gün hayatta kalabildin!", liveday);
                }

                if (biyomlar[biyom] == "Issız Adada" && ada_nedeni[neden4] == "susuzluk")
                {
                    Console.WriteLine("Deniz biyoloğu olarak araştırma için okyanusa açıldıktan sonra\n" +
                        "hava kötüleşiyor ve gemin alabora oluyor gözlerini açtığında kendini\n" +
                        "{0} buluyorsun ve böylece ada maceran başlamış oluyor\n" +
                        "{1} ki ana yemeğin {2} \n{3} yaşıyorsun \nuzun zamandır su tüketmediğin için {4}tan böbreğin iflas etti ve öldün ",
                    biyomlar[biyom], biyomlar[biyom], ada_yiyecekler[food4], ada_barınaklar[barınak4], ada_nedeni[neden4]);
                    Console.WriteLine("{0} gün hayatta kalabildin!", liveday);
                }

            }
            else if (faith[kader] == "hayatta")
            {
                if (biyomlar[biyom] == "Yağmur Ormanında")
                {
                    Console.WriteLine("Özel Uçağın ile seyahatin sırasında uçak brezilya açıklarında kaza yapıyor\n" +
                        "kazadan sonra kendine geldiğinde sadece kendinin sağ çıkıtığını farkediyorsun\n" +
                        "Etrafına bakındığında {0} mahsur kaldığını anlıyorsun ve {1}ki maceran başlamış oluyor \n" +
                        "{2} ki ana yemeğin {3} \n{4} yaşıyorsun ",
                     biyomlar[biyom], biyomlar[biyom], biyomlar[biyom], orman_yiyecekler[food1], orman_barınaklar[barınak1]);
                    Console.WriteLine("{0} gündür hayattasın ve kurtarılmayı bekliyorsun!", liveday);
                }

                if (biyomlar[biyom] == "Çölde")
                {
                    Console.WriteLine("Afrika'da ki tur gezisi sırasında ekibinden ayrı düştün\n" +
                        "üzerinde herhangi bir iletişim aracı olmadığından dolayı tek başına kaldığını farkediyorsun\n" +
                        "{0} Mahsur kalıyorsun ve {1}ki maceran başlamış oluyor\n" +
                        "{2} ki ana yemeğin {3} \n{4} yaşıyorsun ",
                     biyomlar[biyom], biyomlar[biyom], biyomlar[biyom], biyomlar[biyom], çöl_yiyecekler[food2], çöl_barınaklar[barınak2]);
                    Console.WriteLine("{0} gündür hayattasın ve kurtarılmayı bekliyorsun!", liveday);
                }

                if (biyomlar[biyom] == "Bataklıkta")
                {
                    Console.WriteLine("Balık tutmaya gittiğin {0} kayığının su alıp batıyor\n" +
                        "boğulmaktan kıl payı kurtuluyorsun ama iletişim araçların su yüzünden bozuluyor\n" +
                        "{1} mahsur kalıyorsun ve {2}ki maceran başlamış oluyor\n" +
                        "{3} ki ana yemeğin {4} \n{5} yaşıyorsun ",
                     biyomlar[biyom], biyomlar[biyom], biyomlar[biyom], biyomlar[biyom], bataklık_yiyecekler[food3], bataklık_barınaklar[barınak3]);
                    Console.WriteLine("{0} gündür hayattasın ve kurtarılmayı bekliyorsun!", liveday);
                }

                if (biyomlar[biyom] == "Issız Adada")
                {
                    Console.WriteLine("Deniz biyoloğu olarak araştırma için okyanusa açıldıktan sonra\n" +
                        "hava kötüleşiyor ve gemin alabora oluyor gözlerini açtığında kendini\n" +
                        "{0} buluyorsun ve böylece ada maceran başlamış oluyor\n" +
                        "{1} ki ana yemeğin {2} \n{3} yaşıyorsun ",
                     biyomlar[biyom], biyomlar[biyom], ada_yiyecekler[food4], ada_barınaklar[barınak4]);
                    Console.WriteLine("{0} gündür hayattasın ve kurtarılmayı bekliyorsun!", liveday);
                }

            }
            else
            {

            }

            Console.ReadLine();

        }

    }
}


        


