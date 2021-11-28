using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] public Vector3 _rotation;
    public GameObject table;
    public void Rotate()
    {
        table.SetActive(false);
        Quaternion targetRotation = Quaternion.Euler(_rotation);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 5);
    }
    public void DeRotate()
    {
        table.SetActive(true);
        transform.rotation = Quaternion.identity;
        
    }
}
