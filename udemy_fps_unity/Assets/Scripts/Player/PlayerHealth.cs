using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float health = 200f;

    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            GetComponent<DeathHandler>().HandleDeath();
        }
    }
}
