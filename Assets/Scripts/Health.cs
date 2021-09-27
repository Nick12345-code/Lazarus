using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Health : MonoBehaviour
{
    [SerializeField] private int health;
    [SerializeField] private TextMeshProUGUI healthText;
    
    public void LoseLife(int amount)
    {
        health -= amount;
        healthText.text = health.ToString();
    }

    private void Update() => LoseGame();

    private void LoseGame()
    {
        if (health <= 0)
        {
            SceneManager.LoadScene("Lose");
        }
    }
}
