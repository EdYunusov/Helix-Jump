using UnityEngine;
using UnityEngine.Events;


[RequireComponent(typeof(BallMovment))]
public class BallController : OneColliderTrigger
{
    [SerializeField] private GameObject soundEffect;
    [SerializeField] private GameObject levelFinishSound;
    [SerializeField] private GameObject loseSoundEffect;

    private BallMovment movment;
    private Animator animator;


    [HideInInspector] public UnityEvent<SegmentType> CollisionSegment;

    private void Start()
    {
        movment = GetComponent<BallMovment>();
    }

    protected override void OnOneTriggerEnter(Collider other)
    {
        Segment segment = other.GetComponent<Segment>();

        if(segment != null)
        {
            if(segment.Type == SegmentType.Empty)
            {
                movment.Fall(other.transform.position.y);
            }

            if(segment.Type == SegmentType.Default)
            {
                movment.Jump();
                Instantiate(soundEffect);
            }

            if(segment.Type == SegmentType.Trap || segment.Type == SegmentType.Finish)
            {
                movment.Stop();
                
            }

            if (segment.Type == SegmentType.Finish)
            {
                Instantiate(levelFinishSound);
            }

            if(segment.Type == SegmentType.Trap)
            {
                Instantiate(loseSoundEffect);
            }

            CollisionSegment.Invoke(segment.Type);
        }
    }
}
