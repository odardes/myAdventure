using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraHareket : MonoBehaviour
{
    float hiz;
    float hizlanma;
    float maxHiz;
    bool hareket;

    void Start()
    {
        hareket = true;
        if (KayıtAlanı.kolaydegeroku() == 1)
        {
            hiz = 0.3f;
            hizlanma = 0.03f;
            maxHiz = 1.5f;
        }
        if (KayıtAlanı.ortadegeroku() == 1)
        {
            hiz = 0.5f;
            hizlanma = 0.05f;
            maxHiz = 2.0f;
        }
        if (KayıtAlanı.zordegeroku() == 1)
        {
            hiz = 0.8f;
            hizlanma = 0.08f;
            maxHiz = 2.5f;
        }
    }

    void Update()
    {
        if (hareket)
        {
            kameraHareketEttir();
        }
       
    }

    void kameraHareketEttir()
    {
        transform.position += transform.up * hiz * Time.deltaTime;
        hiz += hizlanma * Time.deltaTime;
        if (hiz>maxHiz)
        {
            hiz = maxHiz;
        }
    }

    public void oyunbitti()
    {
        hareket = false;
    }
}
