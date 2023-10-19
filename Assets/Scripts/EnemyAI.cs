using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] Transform ballTransform;
    [SerializeField] Rigidbody2D _rb;
    [SerializeField] float ySpeed = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        float myY = transform.position.y;
        float ballY = ballTransform.position.y;
        if (myY < ballY)
        {
            _rb.velocity = new Vector2(0, ySpeed);
        }
        else if (myY > ballY)
        {
            _rb.velocity = new Vector2(0, -ySpeed);
        }
        else
        {
            _rb.velocity = Vector2.zero;
        }    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
