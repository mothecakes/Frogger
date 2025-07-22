using UnityEngine;

public class Log : MonoBehaviour
{
    public enum FlowDirection
    {
        LEFT,
        RIGHT
    }

    [SerializeField] FlowDirection flowDirection;

    Rigidbody2D rb;
    
    float speed;
    float DEFAULT_SPEED = 4f;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        Vector2 pos = new Vector2(transform.position.x, transform.position.y);
        if (flowDirection == FlowDirection.LEFT)
            rb.MovePosition(pos + Vector2.left * speed * Time.fixedDeltaTime);
        else
            rb.MovePosition(pos + Vector2.right * speed * Time.fixedDeltaTime);
    }

    public void SetSpeedAndDirection(float spd, FlowDirection flow)
    {
        speed = spd < 0 ? DEFAULT_SPEED : spd;
        flowDirection = flow;
    } 
}
