using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerControls : MonoBehaviour
{
    public static Animator animator;
    public Rigidbody2D wilta;

    // Start is called before the first frame update
    void Awake()
    {
        animator = GetComponent<Animator> ();

    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("isAttackingHigh", Input.GetKeyDown(KeyCode.Space));
        animator.SetBool("isAttackingMid", Input.GetKeyDown(KeyCode.Space));
        animator.SetBool("isAttackingLow", Input.GetKeyDown(KeyCode.Space));
        animator.SetBool("isWalking", wilta.velocity.x > 0);

        //if(HealthScript.curHealth <= 1)
        {
            //animator.SetBool("Gobo1",true);
        }

    }
}
