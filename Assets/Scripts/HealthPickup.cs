using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
   [SerializeField] private int healthAmount = 13;

   private void OnCollisionEnter(Collision collision)
   {
      GameObject collisionObject = collision.gameObject ;
      
      if (collision.gameObject.tag == "Player")
      {
         collisionObject.GetComponent<PlayerHealth>().IncreaseHealth(healthAmount);
         Destroy(gameObject);
      }
   }
}
