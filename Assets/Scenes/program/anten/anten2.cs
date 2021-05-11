using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//よく使う方の暗転

public class anten2 : MonoBehaviour
{
    float weittime = 0;
    public static int day = 0; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(baketu_taosu.taositaka == "yes")
        {
            weittime += Time.deltaTime;
            if (weittime >= 1.5)
            {
                SceneManager.LoadScene("si_baketu_taoreta");
            }
        }
        else if(esa.esa_count_STATIC >= 70)
        {
            weittime += Time.deltaTime;
            if(weittime >= 1.5)
            {
                SceneManager.LoadScene("si_esa_yarisugi");
            }
        }
        else if (esa.esa_count_STATIC <= 40)
        {
            weittime += Time.deltaTime;
            if (weittime >= 1.5)
            {
                SceneManager.LoadScene("si_esa_agenasasugi");
            }
        }
        else
        {
            weittime += Time.deltaTime;
            if (weittime >= 3)
            {
                SceneManager.LoadScene("baketu");
                esa.esa_count_STATIC = 0;
                day += 1;
            }
        }
    }
}
