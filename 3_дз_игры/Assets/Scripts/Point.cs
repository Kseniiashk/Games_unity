using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.UIElements;

public class Point : MonoBehaviour
{
    [SerializeField] private float speed_angles = 10;

    // Start is called before the first frame update
    void Update()
    {
        transform.rotation = transform.rotation * Quaternion.Euler(0, speed_angles, 0);
    }

    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
