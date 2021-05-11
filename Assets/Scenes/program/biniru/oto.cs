using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class oto : MonoBehaviour
{
    AudioSource AS;
    float WeitTime = 0;
    float AudioTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        AS = GetComponent<AudioSource>();
        AS.volume = 0.4f;
    }

    // Update is called once per frame
    void Update()
    {
        WeitTime += Time.deltaTime;
        if(WeitTime >= 20)
        {
            AS.volume += Time.deltaTime / 5;
        }
        if (WeitTime >= 28)
        {
            SceneManager.LoadScene("biniru_ie");
        }
    }
}
