using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float maxDistanceDelta = 30f;
    Vector3 playerPos;
    
    private void Awake() 
    {
        gameObject.SetActive(false);
    }

    void Start()
    {
        playerPos = player.transform.position;
    }

    void Update()
    {
        MoveToPlayer();
        DestroyWhenReach();
    }

    void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPos, maxDistanceDelta * Time.deltaTime);
    }

    void DestroyWhenReach()
    {
        if (transform.position == playerPos)
        {
            Destroy(gameObject);
        }
    }
}
