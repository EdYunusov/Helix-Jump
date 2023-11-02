using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelProgress : BallEvents
{

    [SerializeField] private ScoreCollector scoreCollector;
    


    [SerializeField] private int maxScores;
    [SerializeField] private int scores;

    private int current_Level = 1;
    public int Current_Level => current_Level;

    private void Start()
    {
        ballController.CollisionSegment.AddListener(OnBallCollisionSegment);
        maxScores = PlayerPrefs.GetInt("LevelProgress:CurrentLevel", maxScores);
    }

    protected override void OnDestroy()
    {
        ballController.CollisionSegment.RemoveListener(OnBallCollisionSegment);
    }

    protected override void Awake()
    {
        Load();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1) == true)
        {
            Reset();
        }

        if (Input.GetKeyDown(KeyCode.F2) == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if(type == SegmentType.Finish)
        {
            current_Level++;
            Save();
        }
    }

    private void Save()
    {
        PlayerPrefs.SetInt("LevelProgress:CurrentLevel", current_Level);
    }

    private void Load()
    {
        current_Level = PlayerPrefs.GetInt("LevelProgress:CurrentLevel", 1);
        
    }

    private void Reset()
    {
        PlayerPrefs.DeleteAll();

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
