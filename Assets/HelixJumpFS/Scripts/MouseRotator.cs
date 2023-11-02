using UnityEngine;

public class MouseRotator : MonoBehaviour
{
    [SerializeField] private string MouseInputAxis;
    [SerializeField] private float sensitive;
    private void Update()
    {
        if(Input.GetMouseButton(0) == true)
        {
            transform.Rotate(0, Input.GetAxis(MouseInputAxis) * - sensitive, 0);
        }
    }
}
