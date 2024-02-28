using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UcuncuDers : MonoBehaviour
{

    /*
     * "\n"
     * Kar��la�t�rma
     * Kar��la�t�rma Aray�z(Butonlar-Textler) ile
     * if else if else bloklar� detayl�
     * Biografi
     * Bilgi yar��mas�
     * Linkedin ve Github payla��m�
    */



    // Soru ba�l��� i�eri�i
    public Text soruBasligiMetni;
    //Sorunun metni
    public Text sorununMetni;
    //Sorunun numaras�
    public int soruNumaras�;
    public Text soruNumarasiMetni;

    //-----�LK G�REVLER�M TAMAMLANDI--------


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
        dogruCevap = "�lham";
        if (dogruCevap==cevap)
        {
            sorununMetni.text = "Tebrikler! Soruya do�ru cevap verdiniz.";
            aSikkiDogrulukResmi.color = Color.green;
            bSikkiDogrulukResmi.color = Color.white;
        }
        else
        {
            sorununMetni.text = "Hay Aksi! Soruya yanl�� cevap verdiniz.";
            aSikkiDogrulukResmi.color = Color.white;
            bSikkiDogrulukResmi.color = Color.red;
        }
    }
    public void SoruUret()
    {
        aSikkiDogrulukResmi.color = Color.white;
        bSikkiDogrulukResmi.color = Color.white;

        soruBasligiMetni.text = "Genel K�lt�r/Teknoloji";
        sorununMetni.text = "�nspimo'nun kelime anlam� a�a��dakilerden hangisidir?";
        soruNumaras� = 1;
        soruNumarasiMetni.text = soruNumaras�.ToString();

        aSikkiMetni.text = "A) " + "�lham";
        bSikkiMetni.text = "B) " + "�ntikam";
    }
    
}