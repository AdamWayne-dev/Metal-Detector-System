using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTreasures : MonoBehaviour
{
    [SerializeField] Transform spawnZone;
    [SerializeField] GameObject treasure;

    private Vector3 colliderSize;
    private Vector3 cubeSize;
    // Start is called before the first frame update
    private void Awake()
    {
        spawnZone = GetComponent<Transform>();
        cubeSize = transform.position;
        colliderSize.x = spawnZone.transform.localScale.x;
        colliderSize.y = spawnZone.transform.localScale.y;
        colliderSize.z = spawnZone.transform.localScale.z;
    }

    void Start()
    {
        
        GameObject treasureSpawn = Instantiate(treasure, GetRandomLocation(), Quaternion.identity);
    }


    
    // Update is called once per frame
    void Update()
    {
        
    }

     private Vector3 GetRandomLocation()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-colliderSize.x / 2, colliderSize.x / 2), (Random.Range(-colliderSize.y / 2, colliderSize.y / 2)), (Random.Range(-colliderSize.z / 2, colliderSize.z / 2)));

        return randomPosition + cubeSize;
    }
    
}
