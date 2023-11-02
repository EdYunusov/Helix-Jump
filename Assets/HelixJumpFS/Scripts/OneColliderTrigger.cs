using UnityEngine;

public abstract class OneColliderTrigger : MonoBehaviour
{
    private Collider lastCollaider;
    protected virtual void OnOneTriggerEnter(Collider other) { }

    private void OnTriggerEnter(Collider other)
    {
        if (lastCollaider != null && lastCollaider != other) return;

        lastCollaider = other;
        OnOneTriggerEnter(other);
    }

    private void OnTriggerExit(Collider other)
    {
        if (lastCollaider == other) lastCollaider = null;
    }
}
