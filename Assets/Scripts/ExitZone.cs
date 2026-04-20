using UnityEngine;

public class ExitZone : MonoBehaviour
{
    public GameManager gameManager;

    public void WinGame()
    {
        Debug.Log("GANASTE");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && gameManager.hasItem)
        {
            gameManager.WinGame();
        }
    }
}