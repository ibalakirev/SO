using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Abillities/New Abillity")]

public class Ability : ScriptableObject
{
    [SerializeField] private AbillityPlaceLogic _abillityPlaceLogic;
    [SerializeField] private List<AbillityAction> _abillityActions;

    public void ApplyAction(List<Units> targets)
    {
        foreach (var action in _abillityActions)
        {
            foreach (var target in targets)
            {
                action.Action(target);
            }
        }
    }

    public List<Units> SelectTargets(Vector2 screenPoint)
    {
        return _abillityPlaceLogic.TryGetTargets(screenPoint);
    }
}
