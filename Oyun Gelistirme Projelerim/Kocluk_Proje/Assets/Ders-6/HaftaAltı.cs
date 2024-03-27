using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HaftaAltı : MonoBehaviour
{
    public float hiz=10f;
    public Animator animasyonlarım;

    public Text metin;


    private void Start()
    {
        metin.text = "Oyun Başladı!...";
    }
    void Update()
    {
        ObjeHareketEt();
        KarakterHareketEt();
    }

    public void ObjeHareketEt()
    {
        // x ve z eksenlerinde hareket sağlayacağız.
        float xEkseni = Input.GetAxis("Horizontal");
        float zEkseni = Input.GetAxis("Vertical");

        // bu bilgileri bir vektöre atadık
        Vector3 hareketSistemi = new Vector3(xEkseni, 0.0f, zEkseni);

        // almış oldugumuz vektör değerlini karaktere atacağız.
        this.transform.position += hareketSistemi * hiz * Time.deltaTime;
    }

    public void KarakterHareketEt()
    {
        if (Input.GetKey(KeyCode.W))
        {
            metin.text = "W Animasyonu Çalıştı";
            animasyonlarım.SetBool("İleriYürüme", true);
        }
        else
        {
            animasyonlarım.SetBool("İleriYürüme", false);
        }
        if (Input.GetKey(KeyCode.A))
        {
            metin.text = "A Animasyonu Çalıştı";
            animasyonlarım.SetBool("SolaDon", true);
        }
        else
        {
            animasyonlarım.SetBool("SolaDon", false);
        }
        if (Input.GetKey(KeyCode.D))
        {
            metin.text = "D Animasyonu Çalıştı";
            animasyonlarım.SetBool("SagaDon", true);
        }
        else
        {
            animasyonlarım.SetBool("SagaDon", false);
        }
    }
    // -------------------------------- Ö D E V --------------------------------
    // BOX RİNGİ SAHNESİ TASARLA (50 büyüklükte çok fazla genıs alana yayılmadan kucuk bır alanda sahne tasarla)()

    // Karakter Ekle => Bu karakter ileri, geri, sağ, sol yürüme animasyonları olsun. Ayrıca koşma animasyonu da olsun. // HAREKET

    // Karakter Ekle => Bu karakter tekme atma, sağ ve sol yumruk atma, zıplama ve yere düşme animasyonları olsun.      // SABİT DURMA

    // Sahnede ve her bir efektte Müzik ve ses efektleri olmalı
    // Ayrıca bu işlemleri text ile ekranda cıktı gosterılmelı

}
