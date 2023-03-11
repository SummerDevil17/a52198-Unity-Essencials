using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTransform : MonoBehaviour
{
    [SerializeField] Vector3 scaleChangeEveryFrame;

    void Update()
    {
        transform.localScale += scaleChangeEveryFrame;
    }
}
