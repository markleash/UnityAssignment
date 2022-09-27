using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private PlayerTurn playerTurn;
    [SerializeField] private Timer timer;
    void Update()
    {
        bool isShooting = Input.GetKeyDown(KeyCode.F); 
        if (isShooting)
        {
            animator.SetTrigger("AttackTrigger");
        }

        bool isWalking = Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0;
        if (isWalking)
        {
            animator.SetBool("IsWalking", true);
        }
        else
        {
            animator.SetBool("IsWalking", false);
        }

        if (!isWalking && !isShooting)
        {
            animator.SetBool("Idle", true);
        }
        
    }
}
