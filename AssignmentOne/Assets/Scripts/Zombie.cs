/*
 * Gerard Lamoureux
 * Zombie
 * Assignment 1
 * Handles the Zombie Class which Extends Enemy and some interfaces
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : Enemy, ICanRun, ICanSwipe
{
    protected float swipeSpeed;
    public Zombie(string n = "bob", float s = 1.0f, int d = 10, int h = 100, float ss = 1.0f)
    {
        name = n;
        speed = s;
        damage = d;
        health = h;
        swipeSpeed = ss;

        Debug.Log("New Zombie Created! Name: " + name + " Speed: " + speed + " Damage: " + damage + " Health: " + health + " Swipe-Speed: " + swipeSpeed);
    }
    public override void Attack(IDamageable target)
    {
        Debug.Log("Zombie of name: \"" + name + "\" attempts to attack given target for " + damage + " damage!");
        target.TakeDamage(damage);
    }

    public override void TakeDamage(int amount)
    {
        Debug.Log("Zombie of name: \"" + name + "\" took " + amount + " damage from " + health + " health");
        health -= amount;
    }

    public void Run()
    {
        Debug.Log("Zombie of name: \"" + name + "\" starts running!");
    }
    public void Swipe(IDamageable target = null)
    {
        if(target == null)
        {
            Debug.Log("Zombie of name: \"" + name + "\" attempts to swipe but no target is found");
        }
        else
        {
            Debug.Log("Zombie of name: \"" + name + "\" swipes at target with speed: " + swipeSpeed);
            Attack(target);
        }
    }

}
