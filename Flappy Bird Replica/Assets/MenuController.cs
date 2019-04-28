using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MenuController : MonoBehaviour
{
    public GameObject playButton;
    public GameObject menuButton;
    public GameObject muteSoundButton;
    public GameObject okButton;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void PlayButton()
    {
        SceneManager.LoadScene(1);
    }

    public void MenuButton()
    {
        playButton.SetActive(false);
        menuButton.SetActive(false);
        muteSoundButton.SetActive(true);
        okButton.SetActive(true);
    }

    public void OkButton()
    {
        playButton.SetActive(true);
        menuButton.SetActive(true);
        muteSoundButton.SetActive(false);
        okButton.SetActive(false);
    }

    public void MuteSoundButton()
    {

    }
}
