using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class esa : MonoBehaviour
{
    public GameObject obj;
    public int esa_ryou = 30;
    public float esa_matu = 0.1f;
    float weittime;

    public int esa_count = 0;
    public static int esa_count_STATIC = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        esa_count_STATIC = esa_count;
    }
    public void esadayo()
    {
        weittime += Time.deltaTime;
        if (weittime >= esa_matu)
        {
            Instantiate(obj, new Vector3(Random.Range(-0.8f, -1.5f), Random.Range(2.2f, 2.5f), Random.Range(-1f, -1.6f)), Quaternion.identity);
            weittime = 0;
            esa_count += 1;
            Debug.Log(esa_count);
        }
    }
}
