using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BesinciDers : MonoBehaviour
{
    // VECTOR 3 / VECTOR 2
    // COLLIDER
    // TAG
    // ONTR�GGER / ONCOLLISION
    // SINGLETON DESIGN PATTERN
    // CLASSLAR ARASI ERISIM VE ETKILESIM
    // AUDIO SOURCE ve AUDIO CLIP (ses ve muz�k efektler�)

    public Text skorText;
    public int skor;
    public int hareketH�z�;
    public int z�plamaH�z�;
    public bool oyunDevamEdiyorMu;
    public GameObject karakter;
    Vector3 eksenler;
    public Rigidbody fizikSistemi;
    public AudioSource sesKutusu;
    public AudioClip ku�SesiEfekti;

    public static BesinciDers Kopya { get; private set; }
    private void Awake()
    {
        // Bir �rnek varsa ve ben de�ilse, yoket.

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
        eksenler.z += Time.deltaTime * z�plamaH�z�;
        karakter.transform.position = eksenler;
    }
    public void Ziplama()
    {
        // rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        // KLAVYE G�RD�S� NASIL ALINIR?
        // getkey , getkeydown , getkeyup

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            fizikSistemi.AddForce(Vector3.up * hareketH�z�, ForceMode.Impulse);
            sesKutusu.PlayOneShot(ku�SesiEfekti);
        }
    }
   

}
