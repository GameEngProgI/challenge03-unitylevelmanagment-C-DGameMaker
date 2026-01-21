using Unity.VisualScripting;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private GameObject currentLevel;
    private  GameObject player;


    public GameObject level01;
    public GameObject level02;

    private void Start()
    {
        currentLevel = level01;

        player = ServiceHub.Instance.playerController.gameObject;
    }

    public void LevelChange(GameObject targetLevel, Transform spawnLocation)
    {
        currentLevel.SetActive(false);
        targetLevel.SetActive(true);

        currentLevel = targetLevel;

        player.transform.position = spawnLocation.position;



        
        
    }
}
