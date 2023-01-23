/*
 * Gerard Lamoureux
 * ParaZombie
 * Assignment 1
 * Handles the ParaZombie Class which Extends Enemy and some interfaces
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParaZombie : Enemy, ICanRun, ICanFly, ICanSwipe, ICanShoot
{
    protected float swipeSpeed;
    public ParaZombie(string n = "bob", float s = 1.0f, int d = 10, int h = 100, float ss = 1.0f)
    {
        name = n;
        speed = s;
        damage = d;
        health = h;
        swipeSpeed = ss;

        Debug.Log("New ParaZombie Created! Name: " + name + " Speed: " + speed + " Damage: " + damage + " Health: " + health + " Swipe-Speed: " + swipeSpeed);
    }
    public override void Attack(IDamageable target)
    {
        Debug.Log("ParaZombie of name: \"" + name + "\" attempts to attack given target for " + damage + " damage!");
        target.TakeDamage(damage);
    }

    public override void TakeDamage(int amount)
    {
        Debug.Log("ParaZombie of name: \"" + name + "\" took " + amount + " damage from " + health + " health");
        health -= amount;
    }

    public void Run()
    {
        Debug.Log("ParaZombie of name: \"" + name + "\" starts running!");
    }
    public void Swipe(IDamageable target = null)
    {
        if (target == null)
        {
            Debug.Log("ParaZombie of name: \"" + name + "\" attempts to swipe but no target is found");
        }
        else
        {
            Debug.Log("ParaZombie of name: \"" + name + "\" swipes at target with speed: " + swipeSpeed);
            Attack(target);
        }
    }

    public void Fly()
    {
        Debug.Log("ParaZombie of name: \"" + name + "\" started flying!");
    }

    public void Shoot(IDamageable target = null)
    {
        if (target == null)
        {
            Debug.Log("ParaZombie of name: \"" + name + "\" attempts to shoot but no target is found");
        }
        else
        {
            Debug.Log("ParaZombie of name: \"" + name + "\" shoots at target");
            Attack(target);
        }
    }
}
