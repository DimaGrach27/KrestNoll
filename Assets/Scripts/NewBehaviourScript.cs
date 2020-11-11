using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public static bool firstPlayer;
    private int whoIsFirst;

    [SerializeField] Text winCondition;
    [SerializeField] GameObject textPanel;

    WinCondition winCond;

    void Start()
    {
        whoIsFirst = Random.Range(1, 3);

        Debug.Log($"Ikrok: {whoIsFirst} hodit");
        textPanel.SetActive(false);

        if (whoIsFirst == 1)
            firstPlayer = true;

        else if (whoIsFirst == 2)
            firstPlayer = false;

        winCond = new WinCondition();
        winCond.RgisterHeandler(new WinCondition.WinCond(Wineble));
    }


    void Update()
    {
        winCond.Win();

        if (textPanel.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(0);
            }
        }
    }

    void Wineble()
    {
        if(WinCondition.whoIsWineble == 1)
        {
            winCondition.text = "Igrok 1 pobedil";
            textPanel.SetActive(true);
        }
        else if (WinCondition.whoIsWineble == 2)
        {
            winCondition.text = "Igrok 2 pobedil";
            textPanel.SetActive(true);
        }
    }
}
