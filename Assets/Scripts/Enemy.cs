using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] ParticleSystem bloodParticle;

    float health = 50f;
    public void TakeDamage()
    {
        health -= 50f;
        bloodParticle.Play();
    }
}
