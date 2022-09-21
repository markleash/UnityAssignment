using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody projectileBody;
    [SerializeField] private int projectileDamage = 20;
    private bool isActive;
    
    public void Initialize()
    {
        isActive = true;
        // -------- This method is for projectiles that have a parabole. ----------
        // We add a force only once, not every frame
        // Make sure to have "useGravity" toggled on in the rigid body
        projectileBody.AddForce(transform.forward * 700f + transform.up * 300f);
    }
    
    void Update()
    {
        if (isActive)
        {
            // -------- This method is for projectiles that go in a straight line. ----------
            // We change the position every frame
            // Make sure to have "useGravity" toggled off in the rigid body, otherwise it will fall as it flies (unless thats what you want)

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
            collisionObject.GetComponent<PlayerHealth>().TakeDamage(projectileDamage);
            // GetComponent<PlayerHealth>().TakeDamage(20);
        }
        
    }
}
