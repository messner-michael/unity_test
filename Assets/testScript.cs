using UnityEngine;

public class testScript : MonoBehaviour
{
    bool warningTriggered = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello World!");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0.03f, 0, 0);

        if (transform.position.x > 10 && !warningTriggered)
        {
            warningTriggered = true;
            Debug.LogWarning("x > 10!)");
        }
    }

}
