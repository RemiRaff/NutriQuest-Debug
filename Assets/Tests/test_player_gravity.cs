using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

// Le personnage ne tombe pas
// Comportement attendu :
// Lorsque le joueur marche sur un emplacement vide, il devrait tomber et un game over devrait se déclencher pour recommencer le niveau.
// Comportement actuel :
// Le joueur flotte sur les emplacements vides lorsqu’il marche dessus et ne tombe pas.

public class test_player_gravity
{
    // A Test behaves as an ordinary method
    [Test]
    public void test_player_gravitySimplePasses()
    {
        // Use the Assert class to test conditions
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator test_player_gravityWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
