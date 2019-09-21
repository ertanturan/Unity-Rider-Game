using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiderController : MonoBehaviour
{

    public float Speed = 20;

    private Rigidbody2D _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("right arrow");
            _rb.AddForce(transform.right * Speed * Time.fixedDeltaTime * 100 
                , ForceMode2D.Force);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _rb.velocity = Vector2.zero;
            //_rb.angularVelocity = Mathf.Lerp(_rb.angularVelocity, 0f, .5f * Time.fixedDeltaTime);
        }

    }
}
