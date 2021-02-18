using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurvefour : MonoBehaviour
{
    void Start()
    {
        Character hero1 = new Character("Flash");
        hero1.PrintStatsInfo();

        Paladin hero2 = new Paladin("India", 91);
        hero2.PrintPaladinInfo();

        //hero3 here is instance of Paladin class and calling Character class
        // - contructor using keyword base in paladin class constructor.
        Paladin hero3 = new Paladin("SuperWomen");
        hero3.PrintStatsInfo();
    }

}
/* OUTPUT
 Flash has 0 years experience.
 India has total altitude of 91 feet.
 SuperWomen has 0 years experience.
 */