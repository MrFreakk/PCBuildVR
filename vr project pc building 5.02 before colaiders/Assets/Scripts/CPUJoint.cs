using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPUJoint : MonoBehaviour
{
    private FixedJoint CpuJoint;
    private Rigidbody collisionRigidBody;
        
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "CPUTrigger")
        {
            if (gameObject.GetComponent<FixedJoint>() == false)
            {
                gameObject.AddComponent<FixedJoint>();
                CpuJoint = gameObject.GetComponent<FixedJoint>();
                collisionRigidBody = other.gameObject.GetComponent<Rigidbody>();
                CpuJoint.connectedBody = collisionRigidBody;
            }
            else if (gameObject.GetComponent<FixedJoint>() == true)
            {
                CpuJoint = gameObject.GetComponent<FixedJoint>();
                collisionRigidBody = other.gameObject.GetComponent<Rigidbody>();
                CpuJoint.connectedBody = collisionRigidBody;
            }
            
            
        }

    }
}
