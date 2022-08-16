// See https://aka.ms/new-console-template for more information
using System.Collections;  //Burada dinamik dizileri kullanabilmek için bu komut satırını kullandık

int x=0;
Console.WriteLine("Lütfen Pozitif Bir Tam Sayı Giriniz:"); 
x = Convert.ToInt16(Console.ReadLine());    //Burada Kullanacıdan bir sayı aldık ve değişkene attık

ArrayList isim = new ArrayList(x); //Burada ise kullanıcıdan almış olduğumuz değişkeni koyduk

int z=0; //burada çift sayıları diziye eklemek için dönücek olan değişkenleri sıraladık.

for (int i = 1; i <=x; i++)
{  
        Console.WriteLine("Lütfen"+" "+i+".Sayıyı giriniz:");
        z=Convert.ToInt32(Console.ReadLine()); //Burada ise z değişkenine döngü döndükçe kullanıcınını girdiği sayıları tek tek derledik.

                            if(z % 2 == 0)
                            {
                            isim.Add(z);  //Asıl olay burada, çift sayıları burada ayırıp isim adlı dizimize attık . 
                            } 
}
foreach (var sayi in isim)
{
    Console.WriteLine("Çift Sayılar:"+sayi);
}

  
  



