using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    [SerializeField] private Animator animator;
    void Update()
    {
        bool isShooting = Input.GetKeyDown(KeyCode.V); 
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