using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puan : MonoBehaviour
{
    [SerializeField]
    Text text = default;
    [SerializeField]
    Text altintext = default;
    [SerializeField]
    Text oyunbittipuantext = default;
    [SerializeField]
    Text oyunbittialtıntext = default;
    int puan;
    int enyuksekpuan;
    int altin;
    int enyuksekaltın;
    bool puantopla = true;

    void Start()
    {
        altintext.text = "x "+altin;
    }

    // Update is called once per frame
    void Update()
    {
        if (puantopla)
        {
            puan = (int)Camera.main.transform.position.y;
            text.text = "Puan: " + puan;
        }
        
    }

    public void altinkazan()
    {
        FindObjectOfType<SesKontrol>().AltinSes();
        altin++;
        altintext.text = "x " + altin;
    }

    public void oyunbitti()
    {
        if (KayıtAlanı.kolaydegeroku() == 1)
        {
            enyuksekpuan = KayıtAlanı.kolaypuandegeroku();
            enyuksekaltın = KayıtAlanı.kolayaltındegeroku();
            if (puan>enyuksekpuan)
            {
                KayıtAlanı.kolaypuandegerata(puan);
            }
            if (altin > enyuksekpuan)
            {
                KayıtAlanı.kolayaltındegerata(altin);
            }
        }
        if (KayıtAlanı.ortadegeroku() == 1)
        {
            enyuksekpuan = KayıtAlanı.ortapuandegeroku();
            enyuksekaltın = KayıtAlanı.ortaaltındegeroku();
            if (puan > enyuksekpuan)
            {
                KayıtAlanı.ortapuandegerata(puan);
            }
            if (altin > enyuksekpuan)
            {
                KayıtAlanı.ortaaltındegerata(altin);
            }
        }
        if (KayıtAlanı.zordegeroku() == 1)
        {
            enyuksekpuan = KayıtAlanı.zorpuandegeroku();
            enyuksekaltın = KayıtAlanı.zoraltındegeroku();
            if (puan > enyuksekpuan)
            {
                KayıtAlanı.zorpuandegerata(puan);
            }
            if (altin > enyuksekpuan)
            {
                KayıtAlanı.zoraltındegerata(altin);
            }
        }
        oyunbittipuantext.text = "Puan: " + puan;
        oyunbittialtıntext.text = "x " + altin;
        puantopla = false;
    }
}
