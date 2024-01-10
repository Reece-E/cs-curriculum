using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class Loot : ScriptableObject
{
    public Sprite lootsprite;
    public string lootName;
    public int dropchance;

    public Loot(string lootname, int dropchance)
    {
        this.lootName = lootname;
        this.dropchance = dropchance;
    }
}
