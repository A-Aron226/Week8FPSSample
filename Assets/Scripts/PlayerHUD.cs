using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class PlayerHUD : MonoBehaviour
{
    [SerializeField] Image healthBar;
    [SerializeField] TMP_Text currentAmmoText;
    [SerializeField] TMP_Text maxAmmoText;
    [SerializeField] HealthStat health;

    FPSController player;
    Gun gun;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<FPSController>();
        gun = FindAnyObjectByType<Gun>();
        maxAmmoText.text = gun.ammo.ToString();
        currentAmmoText.text = maxAmmoText.text;
        player.OnAmmoChange += ChangeAmmo;
        player.ammo = gun.ammo;
    }

    private void Update()
    {
        healthBar.fillAmount = health.currHealth / health.maxHealth;
    }

    public void ChangeAmmo(int newCurrentAmmo)
    {
        currentAmmoText.text = newCurrentAmmo.ToString();
        player.ammo -= 1;
        if (player.ammo < 0)
        {
            player.ammo = 0;
        }
    }
}
