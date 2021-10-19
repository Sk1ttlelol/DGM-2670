using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float value;
    public UnityEvent minValueEvent, maxValueEvent;

    public void AddToValue (float num)
    {
        value += num;
    }

    public void ResetValue (float num)
    {
        value = num;
    }

    public void AddToValueZero(float num)
    {
        if (value <=0)
        {
            value = 0;
        }
        else
        {
            value += num;
        }
    }

    public void AddHealthToPlayer(float num)
    {
        value += num;
    }

    public void RemoveHealthFromPlayer(float num)
    {
        value += num;
    }

    public void CheckMinValue(float minValue)
    {
        if (!(value <= minValue)) return;
        minValueEvent.Invoke();
        value = minValue;
    }
    
    public void CheckMaxValue(float maxValue)
    {
        if (!(value >= maxValue)) return;
        maxValueEvent.Invoke();
        value = maxValue;
    }
}
