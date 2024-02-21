using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.VFX;

public class İkinciDers : MonoBehaviour
{
    // Tekli Yorum Satırı

    // KISAYOLLAR
    // CTRL + X = Satır Silme
    // CTRL + C = Satır Kopyalama
    // CTRL + V = Satır Yapıştırma
    // CTRL + D = Satır Çoğaltma

    /*
     * TOPLU YORUM SATIRI
     */

    /*
     * int = tam sayı
     * float = ondalıklı sayı
     * double = uzun ve ondalıklı sayı
     * string = metin
     * char = tek karakter
     * bool = true yada false - 0/1       ---->     javada boolean
     */

    // Değişken Tipi + Değişken İsim = Rakam/Sayı/Metin/Karakter/İşlem
    // Tür Dönüşümü

    int a = 1;
    int b = 10;
    string c = "Yazılım Koçluğu";
    char d = 'A';
    bool e = true;


    // BU ALAN SADECE TANIMLAMA YAPILMASI İÇİN KULLANILABİLİNİR.

    /*
     * KARŞILAŞTIRMA OPERATÖRLERİ
     * <
     * >
     * <=
     * >=
     * ==
     * !=
     */

    /*
     * ERİŞİM BELİRLEYİCİ
     * Public
     * Private
     * Protected
     * */

    // Sadece bilinen değişkenler dışında
    // oyunda kullanılan bileşenler de değişken olarak tanımlanabilir.

    /*
    Text yazı;
    Camera camera;
    Light light;
    VisualEffect efekt;
    */

    //System.out.println("Oyun Başladı");  ---> Java
    //Console.WriteLine("Oyun Başladı");   ---> C#
    //Debug.Log("Oyun Başladı");           ---> Unity & C#

    // Time.deltaTime = Geçen zamanı hesaplama
    // gameObject.SetActive(True/False)

    public Text helloWorld;
    public Text sayacText;

    public Image sayacResmi;

    public float sayac = 5;

    void Start()
    {
        helloWorld.text = "Merhaba Dünya!";


        Debug.Log("Oyun Başladı-START");
    }


    void Update()
    {
        if (sayac > 0)
        {
            sayac = sayac - Time.deltaTime;
            helloWorld.text = "Ders Başlıyor...";
            
            //sayacText.text = sayac.ToString(); // mantık hatası olacak!
            sayacText.text = TimeSpan.FromSeconds(sayac).ToString(@"mm\:ss");
        }
        else if (sayac <= 0)
        {
            sayac = 0;
            sayacResmi.gameObject.SetActive(false);
            sayacText.text = "";
            helloWorld.text = "Ders Başladı!..";
        }
    }
}
