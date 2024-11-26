using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerStats : MonoBehaviour
{
    [SerializeField] public int Health;
    [SerializeField] public int Mana;
    [SerializeField] public int Attack;
    [SerializeField] public int Defense;
    [SerializeField] public int Speed;
}
