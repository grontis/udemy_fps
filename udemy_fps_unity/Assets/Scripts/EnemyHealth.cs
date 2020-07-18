using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private float hitPoints = 100;
    
    //TODO create public method to decrease hitpoints

    public void TakeDamage(float damage)
    {

        hitPoints -= damage;

        if(hitPoints <= 0)
        {
            hitPoints = 0;
            Destroy(gameObject);
            //TODO enemy death actions
        }
    }
}
