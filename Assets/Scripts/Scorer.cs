using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "Hit")
        {
            hits = hits + 1;    // or hits++;
            Debug.Log("You have bumped into a thing this many times:" + hits);
        }
    }
}
