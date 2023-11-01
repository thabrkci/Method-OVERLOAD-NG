namespace Method_OVERLOADİNG;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("_--_-_-_Out Parametres_-__-_");
        string plus = "999";
        bool hand = int.TryParse(plus ,out int outplus);//string veri tipindeki sayıyı tryparse ile "out"
        //yardımı ile int veri tipine çevirdik if ile çevirebilirse yazmasını çeviremez ise else ile yazdırmasını sağladık.
        if(hand)
        {
        Console.WriteLine("Winner");
        Console.WriteLine(outplus);
        }
        else
        {
            Console.WriteLine("Don't Winner");
        }
 
        //Method aşırı yükleme
        methodlistş jungle = new methodlistş();//Class kullandık
        jungle.plus(4,5, out int plusplus);//Class içindeki a ve b değerine 4 ve 5 değerini atadık
        Console.WriteLine(plusplus);//Sonucu Plusplus değer adı ile out ettik
        int methoding =999;
        jungle.Writeforscreen(Convert.ToString(methoding));//String veri tipine çevirdik
        jungle.Writeforscreen(methoding);
        jungle.Writeforscreen("Taha","BÖREKCİ");
                              // ko1-  k02 //
    
        

    }
}

class methodlistş
{
 public void plus(int a, int b,out int pluss)//Out ile int çıkışı sağladık a ve b değeri için
 {
  pluss = a+b;
 }

 public void Writeforscreen(string down)
 {
  Console.WriteLine(down);
 }

 public void Writeforscreen(int down)
 {
  Console.WriteLine(down);
 }

 public void Writeforscreen(string ko1 , string ko2)
 {
  Console.WriteLine(ko1 + ko2);
 }





 }
