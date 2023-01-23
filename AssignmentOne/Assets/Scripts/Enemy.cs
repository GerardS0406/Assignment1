/*
 * Gerard Lamoureux
 * Enemy
 * Assignment 1
 * Handles the Abstract Enemy Class
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : IDamageable
{
    protected string name;
    protected float speed;
    protected int damage;
    protected int health;

    public abstract void Attack(IDamageable target);

    public abstract void TakeDamage(int amount);
}
