using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    [SerializeField] private float speed = 0.5f;

    void Update()
    {
        float AxisX = Input.GetAxis("Horizontal");
        float AxisY = Input.GetAxis("Vertical");
        transform.position += new Vector3 (speed * AxisX * Time.deltaTime, speed * AxisY * Time.deltaTime);
    }
}
