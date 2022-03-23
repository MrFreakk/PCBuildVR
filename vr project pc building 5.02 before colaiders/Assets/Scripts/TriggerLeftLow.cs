using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLeftLow : MonoBehaviour
{
    public bool LeftLowTrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Low_Left_Glass")
        {
            LeftLowTrigger = true;
        }
    }
}
