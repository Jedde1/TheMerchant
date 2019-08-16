using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript1 : MonoBehaviour
{
    public Image healthbar;
    public float maxHealth = 100f;
    public static float curHealth = 0f;

    void Start()
    {
        curHealth = maxHealth;
        SetHealthBar();

    }

    public void TakeDamage(float amount)
    {
        curHealth -= amount;
        if(curHealth <= 0)
        {
            Destroy(gameObject);
        }
        SetHealthBar();
    }

    public void SetHealthBar()
    {
        float myHealth = curHealth / maxHealth;
        healthbar.transform.localScale = new Vector3(Mathf.Clamp(myHealth, 0f, 1f), healthbar.transform.localScale.y, healthbar.transform.localScale.x);
    }
}

