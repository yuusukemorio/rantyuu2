using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idou : MonoBehaviour
{
    public float speed = 5;
    public float OFset_kieru;
    public float OFset_arawareru;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(-21.2f, 12.91727f, transform.position.z + speed);
        if(transform.position.z >= OFset_kieru)
        {
            transform.position = new Vector3(-21.2f, 12.91727f, OFset_arawareru);
        }
    }
}
