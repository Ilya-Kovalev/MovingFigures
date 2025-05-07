using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotaition : MonoBehaviour
{
    [SerializeField] private float _rotaitionSpeed;
   
    void Update()
    {
        transform.Rotate(Vector3.up * _rotaitionSpeed * Time.deltaTime);
    }
}
