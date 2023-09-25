using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

// Les aliments ne sont pas ramassés
// Comportement attendu:
// Lorsque le joueur marche sur un des aliments, celui-ci doit disparaître et le score doit être modifié en fonction.
// Comportement actuel?:
// Lorsque le joueur marche sur un des aliments, rien ne se passe.

public class test_player_collects_food
{
    // A Test behaves as an ordinary method
    [Test]
    public void test_player_collects_foodSimplePasses()
    {
        // Use the Assert class to test conditions
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator test_player_collects_foodWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
