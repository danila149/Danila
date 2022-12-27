using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulka : MonoBehaviour
{
    [SerializeField] private float speed = 0.5f;
    void Update()
    {
        transform.position += new Vector3(speed * Time.deltaTime, 0 );

    }
}
