using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float damage = 30f;

    void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<HealthScript>().TakeDamage(damage);
    }


}

