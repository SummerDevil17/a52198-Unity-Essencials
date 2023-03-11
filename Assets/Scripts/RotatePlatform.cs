using UnityEngine;

public class RotatePlatform : MonoBehaviour
{
    [SerializeField] Vector3 rotationEveryFrame;

    void Update()
    {
        transform.Rotate(rotationEveryFrame);
    }
}
