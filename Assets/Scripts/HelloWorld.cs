using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    [SerializeField] string messageToDisplay = "Hello World";

    void Update()
    {
        Debug.Log(messageToDisplay);
    }
}
