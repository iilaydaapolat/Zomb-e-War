
using UnityEngine.SceneManagement;
using UnityEngine;

public class Mainmenu : MonoBehaviour
{
	// Start is called before the first frame update
	public void PlayGame()
	{
		SceneManager.LoadScene("TestScene");
	}
	public void QuitGame()
	{
		Application.Quit();
	}
}

