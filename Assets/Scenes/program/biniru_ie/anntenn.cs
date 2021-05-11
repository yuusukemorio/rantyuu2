using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class anntenn : MonoBehaviour
{
    float WeitTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        //お祭りから帰ってきたときの暗転
    }

    // Update is called once per frame
    void Update()
    {
        WeitTime += Time.deltaTime;
        if (WeitTime >= 26.5)
        {
            SceneManager.LoadScene("ie");
        }
    }
}
