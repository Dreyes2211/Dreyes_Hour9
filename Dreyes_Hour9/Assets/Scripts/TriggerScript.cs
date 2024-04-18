using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{

    public int collisioncount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name + " entered cube's trigger");
        Debug.Log(collisioncount += 1);
    }
    
    private void OnTriggerStay(Collider other)
    {
        Debug.Log(other.gameObject.name + " is in cube's trigger");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.gameObject.name + " left cube's trigger");
    }
}
