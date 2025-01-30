using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private float spinSpeed = 90f;
    [SerializeField] private float xAngle = 0;
    [SerializeField] private float yAngle = 1;
    [SerializeField] private float zAngle = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xAngle * Time.deltaTime, yAngle * spinSpeed * Time.deltaTime, zAngle * Time.deltaTime);
        // transform.Rotate(Vector3.forward, spinSpeed * Time.deltaTime);
        // transform.Rotate(Vector3.right, spinSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up, spinSpeed * Time.deltaTime);
    }
}
