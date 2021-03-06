using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] ParticleSystem bloodParticle = null;

    public HealthBar enemyHealthBar;
    float health = 200f;

    void OnTriggerEnter(Collider other)
    {
        AOE aOE = other.GetComponent<AOE>();
        PlayerHealth playerHealth = other.GetComponentInParent<PlayerHealth>();

        if(aOE.IsActive() && aOE != null)
        {
            TakeDamage();
            playerHealth.Heal();
        }
    }

    public void TakeDamage()
    {
        health -= 50f;
        bloodParticle.Play();
        enemyHealthBar.SetHealth(health);

        if(health <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
