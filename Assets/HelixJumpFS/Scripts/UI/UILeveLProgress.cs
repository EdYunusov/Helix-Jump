using UnityEngine;
using UnityEngine.UI;


public class UILeveLProgress : BallEvents
{
    [SerializeField] private LevelProgress levelProgress;
    [SerializeField] private LevelGenerator levelGenerator;
    [SerializeField] private Text currentLevelText;
    [SerializeField] private Text nextLevelText;
    [SerializeField] private Image progressBar;

    private float fillAmountStep;

    private void Start()
    {
        currentLevelText.text = levelProgress.Current_Level.ToString();
        nextLevelText.text = (levelProgress.Current_Level + 1).ToString();

        progressBar.fillAmount = 0;

        fillAmountStep = 1 / levelGenerator.FloorAmount;
    }

    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if(type == SegmentType.Empty || type == SegmentType.Finish)
        {
            progressBar.fillAmount += fillAmountStep;
        }
    }
}
