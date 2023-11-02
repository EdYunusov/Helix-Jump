using UnityEngine;


[RequireComponent(typeof(BallMovment))]
public class BallMovment : MonoBehaviour
{
    [Header("Fall")]
    [SerializeField] private float FallHeight;
    [SerializeField] private float FallSpeedDefault;
    [SerializeField] private float MaxFallSpeed;
    [SerializeField] private float MaxSpeedAxeleration;

    private float FallSpeed;
    private Animator animator;
    private float floor_Y;

    private void Start()
    {
        enabled = false;
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if(transform.position.y > floor_Y)
        {
            transform.Translate(0, -FallSpeed * Time.deltaTime, 0);

            if(FallSpeed < MaxFallSpeed)
            {
                FallSpeed += MaxSpeedAxeleration * Time.deltaTime;
            }
        }

        else
        {
            transform.position = new Vector3(transform.position.x, floor_Y, transform.position.z);
            enabled = false;
        }
    }

    public void Jump()
    {
        animator.speed = 1;
        FallSpeed = FallSpeedDefault;

    }

    public void Fall(float StartFloor_Y)
    {
        animator.speed = 0;
        enabled = true;
        floor_Y = StartFloor_Y - FallHeight;
    }

    public void Stop()
    {
        animator.speed = 0;
    }
}
