using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GPUJoint : MonoBehaviour
{
    private Rigidbody collisionRigidBody;
    private FixedJoint GpuJoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "GPUTrigger")
        {
            if (gameObject.GetComponent<FixedJoint>() == false)
            {
                gameObject.AddComponent<FixedJoint>();
                GpuJoint = gameObject.GetComponent<FixedJoint>();
                collisionRigidBody = other.gameObject.GetComponent<Rigidbody>();
                GpuJoint.connectedBody = collisionRigidBody;
            }
            else if (gameObject.GetComponent<FixedJoint>() == true)
            {
                GpuJoint = gameObject.GetComponent<FixedJoint>();
                collisionRigidBody = other.gameObject.GetComponent<Rigidbody>();
                GpuJoint.connectedBody = collisionRigidBody;
            }


        }

    }
}
