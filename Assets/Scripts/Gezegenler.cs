using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gezegenler : MonoBehaviour
{
    List<GameObject> gezegenler = new List<GameObject>();
    List<GameObject> kullanılangezegenler = new List<GameObject>();
    void Awake()
    {
        Object[] sprites = Resources.LoadAll("Gezegenler");
        for (int i = 1; i < 17; i++)
        {
            GameObject gezegen = new GameObject();
            SpriteRenderer srenderer = gezegen.AddComponent<SpriteRenderer>();
            srenderer.sprite = (Sprite)sprites[i];
            Color spritecolor = srenderer.color;
            spritecolor.a = 0.5f;
            srenderer.color = spritecolor;
            gezegen.name = sprites[i].name;
            srenderer.sortingLayerName = "Gezegen";
            Vector2 pozisyon = gezegen.transform.position;
            pozisyon.x = -10;
            gezegen.transform.position = pozisyon;
            gezegenler.Add(gezegen);
        }
    }

    public void gezegenyerlestir(float refy)
    {
        float yukseklik = EkranHesaplayici.instance.Yukseklik;
        float genislik = EkranHesaplayici.instance.Genislik;
        //1.bölge
        float x1 = Random.Range(0.0f, genislik);
        float y1 = Random.Range(refy, refy + yukseklik);
        GameObject gezegen1 = randomgezegen();
        gezegen1.transform.position = new Vector2(x1, y1);
        //2.bölge
        float x2 = Random.Range(-genislik, 0.0f);
        float y2 = Random.Range(refy, refy + yukseklik);
        GameObject gezegen2 = randomgezegen();
        gezegen2.transform.position = new Vector2(x2, y2);
        //3.bölge
        float x3 = Random.Range(-genislik,0.0f);
        float y3 = Random.Range(refy-yukseklik, refy);
        GameObject gezegen3 = randomgezegen();
        gezegen3.transform.position = new Vector2(x3, y3);
        //4.bölge
        float x4 = Random.Range(0.0f, genislik);
        float y4 = Random.Range(refy-yukseklik, refy);
        GameObject gezegen4 = randomgezegen();
        gezegen4.transform.position = new Vector2(x4, y4);
    }
    GameObject randomgezegen()
    {
        if (gezegenler.Count > 0)
        {
            int random;
            if (gezegenler.Count == 1)
            {
                random = 0;
            }
            else
            {
                random = Random.Range(0, gezegenler.Count - 1);
            }
            GameObject gezegen = gezegenler[random];
            gezegenler.Remove(gezegen);
            kullanılangezegenler.Add(gezegen);
            return gezegen;
        }
        else
        {
            for (int i = 0; i < 8; i++)
            {
                gezegenler.Add(kullanılangezegenler[i]);
            }
            kullanılangezegenler.RemoveRange(0, 8);
            int random = Random.Range(0, 8);
            GameObject gezegen = gezegenler[random];
            gezegenler.Remove(gezegen);
            kullanılangezegenler.Add(gezegen);
            return gezegen;
        }
    }
}
