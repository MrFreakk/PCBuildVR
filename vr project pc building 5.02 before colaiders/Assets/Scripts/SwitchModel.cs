using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchModel : MonoBehaviour
{
    private Vector3 startPos;
    public GameObject motherGpu;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Asus")
        {
            startPos = gameObject.transform.position;
            gameObject.SetActive(false);
            collision.gameObject.SetActive(false);
            motherGpu.SetActive(true);
            motherGpu.transform.position = startPos;
            //motherGpu.AddComponent<Rigidbody>();
            
        }
    }
}
