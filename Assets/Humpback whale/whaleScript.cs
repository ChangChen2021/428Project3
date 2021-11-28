using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whaleScript : MonoBehaviour
{
    public GameObject whatToSpawnPrefab;
    public GameObject whatToSpawnClone;
    public Transform spawnLocations;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Spawn(){
        
        whatToSpawnClone = Instantiate(whatToSpawnPrefab, spawnLocations.transform.position + new Vector3 (0, 0.1f, 0), Quaternion.Euler(0,0,0)) as GameObject;
    }
}
