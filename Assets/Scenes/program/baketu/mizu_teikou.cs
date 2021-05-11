using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mizu_teikou : MonoBehaviour
{
    Rigidbody rb;
    string waterTag = "Water";
    public float waterDrag = 3.0f;
    float defaultDrag = 0.0f;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        defaultDrag = rb.drag;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == waterTag)
        {
            // 水の中の抵抗をセット
            rb.drag = waterDrag;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == waterTag)
        {
            // 通常の抵抗をセット
            rb.drag = defaultDrag;
        }
    }
}
