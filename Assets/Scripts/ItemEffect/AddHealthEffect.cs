using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class AddHealthEffect : UsableItem.UsageEffect
{
    public int playerHealth;
    public override bool Use(CharacterData user)
    {
        user.Stats.ChangeHealth(playerHealth);
        return true;
    }
}
