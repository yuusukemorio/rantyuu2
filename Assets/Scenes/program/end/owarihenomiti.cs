using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class owarihenomiti : MonoBehaviour
{
    float weitTime = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        weitTime += Time.deltaTime;
        if (weitTime >= 15)
        {
            SceneManager.LoadScene("end");
        }
    }
}