using System;
using System.Linq;
using UnityEngine;

public class Player : MonoBehaviour
{
    private string name = "Jakub";
    private bool alive = true;
    private int hp = 12;
    private int schade;

    void Start()
    {
        Debug.Log("mijn naam is: " + name);
        Debug.Log("mijn hitpoints zijn: " + hp);
        Debug.Log("alive: " + alive);

        TookDamage();

        SaysName("noah");

        Debug.Log("Max: " + Max(12, 45));

        BerekenSchade(12, 7);
        Debug.Log("Schade: " + schade);

        Vijanden();

        Score();

        player();
    }

    void Update()
    {
        if (hp <= 0)
        {
            alive = false;
        }
    }

    private void TookDamage()
    {
        hp = hp - 5;

        Debug.Log("mijn hitpoints zijn: " + hp);
        Debug.Log("alive: " + alive);
    }

    private void SaysName(string MyName)
    {
        Debug.Log(MyName);
    }

    private int Max(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else if (a < b)
        {
            return b;
        }
        else
        {
            return a;
        }
    }

    private int BerekenSchade(int aanval, int verdediging)
    {
        return schade = aanval - verdediging;
    }

    private void Vijanden()
    {
        string[] Vijanden = new string[5];

        Vijanden[0] = "orc";
        Vijanden[1] = "dragon";
        Vijanden[2] = "goblin";
        Vijanden[3] = "Knight";
        Vijanden[4] = "teacher";

        for (int i = 0; i < Vijanden.Length; i++)
        {
            Debug.Log(Vijanden[i]);
        }
    }

    private void Score()
    {
        int[] scores = new int[] { 12, 230, 34, 45, 56 };

        Debug.Log("Hoogste score: " + scores.Max());
    }

    class Speler
    {
        public string Naam;
        public int HP;
        public int Score;
    }

    private void player()
    {
        Speler Mario = new Speler();

        Mario.Naam = "Mario";
        Mario.HP = 10;
        Mario.Score = 1000;

        Speler Luigi = new Speler();

        Luigi.Naam = "Luigi";
        Luigi.HP = 4;
        Luigi.Score = 500;

        Debug.Log("Speler.name : " + Mario.Naam);
        Debug.Log("Speler.HP : " + Mario.HP);
        Debug.Log("Speler.Score : " + Mario.Score);

        Debug.Log("");

        Debug.Log("Speler.name : " + Luigi.Naam);
        Debug.Log("Speler.HP : " + Luigi.HP);
        Debug.Log("Speler.Score : " + Luigi.Score);

        Debug.Log(
            $"Ik ben {Mario.Naam}, mijn HP is {Mario.HP} en mijn score is {Mario.Score}."
        );
    }
}