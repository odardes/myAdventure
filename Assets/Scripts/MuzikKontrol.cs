﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuzikKontrol : MonoBehaviour
{
    public static MuzikKontrol instance;
    AudioSource audioSource;
    void Awake()
    {
        Singleton();
        audioSource = GetComponent<AudioSource>();
    }

   void Singleton()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance=this;
            DontDestroyOnLoad(instance); //sahneler arası geçişte çalmaya devam etsin
        }
    }

    public void muzikcal(bool play)
    {
        if (play)
        {

            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        else
        {
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }
        }
    }
}
