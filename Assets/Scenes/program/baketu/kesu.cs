using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kesu : MonoBehaviour
{
    float weittime;
    string OBJname;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(esa.esa_count_STATIC <= 40)
        {
            if (OBJname == "mizu_yuka")
            {
                weittime += Time.deltaTime;
                if (weittime >= 5)
                {
                    Destroy(this.gameObject);
                }
            }
        }


    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "mizu_yuka")
        {
            OBJname = "mizu_yuka";
        }
    }
}
