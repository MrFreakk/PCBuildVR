using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRightLow : MonoBehaviour
{
    public bool RightLowTrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Low_Right_Glass")
        {
            RightLowTrigger = true;
        }
    }
}
