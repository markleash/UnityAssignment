using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterWeapon : MonoBehaviour
{
    [SerializeField] private PlayerTurn playerTurn;
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private Transform shootingStartPosition;
    [SerializeField] private LineRenderer lineRenderer;

    
    //[SerializeField] private CharacterController newWeaponPosition;


    private void Update()
    {

    //  newWeaponPosition.transform.rotation = shootingStartPosition.transform.rotation;
    
        if (Input.GetKeyDown(KeyCode.V))
        {
            bool IsPlayerTurn = playerTurn.IsPlayerTurn();
            if (IsPlayerTurn)
            {
                TurnManager.GetInstance().TriggerChangeTurn();
                GameObject newProjectile = Instantiate(projectilePrefab);
                newProjectile.transform.position = shootingStartPosition.position;
                newProjectile.transform.rotation = shootingStartPosition.rotation;
                newProjectile.GetComponent<Projectile>().Initialize();
                //GetComponent<Animator>().SetTrigger("attack");
                //GetComponent<Animator>().SetTrigger("idle");
            }
        }
    }
}
