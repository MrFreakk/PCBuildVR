using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestFixedJoin : MonoBehaviour
{
    public FixedJoint joint;
    
    public Rigidbody child;
    
    private void OnCollisionEnter(Collision collisison)
    {
        if (collisison.gameObject.name == "UsefullComputer")
        {
            joint.connectedBody = child;
        }     

    }
}
