using UnityEngine;
using UnityEngine.UI;

public class PauseGame : MonoBehaviour
{

    public bool isPaused;
    public Text PausedText;
    public void PauseToggle(Toggle obj)
    {
        Time.timeScale = obj.isOn ? 0 : 1;
        
        if (isPaused == false)
        {
            PausedText.enabled = true;
            isPaused = true;
            return;
        }

        if (isPaused)
        {
            PausedText.enabled = false;
            isPaused = false;
            return;
        }
    }
}
