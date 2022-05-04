using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minion : MonoBehaviour
{
    [SerializeField] ParticleSystem bloodParticle = null;

    public HealthBar minionHealthBar;
    float health = 150f;

    void OnTriggerEnter(Collider other)
    {
        AOE aOE = other.GetComponent<AOE>();
        PlayerHealth playerHealth = other.GetComponentInParent<PlayerHealth>();
        
        if (aOE.IsActive() && aOE != null)
        {
            TakeDamage();
        }
    }
    public void TakeDamage()
    {
        health -= 50f;
        bloodParticle.Play();
        minionHealthBar.SetHealth(health);

        if (health <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
