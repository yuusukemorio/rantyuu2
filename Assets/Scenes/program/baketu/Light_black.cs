using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Light_black : MonoBehaviour
{
    Light lt;
    float SceneTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        lt = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        SceneTime += Time.deltaTime;
        if (SceneTime >= 55)
        {
            SceneManager.LoadScene("anten");
        }
        else
        {
            //lt.color -= (Color.white / 250.0f) * Time.deltaTime;
        }
    }
}
