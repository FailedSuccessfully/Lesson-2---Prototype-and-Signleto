using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyPrototypes
{
    public int hp, spd, atk, def ;
    public abstract EnemyPrototypes Clone();

    public EnemyPrototypes(int hp, int spd, int atk, int def) {
        this.hp = hp;
        this.spd = spd;
        this.atk = atk;
        this.def = def;
    }
}

public class CuteEnemey:EnemyPrototypes
{
    public CuteEnemey (int hp, int spd, int atk, int def) : base (hp, spd, atk, def) {
        this.spd /=  2;
    }

    public void Meow() {
        Debug.Log("meow");
    }
    public override EnemyPrototypes Clone()
    {
        return ((EnemyPrototypes)MemberwiseClone());
    }
}public class UglyEnemey:EnemyPrototypes
{
    public UglyEnemey (int hp, int spd, int atk, int def) : base (hp, spd, atk, def) {
        this.spd /=  2;
    }

    public void Growl() {
        Debug.Log("grrrrrrr");
    }
    public override EnemyPrototypes Clone()
    {
        return ((EnemyPrototypes)MemberwiseClone());
    }
}