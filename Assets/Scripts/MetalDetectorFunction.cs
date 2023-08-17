using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetalDetectorFunction : MonoBehaviour
{
    [SerializeField] GameObject metalDetectorPrefab;
    [SerializeField] Transform detectorLocation;

   
    
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(metalDetectorPrefab, detectorLocation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
    
}
