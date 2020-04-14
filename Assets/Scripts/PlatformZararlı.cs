using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformZararlı : MonoBehaviour
{
    BoxCollider2D boxCollider2D;
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
        boxCollider2D = GetComponent<BoxCollider2D>();
        randomHız = Random.Range(0.5f, 1.0f);

        float objeGenislik = boxCollider2D.bounds.size.x / 2;  //colliderin yarı boyunu al

        if (transform.position.x > 0)  //sağdaysa
        {
            min = objeGenislik;
            max = EkranHesaplayici.instance.Genislik - objeGenislik;
        }
        else  //soldaysa
        {
            min = -EkranHesaplayici.instance.Genislik + objeGenislik;
            max = -objeGenislik;
        }
    }

    void Update()
    {
        if (hareket)
        {
            float pingpongx = Mathf.PingPong(Time.time * randomHız, max - min) + min;
            Vector2 pingpong = new Vector2(pingpongx, transform.position.y);
            transform.position = pingpong;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ayak")
        {
            FindObjectOfType<OyunKontrol>().OyunuBitir();
        }
    }
}
