using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Abillities/PlcaeLogic/SingleTarget")]

public class AbillityPlaceLogicSingleTarget : AbillityPlaceLogic
{
    public override List<Units> TryGetTargets(Vector2 screenPoint)
    {
        var ray = Camera.main.ScreenPointToRay(new Vector3(screenPoint.x, screenPoint.y, 1));

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 15))
        {
            if (hit.transform.TryGetComponent(out Units unit))
            {
                return new List<Units>() { unit };
            }
        }

        return null;
    }
}
