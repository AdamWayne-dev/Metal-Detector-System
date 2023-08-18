using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScanning : MonoBehaviour
{
    [SerializeField] GameObject detectorRay;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse1))
        {
            detectorRay.SetActive(true);
        }

        else
        {
            detectorRay.SetActive(false);
        }
    }
}
