using UnityEngine;

[CreateAssetMenu]
public class IntData : ScriptableObject
{
    public int value;

    public void AddToValue(int num)
    {
        value += num;
    }

    public void ResetValue(int num)
    {
        value = num;
    }
   
}
