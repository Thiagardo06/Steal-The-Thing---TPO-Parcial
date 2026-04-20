using UnityEngine;

public class PickupItem : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager.hasItem = true;
            Destroy(gameObject);
            gameManager.objectiveText.text = "Objeto robado. Objetivo: Regresa a la salida.";
        }
    }
}
