using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaAnimation : MonoBehaviour
{
    public Animator ani;

    void Awake()
    {
        ani = GetComponent<Animator>();
    }

    void Update()
    {
        if(ScoreManager.Instance.mana >= 10)
        {
            ani.SetBool("is10%", true);
        }
        
    }

}

