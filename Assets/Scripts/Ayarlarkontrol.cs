using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;


public class Ayarlarkontrol : MonoBehaviour
{
    public Button kolay, orta, zor;
    void Start()
    {
        if (KayıtAlanı.kolaydegeroku() == 1)
        {
            kolay.interactable = false;
            orta.interactable = true;
            zor.interactable = true;
        }
        if (KayıtAlanı.ortadegeroku() == 1)
        {
            kolay.interactable = true;
            orta.interactable = false;
            zor.interactable = true;
        }
        if (KayıtAlanı.zordegeroku() == 1)
        {
            kolay.interactable = true;
            orta.interactable = true;
            zor.interactable = false;
        }
    }

    void Update()
    {
        
    }
    public void seceneksecildi(string seviye)
    {
        switch (seviye)
        {
            case "kolay":
                KayıtAlanı.kolaydegerata(1);
                KayıtAlanı.ortadegerata(0);
                KayıtAlanı.zordegerata(0);

                kolay.interactable = false;
                orta.interactable = true;
                zor.interactable = true;
                break;
            case "orta":
                KayıtAlanı.ortadegerata(1);
                KayıtAlanı.zordegerata(0);
                KayıtAlanı.kolaydegerata(0);

                kolay.interactable = true;
                orta.interactable = false;
                zor.interactable = true;
                break;
            case "zor":
                KayıtAlanı.ortadegerata(0);
                KayıtAlanı.zordegerata(1);
                KayıtAlanı.kolaydegerata(0);

                kolay.interactable = true;
                orta.interactable = true;
                zor.interactable = false;
                break;
            default:
                break;
        }
    }
    public void anamenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
