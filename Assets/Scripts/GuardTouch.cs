using UnityEngine;

public class GuardTouch : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("PERDISTE");
        }
    }
}