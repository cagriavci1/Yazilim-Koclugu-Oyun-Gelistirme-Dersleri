using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BesinciDersIki : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Zemin"))
        {
            // OYUN BITTI OYUN SIFIRLANDI SKOR SIFIRLANDI OYUN YENIDEN BASLATILDI VS VS
            Debug.Log("OYUN B�TT� YANDIN!!!");
            BesinciDers.Kopya.skor = 0;
            BesinciDers.Kopya.karakter.transform.position = new Vector3(0, 6, -10);
        }
        if (other.gameObject.CompareTag("Ba�ar�l�Engel"))
        {
            //COK GUZEL SKOR ARTSIN ANIMASYONLAR CALISSIN KARAKTER TAKLA ATSIN SKORT ARTSIN COMBO OLSUN VS VS
            Debug.Log("Skor artt� engelden basar�l� gec�ld�");
            BesinciDers.Kopya.skor++;
        }
    }
}
