using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HaftaDört : MonoBehaviour
{

    public Text isimSoyisim;
    public Text adres;
    public Text webSitesi;
    public Text telefon;
    public Text eMail;
    public Text biografi;

    public Image resim;
    public Sprite profilFotografi;
    public Sprite[] resimlerim;
    void Start()
    {
        biografi.text = "Bilgi çekilirken hata oluştu lütfen tekrar deneyiniz!..";
        resim.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BilgilerimiEDevlettenGetir()
    {
        resim.gameObject.SetActive(true);
        isimSoyisim.text = "Çağrı Avcı";
        adres.text = "Fırat Teknokent \n Ofis:221 Merkez/Elazığ";
        webSitesi.text = "www.inspimo.com.tr";
        telefon.text = "+90 (533) 373 7243";
        eMail.text = "info@inspimo.com.tr";
        biografi.text = "Fırat Üniversitesi Yazılım Mühendisliği mezunu ve " +
            "Tezli Yüksek Lisans öğrenimi görmekteyim. " +
            "Sektörde 4yıl farklı firmalar 2.5 yıl kendi firmamda " +
            "çalışma tecrübesine sahibim.";
        resim.sprite = profilFotografi;
    }

    public void ResimlerimiGetir(int index)
    {
            resim.sprite = resimlerim[index];
    }


}
