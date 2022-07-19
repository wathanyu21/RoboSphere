using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    NavMeshAgent agent;
    public GameObject cube;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray;
            RaycastHit hit;
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (agent.SetDestination(hit.point))
                {
       
                }


            }
            

        }




    }
}
