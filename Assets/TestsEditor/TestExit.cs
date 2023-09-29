using NUnit.Framework;
using UnityEngine;

public class TestExit
{
    // Player prefab with "Player" tag
    [Test]
    public void TestExitLevelExists()
    {
        // ARRANGE
        ExitLevel exitPoint = GameObject.FindObjectOfType<ExitLevel>();

        // ACT

        // ASSERT
        Assert.IsNotNull(exitPoint);
    }
}
