using UnityEngine;

[System.Serializable]
public class LevelPallet
{
    public Color axisColor;
    public Color ballColor;
    public Color defaultSegmentColor;
    public Color trapSegmentColor;
    public Color finishsSegmentColor;
}

public class LevelColors : MonoBehaviour
{
    [SerializeField] private LevelPallet[] pallet;

    [SerializeField] private Material axisMaterial;
    [SerializeField] private Material ballMaterial;
    [SerializeField] private Material defaultSegmentMaterial;
    [SerializeField] private Material trapSegmentMaterial;
    [SerializeField] private Material finishSegmentMaterial;

    public void Start()
    {
        int index = Random.Range(0, pallet.Length);

        axisMaterial.color = pallet[index].axisColor;
        ballMaterial.color = pallet[index].ballColor;
        defaultSegmentMaterial.color = pallet[index].defaultSegmentColor;
        trapSegmentMaterial.color = pallet[index].trapSegmentColor;
        finishSegmentMaterial.color = pallet[index].finishsSegmentColor;
    }

}
