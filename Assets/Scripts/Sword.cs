using UnityEngine;

[CreateAssetMenu(fileName = "New Sword", menuName = "Shop/Sword", order = 51)]

public class Sword : Goods
{
    [SerializeField] protected float _damage;

    public override void ShowInfo()
    {
        Debug.Log($" Название - {Label} Описание - {Description} Цена - {Price} Урон - {_damage}");
    }
}
