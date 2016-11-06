using UnityEngine;

public class Click : MonoBehaviour
{
    public UnityEngine.UI.Text gpc;
    public UnityEngine.UI.Text goldDisplay;
    public float gold = 1.00f;
    public int goldPerClick = 1;
    public int goldPerSecond = 1;

    void Update()
    {
        goldDisplay.text = "Gold: " + gold.ToString("F0");
        gpc.text = goldPerClick + " gold/click";
    }

    public void Clicked()
    {
        gold += goldPerClick;

    }
}
