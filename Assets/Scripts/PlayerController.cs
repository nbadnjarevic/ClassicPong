using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rb;
    [SerializeField] float ySpeed = 2;
    // Start is called before the first frame update
    void Start()
    {
        _rb.velocity = new Vector2(0, ySpeed);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            _rb.velocity = new Vector2(0, ySpeed);
        } else if(Input.GetKey(KeyCode.S))
        {
            _rb.velocity = new Vector2(0, -ySpeed);
        }
        else
        {
            _rb.velocity = Vector2.zero;
        }
    }
}
