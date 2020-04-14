using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PuanKontrol : MonoBehaviour
{
    public Text kolaypuan, kolayaltın, ortapuan, ortaaltın, zorpuan, zoraltın;
    void Start()
    {
        kolaypuan.text = "Puan: " + KayıtAlanı.kolaypuandegeroku();
        kolayaltın.text = " x " + KayıtAlanı.kolayaltındegeroku();

        ortapuan.text = "Puan: " + KayıtAlanı.ortapuandegeroku();
        ortaaltın.text = " x " + KayıtAlanı.ortaaltındegeroku();

        zorpuan.text = "Puan: " + KayıtAlanı.zorpuandegeroku();
        zoraltın.text = " x " + KayıtAlanı.zoraltındegeroku();

    }

    public void puangeri()
    {
        SceneManager.LoadScene("Menu");
    }
}
