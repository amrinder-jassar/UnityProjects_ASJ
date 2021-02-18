using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Character
{
    public string name;
    public int exp;
//###########################################################################
    public Character()// Default Contructor
    {
        name = "Set to Default";
    }
//###########################################################################
    public Character(string Name)//Contructor pass String
    {
        this.name = Name;
    }
//###########################################################################
    public Character(string Name, int Exp)//Contructor Pass String & Integer
    {
        this.name = Name;
        this.exp = Exp;
    }
//###########################################################################
    public virtual void PrintStatsInfo()// Method
    {
        Debug.LogFormat("{0} has {1} years experience.", name, exp);
    }
//###########################################################################
    private void Reset()// This is Encapsulation setting up what is private
    {
        this.name = "Not Assigned";
        this.exp = 0;
    }
}
//******************************** THIS IS STRUCT not CLASS ***********************

public struct Weapon
{
    public string name;
    public int damage;
    public Weapon(string name, int damage)// Costructor declaration
    {
        this.name = name;
        this.damage = damage;
    }
    public void PrintWeaponInfo()// Method
    {
        Debug.LogFormat("{0} has {1} DMB.", name, damage);
    }
}