using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float maxHealth = 200f;
    [SerializeField] float currHealth = 10f;
    [SerializeField] ParticleSystem healParticle;

    public HealthBar healthBar;

    private void Start()
    {
        healthBar.SetHealth(currHealth);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            currHealth += 50f;
    }

    /*public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;

        fill.color = gradient.Evaluate(1f);
    }*/

    public void Heal()
    {
       
        currHealth += ((maxHealth - currHealth) * .15f);
        healthBar.SetHealth(currHealth);
        healParticle.Play();
    }
    /*public void Heal(int numHit)
    {
        if(numHit == 1)
        {
            currHealth += ((maxHealth - currHealth) * .15f); // healing 15% for 1 enemy hit
        }
        if (numHit == 2)
        {
            currHealth += ((maxHealth - currHealth) * .30f); // healing 15% for 2 enemy hit
        }
        if (numHit >= 3)
        {
            currHealth += ((maxHealth - currHealth) * .45f); // healing 15% for 3 or more enemy hit
        }
    }*/
}
