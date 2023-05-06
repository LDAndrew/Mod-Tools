using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public enum BulletType
    {
        HitscanBullet = 0, FlatBullet = 1, PhysicsBullet = 2, SmartBullet = 3, RicochetBullet = 4, DetonatorBullet = 5, PiercingBullet = 6, Blank = 7
    }
    public enum BulletEffect
    {
        None = 0, Fire = 1, Static = 2, Weakness = 3,
    }
}