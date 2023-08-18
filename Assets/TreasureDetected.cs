using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureDetected : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "DetectorRay")
        {
            Debug.Log("Treasure found!");
        }
    }
}
