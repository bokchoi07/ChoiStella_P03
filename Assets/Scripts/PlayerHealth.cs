using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float maxHealth = 200f;
    [SerializeField] float currHealth = 20f;
    [SerializeField] ParticleSystem healParticle = null;

    public HealthBar healthBar;

    private void Start()
    {
        healthBar.SetHealth(currHealth);
    }

    public void Heal()
    {
        currHealth += ((maxHealth - currHealth) * .15f);
        healthBar.SetHealth(currHealth);
        healParticle.Play();
    }
}
