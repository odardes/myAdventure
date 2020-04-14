using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ekrandatut : MonoBehaviour
{
    void Update()
    {
        if (transform.position.x < -EkranHesaplayici.instance.Genislik)
        {
            Vector2 temp = transform.position;
            temp.x = -EkranHesaplayici.instance.Genislik;
            transform.position = temp;
        }
        if (transform.position.x > EkranHesaplayici.instance.Genislik)
        {
            Vector2 temp = transform.position;
            temp.x = EkranHesaplayici.instance.Genislik;
            transform.position = temp;
        }
    }
}
