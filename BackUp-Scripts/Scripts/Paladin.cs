using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paladin : Character
{
    public int newHeight;
    public string newPlace;
    public float newPower;
    public Weapon weapon;

    public override void PrintStatsInfo()
    {
        Debug.LogFormat("Hail {0} - take up your {1} !", name, weapon.name);
    }
    //##########################################################################
    public Paladin()// Default Constructor
    {
        Debug.Log("Not assigned");
    }
//###########################################################################
    public Paladin(string name): base(name)//Character class Contructor Call
    {
        
    }
//############################################################################
    public Paladin(int height)// Constructor passing integer
    {
        this.newHeight = height;
    }
//############################################################################
    public Paladin(float power)// contructor passing float
    {
        this.newPower = power;
    }
//###########################################################################
    public Paladin(string place, int height)//Constructor pass string & Integer
    {
        this.newHeight = height;
        this.newPlace = place;
    }
//#############################################################################
    public void PrintPaladinInfo()// Method
    {
        Debug.LogFormat("{0} has total altitude of {1} feet.", newPlace, newHeight);
    }
    //#############################################################################
}
