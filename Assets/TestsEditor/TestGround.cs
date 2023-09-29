using NUnit.Framework;
using UnityEngine;

public class TestGround
{
    // Use Ground layer for player.isGrounded
    [Test]
    public void TestGroundLayer()
    {
        // ARRANGE
        var goArray = GameObject.FindObjectsOfType<GameObject>();
        bool result = false;

        // ACT
        for (var i = 0; i < goArray.Length; i++)
        {
            if (goArray[i].layer == 3) // 3 is Ground layer
            {
                result = true;
            }
        }

        // ASSERT
        Assert.IsTrue(result);
    }
}
