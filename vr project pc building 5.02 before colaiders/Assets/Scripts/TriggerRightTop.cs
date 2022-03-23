using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRightTop : MonoBehaviour
{
    public bool RightTopTrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Top_Right_Glass")
        {
            RightTopTrigger = true;
        }
    }
}
