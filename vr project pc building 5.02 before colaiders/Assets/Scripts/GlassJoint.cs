using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassJoint : MonoBehaviour
{
    private Rigidbody collisionRigidBody;
    private FixedJoint GlassJoin;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "UsefullComputer")
        {
            if (gameObject.GetComponent<FixedJoint>() == false)
            {
                gameObject.AddComponent<FixedJoint>();
                GlassJoin = gameObject.GetComponent<FixedJoint>();
                collisionRigidBody = other.gameObject.GetComponent<Rigidbody>();
                GlassJoin.connectedBody = collisionRigidBody;
            }
            else if (gameObject.GetComponent<FixedJoint>() == true)
            {
                GlassJoin = gameObject.GetComponent<FixedJoint>();
                collisionRigidBody = other.gameObject.GetComponent<Rigidbody>();
                GlassJoin.connectedBody = collisionRigidBody;
            }


        }

    }
}
