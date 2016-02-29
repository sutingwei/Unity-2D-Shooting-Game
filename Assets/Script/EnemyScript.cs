using UnityEngine;

/// <summary>
/// Enemy generic behavior
/// </summary>
public class EnemyScript : MonoBehaviour
{
    private WeaponScript weapon;

    void Awake()
    {
        // Retrieve the weapon only once
        weapon = GetComponentInChildren<WeaponScript>();
    }

    void Update()
    {
        if (GetComponent<Renderer>().IsVisibleFrom(Camera.main) == false)
            return;
        // Auto-fire
        if (weapon != null && weapon.CanAttack)
        {
            weapon.Attack(true);
            SoundEffectsHelper.Instance.MakeEnemyShotSound();
        }
    }
}
