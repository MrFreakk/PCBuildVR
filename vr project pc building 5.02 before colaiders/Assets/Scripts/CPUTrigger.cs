using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPUTrigger : MonoBehaviour
{
    public GameObject motherBoardCPU;
    //private FixedJoint motherBoaedCPUJoint;
    //private Rigidbody CPURigidbody;
    
    public bool TriggerCheck = false;

    
    private void OnTriggerEnter(Collider CPU)
    {
        if (CPU.gameObject.tag == "CPU")
        {
            TriggerCheck = true;
            
        }
    }
    
}

    




