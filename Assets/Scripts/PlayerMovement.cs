using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    NavMeshAgent myAgent;

    [SerializeField] Camera mainCamera;
    [SerializeField] LayerMask layerMask;

    private Quaternion initRot;

    private void Start()
    {
        myAgent = GetComponent<NavMeshAgent>();
        initRot = transform.rotation;
    }

    private void Update()
    {
        transform.rotation = initRot;

        if (Input.GetMouseButtonDown(1))
        {
           
            RaycastHit hit;
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                myAgent.SetDestination(hit.point);
            }
        }
    }
}
