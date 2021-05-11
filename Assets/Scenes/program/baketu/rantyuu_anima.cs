using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rantyuu_anima : MonoBehaviour
{
    Animator Anima;
    float a = 0;
    string OBJname;

    public esa esadayo;
    // Start is called before the first frame update
    void Start()
    {
        Anima = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (esadayo.esa_count >= 40)
        {
            if (a >= 0)
            {
                Anima.SetFloat("rantyuu_speed", a -= Time.deltaTime / 5f);
            }
        }
        else
        {
            if (a >= 0 && a <= 1)
            {
                Anima.SetFloat("rantyuu_speed", a += Time.deltaTime / 5f);
            }
        }
    }
}
