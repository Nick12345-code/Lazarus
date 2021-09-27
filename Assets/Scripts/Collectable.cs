using UnityEngine;
using TMPro;

public class Collectable : MonoBehaviour
{
    [SerializeField] private int collectable;
    [SerializeField] private TextMeshProUGUI collectableText;

    public void Gain(int amount)
    {
        collectable += amount;
        collectableText.text = collectable.ToString();
    }
}
