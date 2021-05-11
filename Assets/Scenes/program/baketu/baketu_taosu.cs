using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class baketu_taosu : MonoBehaviour
{
    Animator Anima;
    public static string taositaka = "no";
    float x = 0;
    bool a = false;
    // Start is called before the first frame update
    void Start()
    {
        Anima = GetComponent<Animator>();
        Anima.SetInteger("taosu_anima", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (a == true)
        {
            Anima.SetInteger("taosu_anima", 1);
            taositaka = "yes";
            x += Time.deltaTime;
            if (x >= 1.2)
            {
                SceneManager.LoadScene("anten");
            }
        }
    }

    public void taosu()
    {
        if (anten2.day >= 1)
        {
            a = true;
        }
    }
}
