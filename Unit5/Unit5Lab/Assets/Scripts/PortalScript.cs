using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalScript : MonoBehaviour
{
    public void TeleportToNewWorld(int world)
    {
        SceneManager.LoadScene(world);
    }
}
