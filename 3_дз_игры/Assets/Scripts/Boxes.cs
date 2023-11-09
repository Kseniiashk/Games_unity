using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxes : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject newBox;
    public GameObject oldBox;

    void Start()
    {
        newBox.SetActive(false);
        oldBox.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        newBox.SetActive(true);
        oldBox.SetActive(false);
    }
}
