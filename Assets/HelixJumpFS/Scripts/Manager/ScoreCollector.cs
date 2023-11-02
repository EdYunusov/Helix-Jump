using UnityEngine;

public class ScoreCollector : BallEvents
{
    [SerializeField] private int scores;
    [SerializeField] private int maxScores;
    [SerializeField] private LevelProgress levelProgress;

    public int MaxScores => maxScores;
    public int Scores => scores;

    protected override void Awake()
    {
        base.Awake();
        LoadMaxScores();
    }

    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if(type == SegmentType.Empty)
        {
            scores += levelProgress.Current_Level;
        }

        if(type == SegmentType.Finish)
        {
            if(scores > maxScores)
            {
                maxScores = scores;
                SaveMaxScores();
            }
        }
    }

    private void SaveMaxScores()
    {
        PlayerPrefs.SetInt("ScoreCollector:MaxScores", maxScores);
    }

    private void LoadMaxScores()
    {
        maxScores = PlayerPrefs.GetInt("ScoreCollector:MaxScores", 0);
    }
}
