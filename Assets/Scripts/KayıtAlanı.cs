using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static public class KayıtAlanı
{
    public static string kolay = "kolay";
    public static string orta = "orta";
    public static string zor = "zor";
    public static string kolaypuan = "kolaypuan";
    public static string ortapuan = "ortapuan";
    public static string zorpuan = "zorpuan";
    public static string kolayaltın = "kolayaltın";
    public static string ortaaltın = "ortaaltın";
    public static string zoraltın = "zoraltın";
    public static string muzikacık = "muzikacık";


    public static void kolaydegerata(int kolay)
    {
        PlayerPrefs.SetInt(KayıtAlanı.kolay,kolay);
    }

    public static int kolaydegeroku()
    {
       return PlayerPrefs.GetInt(KayıtAlanı.kolay);
    }
    public static void ortadegerata(int orta)
    {
        PlayerPrefs.SetInt(KayıtAlanı.orta, orta);
    }
    public static int ortadegeroku()
    {
        return PlayerPrefs.GetInt(KayıtAlanı.orta);
    }
    public static void zordegerata(int zor)
    {
        PlayerPrefs.SetInt(KayıtAlanı.zor, zor);
    }
    public static int zordegeroku()
    {
        return PlayerPrefs.GetInt(KayıtAlanı.zor);
    }

    /*--------------------------------------------------------------*/

    public static void kolaypuandegerata(int kolay)
    {
        PlayerPrefs.SetInt(KayıtAlanı.kolaypuan, kolay);
    }

    public static int kolaypuandegeroku()
    {
        return PlayerPrefs.GetInt(KayıtAlanı.kolaypuan);
    }
    public static void ortapuandegerata(int orta)
    {
        PlayerPrefs.SetInt(KayıtAlanı.ortapuan, orta);
    }
    public static int ortapuandegeroku()
    {
        return PlayerPrefs.GetInt(KayıtAlanı.ortapuan);
    }
    public static void zorpuandegerata(int zor)
    {
        PlayerPrefs.SetInt(KayıtAlanı.zorpuan, zor);
    }
    public static int zorpuandegeroku()
    {
        return PlayerPrefs.GetInt(KayıtAlanı.zorpuan);
    }

    /*-------------------------------------------------------------------------*/

    public static void kolayaltındegerata(int kolay)
    {
        PlayerPrefs.SetInt(KayıtAlanı.kolayaltın, kolay);
    }

    public static int kolayaltındegeroku()
    {
        return PlayerPrefs.GetInt(KayıtAlanı.kolayaltın);
    }
    public static void ortaaltındegerata(int orta)
    {
        PlayerPrefs.SetInt(KayıtAlanı.ortaaltın, orta);
    }
    public static int ortaaltındegeroku()
    {
        return PlayerPrefs.GetInt(KayıtAlanı.ortaaltın);
    }
    public static void zoraltındegerata(int zor)
    {
        PlayerPrefs.SetInt(KayıtAlanı.zoraltın, zor);
    }
    public static int zoraltındegeroku()
    {
        return PlayerPrefs.GetInt(KayıtAlanı.zoraltın);
    }

    /*----------------------------------------------------------------*/

    public static void muzikacıkdegerata(int muzikacık)
    {
        PlayerPrefs.SetInt(KayıtAlanı.muzikacık, muzikacık);
    }
    public static int muzikacıkdegeroku()
    {
        return PlayerPrefs.GetInt(KayıtAlanı.muzikacık);
    }



    public static bool kayıtvarmı()
    {
        if(PlayerPrefs.HasKey(KayıtAlanı.kolay) || PlayerPrefs.HasKey(KayıtAlanı.orta)|| PlayerPrefs.HasKey(KayıtAlanı.zor))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool muzikacıkvarmı()
    {
        if (PlayerPrefs.HasKey(KayıtAlanı.muzikacık))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
