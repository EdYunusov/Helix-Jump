using UnityEngine;

public class InputManager : BallEvents
{
    [SerializeField] private MouseRotator InputRotator;

    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if(type == SegmentType.Finish || type == SegmentType.Trap)
        {
            InputRotator.enabled = false;
        }
    }
}
