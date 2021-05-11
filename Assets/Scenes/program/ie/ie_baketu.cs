using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ie_baketu : MonoBehaviour
{
    float WeitTime = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        WeitTime += Time.deltaTime;
        if (WeitTime >= 9.5)
        {
            SceneManager.LoadScene("baketu");
        }
    }
}
