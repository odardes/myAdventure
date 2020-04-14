using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltınAlgilayici : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ayak")
        {
            GetComponentInParent<Altın>().Altınkapat();
            FindObjectOfType<Puan>().altinkazan();
        }
    }
}
