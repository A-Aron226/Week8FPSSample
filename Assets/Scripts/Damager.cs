using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Damager : MonoBehaviour
{
    [SerializeField] HealthStat health;
    [SerializeField] UnityEvent OnFlash;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnDamaged()
    {
        health.currHealth -= 1;
        OnFlash?.Invoke();
    }
}
