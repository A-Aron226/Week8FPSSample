using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Health Stats")]
public class HealthStat : ScriptableObject
{
    public float maxHealth = 10;
    public float currHealth = 10;
}
