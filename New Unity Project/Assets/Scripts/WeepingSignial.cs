using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WeepingSignial : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Gargoyle")
        {
            other.GetComponent<NavMeshAgent>().speed = 0;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Gargoyle")
        {
            other.GetComponent<NavMeshAgent>().speed = 0.75f;
        }
    }
}
