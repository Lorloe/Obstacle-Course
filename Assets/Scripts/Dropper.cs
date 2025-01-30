using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 3f;
    // Start is called before the first frame update
    MeshRenderer mr;
    Rigidbody rb;

    void Start()
    {
        mr = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();

        mr.enabled = false;
        rb.useGravity = false;

        // GetComponent<MeshRenderer>().material.color = Color.red;
        // GetComponent<MeshRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timeToWait)
        {
            // Debug.Log("You need to stop");
            mr.enabled = true;
            rb.useGravity = true;
            // Debug.Log("Thời gian kể từ khi" + Time.time + "giây");
        }
        // Debug.Log("Thời gian kể từ khi" + Time.time + "giây");
    }
}
