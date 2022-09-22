using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    //[SerializeField] private float speed;
    [SerializeField] private Rigidbody projectileBody;
    [SerializeField] private int projectileDamage = 20;
    private int powerPickup;
    private bool isActive;
    private int powerPickupDamage;
    
    public void Initialize(int pickupAmount, int pickupDamage)
    {
        
        isActive = true;
        // -------- This method is for projectiles that have a parabole. ----------
        // We add a force only once, not every frame
        // Make sure to have "useGravity" toggled on in the rigid body
        projectileBody.AddForce(transform.forward * 700f + transform.up * 300f);
        powerPickup = pickupAmount;
        powerPickupDamage = pickupDamage;


    }
    
    void Update()
    {
        if (isActive)
        {
            // -------- This method is for projectiles that go in a straight line. ----------
            // We change the position every frame
            // Make sure to have "useGravity" toggled off in the rigid body, otherwise it will fall as it flies (unless that's what you want)

            // Use either the following line (movement with the rigid body)
            //projectileBody.MovePosition(transform.position + transform.forward * speed * Time.deltaTime);
            
            // or this one (movement with the transform), both are ok
            //transform.Translate(transform.forward * speed * Time.deltaTime);
            
        }    
    }

    private void OnCollisionEnter(Collision collision) 
    {
        GameObject collisionObject = collision.gameObject ;
        DestructionFree destruction = collisionObject.GetComponent<DestructionFree>();
        if (destruction == null)
        {
            // Destroy(collisionObject);   
            Destroy(gameObject);
        }

        if (collisionObject.tag == "Player")
        {
            
            if (powerPickup == 0)
            {
                collisionObject.GetComponent<PlayerHealth>().TakeDamage(projectileDamage);
            }

            else
            {
                collisionObject.GetComponent<PlayerHealth>().TakeDamage(projectileDamage + (powerPickup * powerPickupDamage));    
            }
            
            
        }
        
    }
}
