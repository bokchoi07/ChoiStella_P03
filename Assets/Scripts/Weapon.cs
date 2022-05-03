using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject axeAOE;
    public GameObject axe;

    void Start()
    {
        axeAOE.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            StartCoroutine(WaitForSwing());
        }
    }

    private IEnumerator WaitForSwing()
    {
        yield return new WaitForSeconds(.75f); // "hefts his axe for .75 seconds"
        
        axeAOE.SetActive(true);
        
        yield return new WaitForSeconds(.5f);

        axeAOE.SetActive(false);
        
    }
}
