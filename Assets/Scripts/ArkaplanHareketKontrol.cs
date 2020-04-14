using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArkaplanHareketKontrol : MonoBehaviour
{
    float arkaplankonum;
    float mesafe = 10.24f;

    void Start()
    {
        arkaplankonum = transform.position.y;
        FindObjectOfType<Gezegenler>().gezegenyerlestir(arkaplankonum);
    }

    void Update()
    {
        if (arkaplankonum + mesafe < Camera.main.transform.position.y)
        {
            arkaplanHareket();
        }
       
    }

    void arkaplanHareket()
    {
        arkaplankonum += mesafe * 2; //3 arkaplan objesi olsaydı *3 olurdu.
        FindObjectOfType<Gezegenler>().gezegenyerlestir(arkaplankonum);
        Vector2 yenipozisyon = new Vector2(0, arkaplankonum);
        transform.position = yenipozisyon;
    }
}
