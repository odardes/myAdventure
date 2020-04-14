using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Altın : MonoBehaviour
{
    [SerializeField]
    GameObject altın = default;

    public void Altınac()
    {
        altın.SetActive(true);
    }
    public void Altınkapat()
    {
        altın.SetActive(false);
    }
}
