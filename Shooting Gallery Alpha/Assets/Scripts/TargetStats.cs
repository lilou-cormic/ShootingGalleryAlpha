using UnityEngine;

[CreateAssetMenu(fileName = "TargetStats", menuName = "TargetStats")]
public class TargetStats : ScriptableObject
{
    public int Id = 0;

    public Sprite Sprite = null;

    public int Points = 0;

    public bool IsDuck = false;

    public int SpawnChance = 0;
}
