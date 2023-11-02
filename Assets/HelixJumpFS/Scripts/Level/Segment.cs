using UnityEngine;

public enum SegmentType
{
    Default,
    Trap,
    Empty,
    Finish
}
public class Segment : MonoBehaviour
{
    
    [SerializeField] private Material Trap_Material;
    [SerializeField] private Material Finish_Material;
    
    [SerializeField] private SegmentType type;

    public SegmentType Type => type;

    private MeshRenderer meshRenderer;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    public void SetTrap()
    {
        meshRenderer.enabled = true;
        meshRenderer.material = Trap_Material;

        type = SegmentType.Trap;
    }

    public void SetEmpty()
    {
        meshRenderer.enabled = false;

        type = SegmentType.Empty;
    }

    public void SetFinish()
    {
        meshRenderer.enabled = true;
        meshRenderer.material = Finish_Material;

        type = SegmentType.Finish;
    }
}
