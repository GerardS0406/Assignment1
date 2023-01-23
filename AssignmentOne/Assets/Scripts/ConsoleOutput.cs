/*
 * Gerard Lamoureux
 * ConsoleOutput
 * Assignment 1
 * Handles the ConsoleOutput Class which is a simulation of enemies.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsoleOutput : MonoBehaviour
{
    public List<Enemy> enemiesList = new List<Enemy>();
    public List<ICanSwipe> swipeList = new List<ICanSwipe>();
    public List<ICanShoot> shootList = new List<ICanShoot>();
    // Start is called before the first frame update
    void Start()
    {
        Zombie zamb1 = new Zombie("Zambyy");
        Zombie zamb2 = new Zombie("Strongby", 1f, 10, 300, 2f);
        enemiesList.Add(zamb1);
        enemiesList.Add(zamb2);
        swipeList.Add(zamb1);
        swipeList.Add(zamb2);
        Parasite para1 = new Parasite("Buggy");
        Parasite para2 = new Parasite("Cocoony", 1f, 10, 100, true);
        enemiesList.Add(para1);
        enemiesList.Add(para2);
        shootList.Add(para1);
        shootList.Add(para2);

        ParaZombie paza = new ParaZombie("JuicedJohn", 3f, 30, 500, 2f);
        enemiesList.Add(paza);
        swipeList.Add(paza);
        shootList.Add(paza);

        zamb1.Swipe(para1);
        zamb1.Swipe(para2);

        para1.Shoot(zamb1);

        paza.Shoot(zamb1);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            foreach (Enemy e in enemiesList)
            {
                e.TakeDamage(10);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            foreach (ICanSwipe z in swipeList)
            {
                z.Swipe(null);
            }
            foreach (ICanShoot p in shootList)
            {
                p.Shoot(null);
            }
        }
    }
}
