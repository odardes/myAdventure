﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EkranHesaplayici : MonoBehaviour
{
    public static EkranHesaplayici instance;

    float yukseklik;
    float genislik;

    public float Yukseklik
    {
        get
        {
            return yukseklik;
        }
    }
    public float Genislik
    {
        get
        {
            return genislik;
        }
    }

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }else if(instance != this){
            Destroy(gameObject);
        }

        yukseklik = Camera.main.orthographicSize;
        genislik = yukseklik * Camera.main.aspect;

    }

    void Update()
    {
        
    }
}
