using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerPickup : MonoBehaviour
{
    [SerializeField] private int powerAmount = 16;

    private void OnCollisionEnter(Collision other)
    {
        GameObject collisionObject = other.gameObject;
        
        if (other.gameObject.tag == "Player")
        {
            collisionObject.GetComponent<PlayerHealth>().IncreaseHealth(powerAmount);
            Destroy(gameObject);
        }
    }
}
