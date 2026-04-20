using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public bool hasItem = false;

    public GameObject winText;
    public GameObject loseText;
    public GameObject overlayPanel;
    public TMP_Text objectiveText;

    bool gameEnded = false;

    void Start()
    {
        objectiveText.text = "Objetivo: Infiltrate y roba el objeto.";
    }
    void Update()
    {
        if (gameEnded && Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void WinGame()
    {
        overlayPanel.SetActive(true);
        winText.SetActive(true);
        gameEnded = true;

        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
    }

    public void LoseGame()
    {
        overlayPanel.SetActive(true);
        loseText.SetActive(true);
        gameEnded = true;

        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
    }
}