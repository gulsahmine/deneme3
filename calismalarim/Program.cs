using System;

namespace calismalarim
{
    class Program
    {
        static void Main(string[] args)
         {
               //Yarı çapı verilen çemberin alanını hesaplayınız pi = 3,14
        //     double alan , yaricap , pi =3.14;
        //     System.Console.Write("Yarıçap Değerini Giriniz : ");
        //     yaricap=double.Parse(Console.ReadLine());
        //     alan=yaricap*yaricap*pi;
        //     System.Console.WriteLine("Çemberin Alanı: " + alan );

               // fiyatı ve kdvsi girilen ürünün tutarını hesaplama.
            //    float fiyat,kdvoran,kdv,tutar;
            //    System.Console.Write("Fiyatı Giriniz : ");
            //    fiyat = float.Parse(Console.ReadLine());
            //    System.Console.Write("KDV Oranını Giriniz : ");
            //    kdvoran = float.Parse(Console.ReadLine());
            //    kdv = fiyat*kdvoran;
            //    tutar=kdv+fiyat;
            //    System.Console.WriteLine("Tutarınız : " + tutar);

                     //derece fahrenait dönüştürme.
        // float derece, fahrenait;
        // System.Console.Write("Farenait değerini giriniz: ");
        // fahrenait = float.Parse(Console.ReadLine());
        // derece=(fahrenait-32)/1.8f;
        // System.Console.WriteLine(" fahrenait : " + fahrenait  + " derece : " + derece);

                  // yaşı 18den büyükse ehliyet alabilirsiniz.

            // int yas;
            // System.Console.WriteLine("Yaşınızı Giriniz: ");       
            // yas = int.Parse(Console.ReadLine());
            // if (yas >= 18)
            // {
            //    System.Console.WriteLine(" Ehliyet Alabilirsiniz ");
            // }   
            // else
            // {
            //     System.Console.WriteLine("Yaşın Tutmuyor Canım");
            // }
                   //Taban ve yüksekliği bilinen bir üçgenin alanını hesaplama

            // int taban , yükseklik , alan;
            // System.Console.Write("Üçgenin Taban Uzunluğunu Giriniz : ");
            // taban=int.Parse(Console.ReadLine());
            // System.Console.Write("Üçgenin Yüksekliğini Giriniz : ");
            // yükseklik= int.Parse(Console.ReadLine());
            // alan = (taban*yükseklik)/2;
            // System.Console.WriteLine("Üçgenin Alanı : " + alan);
   
                  //Pisagor teoremi ile Hipotenüs hesaplama

            // double  b , c , hipotenus ;
            // System.Console.Write(" Üçgenin 1. dik kenarını giriniz : ");
            // b = double.Parse(Console.ReadLine());
            // System.Console.Write(" Üçgenin 2. dik kenarını giriniz : ");
            // c = double.Parse(Console.ReadLine());
            // hipotenus = Math.Sqrt(b*b + c*c); 
            // System.Console.WriteLine("Hipotenüs Değeri : " + a);

                  //Üçgende sinüs teoremi ile alan hesaplama

                // double kenar1, kenar2, aci, alan ;
                // System.Console.Write("1.kenarı giriniz : ");
                // kenar1=double.Parse(Console.ReadLine());
                // System.Console.Write("2.kenarı giriniz : ");
                // kenar2=double.Parse(Console.ReadLine());
                // System.Console.Write("2 kenar arasındaki açıyı giriniz : ");
                // aci=double.Parse(Console.ReadLine());
                // alan = kenar1*kenar2*Math.Sin(aci)/2;
                // System.Console.WriteLine("Alan: " + alan);

               
                //Klavyeden girilen iki sayının bir birine bölünüp bölünmediğini gösteren C# Programı

                // int sayi1,sayi2;
                // System.Console.Write("1. sayıyı giriniz : ");
                // sayi1=int.Parse(Console.ReadLine());
                // System.Console.Write("2. sayıyı giriniz : ");
                // sayi2=int.Parse(Console.ReadLine());
                // if ( sayi1%sayi2==0 || sayi2%sayi1==0 )
                // {
                //    System.Console.WriteLine("Gidiğiniz sayılar birbirlerine bölünmektedir.");
                // }
                // else
                // {
                //     System.Console.WriteLine("Sayılar birbirine bölünen sayılar değillerdir");
                // }

                //Klavyeden girilen ikilik tabandaki bir sayının onluk tabandaki karşılığını yazdıran C# kodu
                   
                    //100lük sistemde notu girilen bir öğrencinin notunu 5lik sisteme çevirme(50 puana göre)

                    // int not ;
                    // System.Console.WriteLine("Notunuzu giriniz : ");
                    // not= int.Parse(Console.ReadLine());
                    
                    // if(  not >100 )
                    // {
                    //     System.Console.WriteLine("Hatalı Giriş Yaptınız");
                    // }
                    
                    // else if ( 0 <=not && not<45)
                    // {
                    //     System.Console.WriteLine("Notunuz 1 ");
                    // }
               
                    // else if( not>=45 && not<55 )
                    // {
                    //     System.Console.WriteLine("Notunuz 2 ");
                    // }
                    
                    // else if(not>=55 && not<70)
                    // {
                    //     System.Console.WriteLine("Notunuz 3 ");
                    // }

                    // else if (not>=70 && not<85)
                    // {
                    //     System.Console.WriteLine("Notunuz 4 ");
                    // }
                    
                    // else
                    // {
                    //     System.Console.WriteLine("Notunuz 5 ");
                    // }

                             //switch-case ile deneme
                    //  double not ;
                    //  System.Console.WriteLine("Notunuzu giriniz : ");
                    //  not= double.Parse (Console.ReadLine());

                    //  switch(not)
                    //  {
                         
                    //      case  double n when (0 <=not && not<45) :System.Console.WriteLine("Notunuz 1");break;
                    //      case  double n when (not>=45 && not<55) :System.Console.WriteLine("Notunuz 2");break;
                    //      case  double n when (not>=55 && not<70) :System.Console.WriteLine("Notunuz 3");break;
                    //      case  double n when (not>=70 && not<85) :System.Console.WriteLine("Notunuz 4");break;
                    //      case  double n when (not>=85 && not<100) :System.Console.WriteLine("Notunuz 5");break;
                    //      default : break;

                    //  }

                         //Girilen sayı 0 dan büyük ise “pozitif” küçük ise “negatif” sıfıra eşit ise “sıfır” mesajını verdirelim.

                        //  int sayi;
                        //  System.Console.WriteLine("sayıyı giriniz : ");
                        //  sayi=int.Parse(Console.ReadLine());
                        //  if (sayi>0)
                        //  {
                        //      System.Console.WriteLine("pozitif sayıdır");
                        //  }
                        //  else if (sayi <0)
                        //  {
                        //      System.Console.WriteLine("Negatif Sayıdır");

                        //  }
                        //  else if (sayi==0)
                        //  {
                        //      System.Console.WriteLine("sayi 0 dır");
                        //  }
                        
                         //swtich-case ile;
                        
                        //  double sayi;
                        //  System.Console.WriteLine("sayıyı giriniz : ");
                        //  sayi=double.Parse(Console.ReadLine());
                        //  switch(sayi)
                        //  {
                        //      case double s when (sayi>0):System.Console.WriteLine("pozitif sayı");break;
                        //      case double s when(sayi<0):System.Console.WriteLine("negatif sayı");break;
                        //      case double s  when(sayi==0):System.Console.WriteLine("sayı 0 dır");break;
                        //      default:break;
                        //  }

                        //Kullanıcının girdiği 3 sayıdan büyük olanını ekrana yazdırınız.

                        // int sayi1,sayi2,sayi3;
                        //  System.Console.WriteLine("1. sayıyı giriniz");
                        // sayi1=int.Parse(Console.ReadLine());
                        //  System.Console.WriteLine("2. sayıyı giriniz");
                        // sayi2=int.Parse(Console.ReadLine());
                        //  System.Console.WriteLine("3. sayıyı giriniz");
                        // sayi3=int.Parse(Console.ReadLine());
                        
                        // if(sayi1>sayi2 && sayi1>sayi3)
                        // {
                        //     System.Console.WriteLine("en büyük sayı :" + sayi1);
                        // }
                        
                        // else if (sayi2>sayi1 && sayi2>sayi3)
                        // {
                        //     System.Console.WriteLine("en büyük sayı :" + sayi2);
                        // }

                        // else if(sayi3>sayi2 && sayi3>sayi1)
                        // {

                        //     System.Console.WriteLine("en büyük sayı :" + sayi3);
                        // }
                        
                                    //Ehliyet alıp almadığı alamadığında kaç sene gerektiği mesajı

                        // int yas,fark;
                        // System.Console.WriteLine("Yaşınızı Giriniz : ");
                        // yas=int.Parse(Console.ReadLine());
                        // fark = 18-yas;
                        // if (yas>=18)
                        // {
                        //     System.Console.WriteLine("Ehliyet Alabilirsiniz");
                        // }
                        // else
                        // {
                        //     System.Console.WriteLine("Ehliyet için gereken süre: " + fark  + " yıl ");
                        // }

                          //1-100 arası 3′ e ve 5’e tam bölünebilen sayıları listeleyen Console Örneği:

                        //   Byte i ;
                        //   for (i=1; i<100 ; i++)
                        //   {
                        //      if (i%3==0 && i%5==0)
                        //      {
                                 
                        //          System.Console.WriteLine(i);
                        //      }
                             
                        //   }

                                    //1-100 arası 5’e veya 7 ye tam bölünmeyen sayıları listeleyen Console Örneği:

                    
                    //  for ( byte i=1; i<100; i++)
                    //  {
                    //      if( i%5 != 0 || i%7 !=0)
                    //      {
                    //         System.Console.WriteLine(i);
                    //      }
                    //  }

                    // //1 den kullanıcının girdiği sayıya kadar olan sayıları listeleyen Console Örneği:
                    // System.Console.Write("sayıyı giriniz : ");
                    // int sayi = int.Parse(Console.ReadLine());
                    // for( int i=1 ; i<sayi ; i++ )
                    // {
                    //     System.Console.WriteLine(i);
                    // }
                     
                       // İki sayı arasındaki sayıları belirlenen adıma göre toplayan program.
                    
                    // int baSayi,biSayi,artis,toplam=0;
                    // System.Console.WriteLine("başlangıç sayısını giriniz : ");
                    // baSayi=int.Parse(Console.ReadLine());
                    // System.Console.WriteLine("bitiş sayısını giriniz : ");
                    // biSayi=int.Parse(Console.ReadLine());
                    // System.Console.WriteLine("Artış miktarını giriniz : ");
                    // artis=int.Parse(Console.ReadLine());
                   
                    

                    // for (int i = baSayi; i<=biSayi; i+=artis)
                    // {
                    //     toplam +=i; 
                    // }
                    //  System.Console.WriteLine("sonuç : " + toplam);

                           //Tabanı ve kuvveti girilen işlemin sonucu yazdıran program örneği
                        //    double taban, üs,sonuc;
                        //    System.Console.Write("taban sayısını giriniz:");
                        //    taban=double.Parse(Console.ReadLine());
                        //    System.Console.Write("üs sayısını giriniz:");
                        //    üs=double.Parse(Console.ReadLine());
                        //    sonuc=Math.Pow(taban,üs);
                        //    System.Console.WriteLine(sonuc);

                   //iki sayı arasındaki asal sayıları ekrana yazdıran program örneği

                  //  int sayi1,sayi2;
                  //  System.Console.Write("ilk sayıyı giriniz : ");    
                  //  sayi1=int.Parse(Console.ReadLine()) ;                    
                  //  System.Console.Write("son sayıyı giriniz : ");                           
                  //  sayi2=int.Parse(Console.ReadLine()) ;         
                  //  bool asalmi=true;
                  //  for(int i = sayi1; i<=sayi2; i++)
                  //  {
                     
                  //  }           
                

            
                    


                          














                    

                     

                        

                   
                   
            

              
        }
    }
}
