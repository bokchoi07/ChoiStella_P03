using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AOE : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Enemy enemy = other.gameObject.GetComponent<Enemy>();
        PlayerHealth playerHealth = GetComponentInParent<PlayerHealth>();
        if (enemy != null)
        {
            Debug.Log("enemy took damage");
            enemy.TakeDamage(); // just say 50f is the damage per strike
            playerHealth.Heal();
        }
    }
}
