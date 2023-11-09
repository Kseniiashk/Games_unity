using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private GameObject _bullerPrefab;
    [SerializeField] private Transform _spam;

    [SerializeField] private float _bulletSpeed = 7;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            GameObject newBullet = Instantiate(_bullerPrefab, _spam.position, _spam.rotation);
            newBullet.GetComponent<Rigidbody>().velocity = transform.forward * _bulletSpeed;
        }
    }
}
