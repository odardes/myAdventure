using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class ReklamKontrol : MonoBehaviour
{
    string gameId = "3555013";
    bool testMode = true;

    void Start()
    {
        Advertisement.Initialize(gameId, testMode);
    }

    public void reklamgoster()
    {
        Advertisement.Show();
    }
}
