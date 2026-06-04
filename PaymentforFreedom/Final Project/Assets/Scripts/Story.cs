using UnityEngine;
using UnityEngine.UI;

public class Story : MonoBehaviour 
{
    public Text introText;        
    public GameObject storyPanel;   

    private string[] storyLines = {
        "Left-click to skip dialogue.",
        "A death sentence... That was my fate until the King made his twisted offer.",
        "Bring him the hidden treasure from this dungeon, and my execution is canceled.",
        "But this place is a death trap. One touch on those red spikes, and I'll execute myself.",
        "I just need to find the 2 golden keys and open that chest to buy my freedom.",
        "CONTROLS: Use 'WASD' to walk and 'Spacebar' to jump."
    };

    private int index = 0;

    void Start() {
        Time.timeScale = 0f; 
        UpdateText();
    }

    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            index++;
            if (index < storyLines.Length) UpdateText();
            else StartGame();
        }
    }

    void UpdateText() { introText.text = storyLines[index]; }

    void StartGame() {
        storyPanel.SetActive(false); 
        Time.timeScale = 1f; 
    }
}