using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName="NPCDATASO",menuName="NPC DATA")]
public class npcdata : ScriptableObject
{
    public string[] dialogueFrases;
    public bool hasTalked;
}
