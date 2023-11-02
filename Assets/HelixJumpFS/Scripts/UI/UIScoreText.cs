using UnityEngine;
using UnityEngine.UI;

public class UIScoreText : BallEvents
{
    [SerializeField] private ScoreCollector scoreCollector;
    [SerializeField] private Text scoreText;
    [SerializeField] private Text maxScoreText;

    [SerializeField] private string markMaxScoreText;

    private void Start()
    {
        maxScoreText.text = (markMaxScoreText + scoreCollector.MaxScores).ToString();
    }

    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if(type != SegmentType.Trap)
        {
            scoreText.text = scoreCollector.Scores.ToString();
        }

        if(type == SegmentType.Finish)
        {
            maxScoreText.text = (markMaxScoreText + scoreCollector.MaxScores).ToString();
        }
    }
}
