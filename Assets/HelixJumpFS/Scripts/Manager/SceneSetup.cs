using UnityEngine;

public class SceneSetup : MonoBehaviour
{
    [SerializeField] private LevelGenerator levelGenerator;
    [SerializeField] private BallController ballController;
    [SerializeField] private LevelProgress levelProgress;


    
    private void Start()
    {
        levelGenerator.Generate(levelProgress.Current_Level);

        ballController.transform.position = new Vector3(ballController.transform.position.x, levelGenerator.Last_Floor_Y, ballController.transform.position.z);

    }
}
