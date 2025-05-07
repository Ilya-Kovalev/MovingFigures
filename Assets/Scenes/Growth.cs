using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Growth : MonoBehaviour
{
    [SerializeField] private float _growthRate;
    void Update()
    {
        Vector3 vector = new Vector3(_growthRate, _growthRate, _growthRate);
        transform.localScale += vector;
    }
}
