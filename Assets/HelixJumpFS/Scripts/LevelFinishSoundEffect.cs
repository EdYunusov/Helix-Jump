using UnityEngine;

public class LevelFinishSoundEffect : MonoBehaviour
{
    [SerializeField] private float LifeTime;

    private void Start()
    {
        Destroy(gameObject, LifeTime);
    }
}
