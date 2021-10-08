using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]

public class SimpleTextBehaviour : MonoBehaviour
{
    private Text Label;
    public UnityEvent UpdateScoreValue;
    public UnityEvent ResetScore;
    
    void Start()
    {
        Label = GetComponent<Text>();
        ResetScore.Invoke();
    }

    private void Update()
    {
        UpdateScoreValue.Invoke();
    }

    public void UpdateTextValue(IntData obj)
    {
        Label.text = obj.value.ToString("0");
    }
}
