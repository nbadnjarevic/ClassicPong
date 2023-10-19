using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rb;
    [SerializeField] float xSpeed = -5;
    private float ySpeed;
    private float constSpeed;
    // Start is called before the first frame update
    void Start()
    {
        ySpeed = Random.Range(-4f, 4f);
        _rb.velocity = new Vector2(xSpeed, ySpeed);
        constSpeed = Mathf.Sqrt(xSpeed * xSpeed - ySpeed * ySpeed);
    }

    // Update is called once per frame
    void Update()
    { 
        _rb.velocity = _rb.velocity.normalized * constSpeed;
    }
}
