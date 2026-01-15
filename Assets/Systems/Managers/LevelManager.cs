using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private GameObject currentLevel;
    public GameObject level01;
    public GameObject level02;

    public void LevelChange()
    {
        level01.SetActive(false);
        level02.SetActive(true);
    }
}
