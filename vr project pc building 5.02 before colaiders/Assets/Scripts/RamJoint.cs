using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RamJoint : MonoBehaviour
{
    private Rigidbody collisionRigidBody;
    private FixedJoint RAMJoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "RAMTriggers")
        {
            if (gameObject.GetComponent<FixedJoint>() == false)
            {
                gameObject.AddComponent<FixedJoint>();
                RAMJoint = gameObject.GetComponent<FixedJoint>();
                collisionRigidBody = other.gameObject.GetComponent<Rigidbody>();
                RAMJoint.connectedBody = collisionRigidBody;
            }
            else if (gameObject.GetComponent<FixedJoint>() == true)
            {
                RAMJoint = gameObject.GetComponent<FixedJoint>();
                collisionRigidBody = other.gameObject.GetComponent<Rigidbody>();
                RAMJoint.connectedBody = collisionRigidBody;
            }


        }

    }

}
