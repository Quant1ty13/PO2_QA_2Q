using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using UnityEngine;

public class GUI : PlayerStats
{
    [SerializeField] PlayerOne PlayerOne;
    [SerializeField] PlayerTwo PlayerTwo;
    [SerializeField] PlayerThree PlayerThree;

    public string label = "Label";
    void OnGUI()
    {
        //Character Details
        UnityEngine.GUI.Label(new Rect(600, 250, 500, 500), label);

        UnityEngine.GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "Le Boxe");

        if (UnityEngine.GUI.Button(new Rect(25, 25, 100, 30), "Player One"))
        {
            label = "Health: " + PlayerOne.Health + "\nMana: " + PlayerOne.Mana + "\nAttack: " + PlayerOne.Attack + "\nDefense: " + PlayerOne.Defense + "\nSpeed: " + PlayerOne.Speed;
        }

        if (UnityEngine.GUI.Button(new Rect(250, 25, 100, 30), "Player Two"))
        {
            label = "Health: " + PlayerTwo.Health + "\nMana: " + PlayerTwo.Mana + "\nAttack: " + PlayerTwo.Attack + "\nDefense: " + PlayerTwo.Defense + "\nSpeed: " + PlayerTwo.Speed;
        }

        if (UnityEngine.GUI.Button(new Rect(500, 25, 100, 30), "Player Three"))
        {
            label = "Health: " + PlayerThree.Health + "\nMana: " + PlayerThree.Mana + "\nAttack: " + PlayerThree.Attack + "\nDefense: " + PlayerThree.Defense + "\nSpeed: " + PlayerThree.Speed;
        }

        //GUI Buttons
        if (UnityEngine.GUI.Button(new Rect(500, 500, 150, 50), "Chest"))
        {
            label = "Coin";
        }

        if (UnityEngine.GUI.Button(new Rect(750, 500, 150, 50), "Switch"))
        {
            label = "Door is Open";
        }
    }
}
