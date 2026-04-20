using UnityEngine;

public class RotateItem : MonoBehaviour
{
    public float rotateSpeed = 50f;
    public float floatSpeed = 2f;
    public float floatHeight = 0.2f;

    Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        transform.Rotate(0f, rotateSpeed * Time.deltaTime, 0f);

        float newY = startPos.y + Mathf.Sin(Time.time * floatSpeed) * floatHeight;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }

}
