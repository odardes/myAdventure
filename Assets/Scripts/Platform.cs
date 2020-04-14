using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    PolygonCollider2D polygonCollider2D;
    bool hareket;
    float randomHız;
    float min, max;

    public bool Hareket
    {
        get
        {
            return hareket;
        }
        set
        {
            hareket = value;
        }
    }

    void Start()
    {
        polygonCollider2D = GetComponent<PolygonCollider2D>();
        if (KayıtAlanı.kolaydegeroku() == 1)
        {
            randomHız = Random.Range(0.2f, 0.8f);

        }
        if (KayıtAlanı.ortadegeroku() == 1)
        {
            randomHız = Random.Range(0.5f, 1.0f);

        }
        if (KayıtAlanı.zordegeroku() == 1)
        {
            randomHız = Random.Range(0.8f, 1.5f);

        }

        float objeGenislik= polygonCollider2D.bounds.size.x / 2;  //colliderin yarı boyunu al

        if (transform.position.x > 0)  //sağdaysa
        {
            min = objeGenislik;
            max = EkranHesaplayici.instance.Genislik-objeGenislik;
        }else  //soldaysa
        {
            min = -EkranHesaplayici.instance.Genislik + objeGenislik;
            max = -objeGenislik;
        }
    }

    void Update()
    {
        if (hareket)
        {
            float pingpongx = Mathf.PingPong(Time.time*randomHız, max-min)+min;
            Vector2 pingpong = new Vector2(pingpongx, transform.position.y);
            transform.position = pingpong;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        {
            if (collision.gameObject.tag == "Ayak")
            {
                GameObject.FindGameObjectWithTag("Player").transform.parent = transform;
                GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<OyuncuHareket>().ziplamayisifirla();
            }
        }
    }

}