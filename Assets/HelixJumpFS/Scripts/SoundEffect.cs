using UnityEngine;

public class SoundEffect : MonoBehaviour
{
    [SerializeField] private float LifeTime;

    private void Start()
    {
        Destroy(gameObject, LifeTime);
    }
}
