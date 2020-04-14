﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullScreen : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        Vector3 tempScale = transform.localScale;

        float spriteGenislik = spriteRenderer.size.x;
        float ekranYükseklik = Camera.main.orthographicSize * 2.0f;
        float ekranGenislik = ekranYükseklik / Screen.height * Screen.width;
        tempScale.x = ekranGenislik / spriteGenislik;
        transform.localScale = tempScale;
    }

    // Update is called once per frame
    void Update()
    {
    }
}