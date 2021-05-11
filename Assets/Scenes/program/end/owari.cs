using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class owari : MonoBehaviour
{
    float weitTime = 0;
    // Start is called before the first frame update
    void Start()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_STANDALONE
      UnityEngine.Application.Quit();
#endif
    }

    // Update is called once per frame
    void Update()
    {
//        weitTime += Time.deltaTime;
//        if (weitTime >= 15)
//        {
//#if UNITY_EDITOR
//            UnityEditor.EditorApplication.isPlaying = false;
//#elif UNITY_STANDALONE
//      UnityEngine.Application.Quit();
//#endif
//        }
    }
}
