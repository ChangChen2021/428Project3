using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{
    Animator animator;
    private Rigidbody _rigidbody;
    public float m_Thrust = 20f;
    public GameObject whatToSpawnPrefab;
    public GameObject whatToSpawnClone;
    public Transform spawnLocations;
    private float timer = 3f;
    private GameObject[] spiders;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(animator.GetBool("isDead") == false)
        {
            _rigidbody.AddForce(m_Thrust * transform.up);  
        }
        
        spiders = GameObject.FindGameObjectsWithTag("Respawn");
        if((animator.GetBool("isDead") == true) & (timer <= 0f) & (spiders.Length < 32))
        {   
            whatToSpawnClone = Instantiate(whatToSpawnPrefab, spawnLocations.transform.position + new Vector3 (0, 0.1f, 0), Quaternion.Euler(0,0,0)) as GameObject;
            animator.SetBool("isDead", false);
            timer = 3f;  
        }
    }
}
