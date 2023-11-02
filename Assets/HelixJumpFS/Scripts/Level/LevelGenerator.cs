using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private Transform axis;
    [SerializeField] private Floor FloorPrefab;

    [Header("Settings")]
    [SerializeField] private int DefaultFloorAmount;
    [SerializeField] private float FloorHeight;
    [SerializeField] private int MinTrapSegment;
    [SerializeField] private int MaxTrapSegment;
    [SerializeField] private int AmountEmptySegment;

    private float floorAmount = 0;
    public float FloorAmount => floorAmount;


    private float last_Floor_Y = 0;
    public float Last_Floor_Y => last_Floor_Y;

    public void Generate(int level)
    {
        DestoryChild();

        floorAmount = DefaultFloorAmount + level;

        axis.transform.localScale = new Vector3(1, floorAmount * FloorHeight + FloorHeight, 1);

        for (int i = 0; i < floorAmount; i++)
        {
            Floor floor = Instantiate(FloorPrefab, transform);
            floor.transform.Translate(0, i * FloorHeight, 0);
            floor.name = "Floor" + i;

            if(i == 0)
            {
                floor.SetFinishAllSegment();
            }

            if(i > 0 && i < floorAmount - 1)
            {
                floor.SetRandomRotation();
                floor.AddEmptySegment(AmountEmptySegment);
                floor.AddTrapSegment(Random.Range(MinTrapSegment, MaxTrapSegment));
            }

            if(i == floorAmount -1)
            {
                floor.AddEmptySegment(2);

                last_Floor_Y = floor.transform.position.y;
            }
        }
    }

    private void DestoryChild()
    {
        for(int i = 0; i < transform.childCount; i++)
        {
            if (transform.GetChild(i) == axis) continue;
            Destroy(transform.GetChild(i).gameObject);
        }
    }
}
