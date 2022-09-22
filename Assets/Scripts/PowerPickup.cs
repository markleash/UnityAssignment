using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerPickup : MonoBehaviour
{
    [SerializeField] public int powerAmount = 16;
    public int pickedUpAmount;

    private void OnCollisionEnter(Collision other)
    {
        GameObject collisionObject = other.gameObject;
        
        if (other.gameObject.tag == "Player")
        {
            
            collisionObject.GetComponent<CharacterWeapon>().IncreasePickup();
            Destroy(gameObject);
        }
    }
}
