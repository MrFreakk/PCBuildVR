using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TriggerRightLow RightLowTrigger;
    public TriggerLeftLow LeftLowTrigger;
    public TriggerRightTop RightTopTrigger;
    public TriggerLeftTop LeftTopTrigger;

    private int triggerCheck;

    public GameObject UsefullPC;
    public Rigidbody Glass;
    private FixedJoint UsefullPCJoint;

    public CPUTrigger CPUTriggerObj;
    
    void Start()
    {
        triggerCheck = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        TriggerCheck();
    }

    private void TriggerCheck()
    {
        if (RightLowTrigger.RightLowTrigger)
        {
            triggerCheck += 1;
            RightLowTrigger.RightLowTrigger = false;
        }

        if (RightTopTrigger.RightTopTrigger)
        {
            triggerCheck += 1;
            RightTopTrigger.RightTopTrigger = false;
        }

        if (LeftLowTrigger.LeftLowTrigger)
        {
            triggerCheck += 1;
            LeftLowTrigger.LeftLowTrigger = false;
        }

        if (LeftTopTrigger.LeftTopTrigger)
        {
            triggerCheck += 1;
            LeftTopTrigger.LeftTopTrigger = false;
        }

        if (triggerCheck == 4)
        {
            UsefullPC.AddComponent<FixedJoint>();
            triggerCheck = 0;
            UsefullPCJoint = UsefullPC.GetComponent<FixedJoint>();
            UsefullPCJoint.connectedBody = Glass;
            triggerCheck = 0;
        }

        if (CPUTriggerObj.TriggerCheck)
        {

            CPUTriggerObj.TriggerCheck = false;
        }
    }
    
}
