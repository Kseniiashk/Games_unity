using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 10;
    [SerializeField] private float speed_angles = 10;

    [SerializeField] private Rigidbody _rb;
    [SerializeField] private Transform _cameraTransform;

    float xRotation;
    public float jumpForce = 5f;
    private bool isJumping = false;

    void Update()
    {
        float real_speed = speed;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            real_speed *= 2;
        }

        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            _rb.AddForce(new Vector3(0f, jumpForce, 0f), ForceMode.Impulse);
            isJumping = true;
        }
        else if (!Input.GetKey(KeyCode.Space))
            isJumping = false;

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector3 forwardoffset = v * transform.forward * real_speed;
        Vector3 rightoffset = h * transform.right * real_speed;
        Vector3 summ = forwardoffset + rightoffset;

        _rb.velocity = new Vector3(summ.x, _rb.velocity.y, summ.z);

        float rotationInputHorizontal = Input.GetAxis("Mouse X");
        float rotationInputVertical = Input.GetAxis("Mouse Y");

        _rb.angularVelocity = new Vector3(0, rotationInputHorizontal * speed_angles * 3, 0);

        xRotation += -rotationInputVertical * speed_angles;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);
        _cameraTransform.localEulerAngles = new Vector3(xRotation, 0, 0);
    }
}
