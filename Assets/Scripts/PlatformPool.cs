using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformPool : MonoBehaviour
{
    [SerializeField]
    GameObject platformPrefab=default;
    [SerializeField]
    GameObject olumculplatformPrefab = default;
    [SerializeField]
    GameObject playerPrefab = default;
    [SerializeField]
    float platformArasıMesafe = default;
    List<GameObject> platforms = new List<GameObject>();
    Vector2 platformPosition;
    Vector2 playerPosition;

    void Start()
    {
        platformUret();
    }

    void Update()
    {
        if (platforms[platforms.Count - 1].transform.position.y<Camera.main.transform.position.y+EkranHesaplayici.instance.Yukseklik)
        {
            Platformyerleştir();
        }
    }

    void platformUret()
    {
        platformPosition = new Vector2(0, 0);
        playerPosition = new Vector2(0, 0.5f);

        GameObject player = Instantiate(playerPrefab, playerPosition, Quaternion.identity);
        GameObject ilkplatform = Instantiate(platformPrefab, platformPosition, Quaternion.identity);
        player.transform.parent = ilkplatform.transform;
        platforms.Add(ilkplatform);
        sonrakiPlatformPosizyon();
        ilkplatform.GetComponent<Platform>().Hareket = true;
        for (int i =0; i<8; i++)
        {
            GameObject platform = Instantiate(platformPrefab, platformPosition, Quaternion.identity);
            platforms.Add(platform);
            platform.GetComponent<Platform>().Hareket = true;
            if (i % 2 == 0)
            {
                platform.GetComponent<Altın>().Altınac();
            }
            sonrakiPlatformPosizyon();
        }
        GameObject olumculplatform = Instantiate(olumculplatformPrefab, platformPosition, Quaternion.identity);
        olumculplatform.GetComponent<PlatformZararlı>().Hareket = true;
        platforms.Add(olumculplatform);
        sonrakiPlatformPosizyon();
    }

    void Platformyerleştir()
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject temp;
            temp = platforms[i + 5];
            platforms[i + 5] = platforms[i];
            platforms[i] = temp;
            platforms[i + 5].transform.position = platformPosition;
            if(platforms[i + 5].gameObject.tag == "Platform")
            {
                platforms[i + 5].GetComponent<Altın>().Altınkapat();
                float rastgele = Random.Range(0.0f, 1.0f);
                if (rastgele < 0.5f)
                {
                    platforms[i + 5].GetComponent<Altın>().Altınac();
                }
            }
            sonrakiPlatformPosizyon();
        }
    }

    void sonrakiPlatformPosizyon()
    {
        platformPosition.y += platformArasıMesafe;
        SıralıPozisyon();
    }

    void KarmaPozisyon()
    {
        float random = Random.Range(0.0f, 1.0f);
        if (random < 0.5f)
        {
            platformPosition.x = EkranHesaplayici.instance.Genislik / 2;
        }
        else
        {
            platformPosition.x = -EkranHesaplayici.instance.Genislik / 2;
        }
    }
    bool yon = true;
    void SıralıPozisyon()
    {
        if (yon)
        {
            platformPosition.x = EkranHesaplayici.instance.Genislik / 2;
            yon = false;
        }
        else
        {
            platformPosition.x = -EkranHesaplayici.instance.Genislik / 2;
            yon = true;
        }
    }
}