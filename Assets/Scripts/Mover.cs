using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private float yValue = 0f;
    Rigidbody rb;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(x, yValue, z);
        TestCallingMethods();
    }

    void TestCallingMethods()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space key was pressed");
        }

        if(Input.GetKey(KeyCode.T))
        {
            rb = GetComponent<Rigidbody>();
            rb.mass = 10;
            rb.useGravity = true;
            GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
