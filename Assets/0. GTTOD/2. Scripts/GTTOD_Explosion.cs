using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GTTOD_Explosion : MonoBehaviour
{
    public LayerMask AvailableLayers;
    public Projectile.BulletEffect Effect;
    public float Damage;
    public float ShieldDamage;
    public float Radius;
    public float Power;
    public float CameraShake;
    public bool Stagger;
    [ConditionalField("Stagger")] public float StaggerDistance = 5;

    [Space(5)]
    [Header("TAGS")]
    public List<string> PhysicsTags;
    public List<string> DamageTags;

    public GameObject HitEffect;
}
