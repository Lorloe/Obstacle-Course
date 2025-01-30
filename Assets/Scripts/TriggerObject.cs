using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerObject : MonoBehaviour
{
    [SerializeField] private GameObject Nibiru;
    [SerializeField] private GameObject Nibiru1;
    [SerializeField] private GameObject Nibiru2;
    [SerializeField] private GameObject Nibiru3;
    [SerializeField] private GameObject Nibiru4;

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag == "Player")
        {
            Nibiru.SetActive(true);
            Nibiru1.SetActive(true);
            Nibiru2.SetActive(true);

            if(Nibiru3 != null)
            {
                Nibiru3.SetActive(true);
            }
            Nibiru4.SetActive(true);    

            Debug.Log("Player entered the trigger");
            Destroy(gameObject);
        }    
    }
}
