using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] Transform ballTransform;
    [SerializeField] Rigidbody2D _rb;
    [SerializeField] float ySpeed = 2;
    private int tickCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        if (tickCount != 8)
        {
            float myY = transform.position.y;
            float ballY = ballTransform.position.y;
            float diff = Mathf.Abs(myY - ballY);
            if (diff < 0.3)
            {
                _rb.velocity = Vector2.zero;
            }
            else if (myY < ballY)
            {
                _rb.velocity = new Vector2(0, ySpeed);
            }
            else if (myY > ballY)
            {
                _rb.velocity = new Vector2(0, -ySpeed);
            }
            tickCount++;
        } else
        {
            tickCount = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
