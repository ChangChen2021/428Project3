using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddRealtiveForce : MonoBehaviour
{
   
    [SerializeField] public Vector3 _position;
    public GameObject table;
    public void Up()
    {
        table.SetActive(false);
        transform.position = transform.position + _position;
    }
    public void Down()
    {
        table.SetActive(false);
        transform.position = transform.position - _position;
    }
}
