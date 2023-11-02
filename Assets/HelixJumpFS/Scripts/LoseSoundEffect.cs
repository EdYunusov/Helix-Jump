using UnityEngine;

public class LoseSoundEffect : MonoBehaviour
{
    [SerializeField] private float LifeTime;

    private void Start()
    {
        Destroy(gameObject, LifeTime);
    }
}
