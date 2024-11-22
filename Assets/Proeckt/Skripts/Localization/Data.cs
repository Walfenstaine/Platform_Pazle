using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "Player_Pos", menuName = "Navigeyter/Player_Pos", order = 1)]
public class Data : ScriptableObject
{
    public int index;
    public List<Vector3> position;
    public List<Quaternion> rotation;
    public bool starter;
}