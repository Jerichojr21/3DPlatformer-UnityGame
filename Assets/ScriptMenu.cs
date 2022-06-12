using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptMenu : MonoBehaviour
{
    public GameObject panelKonfirmasi;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void exit()
    {
        Application.Quit();
        Debug.Log("Keluar....");
    }

    public void play(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void KonfirmasiClicked()
    {
        panelKonfirmasi.SetActive(true);
    }

    public void Kembali()
    {
        panelKonfirmasi.SetActive(false);
    }
}
