using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject ArrowPrefabs;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(instance);
        }
        //DonDestoryOnLoad()
    }
    private void Start()
    {
        InvokeRepeating("Arrow", 0f, 1f);
    }
    public void Arrow()
    {
        //Instantitate 
        Vector3 spawn = new Vector3(-8f, Random.Range(-5f, 5f),0f);
        Instantiate(ArrowPrefabs,spawn,Quaternion.identity);
        //Quaternion.identity => 회전이 존재하지 않음
    }
    public void GameOver()
    {
        Debug.LogWarning("GameOver");
        Time.timeScale = 0f;
    }
}