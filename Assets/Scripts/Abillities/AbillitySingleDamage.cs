using UnityEngine;

[CreateAssetMenu(menuName = "Abillities/Actions/Damage")]

public class AbillitySingleDamage : AbillityAction
{
    [SerializeField] private float _damage;

    public override void Action(Units unit)
    {
        Debug.Log("_damage");
    }
}
