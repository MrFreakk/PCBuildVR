using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotherBoardJoin : MonoBehaviour
{
    private Rigidbody collisionRigidBody;
    private FixedJoint motherboardJoin;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "BackSide")
        {
            if (gameObject.GetComponent<FixedJoint>() == false)
            {
                gameObject.AddComponent<FixedJoint>();
                motherboardJoin = gameObject.GetComponent<FixedJoint>();
                collisionRigidBody = other.gameObject.GetComponent<Rigidbody>();
                motherboardJoin.connectedBody = collisionRigidBody;
            }
            else if (gameObject.GetComponent<FixedJoint>() == true)
            {
                motherboardJoin = gameObject.GetComponent<FixedJoint>();
                collisionRigidBody = other.gameObject.GetComponent<Rigidbody>();
                motherboardJoin.connectedBody = collisionRigidBody;
            }


        }

    }
}
