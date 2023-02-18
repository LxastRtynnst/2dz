using UnityEngine;

public class CatDown : MonoBehaviour
{

    private HingeJoint2D _hingeJoint;

    private void Start()
    {
        _hingeJoint = GetComponent<HingeJoint2D>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            _hingeJoint.enabled = false;
        }
    }
}
