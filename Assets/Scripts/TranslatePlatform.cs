using UnityEngine;

public class TranslatePlatform : MonoBehaviour
{
    [SerializeField] Vector3 translationEveryFrame;

    [SerializeField] float timeBetweenSwappingDirection = 1f;
    float timeElapsed = 0f;

    void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed > timeBetweenSwappingDirection)
        {
            translationEveryFrame = -translationEveryFrame;
            timeElapsed = 0f;
        }

        transform.position += translationEveryFrame;
    }
}
