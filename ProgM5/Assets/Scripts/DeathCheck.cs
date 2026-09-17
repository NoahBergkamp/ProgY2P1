using System;
using Unity.VisualScripting;
using UnityEngine;

public class DeathCheck : MonoBehaviour
{
    private int health = 2;
    private bool death = false;
    public static event Action OnEnemyDeath;
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        health--;
        
        if (health <= 0 )
        {
            OnDeath(true); return;
        }
    }

    void OnDeath(bool death)
    {
        if (death == true)
        {
            OnEnemyDeath?.Invoke();
        }
    }
}
