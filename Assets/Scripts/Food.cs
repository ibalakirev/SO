using UnityEngine;

[CreateAssetMenu(fileName = "New Food", menuName = "Shop/Food", order = 51)]

public class Food : Goods
{
    [SerializeField] private int _calorie;

    public override void ShowInfo()
    {
        Debug.Log($" Название - {Label} Описание - {Description} Цена - {Price} Калории - {_calorie}");
    }
}
