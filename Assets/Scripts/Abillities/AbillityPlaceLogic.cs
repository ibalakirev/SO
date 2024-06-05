using System.Collections.Generic;
using UnityEngine;

public abstract class AbillityPlaceLogic : ScriptableObject
{
    public abstract List<Units> TryGetTargets(Vector2 screenPoint);
}
