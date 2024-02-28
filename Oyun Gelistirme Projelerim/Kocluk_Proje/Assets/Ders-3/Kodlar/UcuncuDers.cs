using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UcuncuDers : MonoBehaviour
{

    /*
     * "\n"
     * Karþýlaþtýrma
     * Karþýlaþtýrma Arayüz(Butonlar-Textler) ile
     * if else if else bloklarý detaylý
     * Biografi
     * Bilgi yarýþmasý
     * Linkedin ve Github paylaþýmý
    */



    // Soru baþlýðý içeriði
    public Text soruBasligiMetni;
    //Sorunun metni
    public Text sorununMetni;
    //Sorunun numarasý
    public int soruNumarasý;
    public Text soruNumarasiMetni;

    //-----ÝLK GÖREVLERÝM TAMAMLANDI--------


    public Text aSikkiMetni;
    public Text bSikkiMetni;


    public string dogruCevap;

    public Image aSikkiDogrulukResmi;
    public Image bSikkiDogrulukResmi;

    private void Start()
    {
        SoruUret();
    }

    
    public void DogrulukKontrolu(string cevap)
    {
        dogruCevap = "Ýlham";
        if (dogruCevap==cevap)
        {
            sorununMetni.text = "Tebrikler! Soruya doðru cevap verdiniz.";
            aSikkiDogrulukResmi.color = Color.green;
            bSikkiDogrulukResmi.color = Color.white;
        }
        else
        {
            sorununMetni.text = "Hay Aksi! Soruya yanlýþ cevap verdiniz.";
            aSikkiDogrulukResmi.color = Color.white;
            bSikkiDogrulukResmi.color = Color.red;
        }
    }
    public void SoruUret()
    {
        aSikkiDogrulukResmi.color = Color.white;
        bSikkiDogrulukResmi.color = Color.white;

        soruBasligiMetni.text = "Genel Kültür/Teknoloji";
        sorununMetni.text = "Ýnspimo'nun kelime anlamý aþaðýdakilerden hangisidir?";
        soruNumarasý = 1;
        soruNumarasiMetni.text = soruNumarasý.ToString();

        aSikkiMetni.text = "A) " + "Ýlham";
        bSikkiMetni.text = "B) " + "Ýntikam";
    }
    
}