using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;
    void Update()
    {
        Vector3 vector = new Vector3(0, 0, _speed);
        transform.position += vector;
    }
}
