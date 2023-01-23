/*
 * Gerard Lamoureux
 * Parasite
 * Assignment 1
 * Handles the Parasite Class which Extends Enemy and some interfaces
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parasite : Enemy, ICanFly, ICanShoot
{
    protected bool shieldUp;
    public Parasite(string n = "bob", float s = 1.0f, int d = 10, int h = 100, bool su = false)
    {
        name = n;
        speed = s;
        damage = d;
        health = h;
        shieldUp = su;

        Debug.Log("New Parasite Created! Name: " + name + " Speed: " + speed + " Damage: " + damage + " Health: " + health + " Shield: " + shieldUp);
    }

    public override void Attack(IDamageable target)
    {
        Debug.Log("Parasite of name: \"" + name + "\" attempts to attack given target for " + damage + " damage!");
        target.TakeDamage(damage);
    }

    public override void TakeDamage(int amount)
    {
        if (shieldUp)
        {
            Debug.Log("Parasite of name: \"" + name + "\" blocked the attack!");
        }
        else
        {
            Debug.Log("Parasite of name: \"" + name + "\" took " + amount + " damage from " + health + " health");
            health -= amount;
        }
    }

    public void Fly()
    {
        Debug.Log("Parasite of name: \"" + name + "\" started flying!");
    }

    public void Shoot(IDamageable target = null)
    {
        if (target == null)
        {
            Debug.Log("Parasite of name: \"" + name + "\" attempts to shoot but no target is found");
        }
        else
        {
            Debug.Log("Parasite of name: \"" + name + "\" shoots at target");
            Attack(target);
        }
    }
}
