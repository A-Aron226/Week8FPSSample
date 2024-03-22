using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Reload : MonoBehaviour
{
    FPSController player;
    Gun gun;
    // Start is called before the first frame update
    void Start()
    {
        player = FindAnyObjectByType<FPSController>();
        gun = FindAnyObjectByType<Gun>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void reloadGun()
    {
            player.ammo = 9;//not ideal but a temporary solution for UI count
            gun.ammo = 10;//temproary solution
            Debug.Log("reloaded!");
    }
}
