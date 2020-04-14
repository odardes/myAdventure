using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    [SerializeField]
    Sprite[] muzikikonlar = default;

    [SerializeField]
    Button muzikbuton = default;
    void Start()
    {
        if (KayıtAlanı.kayıtvarmı()==false)
        {
            KayıtAlanı.kolaydegerata(1);
        }
        if (KayıtAlanı.muzikacıkvarmı() == false)
        {
            KayıtAlanı.muzikacıkdegerata(1);
        }
        muzikayarlarınıdenetle();

    }

    public void oyunubaslat()
    {
        SceneManager.LoadScene("Game");
    }

    public void yuksekPuan()
    {
        SceneManager.LoadScene("Puan");
    }

    public void ayarlar()
    {
        SceneManager.LoadScene("Ayarlar");
    }

    public void muzik()
    {
        if (KayıtAlanı.muzikacıkdegeroku()==1)
        {
            KayıtAlanı.muzikacıkdegerata(0);
            MuzikKontrol.instance.muzikcal(false);
            muzikbuton.image.sprite = muzikikonlar[0];
        }else
        {
            KayıtAlanı.muzikacıkdegerata(1);
            MuzikKontrol.instance.muzikcal(true);
            muzikbuton.image.sprite = muzikikonlar[1];
        }

    }

    void muzikayarlarınıdenetle()
    {
        if (KayıtAlanı.muzikacıkdegeroku()==1)
        {
            muzikbuton.image.sprite = muzikikonlar[1];
            MuzikKontrol.instance.muzikcal(true);


        }
        else
        {
            muzikbuton.image.sprite = muzikikonlar[0];
            MuzikKontrol.instance.muzikcal(false);

        }
    }
}
