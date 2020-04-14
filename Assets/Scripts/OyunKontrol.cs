using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OyunKontrol : MonoBehaviour
{

    public GameObject oyunbittipanel;
    public GameObject joystick;
    public GameObject tabela;
    public GameObject zıplamabutonu;
    public GameObject menubutonu;
    public GameObject slider;


    // Start is called before the first frame update
    void Start()
    {
        oyunbittipanel.SetActive(false);
        Uıac();
    }

    public void OyunuBitir()
    {
        FindObjectOfType<SesKontrol>().Oyunbittises();
        oyunbittipanel.SetActive(true);
        FindObjectOfType<Puan>().oyunbitti();
        FindObjectOfType<OyuncuHareket>().oyunbitti();
        FindObjectOfType<KameraHareket>().oyunbitti();
        Uıkapat();
    }

    public void AnaMenuyeDön()
    {
        SceneManager.LoadScene("Menu");

    }

    public void TekrarOyna()
    {
        SceneManager.LoadScene("Game");

    }

    void Uıac()
    {
        joystick.SetActive(true);
        zıplamabutonu.SetActive(true);
        menubutonu.SetActive(true);
        slider.SetActive(true);
        tabela.SetActive(true);

    }

    void Uıkapat()
    {
        joystick.SetActive(false);
        zıplamabutonu.SetActive(false);
        menubutonu.SetActive(false);
        slider.SetActive(false);
        tabela.SetActive(false);
    }
}
