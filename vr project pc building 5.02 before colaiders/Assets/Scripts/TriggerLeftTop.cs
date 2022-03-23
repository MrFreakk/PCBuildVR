using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLeftTop : MonoBehaviour
{
    public bool LeftTopTrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Top_Left_Glass")
        {
            LeftTopTrigger = true;
        }
    }
}
