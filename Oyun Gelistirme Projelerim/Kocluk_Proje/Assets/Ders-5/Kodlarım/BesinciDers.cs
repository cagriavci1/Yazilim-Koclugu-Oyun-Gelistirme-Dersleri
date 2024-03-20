using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BesinciDers : MonoBehaviour
{
    // VECTOR 3 / VECTOR 2
    // COLLIDER
    // TAG
    // ONTRÝGGER / ONCOLLISION
    // SINGLETON DESIGN PATTERN
    // CLASSLAR ARASI ERISIM VE ETKILESIM
    // AUDIO SOURCE ve AUDIO CLIP (ses ve muzýk efektlerý)

    public Text skorText;
    public int skor;
    public int hareketHýzý;
    public int zýplamaHýzý;
    public bool oyunDevamEdiyorMu;
    public GameObject karakter;
    Vector3 eksenler;
    public Rigidbody fizikSistemi;
    public AudioSource sesKutusu;
    public AudioClip kuþSesiEfekti;

    public static BesinciDers Kopya { get; private set; }
    private void Awake()
    {
        // Bir örnek varsa ve ben deðilse, yoket.

        if (Kopya != null && Kopya != this)
        {
            Destroy(this);
            return;
        }
        Kopya = this;
        DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {
        oyunDevamEdiyorMu = true;
        skor = 0;
        skorText.text = "Skorun: " + skor;
    }

    void Update()
    {
        HareketEt();
        Ziplama();
        skorText.text = "Skorun: " + skor;
    }

    public void HareketEt()
    {
        eksenler = karakter.transform.position;
        eksenler.z += Time.deltaTime * zýplamaHýzý;
        karakter.transform.position = eksenler;
    }
    public void Ziplama()
    {
        // rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        // KLAVYE GÝRDÝSÝ NASIL ALINIR?
        // getkey , getkeydown , getkeyup

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            fizikSistemi.AddForce(Vector3.up * hareketHýzý, ForceMode.Impulse);
            sesKutusu.PlayOneShot(kuþSesiEfekti);
        }
    }
   

}
