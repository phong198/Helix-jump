using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private int i = 0;

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Pass")
        {
            Destroy(other.gameObject);
        }
        ++i;
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "ground")
        {
            if (i < 3)
            {
                i = 0;
            }
            else
            {
                Destroy(other.gameObject.transform.parent.gameObject);
                i = 0;
            }
        } 
    }
}


